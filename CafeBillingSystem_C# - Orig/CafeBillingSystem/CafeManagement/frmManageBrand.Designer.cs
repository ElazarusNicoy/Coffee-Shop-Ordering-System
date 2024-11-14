
namespace CafeManagement
{
    partial class frmManageBrand
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageBrand));
            this.dgvBrandList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.frmBrnLstAdd = new System.Windows.Forms.PictureBox();
            this.frmBrnLstClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrandList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmBrnLstAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmBrnLstClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBrandList
            // 
            this.dgvBrandList.AllowUserToAddRows = false;
            this.dgvBrandList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvBrandList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBrandList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrandList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBrandList.ColumnHeadersHeight = 30;
            this.dgvBrandList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBrandList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBrandList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBrandList.EnableHeadersVisualStyles = false;
            this.dgvBrandList.Location = new System.Drawing.Point(0, 34);
            this.dgvBrandList.Name = "dgvBrandList";
            this.dgvBrandList.RowHeadersVisible = false;
            this.dgvBrandList.RowHeadersWidth = 62;
            this.dgvBrandList.RowTemplate.Height = 28;
            this.dgvBrandList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrandList.Size = new System.Drawing.Size(903, 529);
            this.dgvBrandList.TabIndex = 4;
            this.dgvBrandList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrandList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 59;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Visible = false;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "BRAND";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Width = 8;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Width = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.frmBrnLstAdd);
            this.panel1.Controls.Add(this.frmBrnLstClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 35);
            this.panel1.TabIndex = 3;
            // 
            // frmBrnLstAdd
            // 
            this.frmBrnLstAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmBrnLstAdd.Image = ((System.Drawing.Image)(resources.GetObject("frmBrnLstAdd.Image")));
            this.frmBrnLstAdd.Location = new System.Drawing.Point(824, 0);
            this.frmBrnLstAdd.Name = "frmBrnLstAdd";
            this.frmBrnLstAdd.Size = new System.Drawing.Size(39, 35);
            this.frmBrnLstAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmBrnLstAdd.TabIndex = 4;
            this.frmBrnLstAdd.TabStop = false;
            this.frmBrnLstAdd.Click += new System.EventHandler(this.frmBrnLstAdd_Click);
            // 
            // frmBrnLstClose
            // 
            this.frmBrnLstClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmBrnLstClose.Image = ((System.Drawing.Image)(resources.GetObject("frmBrnLstClose.Image")));
            this.frmBrnLstClose.Location = new System.Drawing.Point(867, 0);
            this.frmBrnLstClose.Name = "frmBrnLstClose";
            this.frmBrnLstClose.Size = new System.Drawing.Size(36, 35);
            this.frmBrnLstClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmBrnLstClose.TabIndex = 3;
            this.frmBrnLstClose.TabStop = false;
            this.frmBrnLstClose.Click += new System.EventHandler(this.frmBrnLstClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "BRAND LIST";
            // 
            // frmManageBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 563);
            this.Controls.Add(this.dgvBrandList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmManageBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrandList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmBrnLstAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmBrnLstClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBrandList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox frmBrnLstAdd;
        private System.Windows.Forms.PictureBox frmBrnLstClose;
        private System.Windows.Forms.Label label1;
    }
}