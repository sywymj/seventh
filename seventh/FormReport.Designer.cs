namespace sixth
{
    partial class FormReport
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
            System.Windows.Forms.Label labDate;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.ReportDate = new System.Windows.Forms.DateTimePicker();
            this.labAddress = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.labContent = new System.Windows.Forms.Label();
            this.comboxType = new System.Windows.Forms.ComboBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.labUsn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            labDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labDate
            // 
            labDate.AutoSize = true;
            labDate.BackColor = System.Drawing.Color.Transparent;
            labDate.Location = new System.Drawing.Point(301, 116);
            labDate.Name = "labDate";
            labDate.Size = new System.Drawing.Size(65, 12);
            labDate.TabIndex = 43;
            labDate.Text = "报修日期：";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtAddress.Location = new System.Drawing.Point(32, 139);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(156, 21);
            this.txtAddress.TabIndex = 0;
            // 
            // ReportDate
            // 
            this.ReportDate.Location = new System.Drawing.Point(303, 138);
            this.ReportDate.Name = "ReportDate";
            this.ReportDate.Size = new System.Drawing.Size(139, 21);
            this.ReportDate.TabIndex = 42;
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.BackColor = System.Drawing.Color.Transparent;
            this.labAddress.Location = new System.Drawing.Point(30, 119);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(65, 12);
            this.labAddress.TabIndex = 44;
            this.labAddress.Text = "报修地点：";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtContent.Location = new System.Drawing.Point(32, 205);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(156, 108);
            this.txtContent.TabIndex = 45;
            // 
            // labContent
            // 
            this.labContent.AutoSize = true;
            this.labContent.BackColor = System.Drawing.Color.Transparent;
            this.labContent.Location = new System.Drawing.Point(30, 183);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(65, 12);
            this.labContent.TabIndex = 46;
            this.labContent.Text = "报修内容：";
            // 
            // comboxType
            // 
            this.comboxType.FormattingEnabled = true;
            this.comboxType.Items.AddRange(new object[] {
            "电脑类",
            "土建类",
            "电器类",
            "门窗类"});
            this.comboxType.Location = new System.Drawing.Point(303, 205);
            this.comboxType.Name = "comboxType";
            this.comboxType.Size = new System.Drawing.Size(139, 20);
            this.comboxType.TabIndex = 47;
            this.comboxType.Text = "保修类型";
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.Location = new System.Drawing.Point(303, 255);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(139, 58);
            this.btnReport.TabIndex = 48;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // labUsn
            // 
            this.labUsn.AutoSize = true;
            this.labUsn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labUsn.Location = new System.Drawing.Point(67, 83);
            this.labUsn.Name = "labUsn";
            this.labUsn.Size = new System.Drawing.Size(2, 14);
            this.labUsn.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(32, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "欢迎";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labUsn);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.comboxType);
            this.Controls.Add(this.labContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.labAddress);
            this.Controls.Add(labDate);
            this.Controls.Add(this.ReportDate);
            this.Controls.Add(this.txtAddress);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormReport";
            this.Text = "报修登记";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReport_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker ReportDate;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label labContent;
        private System.Windows.Forms.ComboBox comboxType;
        private System.Windows.Forms.Button btnReport;
        public System.Windows.Forms.Label labUsn;
        private System.Windows.Forms.Label label1;
    }
}