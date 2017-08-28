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
    public partial class FormAddService : Form
    {
        public FormAddService()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectService_Click(object sender, EventArgs e)
        {
            FormSelectClient fm = new FormSelectClient();
            DialogResult result = fm.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbServiceClient.Text = fm.Person;//回传参数
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (tbServiceTitle.Text.Trim().Length <= 0)
            //{
            //    MessageBox.Show("请输入标题！");
            //    tbServiceTitle.Focus();
            //    return;
            //}
            //if (tbServiceClient.Text.Trim().Length <= 0)
            //{
            //    MessageBox.Show("请选择投诉客户！");
            //    btnSelectService.Focus();
            //    return;
            //}
            //if (tbContent.Text.Trim().Length <= 0)
            //{
            //    MessageBox.Show("请输入服务内容！");
            //    tbContent.Focus();
            //    return;
            //}
            string sql = @"insert into Service (Title,UserName,
                            ServiceType,ServiceMode,
                            StartTime,EndTime,
                            ServiceContent,Feedback,
                            ServiceNote,ServiceResult) values(
                                N'" + tbServiceTitle.Text.Trim() +
                            "',N'" + tbServiceClient.Text.Trim() +
                            "',N'" + cbbServiceType.Text +
                            "',N'" + cbbServiceMode.Text +
                            "',N'" + dtpBegin.Value +
                            "',N'" + dtpEnd.Value +
                            "',N'" + tbContent.Text.Trim() +
                            "',N'" + cbbFeedback.Text +
                            "',N'" + tbNote.Text.Trim() +
                            "',N'" + cbbResult.Text + "')";
            DataBase db = new DataBase();
            db.RunSql(sql);
            MessageBox.Show("添加成功"); 
                                              
        }
    }
}
