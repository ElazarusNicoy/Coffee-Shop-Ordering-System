
namespace CafeManagement
{
    partial class frmUserAcct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAcct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userAcctClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcUserAcct = new System.Windows.Forms.TabControl();
            this.tcreateAcct = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tChangePass = new System.Windows.Forms.TabPage();
            this.tDelAcct = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAcctClose)).BeginInit();
            this.tcUserAcct.SuspendLayout();
            this.tcreateAcct.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.userAcctClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 35);
            this.panel1.TabIndex = 6;
            // 
            // userAcctClose
            // 
            this.userAcctClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userAcctClose.Image = ((System.Drawing.Image)(resources.GetObject("userAcctClose.Image")));
            this.userAcctClose.Location = new System.Drawing.Point(867, 0);
            this.userAcctClose.Name = "userAcctClose";
            this.userAcctClose.Size = new System.Drawing.Size(36, 35);
            this.userAcctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAcctClose.TabIndex = 3;
            this.userAcctClose.TabStop = false;
            this.userAcctClose.Click += new System.EventHandler(this.userAcctClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "USER ACCOUNT";
            // 
            // tcUserAcct
            // 
            this.tcUserAcct.Controls.Add(this.tcreateAcct);
            this.tcUserAcct.Controls.Add(this.tChangePass);
            this.tcUserAcct.Controls.Add(this.tDelAcct);
            this.tcUserAcct.Location = new System.Drawing.Point(96, 95);
            this.tcUserAcct.Name = "tcUserAcct";
            this.tcUserAcct.SelectedIndex = 0;
            this.tcUserAcct.Size = new System.Drawing.Size(710, 395);
            this.tcUserAcct.TabIndex = 7;
            // 
            // tcreateAcct
            // 
            this.tcreateAcct.Controls.Add(this.panel2);
            this.tcreateAcct.Location = new System.Drawing.Point(4, 37);
            this.tcreateAcct.Name = "tcreateAcct";
            this.tcreateAcct.Padding = new System.Windows.Forms.Padding(3);
            this.tcreateAcct.Size = new System.Drawing.Size(702, 354);
            this.tcreateAcct.TabIndex = 0;
            this.tcreateAcct.Text = "Create Account";
            this.tcreateAcct.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbRole);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtRePass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 349);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(402, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 31);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(480, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 31);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(188, 172);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(360, 34);
            this.txtName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "System Admin",
            "Cashier",
            "Registrar"});
            this.cbRole.Location = new System.Drawing.Point(188, 130);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(360, 36);
            this.cbRole.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(188, 50);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(360, 34);
            this.txtPass.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Role";
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(188, 90);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '•';
            this.txtRePass.Size = new System.Drawing.Size(360, 34);
            this.txtRePass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-type Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(188, 10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(360, 34);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // tChangePass
            // 
            this.tChangePass.Location = new System.Drawing.Point(4, 37);
            this.tChangePass.Name = "tChangePass";
            this.tChangePass.Padding = new System.Windows.Forms.Padding(3);
            this.tChangePass.Size = new System.Drawing.Size(702, 354);
            this.tChangePass.TabIndex = 1;
            this.tChangePass.Text = "Change Password";
            this.tChangePass.UseVisualStyleBackColor = true;
            // 
            // tDelAcct
            // 
            this.tDelAcct.Location = new System.Drawing.Point(4, 37);
            this.tDelAcct.Name = "tDelAcct";
            this.tDelAcct.Size = new System.Drawing.Size(702, 354);
            this.tDelAcct.TabIndex = 2;
            this.tDelAcct.Text = "Delete Account";
            this.tDelAcct.UseVisualStyleBackColor = true;
            // 
            // frmUserAcct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 563);
            this.Controls.Add(this.tcUserAcct);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUserAcct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserAcct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAcctClose)).EndInit();
            this.tcUserAcct.ResumeLayout(false);
            this.tcreateAcct.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox userAcctClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcUserAcct;
        private System.Windows.Forms.TabPage tcreateAcct;
        private System.Windows.Forms.TabPage tChangePass;
        private System.Windows.Forms.TabPage tDelAcct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
    }
}