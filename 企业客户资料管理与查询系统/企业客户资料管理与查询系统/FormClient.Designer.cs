namespace CRMSystem
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbAdd = new System.Windows.Forms.ToolStripLabel();
            this.tslbModify = new System.Windows.Forms.ToolStripLabel();
            this.tslbDelete = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnModify = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(990, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbAdd,
            this.tslbModify,
            this.tslbDelete,
            this.tsbtnAdd,
            this.tsbtnModify,
            this.tsbtnDelete,
            this.tsbtnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(990, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tslbAdd
            // 
            this.tslbAdd.Name = "tslbAdd";
            this.tslbAdd.Size = new System.Drawing.Size(32, 22);
            this.tslbAdd.Text = "添加";
            // 
            // tslbModify
            // 
            this.tslbModify.Name = "tslbModify";
            this.tslbModify.Size = new System.Drawing.Size(32, 22);
            this.tslbModify.Text = "修改";
            // 
            // tslbDelete
            // 
            this.tslbDelete.Name = "tslbDelete";
            this.tslbDelete.Size = new System.Drawing.Size(32, 22);
            this.tslbDelete.Text = "删除";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(36, 22);
            this.tsbtnAdd.Text = "添加";
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnModify
            // 
            this.tsbtnModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnModify.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnModify.Image")));
            this.tsbtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnModify.Name = "tsbtnModify";
            this.tsbtnModify.Size = new System.Drawing.Size(36, 22);
            this.tsbtnModify.Text = "修改";
            this.tsbtnModify.Click += new System.EventHandler(this.tsbtnModify_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(36, 22);
            this.tsbtnDelete.Text = "删除";
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(36, 22);
            this.tsbtnRefresh.Text = "刷新";
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 393);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户管理";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbAdd;
        private System.Windows.Forms.ToolStripLabel tslbModify;
        private System.Windows.Forms.ToolStripLabel tslbDelete;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnModify;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
    }
}