﻿
namespace CafeManagement
{
    partial class frmRequest
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
            this.label2 = new System.Windows.Forms.Label();
            this.rtbRequest = new System.Windows.Forms.RichTextBox();
            this.btnSubmitReq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Good Day, Customer! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "May I know what\'s your request?";
            // 
            // rtbRequest
            // 
            this.rtbRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rtbRequest.Location = new System.Drawing.Point(35, 95);
            this.rtbRequest.Name = "rtbRequest";
            this.rtbRequest.Size = new System.Drawing.Size(374, 169);
            this.rtbRequest.TabIndex = 2;
            this.rtbRequest.Text = "";
            // 
            // btnSubmitReq
            // 
            this.btnSubmitReq.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitReq.Location = new System.Drawing.Point(297, 270);
            this.btnSubmitReq.Name = "btnSubmitReq";
            this.btnSubmitReq.Size = new System.Drawing.Size(112, 35);
            this.btnSubmitReq.TabIndex = 3;
            this.btnSubmitReq.Text = "Submit";
            this.btnSubmitReq.UseVisualStyleBackColor = true;
            this.btnSubmitReq.Click += new System.EventHandler(this.btnSubmitReq_Click);
            // 
            // frmRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 323);
            this.Controls.Add(this.btnSubmitReq);
            this.Controls.Add(this.rtbRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer\'s Request";
            this.Load += new System.EventHandler(this.frmRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmitReq;
        public System.Windows.Forms.RichTextBox rtbRequest;
    }
}