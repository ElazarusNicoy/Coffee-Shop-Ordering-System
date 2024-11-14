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
    public partial class frmBrandModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmManageBrand frmList;

        public frmBrandModule(frmManageBrand flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmList = flist;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtBox_brandName.Clear();
            txtBox_brandName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbl_brand(Brand)VALUES(@Brand)", cn);
                    cm.Parameters.AddWithValue("@Brand", txtBox_brandName.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.");
                    Clear();
                    frmList.LoadRecords();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmBrandClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this brand?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tbl_brand SET Brand = @Brand WHERE ID LIKE '" + lblID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@Brand", txtBox_brandName.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been successfully updated.");
                    Clear();
                    frmList.LoadRecords();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
