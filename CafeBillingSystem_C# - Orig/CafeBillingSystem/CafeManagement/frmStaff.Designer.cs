
namespace CafeManagement
{
    partial class frmStaff
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
            this.components = new System.ComponentModel.Container();
            this.gbTrans1 = new System.Windows.Forms.GroupBox();
            this.rtbQueue1 = new System.Windows.Forms.RichTextBox();
            this.btn1Done = new System.Windows.Forms.Button();
            this.btn1Prep = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDisplayCashPay = new System.Windows.Forms.Label();
            this.lblBayadCust = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTransNoStaff = new System.Windows.Forms.Label();
            this.gbTrans1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTrans1
            // 
            this.gbTrans1.Controls.Add(this.rtbQueue1);
            this.gbTrans1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbTrans1.Location = new System.Drawing.Point(24, 91);
            this.gbTrans1.Name = "gbTrans1";
            this.gbTrans1.Size = new System.Drawing.Size(459, 420);
            this.gbTrans1.TabIndex = 0;
            this.gbTrans1.TabStop = false;
            // 
            // rtbQueue1
            // 
            this.rtbQueue1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbQueue1.Location = new System.Drawing.Point(6, 14);
            this.rtbQueue1.Name = "rtbQueue1";
            this.rtbQueue1.ReadOnly = true;
            this.rtbQueue1.Size = new System.Drawing.Size(442, 400);
            this.rtbQueue1.TabIndex = 4;
            this.rtbQueue1.Text = "";
            this.rtbQueue1.Click += new System.EventHandler(this.rtbQueue1_Click);
            this.rtbQueue1.MouseHover += new System.EventHandler(this.rtbQueue1_MouseHover);
            // 
            // btn1Done
            // 
            this.btn1Done.Enabled = false;
            this.btn1Done.Location = new System.Drawing.Point(159, 517);
            this.btn1Done.Name = "btn1Done";
            this.btn1Done.Size = new System.Drawing.Size(102, 41);
            this.btn1Done.TabIndex = 3;
            this.btn1Done.Text = "Done";
            this.btn1Done.UseVisualStyleBackColor = true;
            this.btn1Done.Click += new System.EventHandler(this.btn1Done_Click);
            // 
            // btn1Prep
            // 
            this.btn1Prep.Location = new System.Drawing.Point(30, 517);
            this.btn1Prep.Name = "btn1Prep";
            this.btn1Prep.Size = new System.Drawing.Size(102, 41);
            this.btn1Prep.TabIndex = 3;
            this.btn1Prep.Text = "Preparing";
            this.btn1Prep.UseVisualStyleBackColor = true;
            this.btn1Prep.Click += new System.EventHandler(this.btn1Prep_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(376, 38);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(96, 20);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "00:00AMPM";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(361, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(111, 20);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "MM/DD/YYYY";
            // 
            // lblDisplayCashPay
            // 
            this.lblDisplayCashPay.AutoSize = true;
            this.lblDisplayCashPay.Location = new System.Drawing.Point(155, 9);
            this.lblDisplayCashPay.Name = "lblDisplayCashPay";
            this.lblDisplayCashPay.Size = new System.Drawing.Size(0, 20);
            this.lblDisplayCashPay.TabIndex = 8;
            // 
            // lblBayadCust
            // 
            this.lblBayadCust.AutoSize = true;
            this.lblBayadCust.Location = new System.Drawing.Point(421, 527);
            this.lblBayadCust.Name = "lblBayadCust";
            this.lblBayadCust.Size = new System.Drawing.Size(0, 20);
            this.lblBayadCust.TabIndex = 9;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(26, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 20);
            this.lblUserName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Amount Paid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(76, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "TRANSACTION NO.";
            // 
            // lblTransNoStaff
            // 
            this.lblTransNoStaff.AutoSize = true;
            this.lblTransNoStaff.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTransNoStaff.Location = new System.Drawing.Point(245, 78);
            this.lblTransNoStaff.Name = "lblTransNoStaff";
            this.lblTransNoStaff.Size = new System.Drawing.Size(0, 24);
            this.lblTransNoStaff.TabIndex = 13;
            this.lblTransNoStaff.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 579);
            this.Controls.Add(this.lblTransNoStaff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblBayadCust);
            this.Controls.Add(this.lblDisplayCashPay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btn1Prep);
            this.Controls.Add(this.btn1Done);
            this.Controls.Add(this.gbTrans1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(920, 300);
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Staff: Customer\'s Order/s";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.gbTrans1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTrans1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.RichTextBox rtbQueue1;
        public System.Windows.Forms.Button btn1Prep;
        public System.Windows.Forms.Button btn1Done;
        public System.Windows.Forms.Label lblDisplayCashPay;
        public System.Windows.Forms.Label lblBayadCust;
        public System.Windows.Forms.Label lblUserName;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTransNoStaff;
    }
}