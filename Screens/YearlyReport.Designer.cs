namespace Diploma2020.Screens
{
    partial class YearlyReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.TeacherSecLbl = new System.Windows.Forms.Label();
            this.TeacherFirstLbl = new System.Windows.Forms.Label();
            this.ClassLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.Table.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.Table);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 371);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Table
            // 
            this.Table.AutoScroll = true;
            this.Table.ColumnCount = 3;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Table.Controls.Add(this.TeacherSecLbl, 2, 0);
            this.Table.Controls.Add(this.TeacherFirstLbl, 1, 0);
            this.Table.Controls.Add(this.ClassLbl, 0, 0);
            this.Table.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Table.Location = new System.Drawing.Point(3, 3);
            this.Table.Name = "Table";
            this.Table.RowCount = 2;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.Table.Size = new System.Drawing.Size(769, 368);
            this.Table.TabIndex = 0;
            this.Table.Paint += new System.Windows.Forms.PaintEventHandler(this.Table_Paint);
            // 
            // TeacherSecLbl
            // 
            this.TeacherSecLbl.AutoSize = true;
            this.TeacherSecLbl.Location = new System.Drawing.Point(463, 0);
            this.TeacherSecLbl.Name = "TeacherSecLbl";
            this.TeacherSecLbl.Size = new System.Drawing.Size(105, 32);
            this.TeacherSecLbl.TabIndex = 0;
            this.TeacherSecLbl.Text = "Teacher";
            // 
            // TeacherFirstLbl
            // 
            this.TeacherFirstLbl.AutoSize = true;
            this.TeacherFirstLbl.Location = new System.Drawing.Point(156, 0);
            this.TeacherFirstLbl.Name = "TeacherFirstLbl";
            this.TeacherFirstLbl.Size = new System.Drawing.Size(105, 32);
            this.TeacherFirstLbl.TabIndex = 1;
            this.TeacherFirstLbl.Text = "Teacher";
            // 
            // ClassLbl
            // 
            this.ClassLbl.AutoSize = true;
            this.ClassLbl.Location = new System.Drawing.Point(3, 0);
            this.ClassLbl.Name = "ClassLbl";
            this.ClassLbl.Size = new System.Drawing.Size(78, 32);
            this.ClassLbl.TabIndex = 2;
            this.ClassLbl.Text = "Class";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.SaveBtn);
            this.flowLayoutPanel2.Controls.Add(this.CloseBtn);
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 389);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(776, 49);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(3, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(380, 46);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(389, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(383, 46);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // YearlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diploma2020.Properties.Resources.FonPct;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "YearlyReport";
            this.Text = "YearlyReport";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Table.ResumeLayout(false);
            this.Table.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Label TeacherSecLbl;
        private System.Windows.Forms.Label TeacherFirstLbl;
        private System.Windows.Forms.Label ClassLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}