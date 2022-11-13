
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
            this.txtIDs = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbAcc = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox2.Controls.Add(this.cbAcc);
            this.groupBox2.Controls.Add(this.txtIDs);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.Label12);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(958, 131);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tài khoản";
            // 
            // txtIDs
            // 
            this.txtIDs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtIDs.Location = new System.Drawing.Point(224, 31);
            this.txtIDs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDs.Name = "txtIDs";
            this.txtIDs.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDs.Properties.Appearance.Options.UseFont = true;
            this.txtIDs.Size = new System.Drawing.Size(293, 32);
            this.txtIDs.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mã nhân viên";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPassword.Location = new System.Drawing.Point(691, 82);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Size = new System.Drawing.Size(174, 32);
            this.txtPassword.TabIndex = 16;
            // 
            // Label12
            // 
            this.Label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(575, 84);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(97, 22);
            this.Label12.TabIndex = 15;
            this.Label12.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUsername.Location = new System.Drawing.Point(691, 31);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Size = new System.Drawing.Size(174, 32);
            this.txtUsername.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(571, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 22);
            this.label10.TabIndex = 13;
            this.label10.Text = "Username";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Loại tài khoản";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.btnList);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(0, 131);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(180, 597);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnList
            // 
            this.btnList.Appearance.BackColor = System.Drawing.Color.Coral;
            this.btnList.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Appearance.Options.UseBackColor = true;
            this.btnList.Appearance.Options.UseFont = true;
            this.btnList.AppearanceHovered.BackColor = System.Drawing.Color.DarkOrange;
            this.btnList.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.AppearanceHovered.Options.UseBackColor = true;
            this.btnList.AppearanceHovered.Options.UseFont = true;
            this.btnList.AppearancePressed.BackColor = System.Drawing.Color.DarkOrange;
            this.btnList.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.AppearancePressed.Options.UseBackColor = true;
            this.btnList.AppearancePressed.Options.UseFont = true;
            this.btnList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnList.ImageOptions.Image = global::SaberMart.Properties.Resources.print;
            this.btnList.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnList.Location = new System.Drawing.Point(3, 453);
            this.btnList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(174, 68);
            this.btnList.TabIndex = 10;
            this.btnList.Text = "Xuất danh sách";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.BackColor = System.Drawing.Color.Coral;
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseBackColor = true;
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.AppearanceHovered.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.AppearanceHovered.Options.UseBackColor = true;
            this.btnSearch.AppearanceHovered.Options.UseFont = true;
            this.btnSearch.AppearancePressed.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.AppearancePressed.Options.UseBackColor = true;
            this.btnSearch.AppearancePressed.Options.UseFont = true;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.ImageOptions.Image = global::SaberMart.Properties.Resources.search;
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(3, 521);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(174, 74);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm theo mã";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseBackColor = true;
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.AppearanceHovered.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.AppearanceHovered.Options.UseBackColor = true;
            this.btnEdit.AppearanceHovered.Options.UseFont = true;
            this.btnEdit.AppearancePressed.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.AppearancePressed.Options.UseBackColor = true;
            this.btnEdit.AppearancePressed.Options.UseFont = true;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.ImageOptions.Image = global::SaberMart.Properties.Resources.edit_32x32;
            this.btnEdit.Location = new System.Drawing.Point(3, 101);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(174, 39);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Gold;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.AppearanceHovered.BackColor = System.Drawing.Color.Yellow;
            this.btnDelete.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.AppearanceHovered.Options.UseBackColor = true;
            this.btnDelete.AppearanceHovered.Options.UseFont = true;
            this.btnDelete.AppearancePressed.BackColor = System.Drawing.Color.Gold;
            this.btnDelete.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.AppearancePressed.Options.UseBackColor = true;
            this.btnDelete.AppearancePressed.Options.UseFont = true;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.ImageOptions.Image = global::SaberMart.Properties.Resources.delete_32x32;
            this.btnDelete.Location = new System.Drawing.Point(3, 62);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 39);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.ImageOptions.Image = global::SaberMart.Properties.Resources.add_32x32;
            this.btnAdd.Location = new System.Drawing.Point(3, 23);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 39);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColAccount,
            this.ColUsername,
            this.ColPassword});
            this.dgvAccount.Location = new System.Drawing.Point(240, 169);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(688, 530);
            this.dgvAccount.TabIndex = 21;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColAccount
            // 
            this.ColAccount.HeaderText = "Account type";
            this.ColAccount.MinimumWidth = 6;
            this.ColAccount.Name = "ColAccount";
            this.ColAccount.ReadOnly = true;
            // 
            // ColUsername
            // 
            this.ColUsername.HeaderText = "Username";
            this.ColUsername.MinimumWidth = 6;
            this.ColUsername.Name = "ColUsername";
            this.ColUsername.ReadOnly = true;
            // 
            // ColPassword
            // 
            this.ColPassword.HeaderText = "Password";
            this.ColPassword.MinimumWidth = 6;
            this.ColPassword.Name = "ColPassword";
            this.ColPassword.ReadOnly = true;
            // 
            // cbAcc
            // 
            this.cbAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAcc.FormattingEnabled = true;
            this.cbAcc.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên"});
            this.cbAcc.Location = new System.Drawing.Point(240, 79);
            this.cbAcc.Name = "cbAcc";
            this.cbAcc.Size = new System.Drawing.Size(167, 33);
            this.cbAcc.TabIndex = 21;
            // 
            // ucAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucAccount";
            this.Size = new System.Drawing.Size(958, 728);
            this.Load += new System.EventHandler(this.ucAccount_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private System.Windows.Forms.Label Label12;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPassword;
        private DevExpress.XtraEditors.TextEdit txtIDs;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.ComboBox cbAcc;
    }
}
