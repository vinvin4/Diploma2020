using Diploma2020.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Res = Diploma2020.Properties.Resources;

namespace Diploma2020.Screens
{
    public partial class ClassesConnections : Form
    {
        List<string> classes = AppConstants.AvailableClassesList;
        List<string> teachers = AppConstants.teacs.Select(item => item.SimpleName).ToList();
        Dictionary<string, string> classesConnections = null;
        #region Helpers
        private void InitialiseTable()
        {
            classesConnections = classes.ToDictionary(item => item, item => string.Empty);
            for (int i=0; i<classes.Count; i++)
            {
                AddNewLine(classes[i]);
            }
        }

        /// <summary>
        /// Add new line in the table
        /// </summary>
        private void AddNewLine(string className)
        {
            int rowCount = Table.RowCount;
            Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            Table.RowCount++;
            Label lbl = new Label();
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.BackColor = Color.Transparent;
            lbl.Text = className;
            lbl.Margin = new Padding(5);
            Table.Controls.Add(lbl, 0, rowCount);

            ComboBox cb = new ComboBox();
            cb.Size = new Size(280, 30);
            cb.Items.AddRange(teachers.ToArray());
            cb.Margin = new Padding(5);
            cb.SelectedIndexChanged += SelectTeacherCB;
            Table.Controls.Add(cb, 1, rowCount);
        }
        #endregion
        public ClassesConnections()
        {
            InitializeComponent();
            ClassNameLbl.Text = Res.ClassNameLbl;
            TeacherNameLbl.Text = Res.AdminTeacherLbl;

            CloseBtn.BigBtnSetStyle(Res.CloseBtn);
            SaveBtn.BigBtnSetStyle(Res.SaveBtn);

            InitialiseTable();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectTeacherCB(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string selectedItem = cb.Text;

            var pos = Table.GetCellPosition(cb);
            string affectedClassName = Table.GetControlFromPosition(0, pos.Row).Text;
            classesConnections[affectedClassName] = selectedItem;
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            var anyDuplicate = classesConnections
                .Select(item => item.Value)
                .GroupBy(x => x)
                .Any(g => g.Count() > 1);
            if (anyDuplicate)
            {
                Utilities.RepeatedValues();
                return;
            }
            List<string> errorClasses = classesConnections.Where(item => string.IsNullOrEmpty(item.Value))
                .Select(item => item.Key).ToList();
            bool result = errorClasses.Any();
            if (result)
            {
                Utilities.FillTheTable(string.Join(" ", errorClasses));
            }
            else
            {
                foreach (var item in classesConnections)
                {
                    Teacher th = AppConstants.teacs.Find(teacher => teacher.SimpleName == item.Value);
                    AppConstants.teacs.Find(teacher => teacher.SimpleName == item.Value).Class = item.Key;
                }

                (new Thread(async delegate () {
                    await Database.getInstance().WriteTeachers(AppConstants.teacs);
                })).Start();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
