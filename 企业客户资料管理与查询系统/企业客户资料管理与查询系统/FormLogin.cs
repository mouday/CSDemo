using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CRMSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Common com1=new Common();
            //tbPwd.Text = com1.md5("123456");
            
            //判断用户是否输入用户名
            if (tbUser.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入用户名！");
                tbUser.Focus();
                return;
            }
            //判断用户是否输入密码
            if (tbPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密码！");
                tbPwd.Focus();
                return;
            }
            //创建command对象
            Common com = new Common();
            //创建database对象
            DataBase db = new DataBase();
            //统计所输入的用户名和密码，在对应数据表中个数的查询语句
            int t = 0;
            //将密码用MD5加密，以防密码被盗取
            string sql = "select count(*) from Manager where UserName='" + tbUser.Text.Trim() + "' and Pwd='" + com.md5(tbPwd.Text.Trim()) + "'";

            //将对应表中的数据条数放在变量t中
            t = db.RunSqlInt(sql);
            if (t > 0)
            {
                this.Hide();
                FormMain fm = new FormMain();
                fm.User = tbUser.Text.Trim();//将用户名传入主窗体
                fm.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbUser.Text = "admin";
            tbPwd.Text = "123456";
        }
    }
}
