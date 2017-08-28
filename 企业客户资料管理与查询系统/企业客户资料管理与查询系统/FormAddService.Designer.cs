namespace CRMSystem
{
    partial class FormAddService
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbServiceClient = new System.Windows.Forms.TextBox();
            this.btnSelectService = new System.Windows.Forms.Button();
            this.tbServiceTitle = new System.Windows.Forms.TextBox();
            this.cbbServiceType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbServiceMode = new System.Windows.Forms.ComboBox();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.cbbFeedback = new System.Windows.Forms.ComboBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.cbbResult = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务主题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "对应客户";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "服务类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "开始时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "服务内容";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "备注";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "客户反馈";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "结果";
            // 
            // tbServiceClient
            // 
            this.tbServiceClient.Location = new System.Drawing.Point(104, 70);
            this.tbServiceClient.Name = "tbServiceClient";
            this.tbServiceClient.ReadOnly = true;
            this.tbServiceClient.Size = new System.Drawing.Size(289, 21);
            this.tbServiceClient.TabIndex = 2;
            // 
            // btnSelectService
            // 
            this.btnSelectService.Location = new System.Drawing.Point(408, 68);
            this.btnSelectService.Name = "btnSelectService";
            this.btnSelectService.Size = new System.Drawing.Size(42, 23);
            this.btnSelectService.TabIndex = 3;
            this.btnSelectService.Text = "...";
            this.btnSelectService.UseVisualStyleBackColor = true;
            this.btnSelectService.Click += new System.EventHandler(this.btnSelectService_Click);
            // 
            // tbServiceTitle
            // 
            this.tbServiceTitle.Location = new System.Drawing.Point(104, 24);
            this.tbServiceTitle.Name = "tbServiceTitle";
            this.tbServiceTitle.Size = new System.Drawing.Size(346, 21);
            this.tbServiceTitle.TabIndex = 2;
            // 
            // cbbServiceType
            // 
            this.cbbServiceType.FormattingEnabled = true;
            this.cbbServiceType.Location = new System.Drawing.Point(104, 116);
            this.cbbServiceType.Name = "cbbServiceType";
            this.cbbServiceType.Size = new System.Drawing.Size(132, 20);
            this.cbbServiceType.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "服务方式";
            // 
            // cbbServiceMode
            // 
            this.cbbServiceMode.FormattingEnabled = true;
            this.cbbServiceMode.Location = new System.Drawing.Point(318, 116);
            this.cbbServiceMode.Name = "cbbServiceMode";
            this.cbbServiceMode.Size = new System.Drawing.Size(132, 20);
            this.cbbServiceMode.TabIndex = 4;
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(104, 148);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(132, 21);
            this.dtpBegin.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "结束时间";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(318, 148);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(132, 21);
            this.dtpEnd.TabIndex = 5;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(104, 186);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(346, 54);
            this.tbContent.TabIndex = 2;
            // 
            // cbbFeedback
            // 
            this.cbbFeedback.FormattingEnabled = true;
            this.cbbFeedback.Location = new System.Drawing.Point(104, 246);
            this.cbbFeedback.Name = "cbbFeedback";
            this.cbbFeedback.Size = new System.Drawing.Size(132, 20);
            this.cbbFeedback.TabIndex = 4;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(104, 290);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(346, 54);
            this.tbNote.TabIndex = 2;
            // 
            // cbbResult
            // 
            this.cbbResult.FormattingEnabled = true;
            this.cbbResult.Location = new System.Drawing.Point(104, 350);
            this.cbbResult.Name = "cbbResult";
            this.cbbResult.Size = new System.Drawing.Size(132, 20);
            this.cbbResult.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 392);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(318, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 427);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.cbbServiceMode);
            this.Controls.Add(this.cbbResult);
            this.Controls.Add(this.cbbFeedback);
            this.Controls.Add(this.cbbServiceType);
            this.Controls.Add(this.btnSelectService);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbServiceTitle);
            this.Controls.Add(this.tbServiceClient);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加服务";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbServiceClient;
        private System.Windows.Forms.Button btnSelectService;
        private System.Windows.Forms.TextBox tbServiceTitle;
        private System.Windows.Forms.ComboBox cbbServiceType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbServiceMode;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.ComboBox cbbFeedback;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.ComboBox cbbResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}