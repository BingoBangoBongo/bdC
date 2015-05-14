using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
namespace Access
{
    public partial class FormProcedure2 : Form
    {
        public FormProcedure2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sum;
            string sum1;
            string sum2;
            
            sqlCommand1.Parameters["@str3"].Size = 4000;
            sqlCommand1.Parameters["@str"].Size = 4000;
            sqlCommand1.Parameters["@str1"].Size = 4000;
            sqlCommand1.Parameters["@str2"].Size = 4000;

            sqlCommand1.Parameters["@str3"].Value = textBox1.Text;
            
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            sum = Convert.ToString(sqlCommand1.Parameters["@str"].Value);
            textBox2.Text = sum.ToString();
            sum1 = Convert.ToString(sqlCommand1.Parameters["@str1"].Value);
            textBox3.Text = sum1.ToString();
            sum2 = Convert.ToString(sqlCommand1.Parameters["@str2"].Value);
            
            textBox4.Text = sum2.ToString();
            
            report1.Load(Application.StartupPath + "\\MyReport.frx"); // загружаем файл отчета
            //report1.Preview = previewControl1;
            (report1.FindObject("Text2") as TextObject).Text = this.textBox2.Text; // выводим текст из label1
            (report1.FindObject("Text3") as TextObject).Text = this.textBox3.Text;
            (report1.FindObject("Text4") as TextObject).Text = this.textBox4.Text;// выводим текст из textBox1
            //(report1.FindObject("Rich_iz_rich1") as RichObject).Text = this.richTextBox1.Text; // выводим текст из richTextBox1
            report1.Show();
        }

        private void FormProcedure2_Load(object sender, EventArgs e)
        {

        }
    }
}
