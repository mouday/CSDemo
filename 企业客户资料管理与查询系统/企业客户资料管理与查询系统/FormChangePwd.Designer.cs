namespace CRMSystem
{
    partial class FormChangePwd
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
            this.btnChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOldPwd = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbComfirmPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(55, 239);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "原密码";
            // 
            // tbOldPwd
            // 
            this.tbOldPwd.Location = new System.Drawing.Point(89, 80);
            this.tbOldPwd.Name = "tbOldPwd";
            this.tbOldPwd.Size = new System.Drawing.Size(162, 21);
            this.tbOldPwd.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(196, 239);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "确认密码";
            // 
            // tbComfirmPwd
            // 
            this.tbComfirmPwd.Location = new System.Drawing.Point(89, 177);
            this.tbComfirmPwd.Name = "tbComfirmPwd";
            this.tbComfirmPwd.Size = new System.Drawing.Size(162, 21);
            this.tbComfirmPwd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "新密码";
            // 
            // tbNewPwd
            // 
            this.tbNewPwd.Location = new System.Drawing.Point(89, 129);
            this.tbNewPwd.Name = "tbNewPwd";
            this.tbNewPwd.Size = new System.Drawing.Size(162, 21);
            this.tbNewPwd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(98, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "修改密码";
            // 
            // FormChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 296);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNewPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbComfirmPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOldPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChange);
            this.Name = "FormChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOldPwd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbComfirmPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewPwd;
        private System.Windows.Forms.Label label4;
    }
}