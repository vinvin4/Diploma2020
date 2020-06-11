namespace Diploma2020.Screens
{
    partial class WelkomeScreen
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
            this.WelkomeFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.WelkomeLbl = new System.Windows.Forms.Label();
            this.TeacherCB = new System.Windows.Forms.ComboBox();
            this.NextPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RegistrationBtn = new System.Windows.Forms.Button();
            this.ContinueBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.WelkomeFlow.SuspendLayout();
            this.NextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelkomeFlow
            // 
            this.WelkomeFlow.BackgroundImage = global::Diploma2020.Properties.Resources.FonPct;
            this.WelkomeFlow.Controls.Add(this.WelkomeLbl);
            this.WelkomeFlow.Controls.Add(this.TeacherCB);
            this.WelkomeFlow.Controls.Add(this.NextPanel);
            this.WelkomeFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelkomeFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.WelkomeFlow.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelkomeFlow.Location = new System.Drawing.Point(0, 0);
            this.WelkomeFlow.Margin = new System.Windows.Forms.Padding(5);
            this.WelkomeFlow.Name = "WelkomeFlow";
            this.WelkomeFlow.Size = new System.Drawing.Size(800, 450);
            this.WelkomeFlow.TabIndex = 0;
            // 
            // WelkomeLbl
            // 
            this.WelkomeLbl.AutoSize = true;
            this.WelkomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.WelkomeLbl.Location = new System.Drawing.Point(3, 0);
            this.WelkomeLbl.Name = "WelkomeLbl";
            this.WelkomeLbl.Size = new System.Drawing.Size(191, 32);
            this.WelkomeLbl.TabIndex = 0;
            this.WelkomeLbl.Text = "Welkome Label";
            // 
            // TeacherCB
            // 
            this.TeacherCB.FormattingEnabled = true;
            this.TeacherCB.Location = new System.Drawing.Point(15, 47);
            this.TeacherCB.Margin = new System.Windows.Forms.Padding(15);
            this.TeacherCB.Name = "TeacherCB";
            this.TeacherCB.Size = new System.Drawing.Size(761, 39);
            this.TeacherCB.TabIndex = 1;
            this.TeacherCB.SelectedIndexChanged += new System.EventHandler(this.TeacherCB_SelectedIndexChanged);
            // 
            // NextPanel
            // 
            this.NextPanel.BackColor = System.Drawing.Color.Transparent;
            this.NextPanel.Controls.Add(this.RegistrationBtn);
            this.NextPanel.Controls.Add(this.ContinueBtn);
            this.NextPanel.Controls.Add(this.CloseBtn);
            this.NextPanel.Location = new System.Drawing.Point(15, 116);
            this.NextPanel.Margin = new System.Windows.Forms.Padding(15);
            this.NextPanel.Name = "NextPanel";
            this.NextPanel.Size = new System.Drawing.Size(390, 207);
            this.NextPanel.TabIndex = 3;
            // 
            // RegistrationBtn
            // 
            this.RegistrationBtn.Location = new System.Drawing.Point(5, 5);
            this.RegistrationBtn.Margin = new System.Windows.Forms.Padding(5);
            this.RegistrationBtn.Name = "RegistrationBtn";
            this.RegistrationBtn.Size = new System.Drawing.Size(329, 64);
            this.RegistrationBtn.TabIndex = 0;
            this.RegistrationBtn.Text = "Регистрация";
            this.RegistrationBtn.UseVisualStyleBackColor = true;
            this.RegistrationBtn.Click += new System.EventHandler(this.RegistrationBtn_Click);
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.Location = new System.Drawing.Point(5, 79);
            this.ContinueBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(329, 62);
            this.ContinueBtn.TabIndex = 1;
            this.ContinueBtn.Text = "Продолжить";
            this.ContinueBtn.UseVisualStyleBackColor = true;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackgroundImage = global::Diploma2020.Properties.Resources.BigBtn;
            this.CloseBtn.Location = new System.Drawing.Point(5, 151);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(5);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(329, 63);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // WelkomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WelkomeFlow);
            this.Name = "WelkomeScreen";
            this.Text = "Оптимизация отчётности учителей";
            this.Load += new System.EventHandler(this.WelkomeScreen_Load);
            this.WelkomeFlow.ResumeLayout(false);
            this.WelkomeFlow.PerformLayout();
            this.NextPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel WelkomeFlow;
        private System.Windows.Forms.Label WelkomeLbl;
        private System.Windows.Forms.ComboBox TeacherCB;
        private System.Windows.Forms.FlowLayoutPanel NextPanel;
        private System.Windows.Forms.Button RegistrationBtn;
        private System.Windows.Forms.Button ContinueBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}