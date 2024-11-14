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
    public partial class OrderingSystem : Form
    {
        private transNo trans1 = new transNo();

        public static string cusOrder;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string busName = "Coffee Shop";

        //P.S hindi magpapakita yung mga 'out of stock' products kasi naka disable ang database pag isesend ko sa gc

        public OrderingSystem()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            // toMenu();

        }

        public class transNo
        {
            int x = 1000;
            public static string getNo = "";
            public static Queue<string> Qstring = new Queue<string>();
            public string cats(string dog)
            {
                x++;
                dog = dog + x.ToString();
                return dog;
            }
        }

        public void Reset()
        {
            txtLatteM.Text = "0";
            txtEspressoM.Text = "0";
            txtMochaM.Text = "0";
            txtValeCoffeeM.Text = "0";
            txtCappuccinoM.Text = "0";
            txtCaramelMacchiatoM.Text = "0";
            txtBrewedCoffeeM.Text = "0";
            txtFrenchVanillaM.Text = "0";
            txtLatteL.Text = "0";
            txtEspressoL.Text = "0";
            txtMochaL.Text = "0";
            txtValeCoffeeL.Text = "0";
            txtCappuccinoL.Text = "0";
            txtCaramelMachiatoL.Text = "0";
            txtBrewedCoffeeL.Text = "0";
            txtFrenchVanillaL.Text = "0";
            txtCoffeeCake.Text = "0";
            txtRedVelvetCake.Text = "0";
            txtBlackForestCake.Text = "0";
            txtBlueberryCheeseCake.Text = "0";
            txtUbeCustard.Text = "0";
            txtMoistChocolate.Text = "0";
            txtCarrotCake.Text = "0";
            txtMochaCake.Text = "0";
            lblCakeCost.Text = "0";
            lblCoffeeCost.Text = "0";
            lblAsstCharge.Text = "10.00";
            lblTax.Text = "0";
            lblSubTotal.Text = "0";
            lblTotal.Text = "0";

            chkLatte.Checked = false;
            chkEspresso.Checked = false;
            chkMocha.Checked = false;
            chkValeCoffee.Checked = false;
            chkCappuccino.Checked = false;
            chkCaramelMachiato.Checked = false;
            chkBrewedCoffee.Checked = false;
            chkFrenchVanilla.Checked = false;
            chkRedVelvetCake.Checked = false;
            chkCoffeeCake.Checked = false;
            chkBlackForestCake.Checked = false;
            chkBlueberryCheeseCake.Checked = false;
            chkUbeCustard.Checked = false;
            chkMoistChocolate.Checked = false;
            chkCarrotCake.Checked = false;
            chkMochaCake.Checked = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {  //btnReset
            Reset();
            rtbReceipt.Clear();
        }
        private void btnTotReceipt_Click(object sender, EventArgs e)
        {
            rtbReceipt.Visible = true;

            rtbReceipt.AppendText("--------------------------------------------" + Environment.NewLine);
            rtbReceipt.AppendText("\t\t  " + "Coffee Shop" + Environment.NewLine);
            rtbReceipt.AppendText("\t     " + "TANAUAN CITY BATANGAS" + Environment.NewLine);
            rtbReceipt.AppendText("--------------------------------------------" + Environment.NewLine);

            double latteM, espressoM, mochaM, valeM, cappuM, caramelM, brewedM, frenchM;
            double latteL, espressoL, mochaL, valeL, cappuL, caramelL, brewedL, frenchL;
            double cCake, rVelvet, bFor, bBerry, ubeCus, mChoco, carrotC, mochaC;

            //medium 75.00  large 105
            latteM = 75.00; espressoM = 75.00; mochaM = 75.00; valeM = 75.00; cappuM = 75.00; caramelM = 75.00; brewedM = 75.00; frenchM = 75.00; //coffee medium prices
            latteL = 105.00; espressoL = 105.00; mochaL = 105.00; valeL = 105.00; cappuL = 105.00; caramelL = 105.00; brewedL = 105.00; frenchL = 105.00; //coffee large prices
            cCake = 55.00; rVelvet = 55.00; bFor = 55.00; bBerry = 55.00; ubeCus = 55.00; mChoco = 55.00; carrotC = 55.00; mochaC = 55.00; //cake prices

            //Coffee
            double latteeCofM = Convert.ToDouble(txtLatteM.Text);
            double mochaCofM = Convert.ToDouble(txtMochaM.Text);
            double espressoCofM = Convert.ToDouble(txtEspressoM.Text);
            double valeCoffeeM = Convert.ToDouble(txtValeCoffeeM.Text);
            double cappCofM = Convert.ToDouble(txtCappuccinoM.Text);
            double caraMachM = Convert.ToDouble(txtCaramelMacchiatoM.Text);
            double brewCofM = Convert.ToDouble(txtBrewedCoffeeM.Text);
            double frenchVanM = Convert.ToDouble(txtFrenchVanillaM.Text);

            var latteeCofL = Convert.ToDouble(txtLatteL.Text);
            double mochaCofL = Convert.ToDouble(txtMochaL.Text);
            double espressoCofL = Convert.ToDouble(txtEspressoL.Text);
            double valeCoffeeL = Convert.ToDouble(txtValeCoffeeL.Text);
            double cappCofL = Convert.ToDouble(txtCappuccinoL.Text);
            double caraMachL = Convert.ToDouble(txtCaramelMachiatoL.Text);
            double brewCofL = Convert.ToDouble(txtBrewedCoffeeL.Text);
            double frenchVanL = Convert.ToDouble(txtFrenchVanillaL.Text);

            //Cakes
            double cofCake = Convert.ToDouble(txtCoffeeCake.Text);
            double redVelvet = Convert.ToDouble(txtRedVelvetCake.Text);
            double bForest = Convert.ToDouble(txtBlackForestCake.Text);
            double bbCheese = Convert.ToDouble(txtBlueberryCheeseCake.Text);
            double uCust = Convert.ToDouble(txtUbeCustard.Text);
            double moistChoco = Convert.ToDouble(txtMoistChocolate.Text);
            double carCake = Convert.ToDouble(txtCarrotCake.Text);
            double moCake = Convert.ToDouble(txtMochaCake.Text);

            Cafe kopiShop = new Cafe(latteeCofM, mochaCofM, espressoCofM, valeCoffeeM, cappCofM, caraMachM, brewCofM, frenchVanM,
                latteeCofL, mochaCofL, espressoCofL, valeCoffeeL, cappCofL, caraMachL, brewCofL, frenchVanL,
                cofCake, redVelvet, bForest, bbCheese, uCust, moistChoco, carCake, moCake);

            double drinkCosts = (latteeCofM * latteM) + (latteeCofL * latteL) + (mochaCofM * mochaM) + (mochaCofL * mochaL) + (espressoCofM * espressoM) + (espressoCofL * espressoL) + (valeCoffeeM * valeM) + (valeCoffeeL * valeL) + (cappCofM * cappuM) + (cappCofL * cappuL) + (caraMachM * caramelM) + (caraMachL * caramelL) + (brewCofM * brewedM) + (brewCofL * brewedL) + (frenchVanM * frenchM) + (frenchVanL * frenchL);
            lblCoffeeCost.Text = Convert.ToString(drinkCosts);
            double cakeCosts = (cofCake * cCake) + (redVelvet * rVelvet) + (bForest * bFor) + (bbCheese * bBerry) + (uCust * ubeCus) + (moistChoco * mChoco) + (carCake * carrotC) + (moCake * mochaC);
            lblCakeCost.Text = Convert.ToString(cakeCosts);

            double taxx;
            double svcCharge = Convert.ToDouble(lblAsstCharge.Text);
            double totalAftTax = Convert.ToDouble(lblTax.Text);

            double tax;
            tax = 0.45;
            taxx = (((cakeCosts + drinkCosts + svcCharge) * tax) / 100);
            double tots;
            tots = cakeCosts + drinkCosts + svcCharge + totalAftTax + taxx;
            lblSubTotal.Text = Convert.ToString(cakeCosts + drinkCosts + svcCharge);
            lblTotal.Text = Convert.ToString(cakeCosts + drinkCosts + svcCharge + totalAftTax);

            lblCoffeeCost.Text = String.Format("{0:C}", drinkCosts);
            lblCakeCost.Text = String.Format("{0:C}", cakeCosts);
            lblAsstCharge.Text = String.Format("{0:C}", svcCharge);
            lblSubTotal.Text = String.Format("{0:C}", (cakeCosts + drinkCosts + svcCharge));
            lblTax.Text = String.Format("{0:C}", taxx);
            lblTotal.Text = String.Format("{0:C}", Math.Round(tots, 2));

            if (int.Parse(txtLatteL.Text) >= 1)
            {
                rtbReceipt.AppendText("Latte Large \n" + txtLatteL.Text + " X ₱105.00/pc \t\t\t" + (latteeCofL * latteL) + ".00" + "\n");
            }

            if (int.Parse(txtLatteM.Text) >= 1)
            {
                rtbReceipt.AppendText("Latte Medium \n" + txtLatteM.Text + " X ₱75.00/pc \t\t\t" + (latteeCofM * latteM) + ".00" + "\n");

            }

            if (int.Parse(txtEspressoL.Text) >= 1)
            {
                rtbReceipt.AppendText("Espresso Large \n" + txtEspressoL.Text + " X ₱105.00/pc \t\t\t" + (espressoCofL * espressoL) + ".00" + "\n");
            }

            if (int.Parse(txtEspressoM.Text) >= 1)
            {
                rtbReceipt.AppendText("Espresso Medium \n" + txtEspressoM.Text + " X ₱75.00/pc \t\t\t" + (espressoCofM * espressoM) + ".00" + "\n");
            }

            if (int.Parse(txtMochaL.Text) >= 1)
            {
                rtbReceipt.AppendText("Mocha Large \n" + txtMochaL.Text + " X ₱105.00/pc \t\t\t" + (mochaCofL * mochaL) + ".00" + "\n");
            }

            if (int.Parse(txtMochaM.Text) >= 1)
            {
                rtbReceipt.AppendText("Mocha Medium \n" + txtMochaM.Text + " X ₱75.00/pc \t\t\t" + (mochaCofM * mochaM) + ".00" + "\n");
            }

            if (int.Parse(txtValeCoffeeL.Text) >= 1)
            {
                rtbReceipt.AppendText("Valecoffee Large \n" + txtValeCoffeeL.Text + " X ₱105.00/pc \t\t\t" + (valeCoffeeL * valeL) + ".00" + "\n");
            }

            if (int.Parse(txtValeCoffeeM.Text) >= 1)
            {
                rtbReceipt.AppendText("Valecoffee Medium \n" + txtValeCoffeeM.Text + " X ₱75.00/pc \t\t\t" + (valeCoffeeM * valeM) + ".00" + "\n");
            }

            if (int.Parse(txtCappuccinoL.Text) >= 1)
            {
                rtbReceipt.AppendText("Cappuccino Large \n" + txtCappuccinoL.Text + " X ₱105.00/pc \t\t\t" + (cappCofL * cappuL) + ".00" + "\n");
            }

            if (int.Parse(txtCappuccinoM.Text) >= 1)
            {
                rtbReceipt.AppendText("Cappuccino Medium \n" + txtCappuccinoM.Text + " X ₱75.00/pc \t\t\t" + (cappCofM * cappuM) + ".00" + "\n");
            }

            if (int.Parse(txtCaramelMachiatoL.Text) >= 1)
            {
                rtbReceipt.AppendText("Caramel Macchiato Large \n" + txtCaramelMachiatoL.Text + " X ₱105.00/pc \t\t\t" + (caraMachL * caramelL) + ".00" + "\n");
            }

            if (int.Parse(txtCaramelMacchiatoM.Text) >= 1)
            {
                rtbReceipt.AppendText("Caramel Macchiato Medium \n" + txtCaramelMacchiatoM.Text + " X ₱75.00/pc \t\t\t" + (caraMachM * caramelM) + ".00" + "\n");
            }

            if (int.Parse(txtBrewedCoffeeL.Text) >= 1)
            {
                rtbReceipt.AppendText("Brewed Coffee Large \n" + txtBrewedCoffeeL.Text + " X ₱105.00/pc \t\t\t" + (brewCofL * brewedL) + ".00" + "\n");
            }

            if (int.Parse(txtBrewedCoffeeM.Text) >= 1)
            {
                rtbReceipt.AppendText("Brewed Coffee Medium \n" + txtBrewedCoffeeM.Text + " X ₱75.00/pc \t\t\t" + (brewCofM * brewedM) + ".00" + "\n");
            }

            if (int.Parse(txtFrenchVanillaL.Text) >= 1)
            {
                rtbReceipt.AppendText("French Vanilla Large \n" + txtFrenchVanillaL.Text + " X ₱105.00/pc \t\t\t" + (frenchVanL * frenchL) + ".00" + "\n");
            }

            if (int.Parse(txtFrenchVanillaM.Text) >= 1)
            {
                rtbReceipt.AppendText("French Vanilla Medium \n" + txtFrenchVanillaM.Text + " X ₱75.00/pc \t\t\t" + (frenchVanM * frenchM) + ".00" + "\n");
            }

            if (int.Parse(txtCoffeeCake.Text) >= 1)
            {
                rtbReceipt.AppendText("Coffee Cake \n" + txtCoffeeCake.Text + " X ₱55.00/pc \t\t\t" + (cofCake * cCake) + ".00" + "\n");
            }

            if (int.Parse(txtRedVelvetCake.Text) >= 1)
            {
                rtbReceipt.AppendText("Red Velvet Cake \n" + txtRedVelvetCake.Text + " X ₱55.00/pc \t\t\t" + (redVelvet * rVelvet) + ".00" + "\n");
            }

            if (int.Parse(txtBlackForestCake.Text) >= 1)
            {
                rtbReceipt.AppendText("Black Forest Cake \n" + txtBlackForestCake.Text + " X ₱55.00/pc \t\t\t" + (bForest * bFor) + ".00" + "\n");
            }

            if (int.Parse(txtBlueberryCheeseCake.Text) >= 1)
            {
                rtbReceipt.AppendText("Blueberry Cheesecake \n" + txtBlueberryCheeseCake.Text + " X ₱55.00/pc \t\t\t" + (bbCheese * bBerry) + ".00" + "\n");
            }

            if (int.Parse(txtUbeCustard.Text) >= 1)
            {
                rtbReceipt.AppendText("Ube Custard \n" + txtUbeCustard.Text + " X ₱55.00/pc \t\t\t" + (uCust * ubeCus) + ".00" + "\n");
            }

            if (int.Parse(txtMoistChocolate.Text) >= 1)
            {
                rtbReceipt.AppendText("Moist Chocolate \n" + txtMoistChocolate.Text + " X ₱55.00/pc \t\t\t" + (moistChoco * mChoco) + ".00" + "\n");
            }

            if (int.Parse(txtCarrotCake.Text) >= 1)
            {
                rtbReceipt.AppendText("Carrot Cake \n" + txtCarrotCake.Text + " X ₱55.00/pc \t\t\t" + (carCake * carrotC) + ".00" + "\n");
            }

            if (int.Parse(txtMochaCake.Text) >= 1)
            {
                rtbReceipt.AppendText("Mocha Cake \n" + txtMochaCake.Text + " X ₱55.00/pc \t\t\t" + (moCake * mochaC) + ".00" + "\n");
            }
            rtbReceipt.AppendText("\n");
            rtbReceipt.AppendText("********************************************" + Environment.NewLine);
            rtbReceipt.AppendText("Request: " + frmRequest.reqText + "\n");
            rtbReceipt.AppendText("********************************************" + Environment.NewLine);

            rtbReceipt.AppendText("TAX \t\t\t\t" + String.Format("{0:C}", "₱" + Math.Round(taxx, 2) + "\n"));
            rtbReceipt.AppendText("SUB TOTAL \t\t\t" + String.Format("{0:C}", (cakeCosts + drinkCosts + svcCharge)) + "\n");

            rtbReceipt.AppendText(("TOTAL \t\t\t\t" + String.Format("{0:C}", "₱" + Math.Round(tots, 2) + "\n")));



            rtbReceipt.AppendText("--------------------------------------------" + Environment.NewLine);
            rtbReceipt.AppendText("\t" + lblTimer.Text + "\t    " + lblDate.Text + "\n");

            rtbReceipt.AppendText("--------------------------------------------" + Environment.NewLine);
        }

        private void TxtLatteM_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            double latteeCofM = Convert.ToDouble(txtLatteM.Text);
            double latteeCofL = Convert.ToDouble(txtLatteL.Text);
            new frmWelcome().Show();
            this.Dispose();
        }

        //still on developing process-Transaction No.
        //disable muna mag ipapasa kay raden 
        private void GetTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string transno;
                int count;
                cn.Open();
                cm = new SqlCommand("SELECT Top 1 TransactionNo FROM tbl_order WHERE TransactionNo LIKE '" + sdate + "%' ORDER BY ID DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lbltransNo.Text = sdate + (count + 1);

                }
                else
                {
                    transno = sdate + "1001";
                    lbltransNo.Text = transno;
                }
                dr.Close();

                cn.Close();

            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message, busName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OrderingSystem_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
            //GetTransNo();

            txtLatteM.Text = "0";
            txtEspressoM.Text = "0";
            txtMochaM.Text = "0";
            txtValeCoffeeM.Text = "0";
            txtCappuccinoM.Text = "0";
            txtCaramelMacchiatoM.Text = "0";
            txtBrewedCoffeeM.Text = "0";
            txtFrenchVanillaM.Text = "0";
            txtLatteL.Text = "0";
            txtEspressoL.Text = "0";
            txtMochaL.Text = "0";
            txtValeCoffeeL.Text = "0";
            txtCappuccinoL.Text = "0";
            txtCaramelMachiatoL.Text = "0";
            txtBrewedCoffeeL.Text = "0";
            txtFrenchVanillaL.Text = "0";
            txtCoffeeCake.Text = "0";
            txtRedVelvetCake.Text = "0";
            txtBlackForestCake.Text = "0";
            txtBlueberryCheeseCake.Text = "0";
            txtUbeCustard.Text = "0";
            txtMoistChocolate.Text = "0";
            txtCarrotCake.Text = "0";
            txtMochaCake.Text = "0";
            lblCakeCost.Text = "0";
            lblCoffeeCost.Text = "0";
            lblAsstCharge.Text = "10.00";
            lblSubTotal.Text = "0";
            lblTax.Text = "0";
            lblTotal.Text = "0";

            txtLatteM.Enabled = false;
            txtEspressoM.Enabled = false; 
            txtMochaM.Enabled = false;
            txtValeCoffeeM.Enabled = false;
            txtCappuccinoM.Enabled = false;
            txtCaramelMacchiatoM.Enabled = false;
            txtBrewedCoffeeM.Enabled = false;
            txtFrenchVanillaM.Enabled = false;
            txtLatteL.Enabled = false;
            txtEspressoL.Enabled = false;
            txtMochaL.Enabled = false;
            txtValeCoffeeL.Enabled = false;
            txtCappuccinoL.Enabled = false;
            txtCaramelMachiatoL.Enabled = false;
            txtBrewedCoffeeL.Enabled = false;
            txtFrenchVanillaL.Enabled = false;
            txtCoffeeCake.Enabled = false;
            txtRedVelvetCake.Enabled = false;
            txtBlackForestCake.Enabled = false;
            txtBlueberryCheeseCake.Enabled = false;
            txtUbeCustard.Enabled = false;
            txtMoistChocolate.Enabled = false;
            txtCarrotCake.Enabled = false;
            txtMochaCake.Enabled = false;

            chkLatte.Checked = false;
            chkEspresso.Checked = false;
            chkMocha.Checked = false;
            chkValeCoffee.Checked = false;
            chkCappuccino.Checked = false;
            chkCaramelMachiato.Checked = false;
            chkBrewedCoffee.Checked = false;
            chkFrenchVanilla.Checked = false;
            chkRedVelvetCake.Checked = false;
            chkCoffeeCake.Checked = false;
            chkBlackForestCake.Checked = false;
            chkBlueberryCheeseCake.Checked = false;
            chkUbeCustard.Checked = false;
            chkMoistChocolate.Checked = false;
            chkCarrotCake.Checked = false;
            chkMochaCake.Checked = false;

            rtbReceipt.Visible = false;

            //pag nag order na si customer, check ng box ay mag papakita na red meaning out of stock.
            cn.Open();
            SqlCommand qtyLatteM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P100A'", cn);
            SqlCommand qtyLatteL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P100C'", cn);

            SqlCommand qtyEspresM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P101A'", cn);
            SqlCommand qtyEspresL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P101C'", cn);

            SqlCommand qtyMochaM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P102A'", cn);
            SqlCommand qtyMochaL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P102C'", cn);

            SqlCommand qtyValeM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P103A'", cn);
            SqlCommand qtyValeL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P103C'", cn);

            SqlCommand qtyCappM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P104A'", cn);
            SqlCommand qtyCappL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P104C'", cn);

            SqlCommand qtyCaramM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P105A'", cn);
            SqlCommand qtyCaramL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P105C'", cn);

            SqlCommand qtyBrewM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P106A'", cn);
            SqlCommand qtyBrewL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P106C'", cn);

            SqlCommand qtyFrenM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P107A'", cn);
            SqlCommand qtyFrenL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P107C'", cn);

            int qtyLttM = (int)qtyLatteM.ExecuteScalar();
            int qtyLttL = (int)qtyLatteL.ExecuteScalar();

            int qtyEsM = (int)qtyEspresM.ExecuteScalar();
            int qtyEsL = (int)qtyEspresL.ExecuteScalar();

            int qtyMochM = (int)qtyMochaM.ExecuteScalar();
            int qtyMochL = (int)qtyMochaL.ExecuteScalar();

            int qtyValM = (int)qtyValeM.ExecuteScalar();
            int qtyValL = (int)qtyValeL.ExecuteScalar();

            int qtyCapM = (int)qtyCappM.ExecuteScalar();
            int qtyCapL = (int)qtyCappL.ExecuteScalar();

            int qtyCarM = (int)qtyCaramM.ExecuteScalar();
            int qtyCarL = (int)qtyCaramL.ExecuteScalar();

            int qtyBreM = (int)qtyBrewM.ExecuteScalar();
            int qtyBreL = (int)qtyBrewL.ExecuteScalar();

            int qtyFreM = (int)qtyFrenM.ExecuteScalar();
            int qtyFreL = (int)qtyFrenL.ExecuteScalar();
            cn.Close();

            //LATTE MEDIUM & LARGE
            if (qtyLttM > 0 && qtyLttL > 0 && chkLatte.Checked == false)
            {
                txtLatteM.Enabled = false;
                txtLatteM.Text = "0";
                txtLatteL.Enabled = false;
                txtLatteL.Text = "0";
            }
            if (qtyLttM > 0 && qtyLttL > 0 && chkLatte.Checked == true)
            {
                txtLatteM.Enabled = true;
                txtLatteL.Enabled = true;

            }
            if (qtyLttM > 0 && qtyLttL == 0)
            //may stock si Latte medium pero si Latte large ay walang stock
            {
                txtLatteM.Enabled = true;
                txtLatteL.Enabled = false;
                txtLatteL.BackColor = Color.Red;

            }

            if (qtyLttM == 0 && qtyLttL > 0)
            //walang stock si Latte medium pero si may stock si Latte large
            {
                txtLatteM.Enabled = false;
                txtLatteM.BackColor = Color.Red;
                txtLatteL.Enabled = true;
            }
            if (qtyLttM == 0 && qtyLttL == 0)
            //walang stock si Latte medium at si Latte large
            {
                chkLatte.Enabled = false;
                txtLatteM.Enabled = false;
                txtLatteM.BackColor = Color.Red;
                txtLatteL.Enabled = false;
                txtLatteL.BackColor = Color.Red;

            }

            //ESPRESSO MEDIUM & LARGE
            if (qtyEsM > 0 && qtyEsL > 0 && chkEspresso.Checked == false)
            {
                txtEspressoM.Enabled = false;
                txtEspressoM.Text = "0";
                txtEspressoL.Enabled = false;
                txtEspressoL.Text = "0";
            }
            if (qtyEsM > 0 && qtyEsL > 0 && chkEspresso.Checked == true)
            {
                txtEspressoM.Enabled = true;
                txtEspressoL.Enabled = true;

            }
            if (qtyEsM > 0 && qtyEsL == 0)
            //may stock si Espresso medium pero si Espresso large ay walang stock
            {
                txtEspressoM.Enabled = true;
                txtEspressoL.Enabled = false;
                txtEspressoL.BackColor = Color.Red;

            }

            if (qtyEsM == 0 && qtyEsL > 0)
            //walang stock si Espresso medium pero si may stock si Espresso large
            {
                txtEspressoM.Enabled = false;
                txtEspressoM.BackColor = Color.Red;
                txtEspressoL.Enabled = true;
            }
            if (qtyEsM == 0 && qtyEsL == 0)
            //walang stock si Espresso medium at si Espresso large
            {
                chkEspresso.Enabled = false;
                txtEspressoM.Enabled = false;
                txtEspressoM.BackColor = Color.Red;
                txtEspressoL.Enabled = false;
                txtEspressoL.BackColor = Color.Red;

            }

            //MOCHA MEDIUM & LARGE
            if (qtyMochM > 0 && qtyMochL > 0 && chkMocha.Checked == false)
            {
                txtMochaM.Enabled = false;
                txtMochaM.Text = "0";
                txtMochaL.Enabled = false;
                txtMochaL.Text = "0";
            }
            if (qtyMochM > 0 && qtyMochL > 0 && chkMocha.Checked == true)
            {
                txtMochaM.Enabled = true;
                txtMochaL.Enabled = true;

            }
            if (qtyMochM > 0 && qtyMochL == 0)
            //may stock si Mocha medium pero si Mocha large ay walang stock
            {
                txtMochaM.Enabled = true;
                txtMochaL.Enabled = false;
                txtMochaL.BackColor = Color.Red;

            }

            if (qtyMochM == 0 && qtyMochL > 0)
            //walang stock si Mocha medium pero si may stock si Mocha large
            {
                txtMochaM.Enabled = false;
                txtMochaM.BackColor = Color.Red;
                txtMochaL.Enabled = true;
            }
            if (qtyMochM == 0 && qtyMochL == 0)
            //walang stock si Mocha medium at si Mocha large
            {
                chkMocha.Enabled = false;
                txtMochaM.Enabled = false;
                txtMochaM.BackColor = Color.Red;
                txtMochaL.Enabled = false;
                txtMochaL.BackColor = Color.Red;

            }

            //VALECOFFEE MEDIUM & LARGE
            if (qtyValM > 0 && qtyValL > 0 && chkValeCoffee.Checked == false)
            {
                txtValeCoffeeM.Enabled = false;
                txtValeCoffeeM.Text = "0";
                txtValeCoffeeL.Enabled = false;
                txtValeCoffeeL.Text = "0";
            }
            if (qtyValM > 0 && qtyValL > 0 && chkValeCoffee.Checked == true)
            {
                txtValeCoffeeM.Enabled = true;
                txtValeCoffeeL.Enabled = true;

            }
            if (qtyValM > 0 && qtyValL == 0)
            //may stock si ValeCoffee medium pero si ValeCoffee large ay walang stock
            {
                txtValeCoffeeM.Enabled = true;
                txtValeCoffeeL.Enabled = false;
                txtValeCoffeeL.BackColor = Color.Red;

            }

            if (qtyValM == 0 && qtyValL > 0)
            //walang stock si ValeCoffee medium pero si may stock si ValeCoffee large
            {
                txtValeCoffeeM.Enabled = false;
                txtValeCoffeeM.BackColor = Color.Red;
                txtValeCoffeeL.Enabled = true;
            }
            if (qtyValM == 0 && qtyValL == 0)
            //walang stock si ValeCoffee medium at si ValeCoffee large
            {
                chkValeCoffee.Enabled = false;
                txtValeCoffeeM.Enabled = false;
                txtValeCoffeeM.BackColor = Color.Red;
                txtValeCoffeeL.Enabled = false;
                txtValeCoffeeL.BackColor = Color.Red;

            }

            //CAPPUCCINO MEDIUM & LARGE
            if (qtyCapM > 0 && qtyCapL > 0 && chkCappuccino.Checked == false)
            {
                txtCappuccinoM.Enabled = false;
                txtCappuccinoM.Text = "0";
                txtCappuccinoL.Enabled = false;
                txtCappuccinoL.Text = "0";
            }
            if (qtyCapM > 0 && qtyCapL > 0 && chkCappuccino.Checked == true)
            {
                txtCappuccinoM.Enabled = true;
                txtCappuccinoL.Enabled = true;

            }
            if (qtyCapM > 0 && qtyCapL == 0)
            //may stock si Cappuccino medium pero si Cappuccino large ay walang stock
            {
                txtCappuccinoM.Enabled = true;
                txtCappuccinoL.Enabled = false;
                txtCappuccinoL.BackColor = Color.Red;

            }

            if (qtyCapM == 0 && qtyCapL > 0)
            //walang stock si Cappuccino medium pero si may stock si Cappuccino large
            {
                txtCappuccinoM.Enabled = false;
                txtCappuccinoM.BackColor = Color.Red;
                txtCappuccinoL.Enabled = true;
            }
            if (qtyCapM == 0 && qtyCapL == 0)
            //walang stock si Cappuccino medium at si Cappuccino large
            {
                chkCappuccino.Enabled = false;
                txtCappuccinoM.Enabled = false;
                txtCappuccinoM.BackColor = Color.Red;
                txtCappuccinoL.Enabled = false;
                txtCappuccinoL.BackColor = Color.Red;

            }

            //CARAMEL MACCHIATO MEDIUM & LARGE
            if (qtyCarM > 0 && qtyCarL > 0 && chkCaramelMachiato.Checked == false)
            {
                txtCaramelMacchiatoM.Enabled = false;
                txtCaramelMacchiatoM.Text = "0";
                txtCaramelMachiatoL.Enabled = false;
                txtCaramelMachiatoL.Text = "0";
            }
            if (qtyCarM > 0 && qtyCarL > 0 && chkCaramelMachiato.Checked == true)
            {
                txtCaramelMacchiatoM.Enabled = true;
                txtCaramelMachiatoL.Enabled = true;

            }
            if (qtyCarM > 0 && qtyCarL == 0)
            //may stock si Caramel Macchiato medium pero si Caramel Macchiato large ay walang stock
            {
                txtCaramelMacchiatoM.Enabled = true;
                txtCaramelMachiatoL.Enabled = false;
                txtCaramelMachiatoL.BackColor = Color.Red;

            }

            if (qtyCarM == 0 && qtyCarL > 0)
            //walang stock si Caramel Macchiato medium pero si may stock si Caramel Macchiato large
            {
                txtCaramelMacchiatoM.Enabled = false;
                txtCaramelMacchiatoM.BackColor = Color.Red;
                txtCaramelMachiatoL.Enabled = true;
            }
            if (qtyCarM == 0 && qtyCarL == 0)
            //walang stock si latte medium at si latte large
            {
                chkCaramelMachiato.Enabled = false;
                txtCaramelMacchiatoM.Enabled = false;
                txtCaramelMacchiatoM.BackColor = Color.Red;
                txtCaramelMachiatoL.Enabled = false;
                txtCaramelMachiatoL.BackColor = Color.Red;

            }

            //BREWED COFFEE MEDIUM & LARGE
            if (qtyBreM > 0 && qtyBreL > 0 && chkBrewedCoffee.Checked == false)
            {
                txtBrewedCoffeeM.Enabled = false;
                txtBrewedCoffeeM.Text = "0";
                txtBrewedCoffeeL.Enabled = false;
                txtBrewedCoffeeL.Text = "0";
            }
            if (qtyBreM > 0 && qtyBreL > 0 && chkBrewedCoffee.Checked == true)
            {
                txtBrewedCoffeeM.Enabled = true;
                txtBrewedCoffeeL.Enabled = true;

            }
            if (qtyBreM > 0 && qtyBreL == 0)
            //may stock si Brewed Coffee medium pero si Brewed Coffee large ay walang stock
            {
                txtBrewedCoffeeM.Enabled = true;
                txtBrewedCoffeeL.Enabled = false;
                txtBrewedCoffeeL.BackColor = Color.Red;

            }

            if (qtyBreM == 0 && qtyBreL > 0)
            //walang stock si Brewed Coffee medium pero si may stock si Brewed Coffee large
            {
                txtBrewedCoffeeM.Enabled = false;
                txtBrewedCoffeeM.BackColor = Color.Red;
                txtBrewedCoffeeL.Enabled = true;
            }
            if (qtyBreM == 0 && qtyBreL == 0)
            //walang stock si Brewe dCoffee medium at si Brewed Coffee large
            {
                chkBrewedCoffee.Enabled = false;
                txtBrewedCoffeeM.Enabled = false;
                txtBrewedCoffeeM.BackColor = Color.Red;
                txtBrewedCoffeeL.Enabled = false;
                txtBrewedCoffeeL.BackColor = Color.Red;
            }

            //FRENCH VANILLA MEDIUM & LARGE
            if (qtyFreM > 0 && qtyFreL > 0 && chkFrenchVanilla.Checked == false)
            {
                txtFrenchVanillaM.Enabled = false;
                txtFrenchVanillaM.Text = "0";
                txtFrenchVanillaL.Enabled = false;
                txtFrenchVanillaL.Text = "0";
            }
            if (qtyFreM > 0 && qtyFreL > 0 && chkFrenchVanilla.Checked == true)
            {
                txtFrenchVanillaM.Enabled = true;
                txtFrenchVanillaL.Enabled = true;

            }
            if (qtyFreM > 0 && qtyFreL == 0)
            //may stock si French Vanilla medium pero si French Vanilla large ay walang stock
            {
                txtFrenchVanillaM.Enabled = true;
                txtFrenchVanillaL.Enabled = false;
                txtFrenchVanillaL.BackColor = Color.Red;

            }

            if (qtyFreM == 0 && qtyFreL > 0)
            //walang stock si French Vanilla medium pero si may stock si French Vanilla large
            {
                txtFrenchVanillaM.Enabled = false;
                txtFrenchVanillaM.BackColor = Color.Red;
                txtFrenchVanillaL.Enabled = true;
            }
            if (qtyFreM == 0 && qtyFreL == 0)
            //walang stock si French Vanilla medium at si French Vanilla large
            {
                chkFrenchVanilla.Enabled = false;
                txtFrenchVanillaM.Enabled = false;
                txtFrenchVanillaM.BackColor = Color.Red;
                txtFrenchVanillaL.Enabled = false;
                txtFrenchVanillaL.BackColor = Color.Red;

            }

           // Shows red color per textbox pag walang stock ang item

            //COFFEE CAKE - upon loading kasi isa lang naman textbox(option)
            cn.Open();
            SqlCommand qtyCofCake = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P108B'", cn);
            int qtyCfC = (int)qtyCofCake.ExecuteScalar();
            cn.Close();

            //COFFEE CAKE - 1 SLICE
            if (qtyCfC > 0 && chkCoffeeCake.Checked == false)
            {
                txtCoffeeCake.Enabled = false;
                txtCoffeeCake.Text = "0";
            }
            if (qtyCfC > 0 && chkCoffeeCake.Checked == true)
            {
                txtCoffeeCake.Enabled = true;
            }
            if (qtyCfC == 0)
            //walang stock si Coffee Cake - 1 Slice
            {
                chkCoffeeCake.Enabled = false;
                txtCoffeeCake.Enabled = false;
                txtCoffeeCake.BackColor = Color.Red;
            }

            //RED VELVET CAKE - upon loading kasi isa lang naman textbox(option)
            cn.Open();
            SqlCommand qtyRedCake = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P109B'", cn);
            int qtyRdC = (int)qtyRedCake.ExecuteScalar();
            cn.Close();

            //RED VELVET CAKE - 1 SLICE
            if (qtyRdC > 0 && chkRedVelvetCake.Checked == false)
            {
                txtRedVelvetCake.Enabled = false;
                txtRedVelvetCake.Text = "0";
            }
            if (qtyRdC > 0 && chkRedVelvetCake.Checked == true)
            {
                txtRedVelvetCake.Enabled = true;
            }
            if (qtyRdC == 0)
            //walang stock si Red Velvet Cake - 1 Slice
            {
                chkRedVelvetCake.Enabled = false;
                txtRedVelvetCake.Enabled = false;
                txtRedVelvetCake.BackColor = Color.Red;
            }

            //BLACKFOREST CAKE - upon loading kasi isa lang naman textbox(option)
            cn.Open();
            SqlCommand qtyBlfCake = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P110B'", cn);
            int qtyBfC = (int)qtyBlfCake.ExecuteScalar();
            cn.Close();

            //BLACKFOREST CAKE - 1 SLICE
            if (qtyBfC > 0 && chkBlackForestCake.Checked == false)
            {
                txtBlackForestCake.Enabled = false;
                txtBlackForestCake.Text = "0";
            }
            if (qtyBfC > 0 && chkBlackForestCake.Checked == true)
            {
                txtBlackForestCake.Enabled = true;
            }
            if (qtyBfC == 0)
            //walang stock si Blackforest Cake - 1 Slice
            {
                chkBlackForestCake.Enabled = false;
                txtBlackForestCake.Enabled = false;
                txtBlackForestCake.BackColor = Color.Red;
            }

            //BLUEBERRY CHEESECAKE - upon loading kasi isa lang naman textbox(option)
            cn.Open();
            SqlCommand qtyBbChCake = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P111B'", cn);
            int qtyBChC = (int)qtyBbChCake.ExecuteScalar();
            cn.Close();

            //BLUEBERRY CHEESECAKE - 1 SLICE 
            if (qtyBChC > 0 && chkBlueberryCheeseCake.Checked == false)
            {
                txtBlueberryCheeseCake.Enabled = false;
                txtBlueberryCheeseCake.Text = "0";
            }
            if (qtyBChC > 0 && chkBlueberryCheeseCake.Checked == true)
            {
                txtBlueberryCheeseCake.Enabled = true;
            }
            if (qtyBChC == 0)
            //walang stock si Blueberry Cheesecake - 1 Slice
            {
                chkBlueberryCheeseCake.Enabled = false;
                txtBlueberryCheeseCake.Enabled = false;
                txtBlueberryCheeseCake.BackColor = Color.Red;
            }

            //UBE CUSTARD - upon loading kasi isa lang naman textbox(option)
            cn.Open();
            SqlCommand qtyUbeC = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P112B'", cn);
            int qtyUbC = (int)qtyUbeC.ExecuteScalar();
            cn.Close();

            //UBE CUSTARD - 1 SLICE
            if (qtyUbC > 0 && chkUbeCustard.Checked == false)
            {
                txtUbeCustard.Enabled = false;
                txtUbeCustard.Text = "0";
            }
            if (qtyUbC > 0 && chkUbeCustard.Checked == true)
            {
                txtUbeCustard.Enabled = true;
            }
            if (qtyUbC == 0)
            //walang stock si Ube Custard - 1 Slice
            {
                chkUbeCustard.Enabled = false;
                txtUbeCustard.Enabled = false;
                txtUbeCustard.BackColor = Color.Red;
            }

            //MOIST CHOCOLATE - upon loading kasi isa lang naman textbox(option)
            cn.Open();
            SqlCommand qtyMoiCho = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P113B'", cn);
            int qtyMoiC = (int)qtyMoiCho.ExecuteScalar();
            cn.Close();

            //MOIST CHOCOLATE - 1 SLICE
            if (qtyMoiC > 0 && chkMoistChocolate.Checked == false)
            {
                txtMoistChocolate.Enabled = false;
                txtMoistChocolate.Text = "0";
            }
            if (qtyMoiC > 0 && chkMoistChocolate.Checked == true)
            {
                txtMoistChocolate.Enabled = true;
            }
            if (qtyMoiC == 0)
            //walang stock si Moist Chocolate - 1 Slice
            {
                chkMoistChocolate.Enabled = false;
                txtMoistChocolate.Enabled = false;
                txtMoistChocolate.BackColor = Color.Red;
            }

            //CARROT CAKE - upon loading kasi isa lang naman textbox(option)
            cn.Open();
            SqlCommand qtyCarCake = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P114B'", cn);
            int qtyCarC = (int)qtyCarCake.ExecuteScalar();
            cn.Close();

            //CARROT CAKE - 1 SLICE
            if (qtyCarC > 0 && chkCarrotCake.Checked == false)
            {
                txtCarrotCake.Enabled = false;
                txtCarrotCake.Text = "0";
            }
            if (qtyCarC > 0 && chkCarrotCake.Checked == true)
            {
                txtCarrotCake.Enabled = true;
            }
            if (qtyCarC == 0)
            //walang stock si Coffee Cake - 1 Slice
            {
                chkCarrotCake.Enabled = false;
                txtCarrotCake.Enabled = false;
                txtCarrotCake.BackColor = Color.Red;
            }

            //MOCHA CAKE - upon loading kasi isa lang naman textbox(option)
            cn.Open();
            SqlCommand qtyMocCake = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P115B'", cn);
            int qtyMoC = (int)qtyMocCake.ExecuteScalar();
            cn.Close();

            //MOCHA CAKE - 1 SLICE
            if (qtyMoC > 0 && chkMochaCake.Checked == false)
            {
                txtMochaCake.Enabled = false;
                txtMochaCake.Text = "0";
            }
            if (qtyMoC > 0 && chkMochaCake.Checked == true)
            {
                txtMochaCake.Enabled = true;
            }
            if (qtyMoC == 0)
            //walang stock si Mocha Cake - 1 Slice
            {
                chkMochaCake.Enabled = false;
                txtMochaCake.Enabled = false;
                txtMochaCake.BackColor = Color.Red;
            }


        }
        private void chkLatte_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkLatte.Checked == true)
            {
                txtLatteM.Enabled = true;
                txtLatteL.Enabled = true;
            }
            else
            {
                txtLatteM.Enabled = false;
                txtLatteM.Text = "0";
                txtLatteL.Enabled = false;
                txtLatteL.Text = "0";
            }
            //red txtbox pag walang stock is inside every code pag sa cake, kasi isa lang naman option dito

            cn.Open();
            SqlCommand qtyLatteM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P100A'", cn);
            SqlCommand qtyLatteL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P100C'", cn);
            int qtyLttM = (int)qtyLatteM.ExecuteScalar();
            int qtyLttL = (int)qtyLatteL.ExecuteScalar();
            cn.Close();

            //LATTE MEDIUM & LARGE
            if (qtyLttM > 0 && qtyLttL > 0 && chkLatte.Checked == false)
            {
                txtLatteM.Enabled = false;
                txtLatteM.Text = "0";
                txtLatteL.Enabled = false;
                txtLatteL.Text = "0";
            }
            if (qtyLttM > 0 && qtyLttL > 0 && chkLatte.Checked == true)
            {
                txtLatteM.Enabled = true;
                txtLatteL.Enabled = true;

            }
            if (qtyLttM > 0 && qtyLttL == 0)
            //may stock si Latte medium pero si Latte large ay walang stock
            {
                txtLatteM.Enabled = true;
                txtLatteL.Enabled = false;
                txtLatteL.BackColor = Color.Red;

            }

            if (qtyLttM == 0 && qtyLttL > 0)
            //walang stock si Latte medium pero si may stock si Latte large
            {
                txtLatteM.Enabled = false;
                txtLatteM.BackColor = Color.Red;
                txtLatteL.Enabled = true;
            }
            if (qtyLttM == 0 && qtyLttL == 0)
            //walang stock si Latte medium at si Latte large
            {
                chkLatte.Enabled = false;
                txtLatteM.Enabled = false;
                txtLatteM.BackColor = Color.Red;
                txtLatteL.Enabled = false;
                txtLatteL.BackColor = Color.Red;

            }

        }

        private void txtLatteM_Click(object sender, EventArgs e)
        {
            txtLatteM.Text = "";
            txtLatteM.Focus();
        }
        private void txtLatteM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtLatteL_Click(object sender, EventArgs e)
        {
            txtLatteL.Text = "";
            txtLatteL.Focus();
        }
        private void txtLatteL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspresso.Checked == true)
            {
                txtEspressoM.Enabled = true;
                txtEspressoL.Enabled = true;
            }
            else
            {
                txtEspressoM.Enabled = false;
                txtEspressoM.Text = "0";
                txtEspressoL.Enabled = false;
                txtEspressoL.Text = "0";
            }
            cn.Open();
            SqlCommand qtyEspresM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P101A'", cn);
            SqlCommand qtyEspresL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P101C'", cn);
            int qtyEsM = (int)qtyEspresM.ExecuteScalar();
            int qtyEsL = (int)qtyEspresL.ExecuteScalar();

            //ESPRESSO MEDIUM & LARGE
            if (qtyEsM > 0 && qtyEsL > 0 && chkEspresso.Checked == false)
            {
                txtEspressoM.Enabled = false;
                txtEspressoM.Text = "0";
                txtEspressoL.Enabled = false;
                txtEspressoL.Text = "0";
            }
            if (qtyEsM > 0 && qtyEsL > 0 && chkEspresso.Checked == true)
            {
                txtEspressoM.Enabled = true;
                txtEspressoL.Enabled = true;

            }
            if (qtyEsM > 0 && qtyEsL == 0)
            //may stock si Espresso medium pero si Espresso large ay walang stock
            {
                txtEspressoM.Enabled = true;
                txtEspressoL.Enabled = false;
                txtEspressoL.BackColor = Color.Red;

            }

            if (qtyEsM == 0 && qtyEsL > 0)
            //walang stock si Espresso medium pero si may stock si Espresso large
            {
                txtEspressoM.Enabled = false;
                txtEspressoM.BackColor = Color.Red;
                txtEspressoL.Enabled = true;
            }
            if (qtyEsM == 0 && qtyEsL == 0)
            //walang stock si Espresso medium at si Espresso large
            {
                chkEspresso.Enabled = false;
                txtEspressoM.Enabled = false;
                txtEspressoM.BackColor = Color.Red;
                txtEspressoL.Enabled = false;
                txtEspressoL.BackColor = Color.Red;

            }

            cn.Close();
        }
        private void txtEspressoM_Click(object sender, EventArgs e)
        {
            txtEspressoM.Text = "";
            txtEspressoM.Focus();

        }
        private void txtEspressoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtEspressoL_Click(object sender, EventArgs e)
        {
            txtEspressoL.Text = "";
            txtEspressoL.Focus();
        }
        private void txtEspressoL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkMocha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMocha.Checked == true)
            {
                txtMochaM.Enabled = true;
                txtMochaL.Enabled = true;
            }
            else
            {
                txtMochaM.Enabled = false;
                txtMochaM.Text = "0";
                txtMochaL.Enabled = false;
                txtMochaL.Text = "0";
            }
            cn.Open();
            SqlCommand qtyMochaM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P102A'", cn);
            SqlCommand qtyMochaL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P102C'", cn);
            int qtyMochM = (int)qtyMochaM.ExecuteScalar();
            int qtyMochL = (int)qtyMochaL.ExecuteScalar();

            //MOCHA MEDIUM & LARGE
            if (qtyMochM > 0 && qtyMochL > 0 && chkMocha.Checked == false)
            {
                txtMochaM.Enabled = false;
                txtMochaM.Text = "0";
                txtMochaL.Enabled = false;
                txtMochaL.Text = "0";
            }
            if (qtyMochM > 0 && qtyMochL > 0 && chkMocha.Checked == true)
            {
                txtMochaM.Enabled = true;
                txtMochaL.Enabled = true;

            }
            if (qtyMochM > 0 && qtyMochL == 0)
            //may stock si Mocha medium pero si Mocha large ay walang stock
            {
                txtMochaM.Enabled = true;
                txtMochaL.Enabled = false;
                txtMochaL.BackColor = Color.Red;

            }

            if (qtyMochM == 0 && qtyMochL > 0)
            //walang stock si Mocha medium pero si may stock si Mocha large
            {
                txtMochaM.Enabled = false;
                txtMochaM.BackColor = Color.Red;
                txtMochaL.Enabled = true;
            }
            if (qtyMochM == 0 && qtyMochL == 0)
            //walang stock si Mocha medium at si Mocha large
            {
                chkMocha.Enabled = false;
                txtMochaM.Enabled = false;
                txtMochaM.BackColor = Color.Red;
                txtMochaL.Enabled = false;
                txtMochaL.BackColor = Color.Red;

            }
            cn.Close();
        }
        private void txtMochaM_Click(object sender, EventArgs e)
        {
            txtMochaM.Text = "";
            txtMochaM.Focus();
        }
        private void txtMochaM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtMochaL_Click(object sender, EventArgs e)
        {
            txtMochaL.Text = "";
            txtMochaL.Focus();
        }
        private void txtMochaL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkValeCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValeCoffee.Checked == true)
            {
                txtValeCoffeeM.Enabled = true;
                txtValeCoffeeL.Enabled = true;
            }
            else
            {
                txtValeCoffeeM.Enabled = false;
                txtValeCoffeeM.Text = "0";
                txtValeCoffeeL.Enabled = false;
                txtValeCoffeeL.Text = "0";
            }
            cn.Open();
            SqlCommand qtyValeM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P103A'", cn);
            SqlCommand qtyValeL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P103C'", cn);
            int qtyValM = (int)qtyValeM.ExecuteScalar();
            int qtyValL = (int)qtyValeL.ExecuteScalar();

            //VALECOFFEE MEDIUM & LARGE
            if (qtyValM > 0 && qtyValL > 0 && chkValeCoffee.Checked == false)
            {
                txtValeCoffeeM.Enabled = false;
                txtValeCoffeeM.Text = "0";
                txtValeCoffeeL.Enabled = false;
                txtValeCoffeeL.Text = "0";
            }
            if (qtyValM > 0 && qtyValL > 0 && chkValeCoffee.Checked == true)
            {
                txtValeCoffeeM.Enabled = true;
                txtValeCoffeeL.Enabled = true;

            }
            if (qtyValM > 0 && qtyValL == 0)
            //may stock si ValeCoffee medium pero si ValeCoffee large ay walang stock
            {
                txtValeCoffeeM.Enabled = true;
                txtValeCoffeeL.Enabled = false;
                txtValeCoffeeL.BackColor = Color.Red;

            }

            if (qtyValM == 0 && qtyValL > 0)
            //walang stock si ValeCoffee medium pero si may stock si ValeCoffee large
            {
                txtValeCoffeeM.Enabled = false;
                txtValeCoffeeM.BackColor = Color.Red;
                txtValeCoffeeL.Enabled = true;
            }
            if (qtyValM == 0 && qtyValL == 0)
            //walang stock si ValeCoffee medium at si ValeCoffee large
            {
                chkValeCoffee.Enabled = false;
                txtValeCoffeeM.Enabled = false;
                txtValeCoffeeM.BackColor = Color.Red;
                txtValeCoffeeL.Enabled = false;
                txtValeCoffeeL.BackColor = Color.Red;

            }

            cn.Close();
        }
        private void txtValeCoffeeM_Click(object sender, EventArgs e)
        {
            txtValeCoffeeM.Text = "";
            txtValeCoffeeM.Focus();
        }
        private void txtValeCoffeeM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtValeCoffeeL_Click(object sender, EventArgs e)
        {
            txtValeCoffeeL.Text = "";
            txtValeCoffeeL.Focus();
        }
        private void txtValeCoffeeL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappuccino.Checked == true)
            {
                txtCappuccinoM.Enabled = true;
                txtCappuccinoL.Enabled = true;
            }
            else
            {
                txtCappuccinoM.Enabled = false;
                txtCappuccinoM.Text = "0";
                txtCappuccinoL.Enabled = false;
                txtCappuccinoL.Text = "0";
            }
            cn.Open();
            SqlCommand qtyCappM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P104A'", cn);
            SqlCommand qtyCappL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P104C'", cn);
            int qtyCapM = (int)qtyCappM.ExecuteScalar();
            int qtyCapL = (int)qtyCappL.ExecuteScalar();

            //CAPPUCCINO MEDIUM & LARGE
            if (qtyCapM > 0 && qtyCapL > 0 && chkCappuccino.Checked == false)
            {
                txtCappuccinoM.Enabled = false;
                txtCappuccinoM.Text = "0";
                txtCappuccinoL.Enabled = false;
                txtCappuccinoL.Text = "0";
            }
            if (qtyCapM > 0 && qtyCapL > 0 && chkCappuccino.Checked == true)
            {
                txtCappuccinoM.Enabled = true;
                txtCappuccinoL.Enabled = true;

            }
            if (qtyCapM > 0 && qtyCapL == 0)
            //may stock si Cappuccino medium pero si Cappuccino large ay walang stock
            {
                txtCappuccinoM.Enabled = true;
                txtCappuccinoL.Enabled = false;
                txtCappuccinoL.BackColor = Color.Red;

            }

            if (qtyCapM == 0 && qtyCapL > 0)
            //walang stock si Cappuccino medium pero si may stock si Cappuccino large
            {
                txtCappuccinoM.Enabled = false;
                txtCappuccinoM.BackColor = Color.Red;
                txtCappuccinoL.Enabled = true;
            }
            if (qtyCapM == 0 && qtyCapL == 0)
            //walang stock si Cappuccino medium at si Cappuccino large
            {
                chkCappuccino.Enabled = false;
                txtCappuccinoM.Enabled = false;
                txtCappuccinoM.BackColor = Color.Red;
                txtCappuccinoL.Enabled = false;
                txtCappuccinoL.BackColor = Color.Red;

            }
            cn.Close();
        }
        private void txtCappuccinoM_Click(object sender, EventArgs e)
        {
            txtCappuccinoM.Text = "";
            txtCappuccinoM.Focus();
        }
        private void txtCappuccinoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtCappuccinoL_Click(object sender, EventArgs e)
        {
            txtCappuccinoL.Text = "";
            txtCappuccinoL.Focus();
        }
        private void txtCappuccinoL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkCaramelMachiato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCaramelMachiato.Checked == true)
            {
                txtCaramelMacchiatoM.Enabled = true;
                txtCaramelMachiatoL.Enabled = true;
            }
            else
            {
                txtCaramelMacchiatoM.Enabled = false;
                txtCaramelMacchiatoM.Text = "0";
                txtCaramelMachiatoL.Enabled = false;
                txtCaramelMachiatoL.Text = "0";
            }
            cn.Open();
            SqlCommand qtyCaramM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P105A'", cn);
            SqlCommand qtyCaramL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P105C'", cn);
            int qtyCarM = (int)qtyCaramM.ExecuteScalar();
            int qtyCarL = (int)qtyCaramL.ExecuteScalar();

            //CARAMEL MACCHIATO MEDIUM & LARGE
            if (qtyCarM > 0 && qtyCarL > 0 && chkCaramelMachiato.Checked == false)
            {
                txtCaramelMacchiatoM.Enabled = false;
                txtCaramelMacchiatoM.Text = "0";
                txtCaramelMachiatoL.Enabled = false;
                txtCaramelMachiatoL.Text = "0";
            }
            if (qtyCarM > 0 && qtyCarL > 0 && chkCaramelMachiato.Checked == true)
            {
                txtCaramelMacchiatoM.Enabled = true;
                txtCaramelMachiatoL.Enabled = true;

            }
            if (qtyCarM > 0 && qtyCarL == 0)
            //may stock si Caramel Macchiato medium pero si Caramel Macchiato large ay walang stock
            {
                txtCaramelMacchiatoM.Enabled = true;
                txtCaramelMachiatoL.Enabled = false;
                txtCaramelMachiatoL.BackColor = Color.Red;

            }

            if (qtyCarM == 0 && qtyCarL > 0)
            //walang stock si Caramel Macchiato medium pero si may stock si Caramel Macchiato large
            {
                txtCaramelMacchiatoM.Enabled = false;
                txtCaramelMacchiatoM.BackColor = Color.Red;
                txtCaramelMachiatoL.Enabled = true;
            }
            if (qtyCarM == 0 && qtyCarL == 0)
            //walang stock si latte medium at si latte large
            {
                chkCaramelMachiato.Enabled = false;
                txtCaramelMacchiatoM.Enabled = false;
                txtCaramelMacchiatoM.BackColor = Color.Red;
                txtCaramelMachiatoL.Enabled = false;
                txtCaramelMachiatoL.BackColor = Color.Red;
            }

            cn.Close();
        }
        private void txtCaramelMacchiatoM_Click(object sender, EventArgs e)
        {
            txtCaramelMacchiatoM.Text = "";
            txtCaramelMacchiatoM.Focus();
        }
        private void txtCaramelMacchiatoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtCaramelMachiatoL_Click(object sender, EventArgs e)
        {
            txtCaramelMachiatoL.Text = "";
            txtCaramelMachiatoL.Focus();
        }
        private void txtCaramelMachiatoL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkBrewedCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBrewedCoffee.Checked == true)
            {
                txtBrewedCoffeeM.Enabled = true;
                txtBrewedCoffeeL.Enabled = true;
            }
            else
            {
                txtBrewedCoffeeM.Enabled = false;
                txtBrewedCoffeeM.Text = "0";
                txtBrewedCoffeeL.Enabled = false;
                txtBrewedCoffeeL.Text = "0";
            }
            cn.Open();
            SqlCommand qtyBrewM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P106A'", cn);
            SqlCommand qtyBrewL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P106C'", cn);
            int qtyBreM = (int)qtyBrewM.ExecuteScalar();
            int qtyBreL = (int)qtyBrewL.ExecuteScalar();

            //BREWED COFFEE MEDIUM & LARGE
            if (qtyBreM > 0 && qtyBreL > 0 && chkBrewedCoffee.Checked == false)
            {
                txtBrewedCoffeeM.Enabled = false;
                txtBrewedCoffeeM.Text = "0";
                txtBrewedCoffeeL.Enabled = false;
                txtBrewedCoffeeL.Text = "0";
            }
            if (qtyBreM > 0 && qtyBreL > 0 && chkBrewedCoffee.Checked == true)
            {
                txtBrewedCoffeeM.Enabled = true;
                txtBrewedCoffeeL.Enabled = true;

            }
            if (qtyBreM > 0 && qtyBreL == 0)
            //may stock si Brewed Coffee medium pero si Brewed Coffee large ay walang stock
            {
                txtBrewedCoffeeM.Enabled = true;
                txtBrewedCoffeeL.Enabled = false;
                txtBrewedCoffeeL.BackColor = Color.Red;

            }

            if (qtyBreM == 0 && qtyBreL > 0)
            //walang stock si Brewed Coffee medium pero si may stock si Brewed Coffee large
            {
                txtBrewedCoffeeM.Enabled = false;
                txtBrewedCoffeeM.BackColor = Color.Red;
                txtBrewedCoffeeL.Enabled = true;
            }
            if (qtyBreM == 0 && qtyBreL == 0)
            //walang stock si Brewe dCoffee medium at si Brewed Coffee large
            {
                chkBrewedCoffee.Enabled = false;
                txtBrewedCoffeeM.Enabled = false;
                txtBrewedCoffeeM.BackColor = Color.Red;
                txtBrewedCoffeeL.Enabled = false;
                txtBrewedCoffeeL.BackColor = Color.Red;
            }
            cn.Close();
        }
        private void txtBrewedCoffeeM_Click(object sender, EventArgs e)
        {
            txtBrewedCoffeeM.Text = "";
            txtBrewedCoffeeM.Focus();
        }
        private void txtBrewedCoffeeM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtBrewedCoffeeL_Click(object sender, EventArgs e)
        {
            txtBrewedCoffeeL.Text = "";
            txtBrewedCoffeeL.Focus();
        }
        private void txtBrewedCoffeeL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkFrenchVanilla_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFrenchVanilla.Checked == true)
            {
                txtFrenchVanillaM.Enabled = true;
                txtFrenchVanillaL.Enabled = true;
            }
            else
            {
                txtFrenchVanillaM.Enabled = false;
                txtFrenchVanillaM.Text = "0";
                txtFrenchVanillaL.Enabled = false;
                txtFrenchVanillaL.Text = "0";
            }

            cn.Open();

            SqlCommand qtyFrenM = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P107A'", cn);
            SqlCommand qtyFrenL = new SqlCommand("SELECT Qty FROM tbl_product WHERE Pcode = 'P107C'", cn);
            int qtyFreM = (int)qtyFrenM.ExecuteScalar();
            int qtyFreL = (int)qtyFrenL.ExecuteScalar();

            //FRENCH VANILLA MEDIUM & LARGE
            if (qtyFreM > 0 && qtyFreL > 0 && chkFrenchVanilla.Checked == false)
            {
                txtFrenchVanillaM.Enabled = false;
                txtFrenchVanillaM.Text = "0";
                txtFrenchVanillaL.Enabled = false;
                txtFrenchVanillaL.Text = "0";
            }
            if (qtyFreM > 0 && qtyFreL > 0 && chkFrenchVanilla.Checked == true)
            {
                txtFrenchVanillaM.Enabled = true;
                txtFrenchVanillaL.Enabled = true;

            }
            if (qtyFreM > 0 && qtyFreL == 0)
            //may stock si French Vanilla medium pero si French Vanilla large ay walang stock
            {
                txtFrenchVanillaM.Enabled = true;
                txtFrenchVanillaL.Enabled = false;
                txtFrenchVanillaL.BackColor = Color.Red;

            }

            if (qtyFreM == 0 && qtyFreL > 0)
            //walang stock si French Vanilla medium pero si may stock si French Vanilla large
            {
                txtFrenchVanillaM.Enabled = false;
                txtFrenchVanillaM.BackColor = Color.Red;
                txtFrenchVanillaL.Enabled = true;
            }
            if (qtyFreM == 0 && qtyFreL == 0)
            //walang stock si French Vanilla medium at si French Vanilla large
            {
                chkFrenchVanilla.Enabled = false;
                txtFrenchVanillaM.Enabled = false;
                txtFrenchVanillaM.BackColor = Color.Red;
                txtFrenchVanillaL.Enabled = false;
                txtFrenchVanillaL.BackColor = Color.Red;

            }

            cn.Close();
        }
        private void txtFrenchVanillaM_Click(object sender, EventArgs e)
        {
            txtFrenchVanillaM.Text = "";
            txtFrenchVanillaM.Focus();
        }
        private void txtFrenchVanillaM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtFrenchVanillaL_Click(object sender, EventArgs e)
        {
            txtFrenchVanillaL.Text = "";
            txtFrenchVanillaL.Focus();
        }
        private void txtFrenchVanillaL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkCoffeeCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffeeCake.Checked == true)
            {
                txtCoffeeCake.Enabled = true;
            }
            else
            {
                txtCoffeeCake.Enabled = false;
                txtCoffeeCake.Text = "0";
            }
            
        }
        private void txtCoffeeCake_Click(object sender, EventArgs e)
        {
            txtCoffeeCake.Text = "";
            txtCoffeeCake.Focus();
        }
        private void txtCoffeeCake_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkRedVelvetCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedVelvetCake.Checked == true)
            {
                txtRedVelvetCake.Enabled = true;
            }
            else
            {
                txtRedVelvetCake.Enabled = false;
                txtRedVelvetCake.Text = "0";
            }
        }
        private void txtRedVelvetCake_Click(object sender, EventArgs e)
        {
            txtRedVelvetCake.Text = "";
            txtRedVelvetCake.Focus();
        }
        private void txtRedVelvetCake_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkBlackForestCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlackForestCake.Checked == true)
            {
                txtBlackForestCake.Enabled = true;
            }
            else
            {
                txtBlackForestCake.Enabled = false;
                txtBlackForestCake.Text = "0";
            }
        }
        private void txtBlackForestCake_Click(object sender, EventArgs e)
        {
            txtBlackForestCake.Text = "";
            txtBlackForestCake.Focus();
        }
        private void txtBlackForestCake_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkBlueberryCheeseCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlueberryCheeseCake.Checked == true)
            {
                txtBlueberryCheeseCake.Enabled = true;
            }
            else
            {
                txtBlueberryCheeseCake.Enabled = false;
                txtBlueberryCheeseCake.Text = "0";
            }
        }
        private void txtBlueberryCheeseCake_Click(object sender, EventArgs e)
        {
            txtBlueberryCheeseCake.Text = "";
            txtBlueberryCheeseCake.Focus();
        }
        private void txtBlueberryCheeseCake_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkUbeCustard_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUbeCustard.Checked == true)
            {
                txtUbeCustard.Enabled = true;
            }
            else
            {
                txtUbeCustard.Enabled = false;
                txtUbeCustard.Text = "0";
            }
        }
        private void txtUbeCustard_Click(object sender, EventArgs e)
        {
            txtUbeCustard.Text = "";
            txtUbeCustard.Focus();
        }
        private void txtUbeCustard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkMoistChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMoistChocolate.Checked == true)
            {
                txtMoistChocolate.Enabled = true;
            }
            else
            {
                txtMoistChocolate.Enabled = false;
                txtMoistChocolate.Text = "0";
            }
        }
        private void txtMoistChocolate_Click(object sender, EventArgs e)
        {
            txtMoistChocolate.Text = "";
            txtMoistChocolate.Focus();
        }
        private void txtMoistChocolate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkCarrotCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarrotCake.Checked == true)
            {
                txtCarrotCake.Enabled = true;
            }
            else
            {
                txtCarrotCake.Enabled = false;
                txtCarrotCake.Text = "0";
            }
        }
        private void txtCarrotCake_Click(object sender, EventArgs e)
        {
            txtCarrotCake.Text = "";
            txtCarrotCake.Focus();
        }
        private void txtCarrotCake_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chkMochaCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMochaCake.Checked == true)
            {
                txtMochaCake.Enabled = true;
            }
            else
            {
                txtMochaCake.Enabled = false;
                txtMochaCake.Text = "0";
            }
        }
        private void txtMochaCake_Click(object sender, EventArgs e)
        {
            txtMochaCake.Text = "";
            txtMochaCake.Focus();
        }
        private void txtMochaCake_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtbReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtbReceipt.Clear();
            Reset();

        }
        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtbReceipt.Cut();
        }
        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtbReceipt.Copy();
        }
        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtbReceipt.Paste();
        }
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will open text files
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                rtbReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will save text files
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            
            
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtbReceipt.Text);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            cusOrder = rtbReceipt.Text;
            string msg = "Your order is sent to the counter";
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult res = MessageBox.Show(msg, "Order Transaction", btn, MessageBoxIcon.Information);


            frmProcessingOrder processOrder = new frmProcessingOrder();
            processOrder.Owner = this;
            processOrder.Show();

            lbltransNo.Text = trans1.cats("P - ");
            transNo.getNo = lbltransNo.Text;
            transNo.Qstring.Enqueue(transNo.getNo);

            frmProcessingOrder orderP = new frmProcessingOrder();
            orderP.Show();
            orderP.lblProcessNo.Text = trans1.cats("P - ");
            orderP.lblProcessNo.Text = transNo.getNo;
            transNo.Qstring.Enqueue(transNo.getNo);

            frmStaff staff = new frmStaff();
            staff.Show();
            staff.lblTransNoStaff.Text = trans1.cats("P - ");
            staff.lblTransNoStaff.Text = transNo.getNo;
            transNo.Qstring.Enqueue(transNo.getNo);

            rtbReceipt.Text = "";
        }

        private void btnReq_Click(object sender, EventArgs e)
        {
            frmRequest req = new frmRequest();
            req.ShowDialog();
        }

        private void rtbReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltransNo_Click(object sender, EventArgs e)
        {

        }
    }
}
