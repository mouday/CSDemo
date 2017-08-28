namespace CRMSystem
{
    partial class FormSelectClient
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
            this.lbAllClient = new System.Windows.Forms.ListBox();
            this.lbSelectedClient = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "所有客户";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择客户";
            // 
            // lbAllClient
            // 
            this.lbAllClient.FormattingEnabled = true;
            this.lbAllClient.ItemHeight = 12;
            this.lbAllClient.Location = new System.Drawing.Point(12, 67);
            this.lbAllClient.Name = "lbAllClient";
            this.lbAllClient.Size = new System.Drawing.Size(158, 232);
            this.lbAllClient.TabIndex = 2;
            // 
            // lbSelectedClient
            // 
            this.lbSelectedClient.FormattingEnabled = true;
            this.lbSelectedClient.ItemHeight = 12;
            this.lbSelectedClient.Location = new System.Drawing.Point(235, 67);
            this.lbSelectedClient.Name = "lbSelectedClient";
            this.lbSelectedClient.Size = new System.Drawing.Size(158, 232);
            this.lbSelectedClient.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(176, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(176, 188);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(53, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(165, 314);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormSelectClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 359);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbSelectedClient);
            this.Controls.Add(this.lbAllClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSelectClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择客户";
            this.Load += new System.EventHandler(this.FormSelectClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbAllClient;
        private System.Windows.Forms.ListBox lbSelectedClient;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnOk;
    }
}