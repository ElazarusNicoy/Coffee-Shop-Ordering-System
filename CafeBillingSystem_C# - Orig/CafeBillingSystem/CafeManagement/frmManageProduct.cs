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
    public partial class frmManageProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public frmManageProduct()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            
        }

        private void dgvProdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvProdList.Columns[e.ColumnIndex].Name;
            if (columnName == "colProdListEdit")
            {
                frmProductModule frmProduct = new frmProductModule(this);

                frmProduct.txtProdCode.Text = dgvProdList.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmProduct.txtBarcode.Text = dgvProdList.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmProduct.txtProdDescrp.Text = dgvProdList.Rows[e.RowIndex].Cells[3].Value.ToString();
                frmProduct.txtProdPrice.Text = dgvProdList.Rows[e.RowIndex].Cells[6].Value.ToString();
                frmProduct.cbProdBrand.Text = dgvProdList.Rows[e.RowIndex].Cells[4].Value.ToString();
                frmProduct.cbProdCatgry.Text = dgvProdList.Rows[e.RowIndex].Cells[5].Value.ToString();
                frmProduct.btnPUpdate.Enabled = true;
                frmProduct.btnPSave.Enabled = false;
                frmProduct.ShowDialog();
            }
            else if (columnName == "colProdListDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbl_product WHERE Pcode LIKE '" + dgvProdList.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    LoadManageProducts();

                }
            }
        }


        public void LoadManageProducts()
        {
            int i = 0;
            dgvProdList.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT P.Pcode, P.Barcode, P.Pdesc, B.Brand, C.Category, P.Price, P.Qty FROM tbl_product AS P INNER JOIN tbl_brand as B ON B.ID = P.BrandID INNER JOIN tbl_category AS C ON C.ID = P.CategoryID WHERE P.Pdesc LIKE '%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProdList.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        
        }

        private void ProdListAdd_Click(object sender, EventArgs e)
        {
            frmProductModule frmProduct = new frmProductModule(this);
            frmProduct.btnPSave.Enabled = true;
            frmProduct.btnPUpdate.Enabled = false;
            frmProduct.LoadCategory();
            frmProduct.LoadBrand();
            frmProduct.ShowDialog();
        }

        private void ProdListClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
