
namespace CafeManagement
{
    partial class frmProcessingOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbDisplayReceipt = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOrderInQ = new System.Windows.Forms.Label();
            this.lblOrderServe = new System.Windows.Forms.Label();
            this.lblOrderPrep = new System.Windows.Forms.Label();
            this.btnBckMenu = new System.Windows.Forms.Button();
            this.txtCashPay = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblProcessNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSACTION NO.";
            // 
            // rtbDisplayReceipt
            // 
            this.rtbDisplayReceipt.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbDisplayReceipt.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.rtbDisplayReceipt.Location = new System.Drawing.Point(30, 48);
            this.rtbDisplayReceipt.Name = "rtbDisplayReceipt";
            this.rtbDisplayReceipt.ReadOnly = true;
            this.rtbDisplayReceipt.Size = new System.Drawing.Size(442, 429);
            this.rtbDisplayReceipt.TabIndex = 1;
            this.rtbDisplayReceipt.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(370, 482);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblOrderInQ
            // 
            this.lblOrderInQ.AutoSize = true;
            this.lblOrderInQ.BackColor = System.Drawing.Color.Crimson;
            this.lblOrderInQ.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderInQ.ForeColor = System.Drawing.Color.White;
            this.lblOrderInQ.Location = new System.Drawing.Point(480, 85);
            this.lblOrderInQ.Name = "lblOrderInQ";
            this.lblOrderInQ.Size = new System.Drawing.Size(277, 34);
            this.lblOrderInQ.TabIndex = 6;
            this.lblOrderInQ.Text = "YOUR ORDER/S IS IN QUEUE";
            this.lblOrderInQ.Click += new System.EventHandler(this.lblOrderInQ_Click);
            // 
            // lblOrderServe
            // 
            this.lblOrderServe.AutoSize = true;
            this.lblOrderServe.BackColor = System.Drawing.Color.Lime;
            this.lblOrderServe.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lblOrderServe.ForeColor = System.Drawing.Color.Black;
            this.lblOrderServe.Location = new System.Drawing.Point(480, 212);
            this.lblOrderServe.Name = "lblOrderServe";
            this.lblOrderServe.Size = new System.Drawing.Size(323, 34);
            this.lblOrderServe.TabIndex = 7;
            this.lblOrderServe.Text = "YOUR ORDER IS READY TO SERVE";
            this.lblOrderServe.VisibleChanged += new System.EventHandler(this.lblOrderServe_VisibleChanged);
            // 
            // lblOrderPrep
            // 
            this.lblOrderPrep.AutoSize = true;
            this.lblOrderPrep.BackColor = System.Drawing.Color.Yellow;
            this.lblOrderPrep.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lblOrderPrep.ForeColor = System.Drawing.Color.Black;
            this.lblOrderPrep.Location = new System.Drawing.Point(480, 151);
            this.lblOrderPrep.Name = "lblOrderPrep";
            this.lblOrderPrep.Size = new System.Drawing.Size(345, 34);
            this.lblOrderPrep.TabIndex = 8;
            this.lblOrderPrep.Text = "YOUR ORDER/S IS BEING PREPARED";
            // 
            // btnBckMenu
            // 
            this.btnBckMenu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBckMenu.Location = new System.Drawing.Point(678, 482);
            this.btnBckMenu.Name = "btnBckMenu";
            this.btnBckMenu.Size = new System.Drawing.Size(132, 38);
            this.btnBckMenu.TabIndex = 9;
            this.btnBckMenu.Text = "Back to Menu";
            this.btnBckMenu.UseVisualStyleBackColor = true;
            this.btnBckMenu.Visible = false;
            this.btnBckMenu.Click += new System.EventHandler(this.btnBckMenu_Click);
            // 
            // txtCashPay
            // 
            this.txtCashPay.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashPay.Location = new System.Drawing.Point(28, 487);
            this.txtCashPay.Multiline = true;
            this.txtCashPay.Name = "txtCashPay";
            this.txtCashPay.Size = new System.Drawing.Size(138, 33);
            this.txtCashPay.TabIndex = 13;
            this.txtCashPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashPay_KeyPress);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(181, 482);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(102, 38);
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblProcessNo
            // 
            this.lblProcessNo.AutoSize = true;
            this.lblProcessNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessNo.Location = new System.Drawing.Point(199, 25);
            this.lblProcessNo.Name = "lblProcessNo";
            this.lblProcessNo.Size = new System.Drawing.Size(0, 24);
            this.lblProcessNo.TabIndex = 14;
            // 
            // frmProcessingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(822, 565);
            this.Controls.Add(this.lblProcessNo);
            this.Controls.Add(this.txtCashPay);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnBckMenu);
            this.Controls.Add(this.lblOrderPrep);
            this.Controls.Add(this.lblOrderServe);
            this.Controls.Add(this.lblOrderInQ);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rtbDisplayReceipt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(350, 300);
            this.Name = "frmProcessingOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Processing Order";
            this.Load += new System.EventHandler(this.frmProcessingOrder_Load);
            this.Click += new System.EventHandler(this.frmProcessingOrder_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblOrderInQ;
        public System.Windows.Forms.Label lblOrderServe;
        public System.Windows.Forms.Label lblOrderPrep;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnBckMenu;
        public System.Windows.Forms.Button btnPay;
        public System.Windows.Forms.TextBox txtCashPay;
        public System.Windows.Forms.Label lblProcessNo;
        public System.Windows.Forms.RichTextBox rtbDisplayReceipt;
    }
}