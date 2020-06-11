using Diploma2020.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Res = Diploma2020.Properties.Resources;

namespace Diploma2020.Screens
{
    public partial class AddNewYearActivity : Form
    {
        KeyValuePair<string, Dictionary<string, string>> resultDict;
        #region Helpers

        /// <summary>
        /// Helper function to Clear the table
        /// </summary>
        private void ClearTable()
        {
            for(int i=Table.RowCount; i>1; )
            {
                i--;
                for (int j=0; j<2; j++)
                {
                    Control cnt = Table.GetControlFromPosition(j, i);
                    if (cnt != null)
                    {
                        Table.Controls.Remove(cnt);
                    }
                }
                Table.RowStyles.RemoveAt(i);
                Table.RowCount--;
            }
        }

        /// <summary>
        /// Helper function to fill the line in table
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
            Table.Controls.Add(cb, 1, rowCount);
        }
        #endregion

        public AddNewYearActivity()
        {
            InitializeComponent();
            SaveBtn.Enabled = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddNewYearActivity_Load(object sender, EventArgs e)
        {
            ClassLbl.Text = Res.ClassNameLbl;
            ActivityNameLbl.Text = Res.ActivityNameLbl;

            FullNameLbl.Text = Res.FullNameLbl;
            NeedToProcessLbl.Text = Res.NeedToProcessLbl;

            SaveBtn.BigBtnSetStyle(Res.SaveBtn);
            CloseBtn.BigBtnSetStyle(Res.CloseBtn);

            ChooseClassCB.Items.AddRange(AppConstants.AvailableClassesList.ToArray());
        }

        private void ChooseClassCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ChooseClassCB.Text))
            {
                return;
            }
            SaveBtn.Enabled = true;
            List<string> lst = AppConstants.pupils
                .Where(item => item.Class == ChooseClassCB.Text)
                .Select(item=>item.SimpleName)
                .ToList();
            ClearTable();
            foreach(string item in lst)
            {
                AddNewLine(item);
            }
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ActivityNameTB.Text))
            {
                Utilities.FillTheTable();
                return;
            }
            resultDict = new KeyValuePair<string, Dictionary<string, string>>(ChooseClassCB.Text, new Dictionary<string, string>());
            for (int i=1; i<Table.RowCount; i++)
            {
                CheckBox cb = (CheckBox)Table.GetControlFromPosition(1, i);
                if (cb.Checked)
                {
                    resultDict.Value.Add(Table.GetControlFromPosition(0, i).Text, Res.InitialActivityResult);
                }
            }
            Database DB = Database.getInstance();
            await DB.WriteActivity(AppConstants.CurrentUser.SimpleName,
                ActivityNameTB.Text, JsonConvert.SerializeObject(resultDict));
            Close();
        }
    }
}
