using Diploma2020.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Res = Diploma2020.Properties.Resources;

namespace Diploma2020.Screens
{
    public partial class OlympicProcess : Form
    {
        private Dictionary<string, Dictionary<string, bool>> currResults = new
            Dictionary<string, Dictionary<string, bool>>();
        private Teacher teach = AppConstants.CurrentUser;
        private List<Pupil> lst = AppConstants.CurrentUser.ClassList;
        private bool IsAlreadyLogged = false;

        #region Helpers
        /// <summary>
        /// Helper to initialise Labels in Table
        /// </summary>
        private void InitTable()
        {
            InitDict();
            foreach(Pupil item in lst)
            {
                AddNewLine(item.SimpleName);
            }
        }

        /// <summary>
        /// Initialise dictionary to save already filled info
        /// </summary>
        private async void InitDict()
        {
            try
            {
                Database DB = Database.getInstance();
                string result = await DB.ReadTeacherOlympic(teach.SimpleName);
                Thread.Sleep(500);
                IsAlreadyLogged = !string.IsNullOrEmpty(result);
                if (IsAlreadyLogged)
                {
                    currResults = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, bool>>>(result);
                }
                else
                {
                    currResults = teach.RespSubjects
                        .ToDictionary(item => item, item => lst
                            .ToDictionary(value => value.SimpleName, value => false));
                }
            }
            catch (Exception ex)
            {
                //Do nothing. There are no table in DB
            }
           
        }

        /// <summary>
        /// Helpers function to create result string
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        private string CorvertDictToString(Dictionary<string, List<string>> dict)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            var classGroups = from item in dict
                              group item by item.Key.Substring(0, item.Key.Length - 1);

            int commonParters = 0;
            foreach (var value in classGroups)
            {
                int pupilCount = 0;
                string resultLine = string.Empty;

                foreach (var kvPair in value)
                {
                    pupilCount += kvPair.Value.Count;
                    resultLine = string.Join("\n", resultLine, $"Класc: {kvPair.Key}", string.Join("\n", kvPair.Value));
                }
                resultLine = string.Join("\n", resultLine, $"Всего учеников: {pupilCount}");
                result.Add(value.Key, resultLine);
                commonParters += pupilCount;
            }

            string docLine = string.Join("\n", result.Select(item => item.Value).ToArray());
            docLine = string.Join("\n", docLine, $"Участников олимпиады: {commonParters.ToString()}");
            return docLine;
        }

        /// <summary>
        /// Helper to Initialise new lines in Table
        /// </summary>
        /// <param name="pupilName"></param>
        private void AddNewLine(string pupilName)
        {
            int rowCount = Table.RowCount;
            Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Table.RowCount++;
            Label lbl = new Label();
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.Text = pupilName;
            lbl.Margin = new Padding(5);
            lbl.Size = new Size(200, 35);
            Table.Controls.Add(lbl, 0, rowCount);

            CheckBox cb = new CheckBox();
            cb.Text = string.Empty;
            cb.Margin = new Padding(5);
            cb.CheckedChanged += ChangeCBSTate;
            Table.Controls.Add(cb, 1, rowCount);
        }

        /// <summary>
        /// Helper function to save pupils, that want to take part in Olympic
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private Dictionary<string, List<string>> ConvertDict(string value)
        {
            Dictionary<string, Dictionary<string, bool>> dict1 = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, bool>>>(value);
            Dictionary<string, List<string>> dict2 = dict1.ToDictionary(
                item => item.Key,
                item => item.Value
                    .Where(result => result.Value)
                    .Select(result => result.Key)
                    .ToList());
            return dict2;
        }
        #endregion

        public OlympicProcess()
        {
            InitializeComponent();
            InitTable();            
            SubjectCB.Items.AddRange(teach.RespSubjects.ToArray());
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OlympicProcess_Load(object sender, EventArgs e)
        {
            ClassLbl.Text = string.Join(" ", Res.ClassNameLbl, AppConstants.CurrentUser.Class);
            UserLbl.Text = AppConstants.CurrentUser.SimpleName;
            CloseBtn.SmallBtnSetStyle(Res.CloseBtn);
            SaveBtn.SmallBtnSetStyle(Res.SaveBtn);
            FullNameLbl.Text = Res.FullNameLbl;
            SubjectLbl.Text = string.Empty;
            SaveToFile.SmallBtnSetStyle(Res.SaveToFileLbl);
            SaveToFile.Visible = teach.IsAdmin;
        }

        private void ChangeCBSTate(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SubjectLbl.Text))
            {
                CheckBox cb = (CheckBox)sender;
                var pos = Table.GetCellPosition(cb);
                currResults[SubjectLbl.Text][Table.GetControlFromPosition(0, pos.Row).Text] = cb.Checked;
            }
        }

        private void SubjectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SubjectCB.Text))
            {
                SubjectLbl.Text = SubjectCB.Text;
                for (int i=0; i<teach.ClassList.Count; i++)
                {
                    CheckBox cb = (CheckBox)Table.GetControlFromPosition(1, i + 2);
                    cb.CheckedChanged -= ChangeCBSTate;
                    cb.Checked = currResults[SubjectCB.Text][lst[i].SimpleName];
                    cb.CheckedChanged += ChangeCBSTate;
                }
            }
            else
            {
                return;
            }
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            Database DB = Database.getInstance();
            await DB.WriteOlympic(teach.SimpleName, JsonConvert.SerializeObject(currResults), IsAlreadyLogged);
            DialogResult = DialogResult.OK;
            Close();
        }

        private async void SaveToFile_Click(object sender, EventArgs e)
        {
            //Read all info about olympic from the table
            Database DB = Database.getInstance();
            var dictionary = await DB.ReadOlympic();
            Thread.Sleep(1000);
            Database.CloseCon();

            //Replase Teacher name on ClassName
            dictionary = dictionary
                .ToDictionary(item => AppConstants.teacs.Find(
                    teacher => teacher.SimpleName == item.Key).Class,
                    item => item.Value);

            //Select only names, that want to take part in Olympic
            Dictionary<string, Dictionary<string, List<string>>> classesSubjectsDictionary =
                dictionary.ToDictionary(item => item.Key, item => ConvertDict(item.Value));

            //Sort values 4a -> Subjects -> Surnames
            classesSubjectsDictionary = classesSubjectsDictionary
                .OrderBy(item => item.Key)
                .ToDictionary(item => item.Key, item => item.Value);

            //Rewrite dictionary to Subject -> Class -> Surnames
            Dictionary<string, Dictionary<string, List<string>>> newDict = new
                Dictionary<string, Dictionary<string, List<string>>>();

            foreach(var item in classesSubjectsDictionary)
            {
                foreach(var insideItem in item.Value)
                {
                    if (!newDict.ContainsKey(insideItem.Key))
                    {
                        newDict.Add(insideItem.Key, new Dictionary<string, List<string>>());
                    }
                    newDict[insideItem.Key].Add(item.Key, insideItem.Value);
                }
            }

            Dictionary<string, string> resultDict = newDict.ToDictionary(item => item.Key,
                item => CorvertDictToString(item.Value));

            (new Thread(async delegate () {
                foreach (var item in resultDict)
                {
                    Utilities.WriteOlympicIntoWordFile(item.Key, item.Value);
                }
            })).Start();
        }
    }
}
