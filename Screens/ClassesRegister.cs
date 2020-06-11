using Diploma2020.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Res = Diploma2020.Properties.Resources;

namespace Diploma2020.Screens
{
    public partial class ClassesRegister : Form
    {
        #region Constants
        private Dictionary<string, List<Pupil>> classesDict =
            new Dictionary<string, List<Pupil>>();
        private List<string> availableClasses = new List<string>();
        #endregion

        #region Helpers
        /// <summary>
        /// Add new line in the table
        /// </summary>
        private void AddNewLine()
        {
            int rowCount = Table.RowCount;
            Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Table.RowCount++;
            for (int i = 0; i < Table.ColumnCount; i++)
            {
                TextBox tb = new TextBox();
                tb.Size = new System.Drawing.Size(280, 30);
                tb.Margin = new Padding(5);
                Table.Controls.Add(tb, i, rowCount);
            }
        }

        /// <summary>
        /// Split word content to create data about pupils
        /// </summary>
        /// <param name="line">Word content</param>
        private void splitContent(string line)
        {
            string[] classes = line.Split(new string[] { "\r\a\r\a\f" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < classes.Length; i++)
            {
                fillDictionary(classes[i]);
            }
        }

        /// <summary>
        /// Fill dictionary with lists of Classes
        /// </summary>
        /// <param name="classData">String that represent table from Word document</param>
        private void fillDictionary(string classData)
        {
            string[] classInfo = classData.Split(new string[] { "\r\a\r\a" }, StringSplitOptions.RemoveEmptyEntries);
            string className = getClassName(classInfo[0]);

            if (checkNeedful(className))
            {
                classesDict.Add(className, new List<Pupil>());
                for (int i = 1; i < classInfo.Length; i++)
                {
                    string[] pupilFullInfo = classInfo[i].Split(new string[] { "\r\a" }, StringSplitOptions.None);
                    if (pupilFullInfo.Length > 2)
                    {
                        Pupil pupil = new Pupil(pupilFullInfo[1]);
                        pupil.Class = className;
                        string line = pupilFullInfo[1].Substring(pupilFullInfo[1].Length - 2);
                        PupilAddInfo pm = new PupilAddInfo()
                        {
                            Birthday = pupilFullInfo[2],
                            Address = pupilFullInfo[3],
                            Sex = (line == "ич") ? "M" : "Ж"
                        };
                        pupil.AddInfo = pm;
                        classesDict[className].Add(pupil);
                    }
                }
                classesDict[className] = classesDict[className].OrderBy(item => item.FullName).ToList();
            }
        }

        /// <summary>
        /// Return Pupil's Class name
        /// </summary>
        /// <param name="classHeader"></param>
        /// <returns></returns>
        private string getClassName(string tableHeader)
        {
            string[] className = tableHeader.Split(' ');
            return className[0];
        }

        /// <summary>
        /// Check, is this class need to process
        /// If need - feel dictionaries
        /// </summary>
        /// <param name="className">Class name to process</param>
        /// <returns></returns>
        private bool checkNeedful(string className)
        {
            bool result = className.Length == 3;
            if (!result)
            {
                result = className[0] >= '4';
            }

            return result;
        }

        /// <summary>
        /// Remove old rows from the Table
        /// </summary>
        private void ClearTable()
        {
            for (int i = Table.RowCount - 1; i > 1; i--)
            {
                for (int j = 0; j < 2; j++)
                {
                    TextBox tb = (TextBox)Table.GetControlFromPosition(j, i);
                    tb.TextChanged -= ChooseClassCB_SelectedIndexChanged;
                    Table.Controls.Remove(tb);
                }
                Table.RowStyles.RemoveAt(i);
                Table.RowCount--;
            }
        }
        #endregion
        public ClassesRegister()
        {
            InitializeComponent();
            ChooseClassLbl.Text = Res.PressClassLbl;
            FullNameLbl.Text = Res.FullNameLbl;

            SaveBtn.SmallBtnSetStyle(Res.SaveBtn);
            ExportBtn.SmallBtnSetStyle(Res.ExportBtn);
            CloseBtn.SmallBtnSetStyle(Res.CloseBtn);

            TableFlow.Visible = false;
            ChooseColumnCB.Enabled = false;
            ChooseColumnCB.Items.AddRange(AppConstants.columnsPupilList.ToArray());
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            string content = Utilities.ReadWordFile(string.Join("/", AppConstants.DiskToDocs,
                AppConstants.ProjectDirectory, AppConstants.PupilsList));

            splitContent(content);
            availableClasses = classesDict
                .Select(item => item.Key)
                .ToList();
            ChooseClassCB.Items.AddRange(availableClasses.ToArray());

            TableFlow.Visible = true;
            ExportBtn.Enabled = false;
        }

        /// <summary>
        /// Process the changing content
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeContentCallback(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            var position = Table.GetCellPosition(tb);
            int rowPos = position.Row - 2;
            if (position.Column == 0)
            {
                classesDict[ChooseClassCB.Text][rowPos].FullName = tb.Text;
            }
            else
            {
                string columnName = ChooseColumnCB.Text;
                PupilAddInfo pai = classesDict[ChooseClassCB.Text][rowPos].AddInfo;
                switch (AppConstants.columnsPupilList.IndexOf(columnName))
                {
                    case 0:
                        pai.Birthday = tb.Text;
                        break;
                    case 1:
                        pai.Address = tb.Text;
                        break;
                    case 2:
                        pai.Sex = tb.Text;
                        break;
                }
                classesDict[ChooseClassCB.Text][rowPos].AddInfo = pai;
            }
        }

        private void ChooseClassCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ChooseClassCB.Text))
            {
                return;
            }
            ClearTable();
            ChooseColumnCB.Enabled = true;
            ChooseColumnCB.SelectedIndexChanged -= ChooseColumnCB_SelectedIndexChanged;
            ChooseColumnCB.Text = string.Empty;
            ChooseColumnCB.SelectedIndexChanged += ChooseColumnCB_SelectedIndexChanged;
            
            List<Pupil> pList = classesDict[ChooseClassCB.Text];
            for (int i=0; i<pList.Count; i++)
            {
                AddNewLine();
                TextBox tb = (TextBox)Table.GetControlFromPosition(0, i + 2);
                tb.Text = pList[i].FullName;
                tb.TextChanged += ChangeContentCallback;
            }
        }

        private void ChooseColumnCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = ChooseColumnCB.Text;
            bool IsBirthday = selectedItem == Res.BirthdayLbl;

            List<Pupil> pList = classesDict[ChooseClassCB.Text];
            for (int i=0; i<pList.Count; i++)
            {
                TextBox tb = (TextBox)Table.GetControlFromPosition(1, i + 2);
                tb.TextChanged -= ChangeContentCallback;
                PupilAddInfo pai = pList[i].AddInfo;
                if (selectedItem == Res.BirthdayLbl)
                {
                    tb.Text = pai.Birthday;
                }
                else if(selectedItem == Res.AddressLbl)
                {
                    tb.Text = pai.Address;
                }
                else
                {
                    tb.Text = pai.Sex;
                }
                tb.TextChanged += ChangeContentCallback;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            AppConstants.AvailableClassesList = availableClasses;

            foreach(var item in classesDict)
            {
                AppConstants.pupils.AddRange(item.Value);
            }

            (new Thread(async delegate() {
                await Database.getInstance().WriteClasses(AppConstants.pupils);
            })).Start();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
