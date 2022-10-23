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

namespace SaberMart.UI.User_control.Admin
{
    public partial class ucAccount : UserControl
    {
        EntityDB context = new EntityDB();

        public ucAccount()
        {
            InitializeComponent();
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
            dgvStaff.Rows.Clear();
            foreach (var item in lstS)
            {
                int index = dgvStaff.Rows.Add();
                dgvStaff.Rows[index].Cells[0].Value = item.TenNV;
                dgvStaff.Rows[index].Cells[1].Value = item.LoaiTK;
                dgvStaff.Rows[index].Cells[2].Value = item.Username;
                dgvStaff.Rows[index].Cells[3].Value = item.MatKhau;
            }
        }

        private void ucAccount_Load(object sender, EventArgs e)
        {
            List<NHANVIEN> nv = context.NHANVIENs.ToList();
            loadGridView(nv);
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStaff.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvStaff.CurrentCell.Selected = true;
                    txtIDs.Text = dgvStaff.Rows[e.RowIndex].Cells["ColName"].FormattedValue.ToString();
                    txtAcc.Text = dgvStaff.Rows[e.RowIndex].Cells["ColAccount"].FormattedValue.ToString();
                    txtUsername.Text = dgvStaff.Rows[e.RowIndex].Cells["ColUsername"].FormattedValue.ToString();
                    txtPassword.Text = dgvStaff.Rows[e.RowIndex].Cells["ColPassword"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIDs.Text == "" || txtAcc.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter full information!", "Notification!", MessageBoxButtons.OK);
            }
            try
            {
                if (checkS(txtIDs.Text) != null)
                {
                    MessageBox.Show("Staff already exist!", "Notification", MessageBoxButtons.OK);
                }
                else
                {
                    NHANVIEN addnv = new NHANVIEN()
                    {
                        MaNV = txtIDs.Text,
                        LoaiTK = txtAcc.Text,
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
            if (checkS(txtIDs.Text) == null)
            {
                MessageBox.Show("Account cannot be found!", "Notification!", MessageBoxButtons.OK);
            }
            else
            {
                NHANVIEN delnv = context.NHANVIENs.FirstOrDefault(p => p.MaNV == txtIDs.Text);
                if (delnv != null)
                {
                    if (MessageBox.Show("Do you want to remove?", "Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.NHANVIENs.Remove(delnv);
                        context.SaveChanges();
                        MessageBox.Show("Remove successfull!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<NHANVIEN> lstS = context.NHANVIENs.ToList();
                        loadGridView(lstS);
                    }
                }
                else
                {
                    MessageBox.Show("Account cannot be found!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtIDs.Text == "" || txtAcc.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter full information!", "Notification!", MessageBoxButtons.OK);
            }
            else
            {
                NHANVIEN Uptk = context.NHANVIENs.FirstOrDefault(p => p.MaNV == txtIDs.Text);
                if (Uptk != null)
                {
                    Uptk.MaNV = txtIDs.Text;
                    Uptk.LoaiTK = txtAcc.Text;
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
            if (checkA(txtAcc.Text) == null)
            {
                MessageBox.Show("Account cannot be found!", "Notification!", MessageBoxButtons.OK);
            }
            else
            {
                NHANVIEN srchtk = context.NHANVIENs.FirstOrDefault(p => p.LoaiTK == txtAcc.Text);
                if(srchtk != null)
                {
                    List<NHANVIEN> lstS = context.NHANVIENs.Where(p => p.LoaiTK == txtAcc.Text).ToList();
                    loadGridView(lstS);
                }
                else
                {
                    MessageBox.Show("Account cannot be found!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
