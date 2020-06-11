using Diploma2020.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Res = Diploma2020.Properties.Resources;

namespace Diploma2020.Screens
{
    public partial class ChooseFunctionality : Form
    {
        public ChooseFunctionality()
        {
            InitializeComponent();
            CloseBtn.BigBtnSetStyle(Res.CloseBtn);
            Welkomelbl.Size = new Size(300, 40);
            Welkomelbl.Text = string.Format(Res.AuthoredWelkomeLbl, AppConstants.CurrentUser.FullName);
            OlympicBtn.BigBtnSetStyle(Res.OlympicLbl);
            OlympicBtn.Enabled = !string.IsNullOrEmpty(AppConstants.CurrentUser.Class);
            Filters.BigBtnSetStyle(Res.Filters);

            YearlyReportBtn.BigBtnSetStyle(Res.YearlyReportLbl);
            YearlyReportBtn.Enabled = AppConstants.CurrentUser.IsAdmin;

            YearActivitiesBtn.BigBtnSetStyle(Res.YearActivitiesBtn);

            FinishYearBtn.BigBtnSetStyle(Res.FinishYearLbl);
            FinishYearBtn.Enabled = AppConstants.CurrentUser.IsAdmin;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OlympicBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OlympicProcess().ShowDialog();
            this.Show();
        }

        private void YearlyReportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new YearlyReport().ShowDialog();
            this.Show();
        }

        private void Filters_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EnlistmentOfficeFilters().ShowDialog();
            this.Show();
        }

        private void YearActivitiesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SelectYearActivity().ShowDialog();
            this.Show();
        }

        private void ButtonsFlow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FinishYearBtn_Click(object sender, EventArgs e)
        {
            Database.CloseCon();

            string filePath = string.Join("/", AppConstants.DiskToDocs, AppConstants.ProjectDirectory);
            List<string> packages = new List<string>()
            {
                AppConstants.ActivityDirectory, AppConstants.ClassDataDirectory, AppConstants.CustomFilesDirectory,
                AppConstants.FiltersDirectory, AppConstants.OlympicDirectory
            };
            foreach(string item in packages)
            {
                if (Directory.Exists(filePath + "/" + item))
                {
                    Directory.Delete(filePath + "/" + item, true);
                }
            }
            Database DB = Database.getInstance();
            Database.CloseCon();
            Close();
        }
    }
}
