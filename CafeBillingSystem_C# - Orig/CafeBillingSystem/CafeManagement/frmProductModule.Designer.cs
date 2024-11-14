
namespace CafeManagement
{
    partial class frmProductModule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductModule));
            this.frmProdModClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProdCatgry = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProdBrand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdDescrp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.btnPCancel = new System.Windows.Forms.Button();
            this.btnPUpdate = new System.Windows.Forms.Button();
            this.btnPSave = new System.Windows.Forms.Button();
            this.txtProdCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.frmProdModClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmProdModClose
            // 
            this.frmProdModClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmProdModClose.Image = ((System.Drawing.Image)(resources.GetObject("frmProdModClose.Image")));
            this.frmProdModClose.Location = new System.Drawing.Point(578, 0);
            this.frmProdModClose.Name = "frmProdModClose";
            this.frmProdModClose.Size = new System.Drawing.Size(36, 35);
            this.frmProdModClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmProdModClose.TabIndex = 4;
            this.frmProdModClose.TabStop = false;
            this.frmProdModClose.Click += new System.EventHandler(this.frmProdModClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Module";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(159, 91);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(419, 34);
            this.txtBarcode.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label7.Location = new System.Drawing.Point(8, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 30);
            this.label7.TabIndex = 40;
            this.label7.Text = "Barcode";
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Location = new System.Drawing.Point(159, 257);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(419, 34);
            this.txtProdPrice.TabIndex = 39;
            this.txtProdPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdPrice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label6.Location = new System.Drawing.Point(8, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 30);
            this.label6.TabIndex = 38;
            this.label6.Text = "Price";
            // 
            // cbProdCatgry
            // 
            this.cbProdCatgry.FormattingEnabled = true;
            this.cbProdCatgry.Location = new System.Drawing.Point(159, 215);
            this.cbProdCatgry.Name = "cbProdCatgry";
            this.cbProdCatgry.Size = new System.Drawing.Size(419, 36);
            this.cbProdCatgry.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.Location = new System.Drawing.Point(8, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 30);
            this.label5.TabIndex = 36;
            this.label5.Text = "Category";
            // 
            // cbProdBrand
            // 
            this.cbProdBrand.FormattingEnabled = true;
            this.cbProdBrand.Location = new System.Drawing.Point(159, 173);
            this.cbProdBrand.Name = "cbProdBrand";
            this.cbProdBrand.Size = new System.Drawing.Size(419, 36);
            this.cbProdBrand.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(8, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 30);
            this.label4.TabIndex = 34;
            this.label4.Text = "Brand";
            // 
            // txtProdDescrp
            // 
            this.txtProdDescrp.Location = new System.Drawing.Point(159, 131);
            this.txtProdDescrp.Name = "txtProdDescrp";
            this.txtProdDescrp.Size = new System.Drawing.Size(419, 34);
            this.txtProdDescrp.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(8, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 32;
            this.label3.Text = "Description";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(404, 309);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(0, 28);
            this.lblPID.TabIndex = 31;
            this.lblPID.Visible = false;
            // 
            // btnPCancel
            // 
            this.btnPCancel.BackColor = System.Drawing.Color.Silver;
            this.btnPCancel.FlatAppearance.BorderSize = 0;
            this.btnPCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCancel.ForeColor = System.Drawing.Color.Black;
            this.btnPCancel.Location = new System.Drawing.Point(313, 306);
            this.btnPCancel.Name = "btnPCancel";
            this.btnPCancel.Size = new System.Drawing.Size(79, 33);
            this.btnPCancel.TabIndex = 30;
            this.btnPCancel.Text = "Cancel";
            this.btnPCancel.UseVisualStyleBackColor = false;
            this.btnPCancel.Click += new System.EventHandler(this.btnPCancel_Click);
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnPUpdate.FlatAppearance.BorderSize = 0;
            this.btnPUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPUpdate.Location = new System.Drawing.Point(222, 306);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(85, 33);
            this.btnPUpdate.TabIndex = 29;
            this.btnPUpdate.Text = "Update";
            this.btnPUpdate.UseVisualStyleBackColor = false;
            this.btnPUpdate.Click += new System.EventHandler(this.btnPUpdate_Click);
            // 
            // btnPSave
            // 
            this.btnPSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnPSave.FlatAppearance.BorderSize = 0;
            this.btnPSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSave.ForeColor = System.Drawing.Color.White;
            this.btnPSave.Location = new System.Drawing.Point(143, 306);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.Size = new System.Drawing.Size(73, 33);
            this.btnPSave.TabIndex = 28;
            this.btnPSave.Text = "Save";
            this.btnPSave.UseVisualStyleBackColor = false;
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
            // 
            // txtProdCode
            // 
            this.txtProdCode.Location = new System.Drawing.Point(159, 51);
            this.txtProdCode.Name = "txtProdCode";
            this.txtProdCode.Size = new System.Drawing.Size(419, 34);
            this.txtProdCode.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Product Code";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.frmProdModClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 35);
            this.panel1.TabIndex = 25;
            // 
            // frmProductModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 353);
            this.ControlBox = false;
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProdPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbProdCatgry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbProdBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProdDescrp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.btnPCancel);
            this.Controls.Add(this.btnPUpdate);
            this.Controls.Add(this.btnPSave);
            this.Controls.Add(this.txtProdCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.frmProdModClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox frmProdModClose;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbProdCatgry;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbProdBrand;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtProdDescrp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblPID;
        public System.Windows.Forms.Button btnPCancel;
        public System.Windows.Forms.Button btnPUpdate;
        public System.Windows.Forms.Button btnPSave;
        public System.Windows.Forms.TextBox txtProdCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}