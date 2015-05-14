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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SELHOZRABOTIDataSet.FAC' table. You can move, or remove it, as needed.
            this.fACTableAdapter.Fill(this.dB_SELHOZRABOTIDataSet.FAC);
            // TODO: This line of code loads data into the 'dB_SELHOZRABOTIDataSet.Works' table. You can move, or remove it, as needed.
            this.worksTableAdapter.Fill(this.dB_SELHOZRABOTIDataSet.Works);
            // TODO: This line of code loads data into the 'dB_SELHOZRABOTIDataSet.FIO' table. You can move, or remove it, as needed.
            this.fIOTableAdapter.Fill(this.dB_SELHOZRABOTIDataSet.FIO);
            // TODO: This line of code loads data into the 'dB_SELHOZRABOTIDataSet2.FAC' table. You can move, or remove it, as needed.
            this.fACTableAdapter.Fill(this.dB_SELHOZRABOTIDataSet.FAC);
            // TODO: This line of code loads data into the 'dB_SELHOZRABOTIDataSet1.Works' table. You can move, or remove it, as needed.
            this.worksTableAdapter.Fill(this.dB_SELHOZRABOTIDataSet.Works);
            // TODO: This line of code loads data into the 'dB_SELHOZRABOTIDataSet.FIO' table. You can move, or remove it, as needed.
            this.fIOTableAdapter.Fill(this.dB_SELHOZRABOTIDataSet.FIO);

            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
            //this.reportViewer3.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
            //this.reportViewer3.RefreshReport();
        }

        private void msStud_Click(object sender, EventArgs e)
        {
            FormStudents fstud = new FormStudents();
            fstud.Show();
        }

        private void msWork_Click(object sender, EventArgs e)
        {
            FormWorks fwork = new FormWorks();
            fwork.Show();
        }

        private void msFAC_Click(object sender, EventArgs e)
        {
            FormFACs ffac = new FormFACs();
            ffac.Show();
        }

        private void работаСПроцедурамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void процедура3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcedure frm = new FormProcedure();
            frm.Show();
        }

        private void процедура1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcedure2 fr = new FormProcedure2();
            fr.Show();
        }

        private void процедура2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcedure3 fr1 = new FormProcedure3();
            fr1.Show();
        }

        private void отчетВТабличнойФормеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //report1.RegisterData(dB_SELHOZRABOTIDataSet.FIO);
            //report1.RegisterData(dB_SELHOZRABOTIDataSet1.);
            //report1.RegisterData(dB_SELHOZRABOTIDataSet2);
            report1.Show();
            
        }

        private void отчетВСвободнойФормеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report2.Show();
        }

        private void отчетСГруппировкойПоДвумТаблицамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report3.Show();
        }
    }
}
