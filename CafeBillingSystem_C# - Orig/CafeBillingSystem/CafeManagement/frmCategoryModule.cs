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
    public partial class frmCategoryModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmManageCategory frmclist;

        public frmCategoryModule(frmManageCategory fclist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmclist = fclist;
        }

        private void frmCatgryClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            btnCSave.Enabled = true;
            btnCUpdate.Enabled = false;
            txtBox_catgryName.Clear();
            txtBox_catgryName.Focus();
        }

        private void btnCSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this category?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbl_category(Category)VALUES(@Category)", cn);
                    cm.Parameters.AddWithValue("@Category", txtBox_catgryName.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been successfully saved.");
                    Clear();
                    frmclist.LoadCategory();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this category?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tbl_category SET Category = @Category WHERE ID LIKE '" + lblCID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@Category", txtBox_catgryName.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been successfully updated.");
                    Clear();
                    frmclist.LoadCategory();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
