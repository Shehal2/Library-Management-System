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
    public partial class frmMember : Form
    {

        
        

        public frmMember()
        {
            InitializeComponent();
        }

        DataTable dt;
        DataRow dr;
        string gender,code;
        DialogResult res;

        public void clear ()
        {
            txtMID.Clear();
            txtName.Clear();
            txtAdd.Clear();
            txtTel.Clear();
            txtNIC.Clear();
            cmbType.Text ="";
            dtpMDate.Text = "";
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            this.ActiveControl = txtMID;
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet4.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.libraryDataSet4.Member);
           
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                this.memberTableAdapter.Fill(this.libraryDataSet4.Member);
                dt = libraryDataSet4.Member;
                dr = dt.NewRow();
                dr["MemberID"] = txtMID.Text;
                dr["MemberName"] = txtName.Text;
                dr["Address"] = txtAdd.Text;
                dr["Tel"] = txtTel.Text;
                dr["NIC"] = txtNIC.Text;
                dr["Type"] = cmbType.Text;
                dr["MemDate"] = dtpMDate.Text;
               // dr["ExpDate"] = dtpMExDate.Text;

                if(rdoMale.Checked == true)
                {
                    gender = "Male";
                }
                else if(rdoFemale.Checked == true)
                {
                    gender = "Female";
                }
                dr["Gender"] = gender;
                dt.Rows.Add(dr);

                memberTableAdapter.Update(libraryDataSet4);
                MessageBox.Show("Record Added Successfully..","Add Record",MessageBoxButtons.OK,MessageBoxIcon.Information);
                 
                this.clear();
            }// end of the try
            catch
            {
                MessageBox.Show("Invalid Member ID","Error..",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                this.memberTableAdapter.Fill(this.libraryDataSet4.Member);
                dt = libraryDataSet4.Member;
                code = txtMID.Text;
                dr = dt.Rows.Find(code);
                txtName.Text = dr["MemberName"].ToString();
                txtAdd.Text = dr["Address"].ToString();
                txtTel.Text = dr["Tel"].ToString();
                txtNIC.Text = dr["NIC"].ToString();
                cmbType.Text = dr["Type"].ToString();
                dtpMDate.Text = dr["MemDate"].ToString();
               // dtpMExDate.Text = dr["Expdate"].ToString();
                gender = dr["Gender"].ToString();

                if(gender == "Male")
                {
                    rdoMale.Checked = true;
                }
                else if(gender == "Female")
                {
                    rdoFemale.Checked = true;
                }
                MessageBox.Show("Search record Found...", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }// end try
            catch
            {
                MessageBox.Show("Record not Found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {


            this.memberTableAdapter.Fill(this.libraryDataSet4.Member);
            dt = libraryDataSet4.Member;
                code = txtMID.Text;
                dr = dt.Rows.Find(code);
                dr.BeginEdit();
                dr["MemberName"] = txtName.Text;
                dr["Address"] = txtAdd.Text;
                dr["Tel"] = txtTel.Text;
                dr["NIC"] = txtNIC.Text;
                dr["Type"] = cmbType.Text;
                dr["MemDate"] = dtpMDate.Text;
               // dr["ExpDate"] = dtpMExDate.Text;
            

                 if (rdoMale.Checked == true)
                 {
                   gender = "Male";
                  
                 }
                 else if(rdoFemale.Checked == true)
                 {
                     gender = "Female";
                 }
                 dr["Gender"] = gender;
                 dr.EndEdit();
                 memberTableAdapter.Update(libraryDataSet4);
                 MessageBox.Show("Record Updated Successfully..", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.clear();
                                
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                this.memberTableAdapter.Fill(this.libraryDataSet4.Member);
                dt = libraryDataSet4.Member;
                code = txtMID.Text;
                dr = dt.Rows.Find(code);
                res = MessageBox.Show("Are you sure Delete this..", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    dr.Delete();
                    memberTableAdapter.Update(libraryDataSet4);
                    MessageBox.Show("Delete..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear();
                }
            }// end try
            catch
            {
                MessageBox.Show("Invalid Member ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void lblNIC_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
