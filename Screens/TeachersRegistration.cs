using Diploma2020.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Res = Diploma2020.Properties.Resources;

namespace Diploma2020.Screens
{
    public partial class TeachersRegistration : Form
    {
        public List<Teacher> teachersList = new List<Teacher>();

        #region Helpers
        /// <summary>
        /// Add new line in the table
        /// </summary>
        private void AddNewLine()
        {            
            int rowCount = Table.RowCount;            
            Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Table.RowCount++;
            for (int i=0; i< Table.ColumnCount; i++)
            {
                TextBox tb = new TextBox();
                tb.Size = new System.Drawing.Size(280, 30);
                tb.Margin = new Padding(5);
                Table.Controls.Add(tb, i, rowCount);
            }
        }

        /// <summary>
        /// Fill table from the dictionary
        /// </summary>
        private void FillTable()
        {
            for (int i=0; i<teachersList.Count; )
            {
                Teacher model = teachersList[i];
                i+=2;
                AddNewLine();
                Table.GetControlFromPosition(0, i).Text = model.FullName;
                Table.Update();
                for (int j = 0; j < Table.ColumnCount; j++)
                {
                    Table.GetControlFromPosition(j, i).TextChanged += ChangeContentCallback;
                }
                i--;
                Thread.Sleep(500);
            }
        }
        
        /// <summary>
        /// Split table content from the document
        /// </summary>
        /// <param name="content">Line, that contains all information from document</param>
        private void splitContent(string content)
        {
            string[] teachers = content.Split(new string[] { "\r\a\r\a" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i < teachers.Length; i++)
            {
                fillDictionary(teachers[i]);
            }
        }

        /// <summary>
        /// Fill dictionary with lists of Classes
        /// </summary>
        /// <param name="classData">String that represent table from Word document</param>
        private void fillDictionary(string teacher)
        {
            string[] teacherInfo = teacher.Split(new string[] { "\r\a" }, StringSplitOptions.None);
            if (teacherInfo.Length > 2)
            {
                Teacher teach = new Teacher();
                teach.FullName = teacherInfo[1];
                TeacherAddInfo tm = new TeacherAddInfo()
                {
                    Birthday = teacherInfo[2],
                    Address = teacherInfo[3],
                    Passport = teacherInfo[4],
                    SNILS = teacherInfo[5],
                    INN = teacherInfo[6],
                    Account = teacherInfo[7],
                    BankAccont = teacherInfo[8],
                    Phone = teacherInfo[9]
                };
                teach.AddInfo = tm;
                teachersList.Add(teach);
            }
        }
        #endregion

        public TeachersRegistration()
        {
            InitializeComponent();
            ExportBtn.SmallBtnSetStyle(Res.ExportBtn);
            CloseBtn.SmallBtnSetStyle(Res.CloseBtn);
            SaveBtn.SmallBtnSetStyle(Res.SaveBtn);
            FullNameLbl.Text = Res.FullNameLbl;

            SaveBtn.Enabled = false;
            ExportBtn.Enabled = true;

            Table.Visible = false;
            ColumnNameCB.Items.AddRange(AppConstants.columnsTeacherList.ToArray());
        }

        /// <summary>
        /// Process "Export" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportBtn_Click(object sender, EventArgs e)
        {
            string content = Utilities.ReadWordFile(string.Join("/", AppConstants.DiskToDocs,
                AppConstants.ProjectDirectory, AppConstants.TeachersFile));

            if (!string.IsNullOrEmpty(content))
            {
                ExportBtn.Enabled = false;
                SaveBtn.Enabled = true;
                splitContent(content);
                teachersList = teachersList.OrderBy(item => item.FullName).ToList();

                Table.Visible = true;

                FillTable();
                var dialogResult = Utilities.CheckFunctionalityDialog();
            }
            
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
            if (position.Column == 0)
            {
                teachersList[position.Row - 2].FullName = tb.Text;
            }
            else
            {
                string columnName = ColumnNameCB.Text;
                int rowPos = position.Row - 2;
                TeacherAddInfo addInfoModel = teachersList[rowPos].AddInfo;
                switch (AppConstants.columnsTeacherList.IndexOf(columnName))
                {
                    case 0:
                        addInfoModel.Birthday = tb.Text;
                        break;
                    case 1:
                        addInfoModel.Address = tb.Text;
                        break;
                    case 2:
                        addInfoModel.Passport = tb.Text;
                        break;
                    case 3:
                        addInfoModel.SNILS = tb.Text;
                        break;
                    case 4:
                        addInfoModel.INN = tb.Text;
                        break;
                    case 5:
                        addInfoModel.Account = tb.Text;
                        break;
                    case 6:
                        addInfoModel.BankAccont = tb.Text;
                        break;
                    case 7:
                        addInfoModel.Phone = tb.Text;
                        break;
                }
                teachersList[rowPos].AddInfo = addInfoModel;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            AppConstants.teacs = teachersList;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ColumnNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columnName = ColumnNameCB.Text;
            for (int i=2; i<Table.RowCount; i++)
            {
                TextBox tb = (TextBox)Table.GetControlFromPosition(1, i);
                tb.TextChanged -= ChangeContentCallback;
                TeacherAddInfo tai = teachersList[i - 2].AddInfo;
                switch (AppConstants.columnsTeacherList.IndexOf(columnName))
                {
                    case 0:
                        tb.Text = tai.Birthday;
                        break;
                    case 1:
                        tb.Text = tai.Address;
                        break;
                    case 2:
                        tb.Text = tai.Passport;
                        break;
                    case 3:
                        tb.Text = tai.SNILS;
                        break;
                    case 4:
                        tb.Text = tai.INN;
                        break;
                    case 5:
                        tb.Text = tai.Account;
                        break;
                    case 6:
                        tb.Text = tai.BankAccont;
                        break;
                    case 7:
                        tb.Text = tai.Phone;
                        break;
                }
                tb.TextChanged += ChangeContentCallback;
            }            
        }
    }
}
