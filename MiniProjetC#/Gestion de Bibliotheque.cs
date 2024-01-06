using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjetC_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void employeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gererEmployeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Employé f4 = new Gestion_Employé();
            f4.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void adherantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouveauEmployéToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void gererAdherantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Adhérent f5 = new Gestion_Adhérent();
            f5.Show();
        }

        private void gererLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Livre f6 = new Gestion_Livre();
            f6.Show();
        }


        private void empruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gestionDesEmpruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_des_emprunts Emp = new Gestion_des_emprunts();
            Emp.Show();
        }
    }
}
