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

namespace SaberMart.UI.User_control
{
    public partial class ucStaff : UserControl
    {
        EntityDB context = new EntityDB();

        public ucStaff()
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

        private void loadGridView(List<NHANVIEN> lstS)
        {
            dgvStaff.Rows.Clear();
            foreach (var item in lstS)
            {
                int index = dgvStaff.Rows.Add();
                dgvStaff.Rows[index].Cells[0].Value = item.MaNV;
                dgvStaff.Rows[index].Cells[1].Value = item.TenNV;
                dgvStaff.Rows[index].Cells[2].Value = item.CHUCVU.TenCV;
                dgvStaff.Rows[index].Cells[3].Value = item.NgaySinh;
                dgvStaff.Rows[index].Cells[4].Value = item.GioiTinh;
                dgvStaff.Rows[index].Cells[5].Value = item.SDT;
                dgvStaff.Rows[index].Cells[6].Value = item.DiaChi;
                dgvStaff.Rows[index].Cells[7].Value = item.CHUCVU.Luong;
            }
        }

        private void ucStaff_Load(object sender, EventArgs e)
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
                    txtIDs.Text = dgvStaff.Rows[e.RowIndex].Cells["ColID"].FormattedValue.ToString();
                    txtNames.Text = dgvStaff.Rows[e.RowIndex].Cells["ColName"].FormattedValue.ToString();
                    txtNamep.Text = dgvStaff.Rows[e.RowIndex].Cells["ColPositon"].FormattedValue.ToString();
                    dtpDate.Text = dgvStaff.Rows[e.RowIndex].Cells["ColDate"].FormattedValue.ToString();
                    cbGender.Text = dgvStaff.Rows[e.RowIndex].Cells["ColGender"].FormattedValue.ToString();
                    txtPN.Text = dgvStaff.Rows[e.RowIndex].Cells["ColPhone"].FormattedValue.ToString();
                    txtAddress.Text = dgvStaff.Rows[e.RowIndex].Cells["ColAddress"].FormattedValue.ToString();
                    txtSalery.Text = dgvStaff.Rows[e.RowIndex].Cells["ColSalery"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIDp.Text == "" || txtNamep.Text == "" || txtSalery.Text == "" ||
                txtIDs.Text == "" || txtNames.Text == "" || dtpDate.Text == "" || 
                cbGender.Text == "" || txtPN.Text == "" || txtAddress.Text == "")
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
                        MaCV = txtIDp.Text,
                        TenNV = txtNames.Text,
                        NgaySinh = dtpDate.Value,
                        GioiTinh = cbGender.Text,
                        SDT = txtPN.Text,
                        DiaChi = txtAddress.Text,
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtIDp.Text == "" || txtNamep.Text == "" || txtSalery.Text == "" ||
                txtIDs.Text == "" || txtNames.Text == "" || cbGender.Text == "" || 
                dtpDate.Text == "" || txtPN.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please enter full information!", "Notification!", MessageBoxButtons.OK);
            }
            else
            {
                NHANVIEN Upnv = context.NHANVIENs.FirstOrDefault(p => p.MaNV == txtIDs.Text);
                if (Upnv != null)
                {
                    Upnv.CHUCVU.MaCV = Upnv.MaCV = txtIDp.Text;
                    Upnv.CHUCVU.TenCV = txtNamep.Text;
                    Upnv.CHUCVU.Luong = int.Parse(txtSalery.Text);
                    Upnv.MaNV = txtIDs.Text;
                    Upnv.TenNV = txtNames.Text;
                    Upnv.GioiTinh = cbGender.Text;
                    Upnv.NgaySinh = dtpDate.Value;
                    Upnv.SDT = txtPN.Text;
                    context.SaveChanges();
                }
                List<NHANVIEN> lstNV = context.NHANVIENs.ToList();
                loadGridView(lstNV);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkS(txtIDs.Text) == null)
            {
                MessageBox.Show("Staff cannot be found!", "Notification!", MessageBoxButtons.OK);
            }
            else
            {
                NHANVIEN delnv = context.NHANVIENs.FirstOrDefault(p => p.MaNV == txtIDs.Text);
                if(delnv != null)
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
                    MessageBox.Show("Staff cannot be found!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<NHANVIEN> lstS = context.NHANVIENs.ToList();
            loadGridView(lstS);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(checkS(txtIDs.Text) == null)
            {
                MessageBox.Show("Staff cannot be found!", "Notification!", MessageBoxButtons.OK);
            }
            else
            {
                NHANVIEN srchnv = context.NHANVIENs.FirstOrDefault(p => p.MaNV == txtIDs.Text);
                if (srchnv != null)
                {
                    List<NHANVIEN> lstS = context.NHANVIENs.Where(p => p.MaNV == txtIDs.Text).ToList();
                    loadGridView(lstS);
                }
                else
                {
                    MessageBox.Show("Staff cannot be found!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
