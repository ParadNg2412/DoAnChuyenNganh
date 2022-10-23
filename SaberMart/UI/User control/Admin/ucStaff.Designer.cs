
namespace SaberMart.UI.User_control
{
    partial class ucStaff
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.cbGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPN = new DevExpress.XtraEditors.TextEdit();
            this.txtNames = new DevExpress.XtraEditors.TextEdit();
            this.txtIDs = new DevExpress.XtraEditors.TextEdit();
            this.txtSalery = new DevExpress.XtraEditors.TextEdit();
            this.txtNamep = new DevExpress.XtraEditors.TextEdit();
            this.txtIDp = new DevExpress.XtraEditors.TextEdit();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNames.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.btnList);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 580);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(997, 104);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function";
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColName,
            this.ColPosition,
            this.ColDate,
            this.ColGender,
            this.ColPhone,
            this.ColAddress,
            this.ColSalary});
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStaff.Location = new System.Drawing.Point(0, 223);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(997, 357);
            this.dgvStaff.TabIndex = 16;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSalery);
            this.groupBox1.Controls.Add(this.txtNamep);
            this.groupBox1.Controls.Add(this.txtIDp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Swordoflogos", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 76);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 11);
            this.label2.TabIndex = 6;
            this.label2.Text = "Position name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(634, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 11);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 11);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbGender);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPN);
            this.groupBox2.Controls.Add(this.txtNames);
            this.groupBox2.Controls.Add(this.txtIDs);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Swordoflogos", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(997, 147);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staff";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(416, 84);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(270, 28);
            this.dtpDate.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(355, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 11);
            this.label11.TabIndex = 17;
            this.label11.Text = "Date\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(733, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 11);
            this.label8.TabIndex = 9;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(520, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 11);
            this.label7.TabIndex = 7;
            this.label7.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 11);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 11);
            this.label5.TabIndex = 2;
            this.label5.Text = "Phone number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 11);
            this.label6.TabIndex = 0;
            this.label6.Text = "Staff ID";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(841, 30);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(108, 28);
            this.txtAddress.TabIndex = 10;
            // 
            // cbGender
            // 
            this.cbGender.Location = new System.Drawing.Point(603, 30);
            this.cbGender.Name = "cbGender";
            this.cbGender.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.Properties.Appearance.Options.UseFont = true;
            this.cbGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGender.Size = new System.Drawing.Size(83, 30);
            this.cbGender.TabIndex = 8;
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(168, 84);
            this.txtPN.Name = "txtPN";
            this.txtPN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPN.Properties.Appearance.Options.UseFont = true;
            this.txtPN.Size = new System.Drawing.Size(155, 28);
            this.txtPN.TabIndex = 5;
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(268, 32);
            this.txtNames.Name = "txtNames";
            this.txtNames.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNames.Properties.Appearance.Options.UseFont = true;
            this.txtNames.Size = new System.Drawing.Size(230, 28);
            this.txtNames.TabIndex = 4;
            // 
            // txtIDs
            // 
            this.txtIDs.Location = new System.Drawing.Point(104, 33);
            this.txtIDs.Name = "txtIDs";
            this.txtIDs.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDs.Properties.Appearance.Options.UseFont = true;
            this.txtIDs.Size = new System.Drawing.Size(87, 28);
            this.txtIDs.TabIndex = 3;
            // 
            // txtSalery
            // 
            this.txtSalery.Location = new System.Drawing.Point(735, 24);
            this.txtSalery.Name = "txtSalery";
            this.txtSalery.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalery.Properties.Appearance.Options.UseFont = true;
            this.txtSalery.Size = new System.Drawing.Size(137, 28);
            this.txtSalery.TabIndex = 5;
            // 
            // txtNamep
            // 
            this.txtNamep.Location = new System.Drawing.Point(416, 24);
            this.txtNamep.Name = "txtNamep";
            this.txtNamep.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamep.Properties.Appearance.Options.UseFont = true;
            this.txtNamep.Size = new System.Drawing.Size(166, 28);
            this.txtNamep.TabIndex = 4;
            // 
            // txtIDp
            // 
            this.txtIDp.Location = new System.Drawing.Point(144, 26);
            this.txtIDp.Name = "txtIDp";
            this.txtIDp.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDp.Properties.Appearance.Options.UseFont = true;
            this.txtIDp.Size = new System.Drawing.Size(87, 28);
            this.txtIDp.TabIndex = 3;
            // 
            // btnList
            // 
            this.btnList.Appearance.BackColor = System.Drawing.Color.Coral;
            this.btnList.Appearance.Font = new System.Drawing.Font("Swordoflogos", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Appearance.Options.UseBackColor = true;
            this.btnList.Appearance.Options.UseFont = true;
            this.btnList.AppearanceHovered.BackColor = System.Drawing.Color.DarkOrange;
            this.btnList.AppearanceHovered.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.AppearanceHovered.Options.UseBackColor = true;
            this.btnList.AppearanceHovered.Options.UseFont = true;
            this.btnList.AppearancePressed.BackColor = System.Drawing.Color.DarkOrange;
            this.btnList.AppearancePressed.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.AppearancePressed.Options.UseBackColor = true;
            this.btnList.AppearancePressed.Options.UseFont = true;
            this.btnList.ImageOptions.Image = global::SaberMart.Properties.Resources.print;
            this.btnList.Location = new System.Drawing.Point(625, 33);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(171, 39);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "Show list";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.BackColor = System.Drawing.Color.Coral;
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Swordoflogos", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseBackColor = true;
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.AppearanceHovered.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.AppearanceHovered.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.AppearanceHovered.Options.UseBackColor = true;
            this.btnSearch.AppearanceHovered.Options.UseFont = true;
            this.btnSearch.AppearancePressed.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.AppearancePressed.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.AppearancePressed.Options.UseBackColor = true;
            this.btnSearch.AppearancePressed.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = global::SaberMart.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(830, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 39);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Swordoflogos", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseBackColor = true;
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.AppearanceDisabled.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.AppearanceDisabled.Options.UseBackColor = true;
            this.btnEdit.AppearanceHovered.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.AppearanceHovered.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.AppearanceHovered.Options.UseBackColor = true;
            this.btnEdit.AppearanceHovered.Options.UseFont = true;
            this.btnEdit.AppearancePressed.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.AppearancePressed.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.AppearancePressed.Options.UseBackColor = true;
            this.btnEdit.AppearancePressed.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = global::SaberMart.Properties.Resources.edit_32x32;
            this.btnEdit.Location = new System.Drawing.Point(357, 33);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 39);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Gold;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Swordoflogos", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.AppearanceHovered.BackColor = System.Drawing.Color.Yellow;
            this.btnDelete.AppearanceHovered.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.AppearanceHovered.Options.UseBackColor = true;
            this.btnDelete.AppearanceHovered.Options.UseFont = true;
            this.btnDelete.AppearancePressed.BackColor = System.Drawing.Color.Gold;
            this.btnDelete.AppearancePressed.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.AppearancePressed.Options.UseBackColor = true;
            this.btnDelete.AppearancePressed.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = global::SaberMart.Properties.Resources.delete_32x32;
            this.btnDelete.Location = new System.Drawing.Point(164, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 39);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Swordoflogos", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.AppearanceHovered.BackColor = System.Drawing.Color.Yellow;
            this.btnAdd.AppearanceHovered.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdd.AppearanceHovered.Options.UseFont = true;
            this.btnAdd.AppearancePressed.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.AppearancePressed.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.AppearancePressed.Options.UseBackColor = true;
            this.btnAdd.AppearancePressed.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = global::SaberMart.Properties.Resources.add_32x32;
            this.btnAdd.Location = new System.Drawing.Point(25, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "Staff ID";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 125;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 125;
            // 
            // ColPosition
            // 
            this.ColPosition.HeaderText = "Position";
            this.ColPosition.MinimumWidth = 6;
            this.ColPosition.Name = "ColPosition";
            this.ColPosition.ReadOnly = true;
            this.ColPosition.Width = 125;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Born Date";
            this.ColDate.MinimumWidth = 6;
            this.ColDate.Name = "ColDate";
            this.ColDate.Width = 125;
            // 
            // ColGender
            // 
            this.ColGender.HeaderText = "Gender";
            this.ColGender.MinimumWidth = 6;
            this.ColGender.Name = "ColGender";
            this.ColGender.Width = 125;
            // 
            // ColPhone
            // 
            this.ColPhone.HeaderText = "Phone number";
            this.ColPhone.MinimumWidth = 6;
            this.ColPhone.Name = "ColPhone";
            this.ColPhone.Width = 125;
            // 
            // ColAddress
            // 
            this.ColAddress.HeaderText = "Address";
            this.ColAddress.MinimumWidth = 6;
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.Width = 125;
            // 
            // ColSalary
            // 
            this.ColSalary.HeaderText = "Salary";
            this.ColSalary.MinimumWidth = 6;
            this.ColSalary.Name = "ColSalary";
            this.ColSalary.ReadOnly = true;
            this.ColSalary.Width = 125;
            // 
            // ucStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.groupBox3);
            this.Name = "ucStaff";
            this.Size = new System.Drawing.Size(997, 684);
            this.Load += new System.EventHandler(this.ucStaff_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNames.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDp.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtSalery;
        private DevExpress.XtraEditors.TextEdit txtNamep;
        private DevExpress.XtraEditors.TextEdit txtIDp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.ComboBoxEdit cbGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtPN;
        private DevExpress.XtraEditors.TextEdit txtNames;
        private DevExpress.XtraEditors.TextEdit txtIDs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSalary;
    }
}
