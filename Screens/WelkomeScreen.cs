using Diploma2020.Helpers;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Res = Diploma2020.Properties.Resources;

namespace Diploma2020.Screens
{
    public partial class WelkomeScreen : Form
    {
        bool IsRegistered = false;
        #region Helpers
        /// <summary>
        /// Update UI Visibility, according the stage of using
        /// </summary>
        private void UpdateScreen()
        {
            TeacherCB.Visible = IsRegistered;
            TeacherCB.Items.AddRange(AppConstants.teacs.Select(item => item.SimpleName).ToArray());
            RegistrationBtn.Enabled = !IsRegistered;            
            ContinueBtn.Enabled = false;
        }
        #endregion

        /// <summary>
        /// Initialise Form
        /// </summary>
        public WelkomeScreen()
        {
            InitializeComponent();
            WelkomeLbl.Text = Res.WelkomeLbl;
            RegistrationBtn.BigBtnSetStyle(Res.RegisterBtn);
            ContinueBtn.BigBtnSetStyle(Res.ContinueBtn);
            CloseBtn.BigBtnSetStyle(Res.CloseBtn);
            UpdateScreen();
        }

        /// <summary>
        /// Process "Close" button pressing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Process action, during the choosing UserName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeacherCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContinueBtn.Enabled = !string.IsNullOrEmpty(TeacherCB.Text);
            RegistrationBtn.Enabled = false;
        }

        private void WelkomeScreen_Load(object sender, EventArgs e)
        {
            string filePath = string.Join("/", AppConstants.DiskToDocs, 
                AppConstants.ProjectDirectory, AppConstants.CustomFilesDirectory);
            if (Directory.Exists(filePath))
            {
                filePath = string.Join("/", filePath, AppConstants.RegistationCompleted);
                IsRegistered = File.Exists(filePath);
            }

            if (IsRegistered)
            {
                Database DB = Database.getInstance();
                DB.ReadSubjects();
                DB.ReadTeachers();
                Thread.Sleep(1000);
                Database.CloseCon();
                AppConstants.AvailableClassesList = AppConstants.teacs
                    .Select(item => item.Class)
                    .Where(item => !string.IsNullOrEmpty(item))
                    .ToList();
                UpdateScreen();
            }
            else
            {
                var dialogResult = Utilities.RegistrationDialog();
                if (dialogResult == DialogResult.OK)
                {
                    RegistrationBtn_Click(sender, e);
                }
            }
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            Database DB = Database.getInstance();
            if (DB == null)
            {
                Database.CloseCon();
            }
            if (new TeachersRegistration().ShowDialog() == DialogResult.OK)
            {
                if (new AdminScreen().ShowDialog() == DialogResult.OK)
                {
                    if (new ClassesRegister().ShowDialog() == DialogResult.OK)
                    {
                        if (new ClassesConnections().ShowDialog() == DialogResult.OK)
                        {
                            IsRegistered = new LearningSubjects().ShowDialog() == DialogResult.OK;
                            UpdateScreen();
                        }
                    }
                }
            }
        }

        private async void ContinueBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TeacherCB.Text))
            {
                AppConstants.CurrentUser = AppConstants.teacs.Find(item => item.SimpleName == TeacherCB.Text);

                if (!AppConstants.pupils.Any())
                {
                    Database DB = Database.getInstance();
                    await DB.ReadClass();
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
