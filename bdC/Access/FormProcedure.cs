using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access
{
    public partial class FormProcedure : Form
    {
        public FormProcedure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum;
            sqlCommand1.Parameters["@fac"].Value = textBox1.Text;
            sqlCommand1.Parameters["@wname"].Value = textBox2.Text;
            sqlCommand1.Parameters["@i"].Value = textBox3.Text;
            
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
           // count_save = sqlCommand1.Parameters["@str"].Value.ToString();
            sum = Convert.ToInt32(sqlCommand1.Parameters["@sum"].Value);
          //count_save1 = sqlCommand1.Parameters["@str1"].Value.ToString(); 
            textBox4.Text = sum.ToString();
           //extBox3.Text = Convert.ToString(count_save1);
        }

        private void FormProcedure_Load(object sender, EventArgs e)
        {

        }
    }
}
