
namespace CafeManagement
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUserSett = new System.Windows.Forms.Button();
            this.btnMngeBrnd = new System.Windows.Forms.Button();
            this.btnMngeCatgry = new System.Windows.Forms.Button();
            this.btnMngeProdts = new System.Windows.Forms.Button();
            this.lblSysAd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Location = new System.Drawing.Point(243, 35);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1010, 608);
            this.panelCenter.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 35);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(88)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.lblRegistrar);
            this.panel2.Controls.Add(this.btnStockIn);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnUserSett);
            this.panel2.Controls.Add(this.btnMngeBrnd);
            this.panel2.Controls.Add(this.btnMngeCatgry);
            this.panel2.Controls.Add(this.btnMngeProdts);
            this.panel2.Controls.Add(this.lblSysAd);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 554);
            this.panel2.TabIndex = 5;
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblRegistrar.ForeColor = System.Drawing.Color.Gold;
            this.lblRegistrar.Location = new System.Drawing.Point(12, 65);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(204, 41);
            this.lblRegistrar.TabIndex = 2;
            this.lblRegistrar.Text = "Registrar";
            this.lblRegistrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRegistrar.Visible = false;
            this.lblRegistrar.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStockIn.FlatAppearance.BorderSize = 0;
            this.btnStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockIn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockIn.ForeColor = System.Drawing.Color.White;
            this.btnStockIn.Image = ((System.Drawing.Image)(resources.GetObject("btnStockIn.Image")));
            this.btnStockIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockIn.Location = new System.Drawing.Point(3, 202);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(240, 61);
            this.btnStockIn.TabIndex = 13;
            this.btnStockIn.Text = "Stock                              Entry";
            this.btnStockIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockIn.UseVisualStyleBackColor = true;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 483);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(237, 68);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUserSett
            // 
            this.btnUserSett.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUserSett.FlatAppearance.BorderSize = 0;
            this.btnUserSett.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSett.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSett.ForeColor = System.Drawing.Color.White;
            this.btnUserSett.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSett.Image")));
            this.btnUserSett.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserSett.Location = new System.Drawing.Point(3, 411);
            this.btnUserSett.Name = "btnUserSett";
            this.btnUserSett.Size = new System.Drawing.Size(240, 75);
            this.btnUserSett.TabIndex = 11;
            this.btnUserSett.Text = "User                               Settings";
            this.btnUserSett.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserSett.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserSett.UseVisualStyleBackColor = true;
            this.btnUserSett.Click += new System.EventHandler(this.btnUserSett_Click);
            // 
            // btnMngeBrnd
            // 
            this.btnMngeBrnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMngeBrnd.FlatAppearance.BorderSize = 0;
            this.btnMngeBrnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngeBrnd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngeBrnd.ForeColor = System.Drawing.Color.White;
            this.btnMngeBrnd.Image = ((System.Drawing.Image)(resources.GetObject("btnMngeBrnd.Image")));
            this.btnMngeBrnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngeBrnd.Location = new System.Drawing.Point(3, 336);
            this.btnMngeBrnd.Name = "btnMngeBrnd";
            this.btnMngeBrnd.Size = new System.Drawing.Size(240, 74);
            this.btnMngeBrnd.TabIndex = 8;
            this.btnMngeBrnd.Text = "Manage                          Brand";
            this.btnMngeBrnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngeBrnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMngeBrnd.UseVisualStyleBackColor = true;
            this.btnMngeBrnd.Click += new System.EventHandler(this.btnMngeBrnd_Click);
            // 
            // btnMngeCatgry
            // 
            this.btnMngeCatgry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMngeCatgry.FlatAppearance.BorderSize = 0;
            this.btnMngeCatgry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngeCatgry.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngeCatgry.ForeColor = System.Drawing.Color.White;
            this.btnMngeCatgry.Image = ((System.Drawing.Image)(resources.GetObject("btnMngeCatgry.Image")));
            this.btnMngeCatgry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngeCatgry.Location = new System.Drawing.Point(3, 272);
            this.btnMngeCatgry.Name = "btnMngeCatgry";
            this.btnMngeCatgry.Size = new System.Drawing.Size(237, 66);
            this.btnMngeCatgry.TabIndex = 7;
            this.btnMngeCatgry.Text = "Manage                        Category";
            this.btnMngeCatgry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngeCatgry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMngeCatgry.UseVisualStyleBackColor = true;
            this.btnMngeCatgry.Click += new System.EventHandler(this.btnMngeCatgry_Click);
            // 
            // btnMngeProdts
            // 
            this.btnMngeProdts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMngeProdts.FlatAppearance.BorderSize = 0;
            this.btnMngeProdts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngeProdts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngeProdts.ForeColor = System.Drawing.Color.White;
            this.btnMngeProdts.Image = ((System.Drawing.Image)(resources.GetObject("btnMngeProdts.Image")));
            this.btnMngeProdts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngeProdts.Location = new System.Drawing.Point(3, 133);
            this.btnMngeProdts.Name = "btnMngeProdts";
            this.btnMngeProdts.Size = new System.Drawing.Size(240, 66);
            this.btnMngeProdts.TabIndex = 6;
            this.btnMngeProdts.Text = "Manage                     Products";
            this.btnMngeProdts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngeProdts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMngeProdts.UseVisualStyleBackColor = true;
            this.btnMngeProdts.Click += new System.EventHandler(this.btnMngeProdts_Click);
            // 
            // lblSysAd
            // 
            this.lblSysAd.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblSysAd.ForeColor = System.Drawing.Color.Gold;
            this.lblSysAd.Location = new System.Drawing.Point(12, 65);
            this.lblSysAd.Name = "lblSysAd";
            this.lblSysAd.Size = new System.Drawing.Size(204, 33);
            this.lblSysAd.TabIndex = 3;
            this.lblSysAd.Text = "System Admin";
            this.lblSysAd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSysAd.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(81, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 589);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCenter);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUserSett;
        private System.Windows.Forms.Button btnMngeBrnd;
        private System.Windows.Forms.Button btnMngeCatgry;
        private System.Windows.Forms.Button btnMngeProdts;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblRegistrar;
        public System.Windows.Forms.Label lblSysAd;
    }
}