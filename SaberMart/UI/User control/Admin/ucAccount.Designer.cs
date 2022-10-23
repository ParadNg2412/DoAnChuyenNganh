
namespace SaberMart.UI.User_control.Admin
{
    partial class ucAccount
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtAcc = new DevExpress.XtraEditors.TextEdit();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIDs = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDs.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox2.Controls.Add(this.txtIDs);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.Label12);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtAcc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Swordoflogos", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(905, 147);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(375, 50);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(104, 11);
            this.Label12.TabIndex = 15;
            this.Label12.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 11);
            this.label10.TabIndex = 13;
            this.label10.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(368, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 11);
            this.label9.TabIndex = 11;
            this.label9.Text = "Account type";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btnList);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 475);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function";
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
            this.btnList.Location = new System.Drawing.Point(27, 340);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(171, 39);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "Show list";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(27, 162);
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
            this.btnDelete.Location = new System.Drawing.Point(27, 97);
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
            this.btnAdd.Location = new System.Drawing.Point(27, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(497, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Size = new System.Drawing.Size(154, 28);
            this.txtPassword.TabIndex = 16;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(148, 39);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Size = new System.Drawing.Size(154, 28);
            this.txtUsername.TabIndex = 14;
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(531, 89);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcc.Properties.Appearance.Options.UseFont = true;
            this.txtAcc.Size = new System.Drawing.Size(134, 28);
            this.txtAcc.TabIndex = 12;
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColAccount,
            this.ColUsername,
            this.ColPassword});
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvStaff.Location = new System.Drawing.Point(221, 147);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(665, 475);
            this.dgvStaff.TabIndex = 21;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 125;
            // 
            // ColAccount
            // 
            this.ColAccount.HeaderText = "Account type";
            this.ColAccount.MinimumWidth = 6;
            this.ColAccount.Name = "ColAccount";
            this.ColAccount.ReadOnly = true;
            this.ColAccount.Width = 125;
            // 
            // ColUsername
            // 
            this.ColUsername.HeaderText = "Username";
            this.ColUsername.MinimumWidth = 6;
            this.ColUsername.Name = "ColUsername";
            this.ColUsername.ReadOnly = true;
            this.ColUsername.Width = 125;
            // 
            // ColPassword
            // 
            this.ColPassword.HeaderText = "Password";
            this.ColPassword.MinimumWidth = 6;
            this.ColPassword.Name = "ColPassword";
            this.ColPassword.ReadOnly = true;
            this.ColPassword.Width = 125;
            // 
            // txtIDs
            // 
            this.txtIDs.Location = new System.Drawing.Point(134, 89);
            this.txtIDs.Name = "txtIDs";
            this.txtIDs.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDs.Properties.Appearance.Options.UseFont = true;
            this.txtIDs.Size = new System.Drawing.Size(87, 28);
            this.txtIDs.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Swordoflogos", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 11);
            this.label6.TabIndex = 19;
            this.label6.Text = "Staff ID";
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
            this.btnSearch.Location = new System.Drawing.Point(27, 405);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 39);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ucAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "ucAccount";
            this.Size = new System.Drawing.Size(905, 622);
            this.Load += new System.EventHandler(this.ucAccount_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDs.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private System.Windows.Forms.Label Label12;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtAcc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPassword;
        private DevExpress.XtraEditors.TextEdit txtIDs;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}
