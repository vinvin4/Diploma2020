namespace Diploma2020.Screens
{
    partial class AddNewYearActivity
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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.ClassLbl = new System.Windows.Forms.Label();
            this.ChooseClassCB = new System.Windows.Forms.ComboBox();
            this.ActivityNameLbl = new System.Windows.Forms.Label();
            this.ActivityNameTB = new System.Windows.Forms.TextBox();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.NeedToProcessLbl = new System.Windows.Forms.Label();
            this.FullNameLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.Table.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.Table);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 365);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.ClassLbl);
            this.flowLayoutPanel3.Controls.Add(this.ChooseClassCB);
            this.flowLayoutPanel3.Controls.Add(this.ActivityNameLbl);
            this.flowLayoutPanel3.Controls.Add(this.ActivityNameTB);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(770, 44);
            this.flowLayoutPanel3.TabIndex = 0;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // ClassLbl
            // 
            this.ClassLbl.AutoSize = true;
            this.ClassLbl.Location = new System.Drawing.Point(3, 0);
            this.ClassLbl.Name = "ClassLbl";
            this.ClassLbl.Size = new System.Drawing.Size(95, 32);
            this.ClassLbl.TabIndex = 0;
            this.ClassLbl.Text = "Класс:";
            // 
            // ChooseClassCB
            // 
            this.ChooseClassCB.FormattingEnabled = true;
            this.ChooseClassCB.Location = new System.Drawing.Point(104, 3);
            this.ChooseClassCB.Name = "ChooseClassCB";
            this.ChooseClassCB.Size = new System.Drawing.Size(181, 39);
            this.ChooseClassCB.TabIndex = 1;
            this.ChooseClassCB.SelectedIndexChanged += new System.EventHandler(this.ChooseClassCB_SelectedIndexChanged);
            // 
            // ActivityNameLbl
            // 
            this.ActivityNameLbl.AutoSize = true;
            this.ActivityNameLbl.Location = new System.Drawing.Point(291, 0);
            this.ActivityNameLbl.Name = "ActivityNameLbl";
            this.ActivityNameLbl.Size = new System.Drawing.Size(140, 32);
            this.ActivityNameLbl.TabIndex = 2;
            this.ActivityNameLbl.Text = "Название:";
            // 
            // ActivityNameTB
            // 
            this.ActivityNameTB.Location = new System.Drawing.Point(437, 3);
            this.ActivityNameTB.Name = "ActivityNameTB";
            this.ActivityNameTB.Size = new System.Drawing.Size(316, 39);
            this.ActivityNameTB.TabIndex = 3;
            // 
            // Table
            // 
            this.Table.AutoScroll = true;
            this.Table.ColumnCount = 2;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.Table.Controls.Add(this.NeedToProcessLbl, 1, 0);
            this.Table.Controls.Add(this.FullNameLbl, 0, 0);
            this.Table.Location = new System.Drawing.Point(3, 53);
            this.Table.Name = "Table";
            this.Table.RowCount = 2;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.Table.Size = new System.Drawing.Size(770, 312);
            this.Table.TabIndex = 1;
            // 
            // NeedToProcessLbl
            // 
            this.NeedToProcessLbl.AutoSize = true;
            this.NeedToProcessLbl.Location = new System.Drawing.Point(542, 0);
            this.NeedToProcessLbl.Name = "NeedToProcessLbl";
            this.NeedToProcessLbl.Size = new System.Drawing.Size(85, 32);
            this.NeedToProcessLbl.TabIndex = 0;
            this.NeedToProcessLbl.Text = "label1";
            // 
            // FullNameLbl
            // 
            this.FullNameLbl.AutoSize = true;
            this.FullNameLbl.Location = new System.Drawing.Point(3, 0);
            this.FullNameLbl.Name = "FullNameLbl";
            this.FullNameLbl.Size = new System.Drawing.Size(85, 32);
            this.FullNameLbl.TabIndex = 1;
            this.FullNameLbl.Text = "label1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.SaveBtn);
            this.flowLayoutPanel2.Controls.Add(this.CloseBtn);
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 383);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(776, 55);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(3, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(376, 52);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(385, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(388, 52);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AddNewYearActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diploma2020.Properties.Resources.FonPct;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AddNewYearActivity";
            this.Text = "AddNewYearActivity";
            this.Load += new System.EventHandler(this.AddNewYearActivity_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.Table.ResumeLayout(false);
            this.Table.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label ClassLbl;
        private System.Windows.Forms.ComboBox ChooseClassCB;
        private System.Windows.Forms.Label ActivityNameLbl;
        private System.Windows.Forms.TextBox ActivityNameTB;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Label NeedToProcessLbl;
        private System.Windows.Forms.Label FullNameLbl;
    }
}