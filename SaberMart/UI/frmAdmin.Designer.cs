
namespace SaberMart.UI
{
    partial class frmAdmin
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
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.employeesNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.employeesLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.customersLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem3 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbiCustomer = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem6 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem7 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbiPos = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbiEmployee = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.employeesNavigationPage.SuspendLayout();
            this.customersNavigationPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tileBar.MaxId = 17;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 135);
            this.tileBar.MinimumSize = new System.Drawing.Size(117, 135);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(34, 14, 34, 14);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(1161, 135);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.tbiPos);
            this.tileBarGroupTables.Items.Add(this.tbiEmployee);
            this.tileBarGroupTables.Items.Add(this.tbiCustomer);
            this.tileBarGroupTables.Items.Add(this.tileBarItem6);
            this.tileBarGroupTables.Items.Add(this.tileBarItem7);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "QUẢN LÝ";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.employeesNavigationPage);
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 135);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.employeesNavigationPage,
            this.customersNavigationPage});
            this.navigationFrame.SelectedPage = this.employeesNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(1161, 555);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // employeesNavigationPage
            // 
            this.employeesNavigationPage.Caption = "employeesNavigationPage";
            this.employeesNavigationPage.Controls.Add(this.employeesLabelControl);
            this.employeesNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeesNavigationPage.Name = "employeesNavigationPage";
            this.employeesNavigationPage.Size = new System.Drawing.Size(1161, 555);
            // 
            // employeesLabelControl
            // 
            this.employeesLabelControl.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.employeesLabelControl.Appearance.Options.UseFont = true;
            this.employeesLabelControl.Appearance.Options.UseForeColor = true;
            this.employeesLabelControl.Appearance.Options.UseTextOptions = true;
            this.employeesLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeesLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.employeesLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.employeesLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesLabelControl.Location = new System.Drawing.Point(0, 0);
            this.employeesLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeesLabelControl.Name = "employeesLabelControl";
            this.employeesLabelControl.Size = new System.Drawing.Size(1161, 555);
            this.employeesLabelControl.TabIndex = 2;
            this.employeesLabelControl.Text = "Employees";
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Caption = "customersNavigationPage";
            this.customersNavigationPage.Controls.Add(this.customersLabelControl);
            this.customersNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(1161, 555);
            // 
            // customersLabelControl
            // 
            this.customersLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.customersLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.customersLabelControl.Appearance.Options.UseFont = true;
            this.customersLabelControl.Appearance.Options.UseForeColor = true;
            this.customersLabelControl.Appearance.Options.UseTextOptions = true;
            this.customersLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customersLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.customersLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.customersLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersLabelControl.Location = new System.Drawing.Point(0, 0);
            this.customersLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersLabelControl.Name = "customersLabelControl";
            this.customersLabelControl.Size = new System.Drawing.Size(1161, 555);
            this.customersLabelControl.TabIndex = 2;
            this.customersLabelControl.Text = "Customers";
            // 
            // tileBarItem2
            // 
            this.tileBarItem2.AppearanceItem.Hovered.BackColor = System.Drawing.Color.Maroon;
            this.tileBarItem2.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileBarItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.Firebrick;
            this.tileBarItem2.AppearanceItem.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem2.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.Text = "tileBarItem1";
            this.tileBarItem2.Elements.Add(tileItemElement6);
            this.tileBarItem2.Id = 3;
            this.tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem2.Name = "tileBarItem2";
            // 
            // tileBarItem3
            // 
            this.tileBarItem3.AppearanceItem.Hovered.BackColor = System.Drawing.Color.Maroon;
            this.tileBarItem3.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileBarItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.Firebrick;
            this.tileBarItem3.AppearanceItem.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem3.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem3.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement7.Text = "tileBarItem1";
            this.tileBarItem3.Elements.Add(tileItemElement7);
            this.tileBarItem3.Id = 3;
            this.tileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem3.Name = "tileBarItem3";
            // 
            // tbiCustomer
            // 
            this.tbiCustomer.BackgroundImage = global::SaberMart.Properties.Resources.customer_32x32;
            this.tbiCustomer.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "KHÁCH HÀNG";
            this.tbiCustomer.Elements.Add(tileItemElement3);
            this.tbiCustomer.Id = 14;
            this.tbiCustomer.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiCustomer.Name = "tbiCustomer";
            // 
            // tileBarItem6
            // 
            this.tileBarItem6.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "tileBarItem6";
            this.tileBarItem6.Elements.Add(tileItemElement4);
            this.tileBarItem6.Id = 15;
            this.tileBarItem6.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem6.Name = "tileBarItem6";
            // 
            // tileBarItem7
            // 
            this.tileBarItem7.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Text = "tileBarItem7";
            this.tileBarItem7.Elements.Add(tileItemElement5);
            this.tileBarItem7.Id = 16;
            this.tileBarItem7.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem7.Name = "tileBarItem7";
            // 
            // tbiPos
            // 
            this.tbiPos.AppearanceItem.Hovered.BackColor = System.Drawing.Color.OrangeRed;
            this.tbiPos.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbiPos.AppearanceItem.Normal.BackColor = System.Drawing.Color.Firebrick;
            this.tbiPos.AppearanceItem.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbiPos.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbiPos.AppearanceItem.Normal.Options.UseFont = true;
            this.tbiPos.BackgroundImage = global::SaberMart.Properties.Resources.boposition2_32x32;
            this.tbiPos.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Text = "CHỨC VỤ";
            this.tbiPos.Elements.Add(tileItemElement1);
            this.tbiPos.Id = 12;
            this.tbiPos.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiPos.Name = "tbiPos";
            // 
            // tbiEmployee
            // 
            this.tbiEmployee.AppearanceItem.Hovered.BackColor = System.Drawing.Color.OrangeRed;
            this.tbiEmployee.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbiEmployee.AppearanceItem.Normal.BackColor = System.Drawing.Color.Firebrick;
            this.tbiEmployee.AppearanceItem.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbiEmployee.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbiEmployee.AppearanceItem.Normal.Options.UseFont = true;
            this.tbiEmployee.BackgroundImage = global::SaberMart.Properties.Resources.employee_32x32;
            this.tbiEmployee.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Text = "KHÁCH HÀNG";
            this.tbiEmployee.Elements.Add(tileItemElement2);
            this.tbiEmployee.Id = 13;
            this.tbiEmployee.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiEmployee.Name = "tbiEmployee";
            // 
            // frmAdmin
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 690);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.employeesNavigationPage.ResumeLayout(false);
            this.customersNavigationPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.NavigationPage employeesNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraEditors.LabelControl employeesLabelControl;
        private DevExpress.XtraEditors.LabelControl customersLabelControl;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem3;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiPos;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiEmployee;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiCustomer;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem6;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem7;
    }
}