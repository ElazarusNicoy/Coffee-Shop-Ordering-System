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
    public partial class frmStaff : Form
    {
        public static string qOrder;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        //SqlDataReader dr;

        //
        public static frmStaff instance;
        public Label lbl45;
        //

        public frmStaff()
        {
            InitializeComponent();
            //cn = new SqlConnection(dbcon.MyConnection());

            //
            instance = this;
            lbl45 = lblBayadCust;
            //
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
            rtbQueue1.AppendText(OrderingSystem.cusOrder + "\n");
            qOrder = rtbQueue1.Text;
            //lblBayadCust.Text = frmProcessingOrder.SetBayadMethod.SetBayad.ToString();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn1Prep_Click(object sender, EventArgs e)
        {
            //if (btn1Prep.Enabled == true)
            //{

            //}
            //else
            //{

            //}
            //frmProcessingOrder frmPO = new frmProcessingOrder();
            //frmPO.btnCancel.Enabled = false;

            //(this.Owner as frmProcessingOrder).btnCancel.Enabled = false;
            //(this.Owner as frmProcessingOrder).btnCancel.BackColor = Color.Red;
            //(this.Owner as frmProcessingOrder).lblOrderInQ.BackColor = Color.Gainsboro;
            //frmPO.lblOrderPrep.Visible = true;

            //(this.Owner as frmProcessingOrder).btnCancel.Enabled = false;
            //(this.Owner as frmProcessingOrder).btnCancel.BackColor = Color.Red;
            //(this.Owner as frmProcessingOrder).lblOrderInQ.BackColor = Color.Gainsboro;
            //(this.Owner as frmProcessingOrder).lblOrderPrep.Visible = true;



            btn1Prep.Enabled = false;
            btn1Done.Enabled = true;
        }

        private void btn1Done_Click(object sender, EventArgs e)
        {
            (this.Owner as frmProcessingOrder).btnCancel.Enabled = false;
            (this.Owner as frmProcessingOrder).btnCancel.BackColor = Color.Red;
            (this.Owner as frmProcessingOrder).lblOrderInQ.BackColor = Color.Gainsboro;
            (this.Owner as frmProcessingOrder).lblOrderPrep.BackColor = Color.Gainsboro;
            (this.Owner as frmProcessingOrder).lblOrderServe.Visible = true;
            (this.Owner as frmProcessingOrder).btnPay.Visible = true;
            (this.Owner as frmProcessingOrder).btnPay.BackColor = Color.Lime;
            (this.Owner as frmProcessingOrder).txtCashPay.Visible = true;


            //double cashBayad;
            //cashBayad = Double.Parse(txtCashPay.Text);


            btn1Prep.Enabled = false;
            btn1Done.Enabled = false;
            //rtbQueue1.Clear();
            //this.Hide();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rtbQueue1_MouseHover(object sender, EventArgs e)
        {
           rtbQueue1.Clear();
        }

        private void rtbQueue1_Click(object sender, EventArgs e)
        {
            rtbQueue1.Clear();
        }
    }
}
