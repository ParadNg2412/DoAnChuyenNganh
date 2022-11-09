using SaberMart.UI.User_control.Admin.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaberMart.UI.User_control.Admin
{
    public partial class ucReport : UserControl
    {
        public ucReport()
        {
            InitializeComponent();
        }

        private void pMenu_Click(object sender, EventArgs e)
        {
            pControl.Controls.Clear();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            pControl.Controls.Clear();
            ucProductrp product = new ucProductrp();
            product.Dock = DockStyle.Fill;
            pControl.Controls.Add(product);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            pControl.Controls.Clear();
            ucBillrp bill = new ucBillrp();
            bill.Dock = DockStyle.Fill;
            pControl.Controls.Add(bill);
        }
    }
}
