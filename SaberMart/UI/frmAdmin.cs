﻿using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using SaberMart.EntityData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaberMart.UI.User_control.Admin;

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
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogin flogin = new frmLogin();
                this.Hide();
                flogin.ShowDialog();
            }           
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            pAdmin.Controls.Clear();
            ucData data = new ucData();
            data.Dock = DockStyle.Fill;
            pAdmin.Controls.Add(data);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pAdmin.Controls.Clear();
            ucAccount account = new ucAccount();
            account.Dock = DockStyle.Fill;
            pAdmin.Controls.Add(account);
        }

        private void paMenu_Click(object sender, EventArgs e)
        {
            pAdmin.Controls.Clear();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            pAdmin.Controls.Clear();
            ucBill bill = new ucBill();
            bill.Dock = DockStyle.Fill;
            pAdmin.Controls.Add(bill);
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            pAdmin.Controls.Clear();
            ucReceipt receipt = new ucReceipt();
            receipt.Dock = DockStyle.Fill;
            pAdmin.Controls.Add(receipt);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pAdmin.Controls.Clear();
            ucReport report = new ucReport();
            report.Dock = DockStyle.Fill;
            pAdmin.Controls.Add(report);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pAdmin.Controls.Clear();
            ucCustomer customer = new ucCustomer();
            customer.Dock = DockStyle.Fill;
            pAdmin.Controls.Add(customer);
        }
    }
}
