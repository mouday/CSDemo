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
    public partial class FormChangePwd : Form
    {
        public FormChangePwd()
        {
            InitializeComponent();
        }
        Common com = new Common();
        DataBase db = new DataBase();
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tbOldPwd.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请输入原密码！");
                tbOldPwd.Focus();
                return;
            }
            if (tbNewPwd.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请输入新密码！");
                tbNewPwd.Focus();
                return;
            }
            //if (tbComfirmPwd.Text.Trim().Length <= 0)
            //{
            //    MessageBox.Show("请再次输入新密码！");
            //    tbComfirmPwd.Focus();
            //    return;
            //}
            if (string.Compare(tbNewPwd.Text.Trim(),tbComfirmPwd.Text.Trim())!=0)
            {
                MessageBox.Show("俩次输入的密码不一致，请重新输入");
                tbNewPwd.Focus();
                return;
            
            }
            string sql = @"select count(*) from Manager where UserName=N'" + user + "'and Pwd=N'" + com.md5(tbOldPwd.Text.Trim()) + "'";
            int t=db.RunSqlInt(sql);
            if (t > 0)
            {
                string updateSql = "update Manager set Pwd='" + com.md5(tbNewPwd.Text.Trim()) + "' where UserName=N'" + user + "'";
                db.RunSql(updateSql);
                MessageBox.Show("密码修改成功！");
            }
            else
            {
                MessageBox.Show("旧密码输入错误！");
                tbOldPwd.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
