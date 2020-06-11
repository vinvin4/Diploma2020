using Diploma2020.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Res = Diploma2020.Properties.Resources;

namespace Diploma2020.Screens
{
    public partial class LearningSubjects : Form
    {
        private List<string> AllSubject = new List<string>();
        private Dictionary<string, Dictionary<string, bool>> subjDictionary = new
            Dictionary<string, Dictionary<string, bool>>();
        #region Helpers
        /// <summary>
        /// Function to initialise Table by default values or the same
        /// </summary>
        private void InitialiseTable()
        {
            TypesCB.Items.AddRange(Res.DefaultClasses.Split(';'));
            
            AllSubject.AddRange(Res.DefaultSubjects.Split(';').ToList());
            AllSubject.AddRange(Res.OlderClassesSubjects.Split(';').ToList());
            AllSubject.AddRange(Res.ExoticSubjects.Split(';').ToList());

            foreach(string value in TypesCB.Items)
            {
                subjDictionary.Add(value, AllSubject
                    .ToDictionary(item => item, item => false));
                InitialiseDict(value);
            }            

            //Initialise Header of Table
            Label subjLbl = new Label();
            subjLbl.Size = new System.Drawing.Size(350, 35);
            subjLbl.Text = Res.SubjectLbl;
            Table.Controls.Add(subjLbl, 0, 0);

            Label needfunLbl = new Label();
            needfunLbl.Size = new System.Drawing.Size(350, 35);
            needfunLbl.Text = Res.UsingSubjectsLbl;
            Table.Controls.Add(needfunLbl, 1, 0);

            for (int i=0; i<AllSubject.Count; i++)
            {
                AddNewLine();
                Table.GetControlFromPosition(0, i + 2).Text = AllSubject[i];
            }
        }

        /// <summary>
        /// Add default values in Dictionary
        /// </summary>
        /// <param name="classType"></param>
        private void InitialiseDict(string classType)
        {
            switch (classType)
            {
                case "4":
                    foreach(string value in Res.DefaultSubjects.Split(';').ToList())
                    {
                        subjDictionary[classType][value] = true;
                    };
                    break;
                case "10":
                    subjDictionary[classType] = subjDictionary[classType]
                        .ToDictionary(item => item.Key, item => true);
                    break;
                default:
                    subjDictionary[classType] = subjDictionary[classType]
                        .ToDictionary(item => item.Key, item => true);
                    foreach (string value in Res.ExoticSubjects.Split(';').ToList())
                    {
                        subjDictionary[classType][value] = false;
                    };
                    break;
            }
        }

        /// <summary>
        /// Add new line in the table
        /// </summary>
        private void AddNewLine()
        {
            int rowCount = Table.RowCount;
            Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Table.RowCount++;
            Label lbl = new Label();
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.Size = new System.Drawing.Size(350, 35);
            Table.Controls.Add(lbl, 0, rowCount);

            CheckBox cb = new CheckBox();
            cb.BackColor = System.Drawing.Color.Transparent;
            cb.Size = new System.Drawing.Size(350, 35);
            cb.CheckedChanged += OnCheckedState;
            Table.Controls.Add(cb, 1, rowCount);
        }
        #endregion

        public LearningSubjects()
        {
            InitializeComponent();
            InitialiseTable();
            CloseBtn.BigBtnSetStyle(Res.CloseBtn);
            SaveBtn.BigBtnSetStyle(Res.SaveBtn);

        }

        public void OnCheckedState(object sender, EventArgs args)
        {
            CheckBox cb = (CheckBox)sender;
            var pos = Table.GetCellPosition(cb);
            string value = Table.GetControlFromPosition(0, pos.Row).Text;
            string classType = TypesCB.Text;
            subjDictionary[classType][value] = cb.Checked;
            cb.Text = (cb.Checked) ? Res.UsingLbl : Res.NonUsingLbl;
        }

        private void TypesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string classType = TypesCB.Text;

            for (int i=2; i<Table.RowCount; i++)
            {
                string value = Table.GetControlFromPosition(0, i).Text;
                CheckBox cb = (CheckBox)Table.GetControlFromPosition(1, i);
                cb.Checked = subjDictionary[classType][value];
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> subjDict = new Dictionary<string, string>();
            foreach(var item in subjDictionary)
            {
                subjDict.Add(item.Key, string.Join(";", item.Value
                    .Where(subject => subject.Value)
                    .Select(subject=>subject.Key).ToList()));
            }

            for (int i = 4; i<=11; i++)
            {
                if (!subjDict.ContainsKey(i.ToString()))
                {
                    subjDict.Add(i.ToString(), subjDict[(i - 1).ToString()]);
                }
            }
            AppConstants.AvailableSubjects = subjDict;
            (new Thread(async delegate () {await
                Database.getInstance().WriteSubject(AppConstants.AvailableSubjects);}))
                .Start();

            string filePath = string.Join("/", AppConstants.DiskToDocs,
                AppConstants.ProjectDirectory, AppConstants.CustomFilesDirectory);
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            filePath = string.Join("/", filePath, AppConstants.RegistationCompleted);
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.AutoFlush = true;
                sw.WriteLine($"Количество учителей: {AppConstants.teacs.Count}");
                sw.WriteLine($"Количество учеников: {AppConstants.pupils.Count}");
                sw.WriteLine($"Классы: {string.Join(", ", AppConstants.AvailableClassesList)}");
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
