using DevExpress.Text.Interop;
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

namespace SaberMart.UI.User_control.Admin
{
    public partial class ucAccount : UserControl
    {
        EntityDB context = new EntityDB();

        public ucAccount()
        {
            InitializeComponent();
        }

        public void loadAccount(List<NHANVIEN> lstS)
        {
            cbIDs.DataSource = lstS;
            cbIDs.DisplayMember = "MaNV";
            cbIDs.ValueMember = "MaNV";
        }

        private string checkS(string ID)
        {
            List<NHANVIEN> lstS = context.NHANVIENs.ToList();
            foreach (var ck in lstS)
            {
                if (ID.Equals(ck.MaNV))
                {
                    return ck.MaNV;
                }
            }
            return null;
        }

        private string checkA(string ID)
        {
            List<NHANVIEN> lstS = context.NHANVIENs.ToList();
            foreach (var ck in lstS)
            {
                if (ID.Equals(ck.LoaiTK))
                {
                    return ck.LoaiTK;
                }
            }
            return null;
        }

        private void loadGridView(List<NHANVIEN> lstS)
        {
            dgvAccount.Rows.Clear();
            foreach (var item in lstS)
            {
                int index = dgvAccount.Rows.Add();
                dgvAccount.Rows[index].Cells[0].Value = item.MaNV;
                dgvAccount.Rows[index].Cells[1].Value = item.TenNV;
                dgvAccount.Rows[index].Cells[2].Value = item.LoaiTK;
                dgvAccount.Rows[index].Cells[3].Value = item.Username;
                dgvAccount.Rows[index].Cells[4].Value = item.MatKhau;
            }
        }

        private void ucAccount_Load(object sender, EventArgs e)
        {
            List<NHANVIEN> nv = context.NHANVIENs.ToList();
            loadGridView(nv);
            loadAccount(nv);
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAccount.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvAccount.CurrentCell.Selected = true;
                    cbIDs.SelectedItem = dgvAccount.Rows[e.RowIndex].Cells["ColID"].FormattedValue.ToString();
                    txtNames.Text = dgvAccount.Rows[e.RowIndex].Cells["ColName"].FormattedValue.ToString();
                    cbAcc.Text = dgvAccount.Rows[e.RowIndex].Cells["ColAccount"].FormattedValue.ToString();
                    txtUsername.Text = dgvAccount.Rows[e.RowIndex].Cells["ColUsername"].FormattedValue.ToString();
                    txtPassword.Text = dgvAccount.Rows[e.RowIndex].Cells["ColPassword"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbIDs.SelectedItem == null || txtNames.Text == "" || cbAcc.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter full information!", "Notification!", MessageBoxButtons.OK);
            }
            try
            {
                if (checkS(txtNames.Text) != null)
                {
                    MessageBox.Show("Account already exist!", "Notification", MessageBoxButtons.OK);
                }
                else
                {
                    NHANVIEN addnv = new NHANVIEN()
                    {
                        MaNV= cbIDs.Text,
                        TenNV = txtNames.Text,
                        LoaiTK = cbAcc.Text,
                        Username = txtUsername.Text,
                        MatKhau = txtPassword.Text
                    };
                    context.NHANVIENs.Add(addnv);
                    context.SaveChanges();
                    List<NHANVIEN> lstS = context.NHANVIENs.ToList();
                    loadGridView(lstS);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkS(txtNames.Text) == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                NHANVIEN delnv = context.NHANVIENs.FirstOrDefault(p => p.MaNV == txtNames.Text);
                if (delnv != null)
                {
                    if (MessageBox.Show("Bạn muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.NHANVIENs.Remove(delnv);
                        context.SaveChanges();
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<NHANVIEN> lstS = context.NHANVIENs.ToList();
                        loadGridView(lstS);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cbIDs.SelectedItem == null || txtNames.Text == "" || cbAcc.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                NHANVIEN Uptk = context.NHANVIENs.FirstOrDefault(p => p.MaNV == txtNames.Text);
                if (Uptk != null)
                {
                    Uptk.MaNV = cbIDs.Text;
                    Uptk.TenNV = txtNames.Text;
                    Uptk.LoaiTK = cbAcc.Text;
                    Uptk.Username = txtUsername.Text;
                    Uptk.MatKhau = txtPassword.Text;
                    context.SaveChanges();
                }
                List<NHANVIEN> lstNV = context.NHANVIENs.ToList();
                loadGridView(lstNV);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<NHANVIEN> lstS = context.NHANVIENs.ToList();
            loadGridView(lstS);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkA(cbAcc.Text) == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                NHANVIEN srchtk = context.NHANVIENs.FirstOrDefault(p => p.LoaiTK == cbAcc.Text);
                if(srchtk != null)
                {
                    List<NHANVIEN> lstS = context.NHANVIENs.Where(p => p.LoaiTK == cbAcc.Text).ToList();
                    loadGridView(lstS);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
