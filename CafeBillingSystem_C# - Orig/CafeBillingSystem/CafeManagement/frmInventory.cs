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
    public partial class frmInventory : Form
    {
        //public static string nameInventory;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        public frmInventory()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            
        }

        private void btnMngeBrnd_Click(object sender, EventArgs e)
        {
            frmManageBrand frmBrandList = new frmManageBrand();
            frmBrandList.TopLevel = false;
            panelCenter.Controls.Add(frmBrandList);
            frmBrandList.BringToFront();
            frmBrandList.Show();
        }

        private void btnMngeCatgry_Click(object sender, EventArgs e)
        {
            frmManageCategory frmCategoryList = new frmManageCategory();
            frmCategoryList.TopLevel = false;
            panelCenter.Controls.Add(frmCategoryList);
            frmCategoryList.BringToFront();
            frmCategoryList.LoadCategory();
            frmCategoryList.Show();
        }

        private void btnMngeProdts_Click(object sender, EventArgs e)
        {
            frmManageProduct frmProductList = new frmManageProduct();
            frmProductList.TopLevel = false;
            panelCenter.Controls.Add(frmProductList);
            frmProductList.BringToFront();
            //frmProductList.LoadRecords();
            frmProductList.LoadManageProducts();
            frmProductList.Show();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            frmStockEntry frmStockIn = new frmStockEntry();
            frmStockIn.TopLevel = false;
            panelCenter.Controls.Add(frmStockIn);
            frmStockIn.BringToFront();
            //frmStockIn.LoadProduct();
            frmStockIn.Show();
        }

        private void btnUserSett_Click(object sender, EventArgs e)
        {
            frmUserAcct frmUserAcct = new frmUserAcct();
            frmUserAcct.TopLevel = false;
            panelCenter.Controls.Add(frmUserAcct);
            frmUserAcct.BringToFront();
            frmUserAcct.Show();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            

            
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
