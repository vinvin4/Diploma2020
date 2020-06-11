namespace Diploma2020.Screens
{
    partial class ClassesRegister
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
            this.CommonFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.TableFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.ChooseClassFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.ChooseClassLbl = new System.Windows.Forms.Label();
            this.ChooseClassCB = new System.Windows.Forms.ComboBox();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.FullNameLbl = new System.Windows.Forms.Label();
            this.ChooseColumnCB = new System.Windows.Forms.ComboBox();
            this.ButtonsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.CommonFlow.SuspendLayout();
            this.TableFlow.SuspendLayout();
            this.ChooseClassFlow.SuspendLayout();
            this.Table.SuspendLayout();
            this.ButtonsFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommonFlow
            // 
            this.CommonFlow.BackColor = System.Drawing.Color.Transparent;
            this.CommonFlow.Controls.Add(this.TableFlow);
            this.CommonFlow.Controls.Add(this.ButtonsFlow);
            this.CommonFlow.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommonFlow.Location = new System.Drawing.Point(12, 12);
            this.CommonFlow.Name = "CommonFlow";
            this.CommonFlow.Size = new System.Drawing.Size(776, 426);
            this.CommonFlow.TabIndex = 0;
            // 
            // TableFlow
            // 
            this.TableFlow.Controls.Add(this.ChooseClassFlow);
            this.TableFlow.Controls.Add(this.Table);
            this.TableFlow.Location = new System.Drawing.Point(3, 3);
            this.TableFlow.Name = "TableFlow";
            this.TableFlow.Size = new System.Drawing.Size(773, 373);
            this.TableFlow.TabIndex = 0;
            // 
            // ChooseClassFlow
            // 
            this.ChooseClassFlow.BackColor = System.Drawing.Color.Transparent;
            this.ChooseClassFlow.Controls.Add(this.ChooseClassLbl);
            this.ChooseClassFlow.Controls.Add(this.ChooseClassCB);
            this.ChooseClassFlow.Location = new System.Drawing.Point(3, 3);
            this.ChooseClassFlow.Name = "ChooseClassFlow";
            this.ChooseClassFlow.Size = new System.Drawing.Size(767, 48);
            this.ChooseClassFlow.TabIndex = 0;
            // 
            // ChooseClassLbl
            // 
            this.ChooseClassLbl.AutoSize = true;
            this.ChooseClassLbl.Location = new System.Drawing.Point(3, 0);
            this.ChooseClassLbl.Name = "ChooseClassLbl";
            this.ChooseClassLbl.Size = new System.Drawing.Size(163, 32);
            this.ChooseClassLbl.TabIndex = 1;
            this.ChooseClassLbl.Text = "Choose class";
            // 
            // ChooseClassCB
            // 
            this.ChooseClassCB.FormattingEnabled = true;
            this.ChooseClassCB.Location = new System.Drawing.Point(172, 3);
            this.ChooseClassCB.Name = "ChooseClassCB";
            this.ChooseClassCB.Size = new System.Drawing.Size(173, 39);
            this.ChooseClassCB.TabIndex = 0;
            this.ChooseClassCB.SelectedIndexChanged += new System.EventHandler(this.ChooseClassCB_SelectedIndexChanged);
            // 
            // Table
            // 
            this.Table.AutoScroll = true;
            this.Table.BackColor = System.Drawing.Color.Transparent;
            this.Table.ColumnCount = 2;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Controls.Add(this.FullNameLbl, 0, 0);
            this.Table.Controls.Add(this.ChooseColumnCB, 1, 0);
            this.Table.Location = new System.Drawing.Point(3, 57);
            this.Table.Name = "Table";
            this.Table.RowCount = 2;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.Table.Size = new System.Drawing.Size(767, 316);
            this.Table.TabIndex = 1;
            // 
            // FullNameLbl
            // 
            this.FullNameLbl.AutoSize = true;
            this.FullNameLbl.Location = new System.Drawing.Point(3, 0);
            this.FullNameLbl.Name = "FullNameLbl";
            this.FullNameLbl.Size = new System.Drawing.Size(138, 32);
            this.FullNameLbl.TabIndex = 0;
            this.FullNameLbl.Text = "Full Name";
            // 
            // ChooseColumnCB
            // 
            this.ChooseColumnCB.FormattingEnabled = true;
            this.ChooseColumnCB.Location = new System.Drawing.Point(386, 3);
            this.ChooseColumnCB.Name = "ChooseColumnCB";
            this.ChooseColumnCB.Size = new System.Drawing.Size(366, 39);
            this.ChooseColumnCB.TabIndex = 1;
            this.ChooseColumnCB.SelectedIndexChanged += new System.EventHandler(this.ChooseColumnCB_SelectedIndexChanged);
            // 
            // ButtonsFlow
            // 
            this.ButtonsFlow.Controls.Add(this.SaveBtn);
            this.ButtonsFlow.Controls.Add(this.ExportBtn);
            this.ButtonsFlow.Controls.Add(this.CloseBtn);
            this.ButtonsFlow.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonsFlow.Location = new System.Drawing.Point(3, 382);
            this.ButtonsFlow.Name = "ButtonsFlow";
            this.ButtonsFlow.Size = new System.Drawing.Size(773, 44);
            this.ButtonsFlow.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(3, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(248, 41);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.Location = new System.Drawing.Point(257, 3);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(253, 41);
            this.ExportBtn.TabIndex = 1;
            this.ExportBtn.Text = "Export";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(516, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(254, 41);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ClassesRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diploma2020.Properties.Resources.FonPct;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CommonFlow);
            this.Name = "ClassesRegister";
            this.Text = "ClassesRegister";
            this.CommonFlow.ResumeLayout(false);
            this.TableFlow.ResumeLayout(false);
            this.ChooseClassFlow.ResumeLayout(false);
            this.ChooseClassFlow.PerformLayout();
            this.Table.ResumeLayout(false);
            this.Table.PerformLayout();
            this.ButtonsFlow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CommonFlow;
        private System.Windows.Forms.FlowLayoutPanel TableFlow;
        private System.Windows.Forms.FlowLayoutPanel ChooseClassFlow;
        private System.Windows.Forms.ComboBox ChooseClassCB;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Label FullNameLbl;
        private System.Windows.Forms.ComboBox ChooseColumnCB;
        private System.Windows.Forms.FlowLayoutPanel ButtonsFlow;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label ChooseClassLbl;
    }
}