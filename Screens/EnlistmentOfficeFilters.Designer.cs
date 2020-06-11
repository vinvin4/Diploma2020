namespace Diploma2020.Screens
{
    partial class EnlistmentOfficeFilters
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
            this.SexContainer = new System.Windows.Forms.GroupBox();
            this.SexCB = new System.Windows.Forms.ComboBox();
            this.YearContainer = new System.Windows.Forms.GroupBox();
            this.YearCB = new System.Windows.Forms.ComboBox();
            this.NameContainer = new System.Windows.Forms.GroupBox();
            this.PressNameTB = new System.Windows.Forms.TextBox();
            this.AddressContainer = new System.Windows.Forms.GroupBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SexContainer.SuspendLayout();
            this.YearContainer.SuspendLayout();
            this.NameContainer.SuspendLayout();
            this.AddressContainer.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.SexContainer);
            this.flowLayoutPanel1.Controls.Add(this.YearContainer);
            this.flowLayoutPanel1.Controls.Add(this.NameContainer);
            this.flowLayoutPanel1.Controls.Add(this.AddressContainer);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 377);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // SexContainer
            // 
            this.SexContainer.Controls.Add(this.SexCB);
            this.SexContainer.Location = new System.Drawing.Point(3, 3);
            this.SexContainer.Name = "SexContainer";
            this.SexContainer.Size = new System.Drawing.Size(241, 103);
            this.SexContainer.TabIndex = 0;
            this.SexContainer.TabStop = false;
            this.SexContainer.Text = "Sex";
            // 
            // SexCB
            // 
            this.SexCB.FormattingEnabled = true;
            this.SexCB.Location = new System.Drawing.Point(6, 48);
            this.SexCB.Name = "SexCB";
            this.SexCB.Size = new System.Drawing.Size(229, 39);
            this.SexCB.TabIndex = 0;
            // 
            // YearContainer
            // 
            this.YearContainer.Controls.Add(this.YearCB);
            this.YearContainer.Location = new System.Drawing.Point(250, 3);
            this.YearContainer.Name = "YearContainer";
            this.YearContainer.Size = new System.Drawing.Size(234, 103);
            this.YearContainer.TabIndex = 1;
            this.YearContainer.TabStop = false;
            this.YearContainer.Text = "Year";
            // 
            // YearCB
            // 
            this.YearCB.FormattingEnabled = true;
            this.YearCB.Location = new System.Drawing.Point(6, 48);
            this.YearCB.Name = "YearCB";
            this.YearCB.Size = new System.Drawing.Size(222, 39);
            this.YearCB.TabIndex = 0;
            // 
            // NameContainer
            // 
            this.NameContainer.Controls.Add(this.PressNameTB);
            this.NameContainer.Location = new System.Drawing.Point(3, 112);
            this.NameContainer.Name = "NameContainer";
            this.NameContainer.Size = new System.Drawing.Size(378, 100);
            this.NameContainer.TabIndex = 2;
            this.NameContainer.TabStop = false;
            this.NameContainer.Text = "Name";
            // 
            // PressNameTB
            // 
            this.PressNameTB.Location = new System.Drawing.Point(3, 35);
            this.PressNameTB.Name = "PressNameTB";
            this.PressNameTB.Size = new System.Drawing.Size(369, 39);
            this.PressNameTB.TabIndex = 0;
            // 
            // AddressContainer
            // 
            this.AddressContainer.Controls.Add(this.AddressTB);
            this.AddressContainer.Location = new System.Drawing.Point(387, 112);
            this.AddressContainer.Name = "AddressContainer";
            this.AddressContainer.Size = new System.Drawing.Size(378, 100);
            this.AddressContainer.TabIndex = 3;
            this.AddressContainer.TabStop = false;
            this.AddressContainer.Text = "Address";
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(3, 35);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(369, 39);
            this.AddressTB.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.SaveBtn);
            this.flowLayoutPanel2.Controls.Add(this.CloseBtn);
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 395);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(776, 43);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(3, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(378, 40);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(387, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(378, 40);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // EnlistmentOfficeFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diploma2020.Properties.Resources.FonPct;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "EnlistmentOfficeFilters";
            this.Text = "EnlistmentOfficeFilters";
            this.Load += new System.EventHandler(this.EnlistmentOfficeFilters_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.SexContainer.ResumeLayout(false);
            this.YearContainer.ResumeLayout(false);
            this.NameContainer.ResumeLayout(false);
            this.NameContainer.PerformLayout();
            this.AddressContainer.ResumeLayout(false);
            this.AddressContainer.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox SexContainer;
        private System.Windows.Forms.ComboBox SexCB;
        private System.Windows.Forms.GroupBox YearContainer;
        private System.Windows.Forms.ComboBox YearCB;
        private System.Windows.Forms.GroupBox NameContainer;
        private System.Windows.Forms.TextBox PressNameTB;
        private System.Windows.Forms.GroupBox AddressContainer;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}