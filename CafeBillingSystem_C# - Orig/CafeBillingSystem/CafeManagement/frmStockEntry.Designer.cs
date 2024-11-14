
namespace CafeManagement
{
    partial class frmStockEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockEntry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.frmStockInClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StockEntryTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dgvStockEntry = new System.Windows.Forms.DataGridView();
            this.dtStckIn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockInBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StockHistoryTab = new System.Windows.Forms.TabPage();
            this.btnLdRecord = new System.Windows.Forms.Button();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvStockInHistory = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStckSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmStockInClose)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.StockEntryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockEntry)).BeginInit();
            this.StockHistoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockInHistory)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.frmStockInClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 35);
            this.panel1.TabIndex = 16;
            // 
            // frmStockInClose
            // 
            this.frmStockInClose.BackColor = System.Drawing.Color.Transparent;
            this.frmStockInClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmStockInClose.Image = ((System.Drawing.Image)(resources.GetObject("frmStockInClose.Image")));
            this.frmStockInClose.Location = new System.Drawing.Point(862, 0);
            this.frmStockInClose.Name = "frmStockInClose";
            this.frmStockInClose.Size = new System.Drawing.Size(36, 35);
            this.frmStockInClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmStockInClose.TabIndex = 5;
            this.frmStockInClose.TabStop = false;
            this.frmStockInClose.Click += new System.EventHandler(this.frmStockInClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock In Module";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StockEntryTab);
            this.tabControl1.Controls.Add(this.StockHistoryTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 491);
            this.tabControl1.TabIndex = 17;
            // 
            // StockEntryTab
            // 
            this.StockEntryTab.BackColor = System.Drawing.Color.White;
            this.StockEntryTab.Controls.Add(this.label6);
            this.StockEntryTab.Controls.Add(this.linkLabel1);
            this.StockEntryTab.Controls.Add(this.dgvStockEntry);
            this.StockEntryTab.Controls.Add(this.dtStckIn);
            this.StockEntryTab.Controls.Add(this.label4);
            this.StockEntryTab.Controls.Add(this.txtStockInBy);
            this.StockEntryTab.Controls.Add(this.label3);
            this.StockEntryTab.Controls.Add(this.txtRefNo);
            this.StockEntryTab.Controls.Add(this.label2);
            this.StockEntryTab.Location = new System.Drawing.Point(4, 37);
            this.StockEntryTab.Name = "StockEntryTab";
            this.StockEntryTab.Padding = new System.Windows.Forms.Padding(3);
            this.StockEntryTab.Size = new System.Drawing.Size(889, 450);
            this.StockEntryTab.TabIndex = 0;
            this.StockEntryTab.Text = "Stock Entry";
            this.StockEntryTab.Click += new System.EventHandler(this.StockEntryTab_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(7, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stock In Details";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.linkLabel1.Location = new System.Drawing.Point(362, 39);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(277, 28);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "[Click Here To Browse Product]";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dgvStockEntry
            // 
            this.dgvStockEntry.AllowUserToAddRows = false;
            this.dgvStockEntry.AllowUserToResizeColumns = false;
            this.dgvStockEntry.AllowUserToResizeRows = false;
            this.dgvStockEntry.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockEntry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockEntry.ColumnHeadersHeight = 34;
            this.dgvStockEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStockEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Delete});
            this.dgvStockEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockEntry.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockEntry.EnableHeadersVisualStyles = false;
            this.dgvStockEntry.Location = new System.Drawing.Point(7, 165);
            this.dgvStockEntry.Name = "dgvStockEntry";
            this.dgvStockEntry.RowHeadersVisible = false;
            this.dgvStockEntry.RowHeadersWidth = 62;
            this.dgvStockEntry.RowTemplate.Height = 28;
            this.dgvStockEntry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockEntry.Size = new System.Drawing.Size(879, 252);
            this.dgvStockEntry.TabIndex = 7;
            this.dgvStockEntry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockEntry_CellContentClick);
            // 
            // dtStckIn
            // 
            this.dtStckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStckIn.Location = new System.Drawing.Point(157, 121);
            this.dtStckIn.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtStckIn.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtStckIn.Name = "dtStckIn";
            this.dtStckIn.Size = new System.Drawing.Size(166, 34);
            this.dtStckIn.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stock In Date";
            // 
            // txtStockInBy
            // 
            this.txtStockInBy.Location = new System.Drawing.Point(157, 81);
            this.txtStockInBy.Name = "txtStockInBy";
            this.txtStockInBy.Size = new System.Drawing.Size(166, 34);
            this.txtStockInBy.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock In By";
            // 
            // txtRefNo
            // 
            this.txtRefNo.Location = new System.Drawing.Point(157, 39);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(166, 34);
            this.txtRefNo.TabIndex = 1;
            this.txtRefNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRefNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reference No.";
            // 
            // StockHistoryTab
            // 
            this.StockHistoryTab.Controls.Add(this.btnLdRecord);
            this.StockHistoryTab.Controls.Add(this.date2);
            this.StockHistoryTab.Controls.Add(this.date1);
            this.StockHistoryTab.Controls.Add(this.label5);
            this.StockHistoryTab.Controls.Add(this.dgvStockInHistory);
            this.StockHistoryTab.Location = new System.Drawing.Point(4, 37);
            this.StockHistoryTab.Name = "StockHistoryTab";
            this.StockHistoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.StockHistoryTab.Size = new System.Drawing.Size(889, 450);
            this.StockHistoryTab.TabIndex = 1;
            this.StockHistoryTab.Text = "Stock In History";
            this.StockHistoryTab.UseVisualStyleBackColor = true;
            this.StockHistoryTab.Click += new System.EventHandler(this.StockHistoryTab_Click);
            // 
            // btnLdRecord
            // 
            this.btnLdRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnLdRecord.FlatAppearance.BorderSize = 0;
            this.btnLdRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLdRecord.ForeColor = System.Drawing.Color.White;
            this.btnLdRecord.Location = new System.Drawing.Point(459, 4);
            this.btnLdRecord.Name = "btnLdRecord";
            this.btnLdRecord.Size = new System.Drawing.Size(178, 37);
            this.btnLdRecord.TabIndex = 30;
            this.btnLdRecord.Text = "Load Record";
            this.btnLdRecord.UseVisualStyleBackColor = false;
            this.btnLdRecord.Click += new System.EventHandler(this.btnLdRecord_Click);
            // 
            // date2
            // 
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(296, 3);
            this.date2.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.date2.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(157, 34);
            this.date2.TabIndex = 11;
            // 
            // date1
            // 
            this.date1.CustomFormat = "YYYY-MM-DD";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(139, 3);
            this.date1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.date1.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(151, 34);
            this.date1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Filter By Date";
            // 
            // dgvStockInHistory
            // 
            this.dgvStockInHistory.AllowUserToAddRows = false;
            this.dgvStockInHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockInHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockInHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStockInHistory.ColumnHeadersHeight = 34;
            this.dgvStockInHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStockInHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockInHistory.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStockInHistory.EnableHeadersVisualStyles = false;
            this.dgvStockInHistory.Location = new System.Drawing.Point(6, 153);
            this.dgvStockInHistory.Name = "dgvStockInHistory";
            this.dgvStockInHistory.RowHeadersVisible = false;
            this.dgvStockInHistory.RowHeadersWidth = 62;
            this.dgvStockInHistory.RowTemplate.Height = 28;
            this.dgvStockInHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockInHistory.Size = new System.Drawing.Size(880, 253);
            this.dgvStockInHistory.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 59;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "REF #";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 96;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "PCODE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 108;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "DESCRIPTION";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 82;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "STOCK IN BY";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 157;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "STOCK IN DATE";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 182;
            // 
            // btnStckSave
            // 
            this.btnStckSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnStckSave.FlatAppearance.BorderSize = 0;
            this.btnStckSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStckSave.ForeColor = System.Drawing.Color.White;
            this.btnStckSave.Location = new System.Drawing.Point(11, 3);
            this.btnStckSave.Name = "btnStckSave";
            this.btnStckSave.Size = new System.Drawing.Size(78, 37);
            this.btnStckSave.TabIndex = 29;
            this.btnStckSave.Text = "Save";
            this.btnStckSave.UseVisualStyleBackColor = false;
            this.btnStckSave.Click += new System.EventHandler(this.btnStckSave_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnStckSave);
            this.panel3.Location = new System.Drawing.Point(1, 493);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1099, 50);
            this.panel3.TabIndex = 30;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 59;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "REF #";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 96;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "PCODE";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 108;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "DESCRIPTION";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "QTY";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 82;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "STOCK IN BY";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 157;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "STOCK IN DATE";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 182;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 73;
            // 
            // frmStockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(898, 543);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStockEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmStockInClose)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.StockEntryTab.ResumeLayout(false);
            this.StockEntryTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockEntry)).EndInit();
            this.StockHistoryTab.ResumeLayout(false);
            this.StockHistoryTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockInHistory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox frmStockInClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StockEntryTab;
        private System.Windows.Forms.TabPage StockHistoryTab;
        public System.Windows.Forms.Button btnStckSave;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnLdRecord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvStockInHistory;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DateTimePicker dtStckIn;
        public System.Windows.Forms.TextBox txtStockInBy;
        public System.Windows.Forms.TextBox txtRefNo;
        public System.Windows.Forms.DateTimePicker date2;
        public System.Windows.Forms.DateTimePicker date1;
        public System.Windows.Forms.DataGridView dgvStockEntry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}