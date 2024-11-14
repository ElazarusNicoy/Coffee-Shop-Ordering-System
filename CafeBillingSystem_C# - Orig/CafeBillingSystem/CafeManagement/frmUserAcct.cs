using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeManagement
{
    public partial class frmUserAcct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
       // SqlDataReader dr;

        public frmUserAcct()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void userAcctClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmUserAcct_Load(object sender, EventArgs e)
        {
            frmUserTabAuthe userAuthe = new frmUserTabAuthe();
            userAuthe.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != txtRePass.Text)
                {
                    MessageBox.Show("Password did not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                cm = new SqlCommand("INSERT INTO tbl_user (Username, Password, Role, Name) VALUES (@Username, @Password, @Role, @Name)", cn);
                cm.Parameters.AddWithValue("@Username", txtUsername.Text);
                cm.Parameters.AddWithValue("@Password", txtPass.Text);
                cm.Parameters.AddWithValue("@Role", cbRole.Text);
                cm.Parameters.AddWithValue("@Name", txtName.Text);

                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New account has saved!");
                Clear();
            }
            catch (Exception ex)
            {
                cn.Close();

                MessageBox.Show(ex.Message);

            }

        }
        private void Clear()
        {
            txtUsername.Clear();
            txtPass.Clear();
            txtRePass.Clear();
            txtName.Clear();
            cbRole.Text = "";
            txtUsername.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUserAcct_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
