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
    public partial class FormSelectClient : Form
    {
        private string person;

        public string Person
        {
            get { return person; }
            set { person = value; }
        }

        public FormSelectClient()
        {
            InitializeComponent();
        }
        Common com = new Common();
        private void FormSelectClient_Load(object sender, EventArgs e)
        {
            string sql = "select Id,UserName from Customer order by Id asc";
            com.BindListBox(lbAllClient,sql);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Person = "";
            for (int i = 0; i < lbSelectedClient.Items.Count; i++)
            {
                Person += lbSelectedClient.Items[i].ToString() + ",";
            }
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbAllClient.SelectedIndex != -1)
            {
                if (lbSelectedClient.Items.Count < 2)
                {
                    lbSelectedClient.Items.Add(lbAllClient.Text);
                }
                else
                    MessageBox.Show("每次最多添加两位用户！");
                {
                }
            }
            else
            {
                MessageBox.Show("请选择要添加的客户！");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbSelectedClient.SelectedIndex != -1)
            {
                lbSelectedClient.Items.RemoveAt(lbSelectedClient.SelectedIndex);
            }
            else
            {
                MessageBox.Show("请选择移除的客户！");
            }
        }
    }
}
