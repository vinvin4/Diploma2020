using Diploma2020.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Res = Diploma2020.Properties.Resources;

namespace Diploma2020.Screens
{
    public partial class UpdateTeacherActivity : Form
    {
        KeyValuePair<string, Dictionary<string, string>> resultDict;
        Dictionary<string, string> readedDict;
        #region Helpers

        private async void InitialiseDictAsync()
        {
            Database DB = Database.getInstance();
            readedDict = await DB.ReadActivity(AppConstants.CurrentUser.SimpleName);
            ActivitiesCB.Items.AddRange(readedDict.Select(item => item.Key).ToArray());
            Thread.Sleep(1000);

        }
        /// <summary>
        /// Helper function to Clear the table
        /// </summary>
        private void ClearTable()
        {
            for (int i = Table.RowCount; i > 1;)
            {
                i--;
                for (int j = 0; j < 2; j++)
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
        private void AddNewLine(string pupilName, string value)
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

            TextBox tb = new TextBox();
            tb.Text = value;
            tb.Size = new Size(200, 30);
            Table.Controls.Add(tb, 1, rowCount);
        }
        #endregion
        public UpdateTeacherActivity()
        {            
            InitializeComponent();
            InitialiseDictAsync();

            ClassNameLbl.Text = string.Empty;

            SaveBtn.Enabled = false;            
        }

        private void UpdateTeacherActivity_Load(object sender, EventArgs e)
        {
            ClassLbl.Text = Res.ClassNameLbl;
            ActivityNameLbl.Text = Res.ActivityNameLbl;

            FullNameLbl.Text = Res.FullNameLbl;
            StatusLbl.Text = Res.StatusLbl;

            SaveBtn.BigBtnSetStyle(Res.SaveBtn);
            CloseBtn.BigBtnSetStyle(Res.CloseBtn);
        }

        private void ActivitiesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ActivitiesCB.Text))
            {
                return;
            }

            SaveBtn.Enabled = true;
            resultDict = JsonConvert.DeserializeObject<KeyValuePair<string, Dictionary<string, string>>>(readedDict[ActivitiesCB.Text]);

            ClassNameLbl.Text = resultDict.Key;

            ClearTable();
            foreach (var item in resultDict.Value)
            {
                AddNewLine(item.Key, item.Value);
            }
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ActivitiesCB.Text))
            {
                Utilities.FillTheTable();
                return;
            }

            resultDict = new KeyValuePair<string, Dictionary<string, string>>(resultDict.Key, new Dictionary<string, string>());
            for (int i = 1; i < Table.RowCount; i++)
            {
                resultDict.Value.Add(Table.GetControlFromPosition(0, i).Text,
                    Table.GetControlFromPosition(1, i).Text);
            }
            Database DB = Database.getInstance();
            await DB.UpdateActivity(AppConstants.CurrentUser.SimpleName,
                ActivitiesCB.Text, JsonConvert.SerializeObject(resultDict));
            Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
