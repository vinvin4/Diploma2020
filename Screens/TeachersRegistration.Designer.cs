namespace Diploma2020.Screens
{
    partial class TeachersRegistration
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
            this.TeachersFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.FullNameLbl = new System.Windows.Forms.Label();
            this.ColumnNameCB = new System.Windows.Forms.ComboBox();
            this.TeachersFlow.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeachersFlow
            // 
            this.TeachersFlow.BackgroundImage = global::Diploma2020.Properties.Resources.FonPct;
            this.TeachersFlow.Controls.Add(this.flowLayoutPanel1);
            this.TeachersFlow.Controls.Add(this.Table);
            this.TeachersFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeachersFlow.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.TeachersFlow.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeachersFlow.Location = new System.Drawing.Point(0, 0);
            this.TeachersFlow.Name = "TeachersFlow";
            this.TeachersFlow.Size = new System.Drawing.Size(800, 450);
            this.TeachersFlow.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.SaveBtn);
            this.flowLayoutPanel1.Controls.Add(this.ExportBtn);
            this.flowLayoutPanel1.Controls.Add(this.CloseBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 384);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(795, 61);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(5, 5);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(253, 50);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportBtn.Location = new System.Drawing.Point(268, 5);
            this.ExportBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(253, 50);
            this.ExportBtn.TabIndex = 1;
            this.ExportBtn.Text = "Word";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(531, 5);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(5);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(253, 50);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Table
            // 
            this.Table.AutoScroll = true;
            this.Table.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.Table.BackColor = System.Drawing.Color.Transparent;
            this.Table.ColumnCount = 2;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Controls.Add(this.FullNameLbl, 0, 0);
            this.Table.Controls.Add(this.ColumnNameCB, 1, 0);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Table.Location = new System.Drawing.Point(5, 10);
            this.Table.Margin = new System.Windows.Forms.Padding(5);
            this.Table.Name = "Table";
            this.Table.RowCount = 2;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.Table.Size = new System.Drawing.Size(795, 364);
            this.Table.TabIndex = 1;
            // 
            // FullNameLbl
            // 
            this.FullNameLbl.AutoSize = true;
            this.FullNameLbl.Location = new System.Drawing.Point(3, 0);
            this.FullNameLbl.Name = "FullNameLbl";
            this.FullNameLbl.Size = new System.Drawing.Size(57, 23);
            this.FullNameLbl.TabIndex = 7;
            this.FullNameLbl.Text = "ФИО";
            // 
            // ColumnNameCB
            // 
            this.ColumnNameCB.FormattingEnabled = true;
            this.ColumnNameCB.Location = new System.Drawing.Point(400, 3);
            this.ColumnNameCB.Name = "ColumnNameCB";
            this.ColumnNameCB.Size = new System.Drawing.Size(383, 31);
            this.ColumnNameCB.TabIndex = 8;
            this.ColumnNameCB.SelectedIndexChanged += new System.EventHandler(this.ColumnNameCB_SelectedIndexChanged);
            // 
            // TeachersRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TeachersFlow);
            this.Name = "TeachersRegistration";
            this.Text = "TeachersRegistration";
            this.TeachersFlow.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Table.ResumeLayout(false);
            this.Table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TeachersFlow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Label FullNameLbl;
        private System.Windows.Forms.ComboBox ColumnNameCB;
    }
}