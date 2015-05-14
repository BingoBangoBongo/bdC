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
    public partial class FormWorks : Form
    {
        public FormWorks()
        {
            InitializeComponent();
        }

        private void FormWorks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SELHOZRABOTIDataSet1.Works' table. You can move, or remove it, as needed.
            this.worksTableAdapter.Fill(this.dB_SELHOZRABOTIDataSet1.Works);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.worksBindingSource.EndEdit();
            this.worksTableAdapter.Update(this.dB_SELHOZRABOTIDataSet1.Works);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dvWorkEach.CurrentCell.RowIndex;

            worksBindingSource.Filter = "WORK_ID = " + dvWorkEach[0, bb].Value;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dvWorkEach.CurrentCell.RowIndex;

            worksBindingSource.Filter = string.Format("WorkName = '{0}'", dvWorkEach[1, bb].Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bb = dvWorkEach.CurrentCell.RowIndex;

            worksBindingSource.Filter = string.Format("Zarplata = '{0}'", dvWorkEach[2, bb].Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            worksBindingSource.Filter = "";
        }
    }
}
