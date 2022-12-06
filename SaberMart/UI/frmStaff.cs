using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using SaberMart.UI.User_control.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaberMart.UI
{
    public partial class frmStaff : DevExpress.XtraEditors.XtraForm
    {
        public frmStaff()
        {
            InitializeComponent();
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

        private void btnBill_Click(object sender, EventArgs e)
        {
            pStaff.Controls.Clear();
            ucBill2 bill2 = new ucBill2();
            bill2.Dock = DockStyle.Fill;
            pStaff.Controls.Add(bill2);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            pStaff.Controls.Clear();
            ucProduct2 product2 = new ucProduct2();
            product2.Dock = DockStyle.Fill;
            pStaff.Controls.Add(product2);
        }

        private void paMenu_Click(object sender, EventArgs e)
        {
            pStaff.Controls.Clear();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

        }
    }
}