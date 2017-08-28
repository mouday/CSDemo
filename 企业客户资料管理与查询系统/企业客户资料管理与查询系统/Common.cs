using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CRMSystem
{
    class Common
    {
        DataBase db = new DataBase();

        /// <summary>
        /// 32位MD5值加密
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public string md5(string pwd)
        {
            string returnPwd = "";
            MD5 md5 = MD5.Create();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(pwd);
            bytes = md5.ComputeHash(bytes);
            md5.Clear();
            for (int i = 0; i < bytes.Length; i++)
            {
                returnPwd += Convert.ToString(bytes[i], 16).PadLeft(2, '0');
            }
            return returnPwd.PadLeft(32, '0');
        }
        /// <summary>
        /// 将sql绑定到ComboBox控件
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="sql"></param>
        public void BindComboBox(ComboBox cb, string sql)
        {
            DataTable dt = new DataTable();
            dt = CreateSource(sql);
            cb.DataSource = dt;
            cb.DisplayMember = dt.Columns[1].ColumnName;
            cb.ValueMember = dt.Columns[0].ColumnName;

        }
        /// <summary>
        /// 将sql绑定到ListBox控件
        /// </summary>
        /// <param name="lb"></param>
        /// <param name="sql"></param>
        public void BindListBox(ListBox lb, string sql)
        {
            DataTable dt = new DataTable();
            dt = CreateSource(sql);
            lb.DataSource = dt;
            lb.DisplayMember = dt.Columns[1].ColumnName;
            lb.ValueMember = dt.Columns[0].ColumnName;
        }
        /// <summary>
        /// 将sql语句生成DataTable对象
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private DataTable CreateSource(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;
            db.RunSql(sql, out dr);
            dt = db.ConvertDataReaderToDataTable(dr);
            return dt;
        }
        /// <summary>
        /// 将sql语句绑定到DataGridView控件
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="sql"></param>
        public void BindDGV(DataGridView dgv, string sql)
        {
            dgv.DataSource = CreateSource(sql);
        }
        /// <summary>
        /// 根据值指定combobox控件索引
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="value"></param>
        public void CbbIndexByText(ComboBox comboBox, string value)
        {
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Items[i].ToString().Trim() == value.Trim())
                {
                    comboBox.SelectedIndex = i;
                    break;
                }
            }

        }

    }
}
