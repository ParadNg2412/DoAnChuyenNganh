namespace SaberMart.UI.User_control.Admin
{
    partial class ucReceipt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paMenu = new System.Windows.Forms.Panel();
            this.btnNew1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.ColIDb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrices = new DevExpress.XtraEditors.TextEdit();
            this.cbIDb = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.standardReportDesigner2 = new DevExpress.XtraReports.UserDesigner.Native.StandardReportDesigner();
            this.btnGridView = new DevExpress.XtraEditors.SimpleButton();
            this.paMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrices.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paMenu
            // 
            this.paMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.paMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paMenu.Controls.Add(this.btnNew1);
            this.paMenu.Controls.Add(this.btnGridView);
            this.paMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paMenu.Location = new System.Drawing.Point(0, 731);
            this.paMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paMenu.Name = "paMenu";
            this.paMenu.Size = new System.Drawing.Size(1154, 87);
            this.paMenu.TabIndex = 4;
            // 
            // btnNew1
            // 
            this.btnNew1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew1.Appearance.BackColor = System.Drawing.Color.Orange;
            this.btnNew1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew1.Appearance.Options.UseBackColor = true;
            this.btnNew1.Appearance.Options.UseBorderColor = true;
            this.btnNew1.Appearance.Options.UseFont = true;
            this.btnNew1.AppearanceHovered.BackColor = System.Drawing.Color.Yellow;
            this.btnNew1.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew1.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew1.AppearanceHovered.Options.UseBackColor = true;
            this.btnNew1.AppearanceHovered.Options.UseBorderColor = true;
            this.btnNew1.AppearanceHovered.Options.UseFont = true;
            this.btnNew1.AppearancePressed.BackColor = System.Drawing.Color.Gold;
            this.btnNew1.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew1.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew1.AppearancePressed.Options.UseBackColor = true;
            this.btnNew1.AppearancePressed.Options.UseBorderColor = true;
            this.btnNew1.AppearancePressed.Options.UseFont = true;
            this.btnNew1.Location = new System.Drawing.Point(323, 14);
            this.btnNew1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew1.Name = "btnNew1";
            this.btnNew1.Size = new System.Drawing.Size(132, 58);
            this.btnNew1.TabIndex = 14;
            this.btnNew1.Text = "Làm mới";
            this.btnNew1.Click += new System.EventHandler(this.btnNew1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvReceipt);
            this.panel3.Location = new System.Drawing.Point(85, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 568);
            this.panel3.TabIndex = 5;
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIDb,
            this.ColDate,
            this.ColPrices});
            this.dgvReceipt.Location = new System.Drawing.Point(16, 17);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.ReadOnly = true;
            this.dgvReceipt.RowHeadersWidth = 51;
            this.dgvReceipt.RowTemplate.Height = 24;
            this.dgvReceipt.Size = new System.Drawing.Size(946, 532);
            this.dgvReceipt.TabIndex = 1;
            this.dgvReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceipt_CellClick);
            // 
            // ColIDb
            // 
            this.ColIDb.HeaderText = "Mã hóa đơn";
            this.ColIDb.MinimumWidth = 6;
            this.ColIDb.Name = "ColIDb";
            this.ColIDb.ReadOnly = true;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Ngày bán";
            this.ColDate.MinimumWidth = 6;
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            // 
            // ColPrices
            // 
            this.ColPrices.HeaderText = "Tổng giá";
            this.ColPrices.MinimumWidth = 6;
            this.ColPrices.Name = "ColPrices";
            this.ColPrices.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1154, 153);
            this.panel5.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.dtpYear);
            this.groupBox1.Controls.Add(this.dtpMonth);
            this.groupBox1.Controls.Add(this.dtpDay);
            this.groupBox1.Controls.Add(this.btnYear);
            this.groupBox1.Controls.Add(this.btnMonth);
            this.groupBox1.Controls.Add(this.btnDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(402, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 149);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // dtpYear
            // 
            this.dtpYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(221, 108);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(77, 28);
            this.dtpYear.TabIndex = 35;
            this.dtpYear.Value = new System.DateTime(2022, 11, 7, 0, 0, 0, 0);
            // 
            // dtpMonth
            // 
            this.dtpMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpMonth.CustomFormat = "MM/yyyy";
            this.dtpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(221, 72);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(112, 28);
            this.dtpMonth.TabIndex = 34;
            this.dtpMonth.Value = new System.DateTime(2022, 11, 7, 0, 0, 0, 0);
            // 
            // dtpDay
            // 
            this.dtpDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDay.Location = new System.Drawing.Point(221, 30);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(140, 28);
            this.dtpDay.TabIndex = 33;
            this.dtpDay.Value = new System.DateTime(2022, 11, 7, 0, 0, 0, 0);
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.Silver;
            this.btnYear.Image = global::SaberMart.Properties.Resources.cash;
            this.btnYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYear.Location = new System.Drawing.Point(26, 103);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(170, 36);
            this.btnYear.TabIndex = 32;
            this.btnYear.Text = "Theo năm";
            this.btnYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYear.UseVisualStyleBackColor = false;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.BackColor = System.Drawing.Color.Silver;
            this.btnMonth.Image = global::SaberMart.Properties.Resources.cash;
            this.btnMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonth.Location = new System.Drawing.Point(26, 64);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(170, 36);
            this.btnMonth.TabIndex = 31;
            this.btnMonth.Text = "Theo tháng";
            this.btnMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMonth.UseVisualStyleBackColor = false;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.Silver;
            this.btnDate.Image = global::SaberMart.Properties.Resources.cash;
            this.btnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDate.Location = new System.Drawing.Point(26, 24);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(170, 36);
            this.btnDate.TabIndex = 30;
            this.btnDate.Text = "Theo ngày";
            this.btnDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tổng doanh thu";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.EditValue = "0";
            this.txtTotal.Location = new System.Drawing.Point(552, 105);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(179, 32);
            this.txtTotal.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPrices);
            this.groupBox2.Controls.Add(this.cbIDb);
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 149);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tổng giá";
            // 
            // txtPrices
            // 
            this.txtPrices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrices.Location = new System.Drawing.Point(141, 100);
            this.txtPrices.Name = "txtPrices";
            this.txtPrices.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrices.Properties.Appearance.Options.UseFont = true;
            this.txtPrices.Size = new System.Drawing.Size(179, 32);
            this.txtPrices.TabIndex = 23;
            // 
            // cbIDb
            // 
            this.cbIDb.FormattingEnabled = true;
            this.cbIDb.Location = new System.Drawing.Point(141, 30);
            this.cbIDb.Name = "cbIDb";
            this.cbIDb.Size = new System.Drawing.Size(121, 30);
            this.cbIDb.TabIndex = 11;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(141, 66);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(148, 28);
            this.dtpDate.TabIndex = 10;
            this.dtpDate.Value = new System.DateTime(2022, 11, 7, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hóa đơn";
            // 
            // btnGridView
            // 
            this.btnGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGridView.Appearance.BackColor = System.Drawing.Color.Orange;
            this.btnGridView.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGridView.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGridView.Appearance.Options.UseBackColor = true;
            this.btnGridView.Appearance.Options.UseBorderColor = true;
            this.btnGridView.Appearance.Options.UseFont = true;
            this.btnGridView.AppearanceHovered.BackColor = System.Drawing.Color.Yellow;
            this.btnGridView.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGridView.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGridView.AppearanceHovered.Options.UseBackColor = true;
            this.btnGridView.AppearanceHovered.Options.UseBorderColor = true;
            this.btnGridView.AppearanceHovered.Options.UseFont = true;
            this.btnGridView.AppearancePressed.BackColor = System.Drawing.Color.Gold;
            this.btnGridView.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGridView.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGridView.AppearancePressed.Options.UseBackColor = true;
            this.btnGridView.AppearancePressed.Options.UseBorderColor = true;
            this.btnGridView.AppearancePressed.Options.UseFont = true;
            this.btnGridView.ImageOptions.Image = global::SaberMart.Properties.Resources.cash;
            this.btnGridView.Location = new System.Drawing.Point(671, 14);
            this.btnGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGridView.Name = "btnGridView";
            this.btnGridView.Size = new System.Drawing.Size(197, 58);
            this.btnGridView.TabIndex = 15;
            this.btnGridView.Text = "Xuất thống kê";
            this.btnGridView.Click += new System.EventHandler(this.btnGridView_Click);
            // 
            // ucReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.paMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucReceipt";
            this.Size = new System.Drawing.Size(1154, 818);
            this.Load += new System.EventHandler(this.ucReceipt_Load);
            this.paMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrices.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paMenu;
        private DevExpress.XtraEditors.SimpleButton btnNew1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvReceipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrices;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbIDb;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtPrices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private DevExpress.XtraReports.UserDesigner.Native.StandardReportDesigner standardReportDesigner2;
        private DevExpress.XtraEditors.SimpleButton btnGridView;
    }
}
