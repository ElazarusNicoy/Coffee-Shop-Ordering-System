using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class frmProcessingOrder : Form
    {
        //
        private staffReceipt sRcpt = new staffReceipt();
        //
        //
        frmStaff staff = new frmStaff();
      //

        public frmProcessingOrder()
        {
            InitializeComponent();
        }
        //
        public class staffReceipt
        {
            int x = 1000;
            public static string getStRc = "";
            public static Queue<string> Qstring = new Queue<string>();
            public string wolf(string lion)
            {
                x++;
                lion = lion + x.ToString();
                return lion;
            }

        }
        //

            private void frmProcessingOrder_Load(object sender, EventArgs e)
        {
            rtbDisplayReceipt.AppendText(OrderingSystem.cusOrder + "\n");

            lblOrderInQ.Visible = true;
            lblOrderPrep.Visible = false;
            lblOrderServe.Visible = false;
            btnBckMenu.Visible = false;

            //
            txtCashPay.Visible = true;
            btnCancel.Visible = true;
            //
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to cancel your order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Clear();
                lblOrderInQ.Visible = false;
                //this.Dispose();
                new OrderingSystem();
                //hover mouse sa rtbQueue1 para ma clear ang receipt ng staff


            }
        }

        private void Clear()
        {
            rtbDisplayReceipt.Text = "";
            frmStaff.qOrder = "";
           
        }

        private void frmProcessingOrder_Click(object sender, EventArgs e)
        {
            //eto yung kapartner ng owner
            frmProcessingOrder frmprocess = new frmProcessingOrder();
            frmprocess.Owner = this;
            //frmprocess.Show();
            
        }

        private void lblOrderInQ_Click(object sender, EventArgs e)
        {
            //shows the staff form
            //frmStaff fEmp = new frmStaff();
            //fEmp.Owner = this;
            //fEmp.Show();
        }

        private void btnBckMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            OrderingSystem os = new OrderingSystem();
            os.Show();
            os.Reset();

        }

        private void lblOrderServe_VisibleChanged(object sender, EventArgs e)
        {
            btnBckMenu.Visible = true;
        }

        private void txtCashPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            frmStaff.instance.lbl45.Text = txtCashPay.Text;
            //frmStaff.lblBayadCust.Text = txtCashPay.Text;

            //    string
            //    frmEmployee emp = new frmEmployee();
            //    double bayad = Convert.ToDouble(txtCashPay.Text);
            //    (this.Owner as frmEmployee).lblDisplayCashPay =


            //        if (string.IsNullOrEmpty(txtCashPay.Text))
            //    {
            //        MessageBox.Show("Required to fill the amount");
            //        frmProcessingOrder.SetBayadMethod.SetBayad = BayadOrder(txtCashPay.Text);

            //        SetBayadMethod.SetBayad = BayadOrder(txtCashPay.Text);

            //        frmStaff frm = new frmStaff();
            //        frm.Show();
            //    }
            //    else
            //    {
            //        try
            //        {
            //            frmProcessingOrder.SetBayadMethod.SetBayad = BayadOrder(txtCashPay.Text);
            //            frmStaff frm = new frmStaff();
            //            frm.ShowDialog();
            //        }
            //        catch (FormatException)
            //        {

            //            MessageBox.Show("The amount must be a number.");

            //        }
            //    }



            //}

            //public int BayadOrder(string bayadOrd)
            //{
            //    _bayad = int.Parse(bayadOrd);
            //    return _bayad;
            //}

            //public class SetBayadMethod
            //{
            //    public static int SetBayad = 0;
            //}
        }

        
    }
}
