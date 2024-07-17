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
    public partial class frmBook : Form
    {

      
       

        public frmBook()
        {
            InitializeComponent();
        }
            DataTable dt;
            DataRow dr;
            string code;
            DialogResult res;


        public void clear()
            {
                txtBID.Clear();
                txtBName.Clear();
                txtISBN.Clear();
                txtAuName.Clear();
                cmbCate.Text = "";
                cmbLang.Text = "";
                txtDoName.Clear();
                txtAName.Text = "";
                txtBoName.Clear();
                this.ActiveControl = txtBID;

            }

        private void frmBookDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet6.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDataSet6.Book);  
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookTableAdapter.Fill(this.libraryDataSet6.Book);
                dt = libraryDataSet6.Book;
                dr = dt.NewRow();
                dr["BookID"] = txtBID.Text;
                dr["BookName"] = txtBName.Text;
                dr["ISBN"] = txtISBN.Text;
                dr["AuName"] = txtAuName.Text;
                dr["Language"] = cmbLang.Text;
                dr["Category"] = cmbCate.Text;
                dr["DoName"] = txtDoName.Text;
                dr["DoDate"] = dtpDoDate.Text;
                dr["BoName"] = txtBoName.Text;
                dr["AuthorName"] = txtAName.Text;


                dt.Rows.Add(dr);
                bookTableAdapter.Update(libraryDataSet6);
                MessageBox.Show("Book Added", "Book Added.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }
            catch
            {
                MessageBox.Show("Invalid BookID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnFIND_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookTableAdapter.Fill(this.libraryDataSet6.Book);
                dt = libraryDataSet6.Book;
                code = txtBID.Text;
                dr = dt.Rows.Find(code);
                txtBName.Text = dr["BookName"].ToString();
                txtISBN.Text = dr["ISBN"].ToString();
                txtAuName.Text = dr["AuName"].ToString();
                cmbLang.Text = dr["Language"].ToString();
                cmbCate.Text = dr["Category"].ToString();
                txtDoName.Text = dr["DoName"].ToString();
                dtpDoDate.Text = dr["DoDate"].ToString();
                txtBoName.Text = dr["BoName"].ToString();
                txtAName.Text = dr["AuthorName"].ToString();

                MessageBox.Show("Book Found..", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Book not Found..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.clear();
            }
            
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
             this.bookTableAdapter.Fill(this.libraryDataSet6.Book);
                dt = libraryDataSet6.Book;
                code = txtBID.Text;
                dr = dt.Rows.Find(code);
                dr.BeginEdit();
                dr["BookName"] = txtBName.Text;
                dr["ISBN"]=txtISBN.Text ;
                dr["AuName"]=txtAuName.Text ;
                dr["Language"]=cmbLang.Text  ;
                dr["Category"]=cmbCate.Text ;
                dr["DoName"]=txtDoName.Text;
                dr["DoDate"]=dtpDoDate.Text  ;
                dr["BoName"]=txtBoName.Text  ;
                dr["AuthorName"] = txtAName.Text;
                dr.EndEdit();
                bookTableAdapter.Update(libraryDataSet6);
                MessageBox.Show("Book Update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }
            catch
            {
                MessageBox.Show("Invalid Book ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
                try
            {
                this.bookTableAdapter.Fill(this.libraryDataSet6.Book);
                dt = libraryDataSet6.Book;
                code = txtBID.Text;
                dr = dt.Rows.Find(code);
                 res = MessageBox.Show("Are you sure Delete this..", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    dr.Delete();
                    bookTableAdapter.Update(libraryDataSet6.Book);
                    MessageBox.Show("Delete..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear();
                }
            }// end try
            catch
            {
                MessageBox.Show("Invalid Member ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCLs_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new frmBook().Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            new frmBR().Show();
            this.Hide();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabBookAdd_Click(object sender, EventArgs e)
        {

        }

        private void txtBID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabDonate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
