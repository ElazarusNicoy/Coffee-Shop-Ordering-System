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
    public partial class frmRequest : Form
    {
        public static string reqText;
        string requestt = "Your request is submitted.";
        string sample = "Customer's Request";
        public frmRequest()
        {
            InitializeComponent();
        }
        private void btnSubmitReq_Click(object sender, EventArgs e)
        {
            reqText = rtbRequest.Text;
            MessageBox.Show(requestt, sample, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
