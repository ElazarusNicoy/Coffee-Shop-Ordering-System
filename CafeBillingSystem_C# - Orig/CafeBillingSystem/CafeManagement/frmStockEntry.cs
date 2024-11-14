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
    public partial class frmStockEntry : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string sysName = "Coffee Shop Inventory";

        public frmStockEntry()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void StockEntryTab_Click(object sender, EventArgs e)
        {
            btnStckSave.Enabled = true;
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvStockEntry.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT Pcode, Pdesc, Qty FROM tbl_product WHERE Pdesc LIKE '%' ORDER BY Pdesc", cn);
            dr = cm.ExecuteReader();
            while (true)
            {
                i++;
                dgvStockEntry.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }

        }

        public void LoadStockIn()
        {
            int i = 0;
            dgvStockEntry.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM viewStockIn WHERE ReferenceNo LIKE '" + txtRefNo.Text + "' AND Status LIKE 'Pending'", cn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                i++;
                dgvStockEntry.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        
        }

        private void frmStockInClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtRefNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgvStockEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvStockEntry.Columns[e.ColumnIndex].Name;
            if (columnName == "Delete")
            {
                if (MessageBox.Show("Remove this item?", sysName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbl_stockin WHERE ID = '" + dgvStockEntry.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    int rowIndex = dgvStockEntry.CurrentCell.RowIndex;
                    dgvStockEntry.Rows.RemoveAt(rowIndex);
                    MessageBox.Show("Item has been successfully removed.", sysName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LoadProduct();
                    //LoadStockIn();
        }
    }
}

        public void Clear()
        {
            txtStockInBy.Clear();
            txtRefNo.Clear();
            dtStckIn.Value = DateTime.Now;
        }
        private void btnStckSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStockEntry.Rows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to save this records?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgvStockEntry.Rows.Count; i++)
                        {
                            //update product qty
                            cn.Open();
                            cm = new SqlCommand("UPDATE tbl_product SET Qty = " + int.Parse(dgvStockEntry.Rows[i].Cells[4].Value.ToString()) + "WHERE Pcode LIKE '" + dgvStockEntry.Rows[i].Cells[2].Value.ToString() + "'", cn); 
                            cm.ExecuteNonQuery();
                            cn.Close();

                            //update tbl_stockin qty
                            cn.Open();
                            cm = new SqlCommand("UPDATE tbl_stockin SET Qty = " + int.Parse(dgvStockEntry.Rows[i].Cells[4].Value.ToString()) + ", Status = 'Done' WHERE Pcode LIKE '" + dgvStockEntry.Rows[i].Cells[2].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                        }
                        MessageBox.Show("Records has been successfully added.", sysName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        dgvStockEntry.Rows.Clear();
                        //LoadStockIn();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, sysName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StockHistoryTab_Click(object sender, EventArgs e)
        {
            btnStckSave.Enabled = false;
        }

        private void LoadStockInHistory()
        {

            int i = 0;
            dgvStockInHistory.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM viewStockIn WHERE CAST (StockDate AS DATE) BETWEEN '" + date1.Value + "' AND '" + date2.Value + "' AND Status LIKE 'Done' ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvStockInHistory.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnLdRecord_Click(object sender, EventArgs e)
        {
            LoadStockInHistory();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBrowseProductList browProdList = new frmBrowseProductList(this);
            
            browProdList.LoadBrowseProductList();
            browProdList.ShowDialog();
        }

        public void LoadRecords()
        {
            int i = 0;
            dgvStockInHistory.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM viewStockIn WHERE CAST (StockDate AS DATE) BETWEEN '" + date1.Value + "' AND '" + date2.Value + "' AND Status LIKE 'Done' ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvStockInHistory.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }
    }
}
