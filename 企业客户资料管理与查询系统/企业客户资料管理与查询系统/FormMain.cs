using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRMSystem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private string user;
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            tsslblUser.Text ="当前用户："+ user;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("你确认退出系统吗？","退出对话框",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Dispose();//释放窗体
                Application.Exit();//退出程序
            }
            else
            {
                e.Cancel = true;//取消事件
            }
        }

        private void lklbExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("你确认退出系统吗？", "退出对话框", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Dispose();//释放窗体
                Application.Exit();//退出程序
            }            
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你确认退出系统吗？", "退出对话框", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Dispose();//释放窗体
                Application.Exit();//退出程序
            }    
        }

        private void lklbAddClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAddClient fm = new FormAddClient();
            fm.Show();
        }

        private void lklbAddService_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAddService fm = new FormAddService();
            fm.Show();
        }

        private void lklbAddComplaint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAddComplaint fm = new FormAddComplaint();
            fm.Show();
        }

        private void 管理客户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClient fm = new FormClient();
            fm.Show();
        }

        private void 添加客户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddClient fm = new FormAddClient();
            fm.Show();
        }

        private void 添加服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddService fm = new FormAddService();
            fm.Show();
        }

        private void 添加投诉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddComplaint fm = new FormAddComplaint();
            fm.Show();
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePwd fm = new FormChangePwd();
            fm.User = this.user;
            fm.Show();
        }

        private void 关于软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout fm = new FormAbout();
            fm.Show();
        }
    }
}
