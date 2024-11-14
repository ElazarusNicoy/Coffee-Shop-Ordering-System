
namespace CafeManagement
{
    partial class frmCategoryModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoryModule));
            this.lblCID = new System.Windows.Forms.Label();
            this.btnCCancel = new System.Windows.Forms.Button();
            this.btnCUpdate = new System.Windows.Forms.Button();
            this.btnCSave = new System.Windows.Forms.Button();
            this.txtBox_catgryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.frmCatgryClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmCatgryClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Location = new System.Drawing.Point(389, 84);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(0, 28);
            this.lblCID.TabIndex = 21;
            this.lblCID.Visible = false;
            // 
            // btnCCancel
            // 
            this.btnCCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCCancel.FlatAppearance.BorderSize = 0;
            this.btnCCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCCancel.Location = new System.Drawing.Point(304, 82);
            this.btnCCancel.Name = "btnCCancel";
            this.btnCCancel.Size = new System.Drawing.Size(79, 33);
            this.btnCCancel.TabIndex = 20;
            this.btnCCancel.Text = "Cancel";
            this.btnCCancel.UseVisualStyleBackColor = false;
            this.btnCCancel.Click += new System.EventHandler(this.btnCCancel_Click);
            // 
            // btnCUpdate
            // 
            this.btnCUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnCUpdate.FlatAppearance.BorderSize = 0;
            this.btnCUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCUpdate.ForeColor = System.Drawing.Color.White;
            this.btnCUpdate.Location = new System.Drawing.Point(213, 82);
            this.btnCUpdate.Name = "btnCUpdate";
            this.btnCUpdate.Size = new System.Drawing.Size(85, 33);
            this.btnCUpdate.TabIndex = 19;
            this.btnCUpdate.Text = "Update";
            this.btnCUpdate.UseVisualStyleBackColor = false;
            this.btnCUpdate.Click += new System.EventHandler(this.btnCUpdate_Click);
            // 
            // btnCSave
            // 
            this.btnCSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnCSave.FlatAppearance.BorderSize = 0;
            this.btnCSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSave.ForeColor = System.Drawing.Color.White;
            this.btnCSave.Location = new System.Drawing.Point(134, 82);
            this.btnCSave.Name = "btnCSave";
            this.btnCSave.Size = new System.Drawing.Size(73, 33);
            this.btnCSave.TabIndex = 18;
            this.btnCSave.Text = "Save";
            this.btnCSave.UseVisualStyleBackColor = false;
            this.btnCSave.Click += new System.EventHandler(this.btnCSave_Click);
            // 
            // txtBox_catgryName
            // 
            this.txtBox_catgryName.Location = new System.Drawing.Point(177, 36);
            this.txtBox_catgryName.Name = "txtBox_catgryName";
            this.txtBox_catgryName.Size = new System.Drawing.Size(376, 34);
            this.txtBox_catgryName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Category Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.frmCatgryClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 35);
            this.panel1.TabIndex = 15;
            // 
            // frmCatgryClose
            // 
            this.frmCatgryClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmCatgryClose.Image = ((System.Drawing.Image)(resources.GetObject("frmCatgryClose.Image")));
            this.frmCatgryClose.Location = new System.Drawing.Point(533, 0);
            this.frmCatgryClose.Name = "frmCatgryClose";
            this.frmCatgryClose.Size = new System.Drawing.Size(36, 35);
            this.frmCatgryClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmCatgryClose.TabIndex = 5;
            this.frmCatgryClose.TabStop = false;
            this.frmCatgryClose.Click += new System.EventHandler(this.frmCatgryClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category Module";
            // 
            // frmCategoryModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 120);
            this.ControlBox = false;
            this.Controls.Add(this.lblCID);
            this.Controls.Add(this.btnCCancel);
            this.Controls.Add(this.btnCUpdate);
            this.Controls.Add(this.btnCSave);
            this.Controls.Add(this.txtBox_catgryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCategoryModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmCatgryClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.Button btnCCancel;
        public System.Windows.Forms.Button btnCUpdate;
        public System.Windows.Forms.Button btnCSave;
        public System.Windows.Forms.TextBox txtBox_catgryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox frmCatgryClose;
        private System.Windows.Forms.Label label1;
    }
}