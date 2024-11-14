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
    public partial class frmManageBrand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();

        public frmManageBrand()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
           LoadRecords();
        }

        private void dgvBrandList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvBrandList.Columns[e.ColumnIndex].Name;
            if (columnName == "Edit")
            {
                frmBrandModule frmBrand = new frmBrandModule(this);

                frmBrand.lblID.Text = dgvBrandList[1, e.RowIndex].Value.ToString();
                frmBrand.txtBox_brandName.Text = dgvBrandList[2, e.RowIndex].Value.ToString();
                frmBrand.btnSave.Enabled = false;
                frmBrand.btnUpdate.Enabled = true;
                frmBrand.ShowDialog();
            }
            else if (columnName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbl_brand WHERE ID LIKE '" + dgvBrandList[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been successfully deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();

                }
            }
        }

        private void frmBrnLstAdd_Click(object sender, EventArgs e)
        {
            frmBrandModule frmBrand = new frmBrandModule(this);
            frmBrand.btnUpdate.Enabled = false;
            frmBrand.btnSave.Enabled = true;
            frmBrand.ShowDialog();
        }

        public void LoadRecords()
        {
            int i = 0;
            dgvBrandList.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbl_brand ORDER BY Brand", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dgvBrandList.Rows.Add(i, dr["id"].ToString(), dr["Brand"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void frmBrnLstClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
