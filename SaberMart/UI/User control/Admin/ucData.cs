using SaberMart.UI.User_control.Admin;
using SaberMart.UI.User_control.Admin.Data;
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
    public partial class ucData : UserControl
    {
        public ucData()
        {
            InitializeComponent();
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            pData.Controls.Clear();
            ucStorage st = new ucStorage();
            st.Dock = DockStyle.Fill;
            pData.Controls.Add(st);
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            pData.Controls.Clear();
            ucBrand br = new ucBrand();
            br.Dock = DockStyle.Fill;
            pData.Controls.Add(br);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            pData.Controls.Clear();
            ucProduct pr = new ucProduct();
            pr.Dock = DockStyle.Fill;
            pData.Controls.Add(pr);
        }

        private void pdMenu_Click(object sender, EventArgs e)
        {
            pData.Controls.Clear();
        }
    }
}
