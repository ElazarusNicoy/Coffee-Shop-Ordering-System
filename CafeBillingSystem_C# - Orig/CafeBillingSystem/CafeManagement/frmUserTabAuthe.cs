using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CafeManagement
{
    public partial class frmUserTabAuthe : Form
    {
       
        public frmUserTabAuthe()
        {
            InitializeComponent();
            
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void chkShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string login = "SELECT * FROM tbl_users WHERE username = '" + txtUsername.Text + " ' and password = '" + txtPassword.Text + "'";
                cmd = new OleDbCommand(login, con);
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true && txtUsername.Text == "Admin1")
                {
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Unauthorized Access!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }

            }

