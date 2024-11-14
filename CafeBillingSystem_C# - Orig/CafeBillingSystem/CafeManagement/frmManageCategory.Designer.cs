
namespace CafeManagement
{
    partial class frmManageCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageCategory));
            this.dgvCategoryList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.frmCatgryLstAdd = new System.Windows.Forms.PictureBox();
            this.frmCatgryLstClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmCatgryLstAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmCatgryLstClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategoryList
            // 
            this.dgvCategoryList.AllowUserToAddRows = false;
            this.dgvCategoryList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCategoryList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCategoryList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategoryList.ColumnHeadersHeight = 30;
            this.dgvCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategoryList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategoryList.EnableHeadersVisualStyles = false;
            this.dgvCategoryList.Location = new System.Drawing.Point(0, 34);
            this.dgvCategoryList.Name = "dgvCategoryList";
            this.dgvCategoryList.RowHeadersVisible = false;
            this.dgvCategoryList.RowHeadersWidth = 62;
            this.dgvCategoryList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCategoryList.RowTemplate.Height = 28;
            this.dgvCategoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoryList.Size = new System.Drawing.Size(903, 529);
            this.dgvCategoryList.TabIndex = 6;
            this.dgvCategoryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoryList_CellContentClick);
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
            this.Column3.HeaderText = "CATEGORY";
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
            this.panel1.Controls.Add(this.frmCatgryLstAdd);
            this.panel1.Controls.Add(this.frmCatgryLstClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 35);
            this.panel1.TabIndex = 5;
            // 
            // frmCatgryLstAdd
            // 
            this.frmCatgryLstAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmCatgryLstAdd.Image = ((System.Drawing.Image)(resources.GetObject("frmCatgryLstAdd.Image")));
            this.frmCatgryLstAdd.Location = new System.Drawing.Point(824, 0);
            this.frmCatgryLstAdd.Name = "frmCatgryLstAdd";
            this.frmCatgryLstAdd.Size = new System.Drawing.Size(39, 35);
            this.frmCatgryLstAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmCatgryLstAdd.TabIndex = 4;
            this.frmCatgryLstAdd.TabStop = false;
            this.frmCatgryLstAdd.Click += new System.EventHandler(this.frmCatgryLstAdd_Click);
            // 
            // frmCatgryLstClose
            // 
            this.frmCatgryLstClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmCatgryLstClose.Image = ((System.Drawing.Image)(resources.GetObject("frmCatgryLstClose.Image")));
            this.frmCatgryLstClose.Location = new System.Drawing.Point(867, 0);
            this.frmCatgryLstClose.Name = "frmCatgryLstClose";
            this.frmCatgryLstClose.Size = new System.Drawing.Size(36, 35);
            this.frmCatgryLstClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmCatgryLstClose.TabIndex = 3;
            this.frmCatgryLstClose.TabStop = false;
            this.frmCatgryLstClose.Click += new System.EventHandler(this.frmCatgryLstClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "CATEGORY LIST";
            // 
            // frmManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 563);
            this.Controls.Add(this.dgvCategoryList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmCatgryLstAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmCatgryLstClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox frmCatgryLstAdd;
        private System.Windows.Forms.PictureBox frmCatgryLstClose;
        private System.Windows.Forms.Label label1;
    }
}