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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string race = "" ;
            string language="";
            foreach (Control c in this.panel1.Controls)
            {
                if (c is RadioButton)
                {
                    if (((RadioButton)c).Checked)
                    {
                        race = c.Text;
                    }
                }
            }
            foreach (Control c in this.panel2.Controls)
            {
                if (c is RadioButton)
                {
                    if (((RadioButton)c).Checked)
                    {
                        language = c.Text;
                    }
                }
            }
            MessageBox.Show("你输入的信息为：\n姓名：" + textBox1.Text +
                "\n单位：" + textBox2.Text + "\n性别：" + comboBox1.SelectedItem +
                "\n年龄：" + numericUpDown1.Value + "\n种族：" + race +
                "\n语言：" + language, "感谢登记");

        }
    }
}
