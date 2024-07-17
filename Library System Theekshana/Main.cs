using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System_Theekshana
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void memberRejisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMember member = new frmMember();
            member.MdiParent = this;
            member.Show();
        }

        private void bookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBook Book = new frmBook();
            Book.MdiParent = this;
            Book.Show();
        }

        private void borrowAndReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBR BorrowandReturn = new frmBR();
            BorrowandReturn.MdiParent = this;
            BorrowandReturn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmLRejister().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLRejister().Show();
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you want to Exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
