using Diploma2020.Helpers;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Res = Diploma2020.Properties.Resources;

namespace Diploma2020.Screens
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
            teacherCB.Items.AddRange(AppConstants.teacs.Select(item => item.SimpleName).ToArray());

            SaveBtn.BigBtnSetStyle(Res.SaveBtn);
            CloseBtn.BigBtnSetStyle(Res.CloseBtn);

            Box.Text = Res.AdminPost;
            SaveBtn.Enabled = false;
        }

        private void teacherCB_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SaveBtn.Enabled = !string.IsNullOrEmpty(teacherCB.Text);
        }

        private void SaveBtn_Click(object sender, System.EventArgs e)
        {
            AppConstants.teacs.Find(item => item.SimpleName == teacherCB.Text).IsAdmin = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CloseBtn_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
