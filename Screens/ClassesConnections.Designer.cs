namespace Diploma2020.Screens
{
    partial class ClassesConnections
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
            this.ClassNameLbl = new System.Windows.Forms.Label();
            this.TeacherNameLbl = new System.Windows.Forms.Label();
            this.ButtonsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.Table.SuspendLayout();
            this.ButtonsFlow.SuspendLayout();
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
            this.Table.BackColor = System.Drawing.Color.Transparent;
            this.Table.ColumnCount = 2;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Controls.Add(this.ClassNameLbl, 0, 0);
            this.Table.Controls.Add(this.TeacherNameLbl, 1, 0);
            this.Table.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Table.Location = new System.Drawing.Point(3, 3);
            this.Table.Name = "Table";
            this.Table.RowCount = 2;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.Table.Size = new System.Drawing.Size(770, 368);
            this.Table.TabIndex = 0;
            // 
            // ClassNameLbl
            // 
            this.ClassNameLbl.AutoSize = true;
            this.ClassNameLbl.Location = new System.Drawing.Point(3, 0);
            this.ClassNameLbl.Name = "ClassNameLbl";
            this.ClassNameLbl.Size = new System.Drawing.Size(145, 32);
            this.ClassNameLbl.TabIndex = 0;
            this.ClassNameLbl.Text = "ClassName";
            // 
            // TeacherNameLbl
            // 
            this.TeacherNameLbl.AutoSize = true;
            this.TeacherNameLbl.Location = new System.Drawing.Point(388, 0);
            this.TeacherNameLbl.Name = "TeacherNameLbl";
            this.TeacherNameLbl.Size = new System.Drawing.Size(172, 32);
            this.TeacherNameLbl.TabIndex = 1;
            this.TeacherNameLbl.Text = "TeacherName";
            // 
            // ButtonsFlow
            // 
            this.ButtonsFlow.BackColor = System.Drawing.Color.Transparent;
            this.ButtonsFlow.Controls.Add(this.SaveBtn);
            this.ButtonsFlow.Controls.Add(this.CloseBtn);
            this.ButtonsFlow.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonsFlow.Location = new System.Drawing.Point(12, 389);
            this.ButtonsFlow.Name = "ButtonsFlow";
            this.ButtonsFlow.Size = new System.Drawing.Size(776, 49);
            this.ButtonsFlow.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(3, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(384, 46);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(393, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(380, 46);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ClassesConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diploma2020.Properties.Resources.FonPct;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonsFlow);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ClassesConnections";
            this.Text = "ClassesConnections";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Table.ResumeLayout(false);
            this.Table.PerformLayout();
            this.ButtonsFlow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel ButtonsFlow;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Label ClassNameLbl;
        private System.Windows.Forms.Label TeacherNameLbl;
    }
}