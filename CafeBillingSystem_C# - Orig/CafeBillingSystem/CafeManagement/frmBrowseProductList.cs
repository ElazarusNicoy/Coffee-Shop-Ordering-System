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
    public partial class frmBrowseProductList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string sysName = "Coffee Shop Inventory";
        frmStockEntry frmsilist;
        

        public frmBrowseProductList(frmStockEntry fsilist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmsilist = fsilist;
        

        }

        private void frmProdModClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        public void LoadBrowseProductList()
        {
            int i = 0;
            dgvBrowseProdList.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT Pcode, Pdesc FROM tbl_product WHERE Pdesc LIKE '%' ORDER BY Pdesc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())  //while (dr.Read()) 
            {
                i++;
                dgvBrowseProdList.Rows.Add(i, dr[0].ToString(), dr[1].ToString()); 
            }
            cn.Close();
        }



        private void dgvBrowseProdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvBrowseProdList.Columns[e.ColumnIndex].Name;
            if (columnName == "Select")
            {
                if (frmsilist.txtRefNo.Text == string.Empty) { MessageBox.Show("Please enter reference no.", sysName, MessageBoxButtons.OK, MessageBoxIcon.Warning); frmsilist.txtRefNo.Focus(); return;}
                if (frmsilist.txtStockInBy.Text == string.Empty) { MessageBox.Show("Please enter stock in by.", sysName, MessageBoxButtons.OK, MessageBoxIcon.Warning); frmsilist.txtStockInBy.Focus(); return;}
                if (MessageBox.Show("Add this Item?", sysName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    //cm = new SqlCommand("SELECT * FROM tbl_product WHERE Pcode LIKE '" + dgvBrowseProdList.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm = new SqlCommand("INSERT INTO viewStockIn (ReferenceNo, Pcode, StockDate, StockInBy)VALUES(@ReferenceNo, @Pcode, @StockDate, @StockInBy)", cn);
                    cm.Parameters.AddWithValue("@ReferenceNo", frmsilist.txtRefNo.Text);
                    cm.Parameters.AddWithValue("@Pcode", dgvBrowseProdList.Rows[e.RowIndex].Cells[1].Value.ToString());
                  //  cm.Parameters.AddWithValue("@Qty", dgvBrowseProdList.Rows[e.RowIndex].Cells[3].Value.ToString());
                    cm.Parameters.AddWithValue("@StockDate", frmsilist.dtStckIn.Value);
                    cm.Parameters.AddWithValue("@StockInBy", frmsilist.txtStockInBy.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                   
                    MessageBox.Show("Successfully added!", sysName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmsilist.LoadStockIn();
                }

            }
        }
    }
}
