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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            ShowCustomer();
        }
        Common com = new Common();
        DataBase db = new DataBase();

        //显示客户的方法
        private void ShowCustomer()
        {
            string sql = "select * from Customer order by Id desc";
            com.BindDGV(dataGridView1,sql);
        
        }
        //添加客户
        private void ShowForm(int t)
        {
            FormAddClient fm = new FormAddClient();
            fm.Id = t;
            DialogResult result = fm.ShowDialog();
            if (result == DialogResult.OK)
            {
                ShowCustomer();
            }

        }
        //修改客户
        private void ModifyClient()
        {
            if (dataGridView1.RowCount > 0)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    string value = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
                    if (value != null && value != string.Empty)
                    {
                        ShowForm(int.Parse(value));
                    }
                    else
                    {
                        MessageBox.Show("所选择行不存在数据！");
                    }
                }
                else
                {
                    MessageBox.Show("请选择一行要修改的数据！");
                }
            }
            else {
                MessageBox.Show("目前没有任何数据！");
            }
        }
        private void DeleteClient()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    string selectID = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
                    if (selectID != null && selectID != string.Empty)
                    { 
                        string sql="delete Customer where Id="+selectID;
                        db.RunSql(sql);
                    }
                }
                ShowCustomer();
            }
            }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "tslbAdd")
            {
                FormAddClient fm = new FormAddClient();
                fm.Show();
            }

            if (e.ClickedItem.Name == "tslbModify")
            {
                ModifyClient();
            }

            if (e.ClickedItem.Name == "tslbDelete")
            {
                DialogResult result = MessageBox.Show("确认删除所选择的行？","确认对话框",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if(result==DialogResult.Yes)
                { 
                    DeleteClient();
                }
                
            }
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            FormAddClient fm = new FormAddClient();
            fm.Show();
        }

        private void tsbtnModify_Click(object sender, EventArgs e)
        {
            ModifyClient();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认删除所选择的行？", "确认对话框", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                DeleteClient();
            }
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }
    }
}
