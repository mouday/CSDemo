using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CRMSystem
{
    class DataBase
    {
        SqlConnection con;
        //Data Source=(localdb)\Projects;Initial Catalog=CRM_DataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False
        /// <summary>
        /// 开启，链接数据库
        /// </summary>
        private void Open()
        {
            if (con == null)
            {
                string constr = @"Data Source=(localdb)\Projects;Initial Catalog=CRM_DataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
                con = new SqlConnection(constr);
            }
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        /// <summary>
        /// 关闭数据库链接
        /// </summary>
        private void Close()
        {
            if (con != null)
            {
                con.Close();
            }
        }
        /// <summary>
        /// 创建SqlCommand命令
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        private SqlCommand CreateCommand(string sqlStr)
        {
            Open();
            SqlCommand com = new SqlCommand(sqlStr, con);
            return com;
        }
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sqlStr"></param>
        public void RunSql(string sqlStr)
        {
            //if (con!=null || con.State == System.Data.ConnectionState.Open)
            //{
            //    con.Close();
            //}
            SqlCommand cmd = CreateCommand(sqlStr);
            cmd.ExecuteNonQuery();
            Close();
        }
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        public int RunSqlInt(string sqlStr)
        {
            SqlCommand cmd = CreateCommand(sqlStr);
            int t = (int)cmd.ExecuteScalar();
            Close();
            return t;
        }
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <param name="dr"></param>
        /// <returns></returns>
        public SqlDataReader RunSql(string sqlStr, out SqlDataReader dr)
        {
            SqlCommand cmd = CreateCommand(sqlStr);
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }

        /// <summary>
        /// 将dataReader对象转换为DataTable对象
        /// </summary>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        public DataTable ConvertDataReaderToDataTable(SqlDataReader dataReader)
        {
            DataTable dt = new DataTable();
            DataTable schemaTable = dataReader.GetSchemaTable();
            try
            {
           
                foreach (DataRow myRow in schemaTable.Rows)
                {
                    DataColumn myDataColumn = new DataColumn();
                    // 添加表头： table.Columns.Add("name", Type.GetType("System.String"));
                    myDataColumn.ColumnName = myRow[0].ToString();
                    myDataColumn.DataType = System.Type.GetType("System.String");
                    dt.Columns.Add(myDataColumn);
                  
                }
                while (dataReader.Read())
                {
                    DataRow mydataRow = dt.NewRow();
                    for (int i = 0; i < schemaTable.Rows.Count; i++)
                    {
                        mydataRow[i] = dataReader[i].ToString();
                    }
                    dt.Rows.Add(mydataRow);
                    mydataRow = null;
                }
                schemaTable = null;
                dataReader.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("转换出错", ex);
            }
        }
    }
}
