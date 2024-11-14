
namespace CafeManagement
{
    partial class frmManageProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProdList = new System.Windows.Forms.DataGridView();
            this.ProdListClose = new System.Windows.Forms.PictureBox();
            this.ProdListAdd = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdListEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colProdListDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdListClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdListAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUCT LIST";
            // 
            // dgvProdList
            // 
            this.dgvProdList.AllowUserToAddRows = false;
            this.dgvProdList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvProdList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdList.ColumnHeadersHeight = 34;
            this.dgvProdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.colProdListEdit,
            this.colProdListDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdList.EnableHeadersVisualStyles = false;
            this.dgvProdList.Location = new System.Drawing.Point(0, 37);
            this.dgvProdList.Name = "dgvProdList";
            this.dgvProdList.RowHeadersVisible = false;
            this.dgvProdList.RowHeadersWidth = 62;
            this.dgvProdList.RowTemplate.Height = 28;
            this.dgvProdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdList.Size = new System.Drawing.Size(900, 526);
            this.dgvProdList.TabIndex = 2;
            this.dgvProdList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdList_CellContentClick);
            // 
            // ProdListClose
            // 
            this.ProdListClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProdListClose.Image = ((System.Drawing.Image)(resources.GetObject("ProdListClose.Image")));
            this.ProdListClose.Location = new System.Drawing.Point(861, 1);
            this.ProdListClose.Name = "ProdListClose";
            this.ProdListClose.Size = new System.Drawing.Size(36, 35);
            this.ProdListClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProdListClose.TabIndex = 3;
            this.ProdListClose.TabStop = false;
            this.ProdListClose.Click += new System.EventHandler(this.ProdListClose_Click);
            // 
            // ProdListAdd
            // 
            this.ProdListAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProdListAdd.Image = ((System.Drawing.Image)(resources.GetObject("ProdListAdd.Image")));
            this.ProdListAdd.Location = new System.Drawing.Point(818, 1);
            this.ProdListAdd.Name = "ProdListAdd";
            this.ProdListAdd.Size = new System.Drawing.Size(39, 35);
            this.ProdListAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProdListAdd.TabIndex = 4;
            this.ProdListAdd.TabStop = false;
            this.ProdListAdd.Click += new System.EventHandler(this.ProdListAdd_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 59;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "PCODE";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 108;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "BARCODE";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 133;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "DESCRIPTION";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "BRAND";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 112;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "CATEGORY";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 143;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "PRICE";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 97;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "QTY";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 82;
            // 
            // colProdListEdit
            // 
            this.colProdListEdit.HeaderText = "";
            this.colProdListEdit.Image = ((System.Drawing.Image)(resources.GetObject("colProdListEdit.Image")));
            this.colProdListEdit.MinimumWidth = 8;
            this.colProdListEdit.Name = "colProdListEdit";
            this.colProdListEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colProdListEdit.Width = 20;
            // 
            // colProdListDelete
            // 
            this.colProdListDelete.HeaderText = "";
            this.colProdListDelete.Image = ((System.Drawing.Image)(resources.GetObject("colProdListDelete.Image")));
            this.colProdListDelete.MinimumWidth = 8;
            this.colProdListDelete.Name = "colProdListDelete";
            this.colProdListDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colProdListDelete.Width = 20;
            // 
            // frmManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.ControlBox = false;
            this.Controls.Add(this.ProdListAdd);
            this.Controls.Add(this.ProdListClose);
            this.Controls.Add(this.dgvProdList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdListClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdListAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ProdListClose;
        private System.Windows.Forms.PictureBox ProdListAdd;
        public System.Windows.Forms.DataGridView dgvProdList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn colProdListEdit;
        private System.Windows.Forms.DataGridViewImageColumn colProdListDelete;
    }
}