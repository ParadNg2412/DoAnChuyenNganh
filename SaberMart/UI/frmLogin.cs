using DevExpress.XtraEditors;
using SaberMart.DataEntity;
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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private string valueText;
        EntityDB context = new EntityDB();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void pHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                pShow.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void pShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                pHide.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (context.NHANVIENs.Where(p => p.Username == txtUsername.Text && p.MatKhau == txtPassword.Text && p.LoaiTK == "Admin").Count() > 0)
                {
                    MessageBox.Show("Admin: Login successfull!", "Notification", MessageBoxButtons.OK);
                    frmAdmin fAdmin = new frmAdmin();
                    valueText = txtUsername.Text;
                    this.Hide();
                    fAdmin.ShowDialog();
                    return;
                }
                //if (context.NHANVIENs.Where(p => p.Username == txtUsername.Text && p.MatKhau == txtPassword.Text && p.LoaiTK == "Nhân viên").Count() > 0)
                //{
                //    MessageBox.Show("Employee: Login successfull!", "Notification!", MessageBoxButtons.OK);
                //    frmMain1 fMain = new frmMain1();
                //    valueText = txtUserName.Text;
                //    this.Hide();
                //    fMain.ShowDialog();
                //}
                else
                {
                    MessageBox.Show("Login failed!", "Notification", MessageBoxButtons.OK);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GoToNextCtrl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);          
            }
        }
    }
}