using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Access
{
    public partial class FormProcedure3 : Form
    {
        public FormProcedure3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int sum;
            //sqlCommand1.Parameters["@fac"].Value = textBox1.Text;
            //DataTable table = new DataTable();
            //sqlConnection1.Open();
            //sqlCommand1.ExecuteNonQuery();
            //            sqlConnection1.Close();
            //DataTable ds = new DataTable();

            //// count_save = sqlCommand1.Parameters["@str"].Value.ToString();
            //sum = Convert.ToInt32(sqlCommand1.Parameters["@a"].Value);
            //textBox2.Text = sum.ToString();
            //dataGridView1.DataSource = sqlCommand1.Parameters["@ReturnValue"].SqlDbType;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows.Clear();
            sqlCommand1.Parameters["@fac"].Size = 1000;
            sqlCommand1.Parameters["@fac"].Value = textBox1.Text;

            sqlConnection1.Open();

            using (sqlCommand1)
            {
                using (SqlDataReader reader = sqlCommand1.ExecuteReader())
                {
                    while (reader.Read())
                        dataGridView1.Rows.Add(reader["FAC_ID"].ToString(), reader["STUD_2d"].ToString(), reader["Zarplata"].ToString(), reader["Workname"].ToString());
                }
            }
            sqlConnection1.Close();

            //extBox3.Text = Convert.ToString(count_save1);
        }

        private void FormProcedure3_Load(object sender, EventArgs e)
        {

        }
    }
}
