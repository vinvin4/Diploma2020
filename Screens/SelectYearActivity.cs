using Diploma2020.Helpers;
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
    public partial class SelectYearActivity : Form
    {
        public SelectYearActivity()
        {
            InitializeComponent();
            NewActivityBtn.BigBtnSetStyle(Res.AddActivityBtn);
            UpdateActivityBtn.BigBtnSetStyle(Res.UpdateActivityBtn);
            WriteFileBtn.BigBtnSetStyle(Res.ExportDataBtn);
            WriteFileBtn.Visible = AppConstants.CurrentUser.IsAdmin;
        }

        private void NewActivityBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddNewYearActivity().ShowDialog();
            this.Show();
        }

        private void UpdateActivityBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateTeacherActivity().ShowDialog();
            this.Show();
        }

        private async void WriteFileBtn_Click(object sender, EventArgs e)
        {
            Database DB = Database.getInstance();
            var value = await DB.ReadActivity();
            (new Thread(async delegate () {
                Utilities.WriteActivitiesIntoWordFile(value);
            })).Start();
        }
    }
}
