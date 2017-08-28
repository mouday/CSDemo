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
    public partial class FormAddClient : Form
    {
        private int id;
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public FormAddClient()
        {
            InitializeComponent();
        }
        Common com = new Common();
        DataBase db = new DataBase();
        private void FormAddClient_Load(object sender, EventArgs e)
        {
            try
            {

                //绑定名族

                com.BindComboBox(cbbNation, "select Id,Nation from Nation order by Id asc");
                com.BindComboBox(cbbGender, "select Id,Gender from Gender order by Id asc");

                if (Id != 0)
                {
                    this.Text = "客户资料修改";
                    btnAdd.Text = "修改";
                    ShowClient(Id);
                }
                else
                {
                    //cbbMarriage.SelectedIndex = 0;
                    //cbbGender.SelectedIndex = 0;
                    //cbbSource.SelectedIndex = 0;
                    //cbbLevel.SelectedIndex = 0;
                    //cbbCulture.SelectedIndex = 0;
                    //cbbConcernment.SelectedIndex = 0;
                    //cbbEarning.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void ShowClient(int t)
        {
            SqlDataReader dr;
            string sql = "select * from Customer where Id=" + t;
            db.RunSql(sql, out dr);
            if (dr.Read())
            {
                tbName.Text = dr["UserName"].ToString();
                com.CbbIndexByText(cbbNation, dr["Nation"].ToString());
                dtpBirthday.Value = DateTime.Parse(dr["Birthday"].ToString());
                com.CbbIndexByText(cbbGender, dr["Gender"].ToString());
                tbIDCard.Text = dr["IDCard"].ToString();
                tbHobby.Text = dr["Hobby"].ToString();
                com.CbbIndexByText(cbbMarriage, dr["Marriage"].ToString());
                com.CbbIndexByText(cbbSource, dr["Source"].ToString());
                com.CbbIndexByText(cbbLevel, dr["Level"].ToString());
                com.CbbIndexByText(cbbConcernment, dr["Concernment"].ToString());
                com.CbbIndexByText(cbbEarning, dr["Earning"].ToString());
                tbMobile.Text = dr["Mobile"].ToString();
                tbTel.Text = dr["Tel"].ToString();
                tbQQ.Text = dr["QQ"].ToString();
                tbEmail.Text = dr["Email"].ToString();
                com.CbbIndexByText(cbbCulture, dr["Culture"].ToString());
                com.CbbIndexByText(cbbProvince, dr["Province"].ToString());
                com.CbbIndexByText(cbbCity, dr["City"].ToString());
                tbAddress.Text = dr["Address"].ToString();

            }
            else
            {
                MessageBox.Show("你所要修改的项不存在，窗口将关闭");
                this.Close();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请输入客户名称");

                tbName.Focus();
                btnAdd.DialogResult = DialogResult.None;
                return;
            }
            //if (cbbGender.SelectedIndex < 0)
            //{
            //    MessageBox.Show("请选择性别！");
            //    cbbGender.Focus();
            //    btnAdd.DialogResult = DialogResult.None;
            //    return;
            //}
            //if (cbbLevel.SelectedIndex < 0)
            //{
            //    MessageBox.Show("请选择重要程度！");
            //    cbbLevel.Focus();
            //    btnAdd.DialogResult = DialogResult.None;
            //    return;
            //}
            //if (tbMobile.Text.Trim().Length <= 0 || tbTel.Text.Trim().Length <= 0)
            //{
            //    MessageBox.Show("请将电话号码和手机好至少输入一个！");
            //    tbMobile.Focus();
            //    btnAdd.DialogResult = DialogResult.None;
            //    return;
            //}
            string sql = "";
            string Rstatus = "添加";
            if (Id == 0)
            {
                sql = @"insert into Customer(
                        UserName,Nation,
                        Birthday,Gender,
                        IDCard,Level,
                        Marriage,Source,
                        Earning,Concernment,
                        Mobile,Tel,
                        QQ,Culture,
                        Email,Province,
                        City,Address,Hobby) values(N'" +
                       tbName.Text.Trim() + "',N'" + cbbNation.Text + "',N'" +
                       dtpBirthday.Value + "',N'" + cbbGender.Text + "',N'" +
                       tbIDCard.Text.Trim() + "',N'" + cbbLevel.Text + "',N'" +
                       cbbMarriage.Text + "',N'" + cbbSource.Text + "',N'" +
                       cbbEarning.Text + "','" + cbbConcernment.Text + "',N'" +
                       tbMobile.Text.Trim() + "',N'" + tbTel.Text.Trim() + "',N'" +
                       tbQQ.Text.Trim() + "',N'" + cbbCulture.Text + "','" +
                       tbEmail.Text.Trim() + "',N'" + cbbProvince.Text + "',N'" +
                       cbbCity.Text + "',N'" + tbAddress.Text.Trim() + "',N'" + tbHobby.Text.Trim() + "')";


            }
            else
            {
                sql = @"update Customer set 
                        UserName=N'" + tbName.Text.Trim() +
                        "',Nation=N'" + cbbNation.Text +
                        "',Birthday=N'" + dtpBirthday.Value +
                        "',Gender=N'" + cbbGender.Text +
                        "',IDCard=N'" + tbIDCard.Text.Trim() +
                        "',Level=N'" + cbbLevel.Text +
                        "',Marriage=N'" + cbbMarriage.Text +
                        "',Source=N'" + cbbSource.Text +
                        "',Earning=N'" + cbbEarning.Text +
                        "',Concernment=N'" + cbbConcernment.Text +
                        "',Mobile=N'" + tbMobile.Text.Trim() +
                        "',Tel=N'" + tbTel.Text.Trim() +
                        "',QQ=N'" + tbQQ.Text.Trim() +
                        "',Culture=N'" + cbbCulture.Text +
                        "',Email=N'" + tbEmail.Text.Trim() +
                        "',Province=N'" + cbbProvince.Text +
                        "',City=N'" + cbbCity.Text +
                        "',Hobby=N'" + tbHobby.Text.Trim() +
                        "',Address=N'" + tbAddress.Text.Trim() + "' where Id=" + Id;

                Rstatus = "修改";
            }
            db.RunSql(sql);
            MessageBox.Show(Rstatus + "成功！");
        }
    }

}
