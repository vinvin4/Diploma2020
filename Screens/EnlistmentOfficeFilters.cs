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
    public partial class EnlistmentOfficeFilters : Form
    {
        public EnlistmentOfficeFilters()
        {
            InitializeComponent();

            SexCB.Items.AddRange(new string[] { "М", "Ж" });
            SexCB.SelectedIndex = 0;

            YearCB.Items.AddRange(AppConstants.pupils
                .Select(item => item.AddInfo.Birthday.Substring(item.AddInfo.Birthday.Length - 4))
                .ToList().Distinct().ToList().OrderBy(item => item).ToArray());
            int currYear = DateTime.Now.Year - 14;
            YearCB.SelectedIndex = YearCB.Items.IndexOf(currYear.ToString());
            
        }

        private void EnlistmentOfficeFilters_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            SaveBtn.BigBtnSetStyle(Res.SaveBtn);
            CloseBtn.BigBtnSetStyle(Res.CloseBtn);
            SexContainer.Text = Res.PupilSexLbl;
            AddressContainer.Text = Res.PupilsAddressLbl;
            YearContainer.Text = Res.YearBirthLbl;
            NameContainer.Text = Res.FullNameLbl;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string sex = SexCB.Text;
            string year = YearCB.Text;
            string name = PressNameTB.Text;
            string address = AddressTB.Text;

            List<Pupil> list = AppConstants.pupils;
            if (!string.IsNullOrEmpty(sex))
            {
                list = list.Where(item => item.AddInfo.Sex.CompareTo("M") == 0).ToList();
            }

            if(!string.IsNullOrEmpty(year))
            {
                list = list.Where(item => item.AddInfo.Birthday.Contains(year)).ToList();
            }

            if (!string.IsNullOrEmpty(name))
            {
                list = list.Where(item => item.FullName.ToUpper().Contains(name.ToUpper())).ToList();
            }

            if (!string.IsNullOrEmpty(address))
            {
                list = list.Where(item => item.AddInfo.Address.ToUpper().Contains(address.ToUpper())).ToList();
            }

            if (list.Any())
            {
                list = list.OrderBy(item => item.FullName).ToList();
            }

            string finalResult = string.Empty;
            foreach (Pupil item in list)
            {
                finalResult += string.Format("{0}, {1}, {2}\n",
                    item.FullName, item.Class, item.AddInfo.Birthday);
            }
            (new Thread(async delegate () {
                Utilities.WriteFiltersResultIntoFile(finalResult);
            })).Start();
        }
    }
}
