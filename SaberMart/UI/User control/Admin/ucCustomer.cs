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
    public partial class ucCustomer : UserControl
    {
        EntityDB context = new EntityDB();

        public ucCustomer()
        {
            InitializeComponent();
        }

        private string checkC(string ID)
        {
            List<KHACHHANG> lstS = context.KHACHHANGs.ToList();
            foreach (var ck in lstS)
            {
                if (ID.Equals(ck.MaKH))
                {
                    return ck.MaKH;
                }
            }
            return null;
        }

        private void loadGridView(List<KHACHHANG> lstC)
        {
            dgvCustomer.Rows.Clear();
            foreach (var item in lstC)
            {
                int index = dgvCustomer.Rows.Add();
                dgvCustomer.Rows[index].Cells[0].Value = item.MaKH;
                dgvCustomer.Rows[index].Cells[1].Value = item.TenKH;
                dgvCustomer.Rows[index].Cells[2].Value = item.NgaySinh;
                dgvCustomer.Rows[index].Cells[3].Value = item.GioiTinh;
                dgvCustomer.Rows[index].Cells[4].Value = item.SDT;
                dgvCustomer.Rows[index].Cells[5].Value = item.DiaChi;
                dgvCustomer.Rows[index].Cells[6].Value = item.DiemTichLuy;
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvCustomer.CurrentCell.Selected = true;
                    txtIDc.Text = dgvCustomer.Rows[e.RowIndex].Cells["ColID"].FormattedValue.ToString();
                    txtNamec.Text = dgvCustomer.Rows[e.RowIndex].Cells["ColName"].FormattedValue.ToString();
                    dtpDate.Text = dgvCustomer.Rows[e.RowIndex].Cells["ColDate"].FormattedValue.ToString();
                    cbGender.Text = dgvCustomer.Rows[e.RowIndex].Cells["ColGender"].FormattedValue.ToString();
                    txtPN.Text = dgvCustomer.Rows[e.RowIndex].Cells["ColPhone"].FormattedValue.ToString();
                    txtAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells["ColAddress"].FormattedValue.ToString();
                    txtPoint.Text = dgvCustomer.Rows[e.RowIndex].Cells["ColPoint"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void ucCustomer_Load(object sender, EventArgs e)
        {
            List<KHACHHANG> kh = context.KHACHHANGs.ToList();
            loadGridView(kh);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIDc.Text == "" || txtNamec.Text == "" || dtpDate.Text == "" || cbGender.SelectedItem == null ||
                txtPN.Text == "" || txtAddress.Text == "" || txtPoint.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            try
            {
                if (checkC(txtIDc.Text) != null)
                {
                    MessageBox.Show("Khách hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    KHACHHANG addkh = new KHACHHANG()
                    {
                        MaKH = txtIDc.Text,
                        TenKH = txtNamec.Text,
                        NgaySinh = dtpDate.Value,
                        GioiTinh = cbGender.Text,
                        SDT = txtPN.Text,
                        DiaChi = txtAddress.Text,
                        DiemTichLuy = int.Parse(txtPoint.Text)
                    };
                    context.KHACHHANGs.Add(addkh);
                    context.SaveChanges();
                    List<KHACHHANG> lstC = context.KHACHHANGs.ToList();
                    loadGridView(lstC);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkC(txtIDc.Text) == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                KHACHHANG delkh = context.KHACHHANGs.FirstOrDefault(p => p.MaKH == txtIDc.Text);
                if (delkh != null)
                {
                    if (MessageBox.Show("Bạn muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.KHACHHANGs.Remove(delkh);
                        context.SaveChanges();
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<KHACHHANG> lstC = context.KHACHHANGs.ToList();
                        loadGridView(lstC);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtIDc.Text == "" || txtNamec.Text == "" || dtpDate.Text == "" || cbGender.SelectedItem == null ||
                txtPN.Text == "" || txtAddress.Text == "" || txtPoint.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                KHACHHANG Upkh = context.KHACHHANGs.FirstOrDefault(p => p.MaKH == txtIDc.Text);
                if (Upkh != null)
                {
                    Upkh.MaKH = txtIDc.Text;
                    Upkh.TenKH = txtNamec.Text;
                    Upkh.GioiTinh = cbGender.Text;
                    Upkh.NgaySinh = dtpDate.Value;
                    Upkh.SDT = txtPN.Text;
                    Upkh.DiaChi = txtAddress.Text;
                    Upkh.DiemTichLuy = int.Parse(txtPoint.Text);
                    context.SaveChanges();
                }
                List<KHACHHANG> lstKH = context.KHACHHANGs.ToList();
                loadGridView(lstKH);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<KHACHHANG> lstC = context.KHACHHANGs.ToList();
            loadGridView(lstC);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkC(txtIDc.Text) == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                KHACHHANG srchkh = context.KHACHHANGs.FirstOrDefault(p => p.MaKH == txtIDc.Text);
                if (srchkh != null)
                {
                    List<KHACHHANG> lstC = context.KHACHHANGs.Where(p => p.MaKH == txtIDc.Text).ToList();
                    loadGridView(lstC);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }   
}
