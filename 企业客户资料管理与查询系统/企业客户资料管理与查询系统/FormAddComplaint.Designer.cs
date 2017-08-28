namespace CRMSystem
{
    partial class FormAddComplaint
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbComplaintTitle = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbComplaintClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbComplaintMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbComplaintType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbComplaintObject = new System.Windows.Forms.ComboBox();
            this.dtpComplaintTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbComplaintContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "投诉主题";
            // 
            // tbComplaintTitle
            // 
            this.tbComplaintTitle.Location = new System.Drawing.Point(123, 35);
            this.tbComplaintTitle.Name = "tbComplaintTitle";
            this.tbComplaintTitle.Size = new System.Drawing.Size(332, 21);
            this.tbComplaintTitle.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(122, 277);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(380, 277);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.Location = new System.Drawing.Point(415, 60);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(40, 23);
            this.btnSelectClient.TabIndex = 2;
            this.btnSelectClient.Text = "...";
            this.btnSelectClient.UseVisualStyleBackColor = true;
            this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "投诉时间";
            // 
            // tbComplaintClient
            // 
            this.tbComplaintClient.Location = new System.Drawing.Point(123, 62);
            this.tbComplaintClient.Name = "tbComplaintClient";
            this.tbComplaintClient.Size = new System.Drawing.Size(286, 21);
            this.tbComplaintClient.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "投诉方式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "投诉内容";
            // 
            // cbbComplaintMode
            // 
            this.cbbComplaintMode.FormattingEnabled = true;
            this.cbbComplaintMode.Location = new System.Drawing.Point(335, 93);
            this.cbbComplaintMode.Name = "cbbComplaintMode";
            this.cbbComplaintMode.Size = new System.Drawing.Size(121, 20);
            this.cbbComplaintMode.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "投诉类型";
            // 
            // cbbComplaintType
            // 
            this.cbbComplaintType.FormattingEnabled = true;
            this.cbbComplaintType.Location = new System.Drawing.Point(123, 93);
            this.cbbComplaintType.Name = "cbbComplaintType";
            this.cbbComplaintType.Size = new System.Drawing.Size(121, 20);
            this.cbbComplaintType.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "投诉对象";
            // 
            // cbbComplaintObject
            // 
            this.cbbComplaintObject.FormattingEnabled = true;
            this.cbbComplaintObject.Location = new System.Drawing.Point(335, 126);
            this.cbbComplaintObject.Name = "cbbComplaintObject";
            this.cbbComplaintObject.Size = new System.Drawing.Size(121, 20);
            this.cbbComplaintObject.TabIndex = 3;
            // 
            // dtpComplaintTime
            // 
            this.dtpComplaintTime.Location = new System.Drawing.Point(122, 129);
            this.dtpComplaintTime.Name = "dtpComplaintTime";
            this.dtpComplaintTime.Size = new System.Drawing.Size(122, 21);
            this.dtpComplaintTime.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "投诉客户";
            // 
            // tbComplaintContent
            // 
            this.tbComplaintContent.Location = new System.Drawing.Point(123, 166);
            this.tbComplaintContent.Multiline = true;
            this.tbComplaintContent.Name = "tbComplaintContent";
            this.tbComplaintContent.Size = new System.Drawing.Size(333, 100);
            this.tbComplaintContent.TabIndex = 1;
            // 
            // FormAddComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 316);
            this.Controls.Add(this.dtpComplaintTime);
            this.Controls.Add(this.cbbComplaintType);
            this.Controls.Add(this.cbbComplaintObject);
            this.Controls.Add(this.cbbComplaintMode);
            this.Controls.Add(this.btnSelectClient);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbComplaintContent);
            this.Controls.Add(this.tbComplaintClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbComplaintTitle);
            this.Controls.Add(this.label1);
            this.Name = "FormAddComplaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加投诉";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComplaintTitle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbComplaintClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbComplaintMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbComplaintType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbComplaintObject;
        private System.Windows.Forms.DateTimePicker dtpComplaintTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbComplaintContent;
    }
}