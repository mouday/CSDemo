using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 简易录入系统
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "欢迎使用本系统，使用前请登录";
            toolStripStatusLabel2.Text = "网址是：www.baidu.com";
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
            menuStrip1.Visible = false;
            toolStrip1.Visible = false;
            txtName.Text = "admin";
            txtPwd.Text = "admin";
            txtName.Focus();
            toolStripMenuItemShow.Enabled = true;
            toolStripMenuItemHide.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pwd = txtPwd.Text;
            if (name == "admin" && pwd == "admin")
            {
                MessageBox.Show("欢迎使用","登录成功");
                this.menuStrip1.Visible = true;
                this.panel1.Visible = false;
                //this.toolStrip1.Visible = true;
                toolStripStatusLabel1.Text = "欢迎使用本系统，登陆成功";
            }
            else
            {
                MessageBox.Show("用户名或密码不正确");
                txtName.Clear();
                txtPwd.Clear();
                txtName.Focus();
            }

        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            int maxVal = 0;
            foreach (Form f in this.MdiChildren)
            {
                int index = Convert.ToInt32(f.Text.Substring(4));
                if (index > maxVal) maxVal = index;
            }

            RegForm fm = new RegForm();
            fm.Text = "信息登记" + (maxVal + 1);
            fm.MdiParent = this;
            fm.BringToFront();
            fm.Show();
        }

        private void toolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            Form activeForm = this.ActiveMdiChild;
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出？","退出提示",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) this.Close();
        }

        private void toolStripMenuItemCas_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripMenuItemHro_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripMenuItemVer_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripMenuItemShow_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            toolStripMenuItemShow.Enabled = false;
            toolStripMenuItemHide.Enabled = true;
        }

        private void toolStripMenuItemHide_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            toolStripMenuItemShow.Enabled = true;
            toolStripMenuItemHide.Enabled = false;
        }

        private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("版权所有@2017","关于我们");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int maxVal = 0;
            foreach (Form f in this.MdiChildren)
            {
                int index = Convert.ToInt32(f.Text.Substring(4));
                if (index > maxVal) maxVal = index;
            }

            RegForm fm = new RegForm();
            fm.Text = "信息登记" + (maxVal + 1);
            fm.MdiParent = this;
            fm.BringToFront();
            fm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form activeForm = this.ActiveMdiChild;
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出？", "退出提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
