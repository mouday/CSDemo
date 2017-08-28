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
    public partial class FormAddComplaint : Form
    {
        public FormAddComplaint()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataBase db = new DataBase();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbComplaintTitle.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请输入投诉主题！");
                tbComplaintTitle.Focus();
                return;
            }
            if (tbComplaintClient.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请输入投诉客户！");
                tbComplaintClient.Focus();
                return;
            }
            if (tbComplaintContent.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请输入投诉内容！");
                tbComplaintContent.Focus();
                return;
            }
            string sql = @"insert into Complaint(ComplaintTitle,ComplaintClient,
                        ComplaintType,ComplaintMode,
                        ComplaintTime,ComplaintObject,
                        ComplaintContent)values(N'" +
                        tbComplaintTitle.Text.Trim() + "',N'" +
                        tbComplaintClient.Text.Trim() + "',N'" +
                        cbbComplaintType.Text + "',N'" +
                        cbbComplaintMode.Text + "',N'" +
                        dtpComplaintTime.Value + "',N'" +
                        cbbComplaintObject.Text + "',N'" +
                        tbComplaintContent.Text.Trim() + "')";
            db.RunSql(sql);
            MessageBox.Show("添加成功！");
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            FormSelectClient fm = new FormSelectClient();
            DialogResult result = fm.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbComplaintClient.Text = fm.Person;
            }
        }
    }
}
