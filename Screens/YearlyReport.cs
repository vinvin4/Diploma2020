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
    public partial class YearlyReport : Form
    {
        private List<Teacher> teachers = null;
        private Dictionary<string, List<string>> connections = null;

        #region Helpers
        /// <summary>
        /// Helper function to initialise constants
        /// </summary>
        private void InitialiseTable()
        {
            List<Teacher> teach = null;
            teachers = AppConstants.teacs
                .Where(item => !string.IsNullOrEmpty(item.Class))
                .ToList();
            teach = teachers
                .Where(item => item.Class.Length == 2)
                .OrderBy(item => item.Class)
                .ToList();
            teach.AddRange(teachers
                .Where(item => item.Class.Length == 3)
                .OrderBy(item => item.Class)
                .ToList());
            teachers = teach;

            connections = teachers
                .Select(item => item.SimpleName)
                .ToDictionary(item => item, item => new List<string>());
            for (int i = 0; i < teachers.Count; i++)
            {
                AddNewLine(teachers[i].Class);
            }
        }

        /// <summary>
        /// Helper to Initialise new lines in Table
        /// </summary>
        /// <param name="pupilName"></param>
        private void AddNewLine(string pupilName)
        {
            int rowCount = Table.RowCount;
            Table.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            Table.RowCount++;
            Label lbl = new Label();
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.Text = pupilName;
            lbl.Margin = new Padding(5);
            //lbl.Size = new Size(150, 35);
            Table.Controls.Add(lbl, 0, rowCount);

            ComboBox cb = new ComboBox();
            cb.Items.AddRange(AppConstants.teacs
                .Select(item => item.SimpleName)
                .ToArray());
            cb.Size = new Size(200, 35);
            Table.Controls.Add(cb, 1, rowCount);

            Button btn = new Button();
            btn.Text = "+";
            btn.Click += AddNewTeacher;
            Table.Controls.Add(btn, 2, rowCount);
        }
        #endregion

        public YearlyReport()
        {
            InitializeComponent();
            InitialiseTable();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Table_Paint(object sender, PaintEventArgs e)
        {
            SaveBtn.BigBtnSetStyle(Res.SaveBtn);
            CloseBtn.BigBtnSetStyle(Res.CloseBtn);
            ClassLbl.Text = Res.ClassNameLbl;
            TeacherFirstLbl.Text = Res.TeacherLbl;
            TeacherSecLbl.Text = Res.ExtraTeacherLbl;
        }

        private void AddNewTeacher(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var pos = Table.GetCellPosition(btn);
            if (!string.IsNullOrEmpty(Table.GetControlFromPosition(1, pos.Row).Text))
            {
                btn.Click -= AddNewTeacher;
                Table.Controls.Remove(btn);
                ComboBox cb = new ComboBox();
                cb.Size = new Size(200, 35);
                cb.Items.AddRange(teachers.Select(item => item.SimpleName).ToArray());
                Table.Controls.Add(cb, pos.Column, pos.Row);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            connections = teachers
                .ToDictionary(item => item.Class, item => new List<string>());
            for (int i = 2; i < Table.RowCount; i++)
            {
                string className = Table.GetControlFromPosition(0, i).Text;
                string firstTeacher = Table.GetControlFromPosition(1, i).Text;
                if (string.IsNullOrEmpty(firstTeacher))
                {
                    Utilities.FillTheTable(className);
                    return;
                }
                var el = Table.GetControlFromPosition(2, i);
                string secondTeacher = string.Empty;
                if (el.GetType() != typeof(Button))
                {
                    secondTeacher = el.Text;
                    if (firstTeacher == secondTeacher)
                    {
                        Utilities.RepeatedValues();
                        return;
                    }
                }
                connections[className].Add(firstTeacher);
                connections[className].Add(secondTeacher);              
            }
            (new Thread(async delegate ()
            {
                Utilities.WriteClassInfoIntoWordFile(connections);
            })).Start();
        }
    }
}
