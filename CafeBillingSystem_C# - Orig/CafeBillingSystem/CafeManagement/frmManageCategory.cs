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
    public partial class frmManageCategory : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmManageCategory()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void dgvCategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvCategoryList.Columns[e.ColumnIndex].Name;
            if (columnName == "Edit")
            {
                frmCategoryModule frmCategory = new frmCategoryModule(this);

                frmCategory.lblCID.Text = dgvCategoryList.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmCategory.txtBox_catgryName.Text = dgvCategoryList.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmCategory.btnCUpdate.Enabled = true;
                frmCategory.btnCSave.Enabled = false;
                frmCategory.ShowDialog();
            }
            else if (columnName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbl_category WHERE ID LIKE '" + dgvCategoryList.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been successfully deleted.");
                    LoadCategory();

                }
            }
        }

        private void frmCatgryLstAdd_Click(object sender, EventArgs e)
        {
            frmCategoryModule frmCategory = new frmCategoryModule(this);
            frmCategory.btnCUpdate.Enabled = false;
            frmCategory.btnCSave.Enabled = true;
            frmCategory.ShowDialog();

        }

        public void LoadCategory()
        {
            int i = 0;
            dgvCategoryList.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbl_category ORDER BY Category", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategoryList.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            cn.Close();

        }

        private void frmCatgryLstClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
