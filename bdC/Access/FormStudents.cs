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
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SELHOZRABOTIDataSet1.Works' table. You can move, or remove it, as needed.
            this.worksTableAdapter.Fill(this.dB_SELHOZRABOTIDataSet1.Works);
            // TODO: This line of code loads data into the 'dB_SELHOZRABOTIDataSet2.FAC' table. You can move, or remove it, as needed.
            this.fACTableAdapter.Fill(this.dB_SELHOZRABOTIDataSet2.FAC);
            // TODO: This line of code loads data into the 'dB_SELHOZRABOTIDataSet.FIO' table. You can move, or remove it, as needed.
            this.fIOTableAdapter.Fill(this.dB_SELHOZRABOTIDataSet.FIO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fIOBindingSource.EndEdit();
            this.fIOTableAdapter.Update(this.dB_SELHOZRABOTIDataSet.FIO);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dvStudEach.CurrentCell.RowIndex;

            fIOBindingSource.Filter = "STUD_ID = " + dvStudEach[0, bb].Value;
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dvStudEach.CurrentCell.RowIndex;

            fIOBindingSource.Filter = string.Format("STUD_2d = '{0}'", dvStudEach[1, bb].Value);
           // sitesBindingSource.Filter = string.Format("Site_ID = '{0}'", comboBox1.SelectedValue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bb = dvStudEach.CurrentCell.RowIndex;

            fIOBindingSource.Filter =  string.Format("STUD_NAME = '{0}'", dvStudEach[2, bb].Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int bb = dvStudEach.CurrentCell.RowIndex;

            fIOBindingSource.Filter = string.Format("STUD_3DNAME = '{0}'", dvStudEach[3, bb].Value);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int bb = dvStudEach.CurrentCell.RowIndex;

            fIOBindingSource.Filter = "FAC_ID = " + dvStudEach[4, bb].Value;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int bb = dvStudEach.CurrentCell.RowIndex;

            fIOBindingSource.Filter = "WORK_ID = " + dvStudEach[5, bb].Value;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fIOBindingSource.Filter = "";
        }
    }
}
