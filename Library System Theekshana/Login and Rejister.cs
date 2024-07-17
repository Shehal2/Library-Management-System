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
    public partial class frmLRejister : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeft,
           int nTop,
           int nRight,
           int nBottom,
           int nWidthEllipse,
           int nHeightEllipse
       );
        public frmLRejister()
        {
            InitializeComponent();
        }

        private void panelReji_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReji_Click(object sender, EventArgs e)
        {
            
        }

        private void frmLRejister_Load(object sender, EventArgs e)
        {
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 30, 30));
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                if (txtUser.Text == "User")
                {
                    if (txtPassword.Text == "Admin")
                    {
                        new frmMain().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error : Login Fail");
                    }
                }
            }
        }

        private void btnRejister_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxshowpass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           // DialogResult Dialog = MessageBox.Show("Do you want to Exit?",
           // "Exit", MessageBoxButtons.YesNo);
          //  If (Dialog == DialogResult.Yes)
          //  {
          //  Application.Exit();
          //  }
          //  else if (Dialog == DialogResult.No)
          //  {
             //   e.
           // }
            this.Close();
        }
    }
}
