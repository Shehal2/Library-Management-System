using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System_Theekshana
{
    public partial class frmBR : Form
    {

       
       
        public frmBR()
        {
            InitializeComponent();
        }
        DataTable dt;
        DataRow dr;
        string code, code1, get, ref1;
        DateTime bor, ret;
        TimeSpan dif;
        string totaldays;
        float total, late, fineperday, totalfine;

        public void clear()
        {
            txtMID.Clear();
            txtName.Clear();
            txtBID.Clear();
            txtBName.Clear();
            dtpBorDate.Text = "";
            dtpRetDate.Text = "";
            txtRefCode1.Clear();
            this.ActiveControl = txtMID;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmBR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.BR' table. You can move, or remove it, as needed.
            this.bRTableAdapter.Fill(this.libraryDataSet1.BR);
            // TODO: This line of code loads data into the 'libraryDataSet1.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.libraryDataSet1.Member);
            // TODO: This line of code loads data into the 'libraryDataSet1.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDataSet1.Book);
            
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnFineperday_Click(object sender, EventArgs e)
        {
            txtFPDay.Text = txtFPDay2.Text;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtMID_KeyPress(object sender, KeyPressEventArgs e)
        {
           try
            {
                if (e.KeyChar == 13)
                {
                     this.memberTableAdapter.Fill(this.libraryDataSet1.Member);
                    dt = libraryDataSet1.Member;
                    code = txtMID.Text;
                    dr = dt.Rows.Find(code);
                    txtName.Text = dr["MemberName"].ToString();
                }
            }// end try
            catch
            {
                MessageBox.Show("Record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
