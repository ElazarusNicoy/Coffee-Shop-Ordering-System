using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.OleDb;
using System.Data.SqlClient;


namespace CafeManagement
{
    public partial class frmLogin : Form
    {
        //public static string nameInventory;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader sdr;

        public frmLogin()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        //OleDbCommand cmd = new OleDbCommand();
        //OleDbDataAdapter da = new OleDbDataAdapter();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _Username = "";
            string _Role = "";
            string _Name = "";
            try
            {
                bool found = false;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tbl_user WHERE Username = @Username AND Password = @Password", cn);
                cm.Parameters.AddWithValue("@Username", txtUsername.Text);
                cm.Parameters.AddWithValue("@Password", txtPassword.Text);
                sdr = cm.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    found = true;
                    _Username = sdr["Username"].ToString();
                    _Role = sdr["Role"].ToString();
                    _Name = sdr["Name"].ToString();
                }
                else
                {
                    found = false;
                }
                sdr.Close();
                cn.Close();

                if (found == true)
                {
                    if (_Role == "Cashier/Barista")
                    {
                        MessageBox.Show("Welcome " + _Name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Clear();
                        txtUsername.Clear();
                        this.Hide();
                        frmStaff frm = new frmStaff();
                        frm.lblUserName.Text = _Username + ": " + _Name;
                        frm.ShowDialog();
                    }
                    else if (_Role == "Registrar")
                    {
                        MessageBox.Show("Welcome " + _Name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Clear();
                        txtUsername.Clear();
                        this.Hide();
                        frmInventory frmI = new frmInventory();
                        frmI.Show();
                        frmI.lblRegistrar.Visible = true;
                        
                    }
                    else
                    //(_Role == "System Admin")
                    {
                        MessageBox.Show("Welcome " + _Name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Clear();
                        txtUsername.Clear();
                        this.Hide();
                        frmInventory frmI = new frmInventory();
                        //frmI.Owner = this;
                        frmI.Show();

                        frmI.lblSysAd.Visible = true;

                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password ", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear();
                }

            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //con.Open();
            //string login = "SELECT * FROM tbl_users WHERE username = '" + txtUsername.Text + " ' and password = '" + txtPassword.Text + "'";
            //cmd = new OleDbCommand(login, con);
            //OleDbDataReader dr = cmd.ExecuteReader();

            //if (dr.Read() == true && txtUsername.Text == "Admin1")
            //{

            //    frmInventory frmInventory = new frmInventory();
            //   frmInventory.Show();
            //    this.Hide();
            //}

            //else if (txtUsername.Text == "Employee1")
            //{
            //    frmEmployee frmEmployee = new frmEmployee();
            //    frmEmployee.Show();
            //    this.Hide();
            //}
            //else if (txtUsername.Text == "Customer")
            //{
            //   new frmWelcome().Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtUsername.Text = "";
            //    txtPassword.Text = "";
            //    txtUsername.Focus();

            //}
        }

        private void Clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }
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

        
    }
}
