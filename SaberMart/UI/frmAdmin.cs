using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using SaberMart.DataEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaberMart.UI.User_control.Admin;
using SaberMart.UI.User_control;

namespace SaberMart.UI
{
    public partial class frmAdmin : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnStaffUC_Click(object sender, EventArgs e)
        {
            pAdmin.Controls.Clear();
            ucStaff staff = new ucStaff();
            staff.Dock = DockStyle.Fill;
            pAdmin.Controls.Add(staff);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogin flogin = new frmLogin();
                this.Hide();
                flogin.ShowDialog();
            }           
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            pAdmin.Controls.Clear();
            ucProductMenu product = new ucProductMenu();
            product.Dock = DockStyle.Fill;
            pAdmin.Controls.Add(product);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pAdmin.Controls.Clear();
            ucAccount account = new ucAccount();
            account.Dock = DockStyle.Fill;
            pAdmin.Controls.Add(account);
        }
    }
}
