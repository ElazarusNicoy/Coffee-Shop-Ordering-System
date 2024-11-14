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
    public partial class frmProductModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmManageProduct frmPList;

        public frmProductModule(frmManageProduct fplist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmPList = fplist;
        }

        private void btnPSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this product?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string BrandID = "", CategoryID = "";
                    cn.Open();
                    cm = new SqlCommand("SELECT ID FROM tbl_brand WHERE Brand LIKE '" + cbProdBrand.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows) { BrandID = dr[0].ToString(); }
                    dr.Close();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("SELECT ID FROM tbl_category WHERE Category LIKE '" + cbProdCatgry.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows) { CategoryID = dr[0].ToString(); }
                    dr.Close();
                    cn.Close();


                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbl_product(Pcode, Barcode, Pdesc, BrandID, CategoryID, Price)VALUES(@Pcode, @Barcode, @Pdesc, @BrandID, @CategoryID, @Price)", cn);
                    cm.Parameters.AddWithValue("@Pcode", txtProdCode.Text);
                    cm.Parameters.AddWithValue("@Barcode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@Pdesc", txtProdDescrp.Text);
                    cm.Parameters.AddWithValue("@BrandID", BrandID);
                    cm.Parameters.AddWithValue("@CategoryID", CategoryID);
                    cm.Parameters.AddWithValue("@Price", txtProdPrice.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully saved.");
                    Clear();
                    //frmPList.LoadRecords();
                    frmPList.LoadManageProducts();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void frmProdModClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadCategory()
        {
            cbProdCatgry.Items.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT Category FROM tbl_category", cn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                cbProdCatgry.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();

        }

        public void LoadBrand()
        {
            cbProdBrand.Items.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT Brand FROM tbl_brand", cn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                cbProdBrand.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();

        }
        public void Clear()
        {
            txtProdCode.Clear();
            txtProdDescrp.Clear();
            txtProdPrice.Clear();
            txtBarcode.Clear();
            cbProdBrand.Text = "";
            cbProdCatgry.Text = "";
            txtProdCode.Focus();
            btnPSave.Enabled = true;
            btnPUpdate.Enabled = false;
        }

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string BrandID = "", CategoryID = "";
                    cn.Open();
                    cm = new SqlCommand("SELECT ID FROM tbl_brand WHERE Brand LIKE '" + cbProdBrand.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows) { BrandID = dr[0].ToString(); }
                    dr.Close();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("SELECT ID FROM tbl_category WHERE Category LIKE '" + cbProdCatgry.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows) { CategoryID = dr[0].ToString(); }
                    dr.Close();
                    cn.Close();


                    cn.Open();
                    cm = new SqlCommand("UPDATE tbl_product SET Barcode=@Barcode, Pdesc=@Pdesc, BrandID=@BrandID, CategoryID=@CategoryID, Price=@Price WHERE Pcode LIKE @Pcode", cn);
                    cm.Parameters.AddWithValue("@Pcode", txtProdCode.Text);
                    cm.Parameters.AddWithValue("@Barcode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@Pdesc", txtProdDescrp.Text);
                    cm.Parameters.AddWithValue("@BrandID", BrandID);
                    cm.Parameters.AddWithValue("@CategoryID", CategoryID);
                    cm.Parameters.AddWithValue("@Price", txtProdPrice.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully updated.");
                    Clear();
                    //frmPList.LoadRecords();
                    frmPList.LoadManageProducts();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtProdPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
