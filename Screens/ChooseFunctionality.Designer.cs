namespace Diploma2020.Screens
{
    partial class ChooseFunctionality
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFunctionality));
            this.CommonFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.Welkomelbl = new System.Windows.Forms.Label();
            this.ButtonsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.OlympicBtn = new System.Windows.Forms.Button();
            this.YearlyReportBtn = new System.Windows.Forms.Button();
            this.Filters = new System.Windows.Forms.Button();
            this.YearActivitiesBtn = new System.Windows.Forms.Button();
            this.FinishYearBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.CommonFlow.SuspendLayout();
            this.ButtonsFlow.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommonFlow
            // 
            this.CommonFlow.BackColor = System.Drawing.Color.Transparent;
            this.CommonFlow.Controls.Add(this.Welkomelbl);
            this.CommonFlow.Controls.Add(this.ButtonsFlow);
            this.CommonFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CommonFlow.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommonFlow.Location = new System.Drawing.Point(12, 12);
            this.CommonFlow.Name = "CommonFlow";
            this.CommonFlow.Size = new System.Drawing.Size(776, 366);
            this.CommonFlow.TabIndex = 0;
            // 
            // Welkomelbl
            // 
            this.Welkomelbl.AutoSize = true;
            this.Welkomelbl.Location = new System.Drawing.Point(3, 0);
            this.Welkomelbl.Name = "Welkomelbl";
            this.Welkomelbl.Size = new System.Drawing.Size(85, 32);
            this.Welkomelbl.TabIndex = 0;
            this.Welkomelbl.Text = "label1";
            // 
            // ButtonsFlow
            // 
            this.ButtonsFlow.AutoScroll = true;
            this.ButtonsFlow.Controls.Add(this.OlympicBtn);
            this.ButtonsFlow.Controls.Add(this.YearlyReportBtn);
            this.ButtonsFlow.Controls.Add(this.Filters);
            this.ButtonsFlow.Controls.Add(this.YearActivitiesBtn);
            this.ButtonsFlow.Controls.Add(this.FinishYearBtn);
            this.ButtonsFlow.Location = new System.Drawing.Point(3, 35);
            this.ButtonsFlow.Name = "ButtonsFlow";
            this.ButtonsFlow.Size = new System.Drawing.Size(433, 295);
            this.ButtonsFlow.TabIndex = 1;
            this.ButtonsFlow.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonsFlow_Paint);
            // 
            // OlympicBtn
            // 
            this.OlympicBtn.Location = new System.Drawing.Point(3, 3);
            this.OlympicBtn.Name = "OlympicBtn";
            this.OlympicBtn.Size = new System.Drawing.Size(343, 52);
            this.OlympicBtn.TabIndex = 0;
            this.OlympicBtn.Text = "Olympic";
            this.OlympicBtn.UseVisualStyleBackColor = true;
            this.OlympicBtn.Click += new System.EventHandler(this.OlympicBtn_Click);
            // 
            // YearlyReportBtn
            // 
            this.YearlyReportBtn.Location = new System.Drawing.Point(3, 61);
            this.YearlyReportBtn.Name = "YearlyReportBtn";
            this.YearlyReportBtn.Size = new System.Drawing.Size(343, 52);
            this.YearlyReportBtn.TabIndex = 1;
            this.YearlyReportBtn.Text = "Year Report";
            this.YearlyReportBtn.UseVisualStyleBackColor = true;
            this.YearlyReportBtn.Click += new System.EventHandler(this.YearlyReportBtn_Click);
            // 
            // Filters
            // 
            this.Filters.Location = new System.Drawing.Point(3, 119);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(343, 52);
            this.Filters.TabIndex = 2;
            this.Filters.Text = "Enlistment office";
            this.Filters.UseVisualStyleBackColor = true;
            this.Filters.Click += new System.EventHandler(this.Filters_Click);
            // 
            // YearActivitiesBtn
            // 
            this.YearActivitiesBtn.Location = new System.Drawing.Point(3, 177);
            this.YearActivitiesBtn.Name = "YearActivitiesBtn";
            this.YearActivitiesBtn.Size = new System.Drawing.Size(343, 52);
            this.YearActivitiesBtn.TabIndex = 3;
            this.YearActivitiesBtn.Text = "Year Activities";
            this.YearActivitiesBtn.UseVisualStyleBackColor = true;
            this.YearActivitiesBtn.Click += new System.EventHandler(this.YearActivitiesBtn_Click);
            // 
            // FinishYearBtn
            // 
            this.FinishYearBtn.Location = new System.Drawing.Point(3, 235);
            this.FinishYearBtn.Name = "FinishYearBtn";
            this.FinishYearBtn.Size = new System.Drawing.Size(343, 52);
            this.FinishYearBtn.TabIndex = 4;
            this.FinishYearBtn.Text = "Finish Year";
            this.FinishYearBtn.UseVisualStyleBackColor = true;
            this.FinishYearBtn.Click += new System.EventHandler(this.FinishYearBtn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.CloseBtn);
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 384);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(776, 54);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(3, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(300, 50);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ChooseFunctionality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.CommonFlow);
            this.Name = "ChooseFunctionality";
            this.Text = "ChooseFunctionality";
            this.CommonFlow.ResumeLayout(false);
            this.CommonFlow.PerformLayout();
            this.ButtonsFlow.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CommonFlow;
        private System.Windows.Forms.Label Welkomelbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.FlowLayoutPanel ButtonsFlow;
        private System.Windows.Forms.Button OlympicBtn;
        private System.Windows.Forms.Button YearlyReportBtn;
        private System.Windows.Forms.Button Filters;
        private System.Windows.Forms.Button YearActivitiesBtn;
        private System.Windows.Forms.Button FinishYearBtn;
    }
}