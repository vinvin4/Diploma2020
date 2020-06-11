namespace Diploma2020.Screens
{
    partial class SelectYearActivity
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
            this.NewActivityBtn = new System.Windows.Forms.Button();
            this.UpdateActivityBtn = new System.Windows.Forms.Button();
            this.WriteFileBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.NewActivityBtn);
            this.flowLayoutPanel1.Controls.Add(this.UpdateActivityBtn);
            this.flowLayoutPanel1.Controls.Add(this.WriteFileBtn);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 231);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // NewActivityBtn
            // 
            this.NewActivityBtn.Location = new System.Drawing.Point(3, 3);
            this.NewActivityBtn.Name = "NewActivityBtn";
            this.NewActivityBtn.Size = new System.Drawing.Size(319, 58);
            this.NewActivityBtn.TabIndex = 0;
            this.NewActivityBtn.Text = "button1";
            this.NewActivityBtn.UseVisualStyleBackColor = true;
            this.NewActivityBtn.Click += new System.EventHandler(this.NewActivityBtn_Click);
            // 
            // UpdateActivityBtn
            // 
            this.UpdateActivityBtn.Location = new System.Drawing.Point(3, 67);
            this.UpdateActivityBtn.Name = "UpdateActivityBtn";
            this.UpdateActivityBtn.Size = new System.Drawing.Size(319, 58);
            this.UpdateActivityBtn.TabIndex = 1;
            this.UpdateActivityBtn.Text = "button2";
            this.UpdateActivityBtn.UseVisualStyleBackColor = true;
            this.UpdateActivityBtn.Click += new System.EventHandler(this.UpdateActivityBtn_Click);
            // 
            // WriteFileBtn
            // 
            this.WriteFileBtn.Location = new System.Drawing.Point(3, 131);
            this.WriteFileBtn.Name = "WriteFileBtn";
            this.WriteFileBtn.Size = new System.Drawing.Size(319, 58);
            this.WriteFileBtn.TabIndex = 2;
            this.WriteFileBtn.Text = "button3";
            this.WriteFileBtn.UseVisualStyleBackColor = true;
            this.WriteFileBtn.Click += new System.EventHandler(this.WriteFileBtn_Click);
            // 
            // SelectYearActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diploma2020.Properties.Resources.FonPct;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SelectYearActivity";
            this.Text = "SelectYearActivities";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button NewActivityBtn;
        private System.Windows.Forms.Button UpdateActivityBtn;
        private System.Windows.Forms.Button WriteFileBtn;
    }
}