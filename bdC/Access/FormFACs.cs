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
    public partial class FormFACs : Form
    {
        public FormFACs()
        {
            InitializeComponent();
        }

        private void FormFACs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SELHOZRABOTIDataSet2.FAC' table. You can move, or remove it, as needed.
            this.fACTableAdapter.Fill(this.dB_SELHOZRABOTIDataSet.FAC);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fACBindingSource.EndEdit();
            this.fACTableAdapter.Update(this.dB_SELHOZRABOTIDataSet.FAC);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dvFACEach.CurrentCell.RowIndex;

            fACBindingSource.Filter = "FAC_ID = " + dvFACEach[0, bb].Value;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dvFACEach.CurrentCell.RowIndex;

            fACBindingSource.Filter = string.Format("FACULT = '{0}'", dvFACEach[1, bb].Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fACBindingSource.Filter = "";
        }
    }
}
