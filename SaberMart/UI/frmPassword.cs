using DevExpress.Utils.Html.Internal;
using DevExpress.XtraEditors;
using SaberMart.EntityData;
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
    public partial class frmPassword : DevExpress.XtraEditors.XtraForm
    {
        EntityDB context = new EntityDB();
        private string valueText;

        public frmPassword()
        {
            InitializeComponent();
        }

        private void pShow_Click(object sender, EventArgs e)
        {
            if (txtPasswordn.PasswordChar == '\0')
            {
                pHide.BringToFront();
                txtPasswordn.PasswordChar = '*';
            }
        }

        private void pHide_Click(object sender, EventArgs e)
        {
            if (txtPasswordn.PasswordChar == '*')
            {
                pShow.BringToFront();
                txtPasswordn.PasswordChar = '\0';
            }
        }

        private void pShow2_Click(object sender, EventArgs e)
        {
            if (txtPasswordre.PasswordChar == '\0')
            {
                pHide.BringToFront();
                txtPasswordre.PasswordChar = '*';
            }
        }

        private void pHide2_Click(object sender, EventArgs e)
        {
            if (txtPasswordre.PasswordChar == '*')
            {
                pShow.BringToFront();
                txtPasswordre.PasswordChar = '\0';
            }
        }

        private string checkP (string ID)
        {
            List<NHANVIEN> lstP = context.NHANVIENs.ToList();
            return null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (context.NHANVIENs.Where(p => p.Username == txtUsername.Text && p.MatKhau == txtPasswordn.Text && p.MatKhau == txtPasswordre.Text).Count() > 0)
            {
                MessageBox.Show("Password changes successfull!", "Notification", MessageBoxButtons.OK);
                frmLogin flog = new frmLogin();
                valueText = txtPasswordn.Text;
                this.Hide();
                flog.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("Password changes failed!", "Notification", MessageBoxButtons.OK);
                txtPasswordn.Clear();
                txtPasswordre.Clear();
                txtUsername.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin flog = new frmLogin();
            this.Hide();
            flog.ShowDialog();
        }
    }
}