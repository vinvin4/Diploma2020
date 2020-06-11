namespace Diploma2020.Screens
{
    partial class AdminScreen
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
            this.Box = new System.Windows.Forms.GroupBox();
            this.teacherCB = new System.Windows.Forms.ComboBox();
            this.Flow = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.Box.SuspendLayout();
            this.Flow.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.BackColor = System.Drawing.Color.Transparent;
            this.Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Box.Controls.Add(this.teacherCB);
            this.Box.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box.Location = new System.Drawing.Point(121, 198);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(531, 76);
            this.Box.TabIndex = 0;
            this.Box.TabStop = false;
            this.Box.Text = "groupBox1";
            // 
            // teacherCB
            // 
            this.teacherCB.FormattingEnabled = true;
            this.teacherCB.Location = new System.Drawing.Point(6, 31);
            this.teacherCB.Name = "teacherCB";
            this.teacherCB.Size = new System.Drawing.Size(519, 39);
            this.teacherCB.TabIndex = 0;
            this.teacherCB.SelectedIndexChanged += new System.EventHandler(this.teacherCB_SelectedIndexChanged);
            // 
            // Flow
            // 
            this.Flow.BackColor = System.Drawing.Color.Transparent;
            this.Flow.Controls.Add(this.SaveBtn);
            this.Flow.Controls.Add(this.CloseBtn);
            this.Flow.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Flow.Location = new System.Drawing.Point(12, 387);
            this.Flow.Name = "Flow";
            this.Flow.Size = new System.Drawing.Size(776, 51);
            this.Flow.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(3, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(379, 48);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(388, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(380, 48);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diploma2020.Properties.Resources.FonPct;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Flow);
            this.Controls.Add(this.Box);
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.Box.ResumeLayout(false);
            this.Flow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.ComboBox teacherCB;
        private System.Windows.Forms.FlowLayoutPanel Flow;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}