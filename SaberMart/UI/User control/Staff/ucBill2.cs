using SaberMart.EntityData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaberMart.UI.User_control.Staff
{
    public partial class ucBill2 : UserControl
    {
        EntityDB context = new EntityDB();

        public ucBill2()
        {
            InitializeComponent();
        }

        public void loadCustomer(List<KHACHHANG> lstC)
        {
            cbIDc.DataSource = lstC;
            cbIDc.DisplayMember = "MaKH";
            cbIDc.ValueMember = "MaKH";
        }

        public void loadDetail(List<CHITIETHOADON> lstBD)
        {
            cbIDb.DataSource = lstBD;
            cbIDb.DisplayMember = "MaHD";
            cbIDb.ValueMember = "MaHD";
        }

        private string checkS(string Name)
        {
            List<NHANVIEN> lstS = context.NHANVIENs.ToList();
            foreach (var item in lstS)
            {
                if (Name == item.Username)
                {
                    return item.MaNV;
                }
            }
            return null;
        }

        private string checkB(string ID)
        {
            List<CHITIETHOADON> lstBD = context.CHITIETHOADONs.ToList();
            foreach (var ck in lstBD)
            {
                if (ID.Equals(ck.MaHD))
                {
                    return ck.MaHD;
                }
            }
            return null;
        }

        private string checkP(string ID)
        {
            List<CHITIETHOADON> lstP = context.CHITIETHOADONs.ToList();
            foreach (var ck in lstP)
            {
                if (ID.Equals(ck.MaSP))
                {
                    return ck.MaSP;
                }
            }
            return null;
        }

        private void loadGridSP(List<SANPHAM> lstP)
        {
            dgvProduct.Rows.Clear();
            foreach (var item in lstP)
            {
                int index = dgvProduct.Rows.Add();
                dgvProduct.Rows[index].Cells[0].Value = item.MaSP;
                dgvProduct.Rows[index].Cells[1].Value = item.TenSP;
                dgvProduct.Rows[index].Cells[2].Value = item.DonViTinh;
                dgvProduct.Rows[index].Cells[3].Value = item.GiaBan;
            }
        }

        private void loadGridHD(List<HOADON> lstB)
        {
            dgvBill.Rows.Clear();
            foreach (var item in lstB)
            {
                int index = dgvBill.Rows.Add();
                dgvBill.Rows[index].Cells[0].Value = item.MaHD;
                dgvBill.Rows[index].Cells[1].Value = item.NHANVIEN.TenNV;
                dgvBill.Rows[index].Cells[2].Value = item.KHACHHANG.TenKH;
                dgvBill.Rows[index].Cells[3].Value = item.NgayBan;
                dgvBill.Rows[index].Cells[4].Value = item.TongTienBan;
            }
        }

        private void loadGridCTHD(List<CHITIETHOADON> lstBD)
        {
            dgvDetail.Rows.Clear();
            foreach (var item in lstBD)
            {
                int index = dgvDetail.Rows.Add();
                dgvDetail.Rows[index].Cells[0].Value = item.MaHD;
                dgvDetail.Rows[index].Cells[1].Value = item.SANPHAM.TenSP;
                dgvDetail.Rows[index].Cells[2].Value = item.SANPHAM.DonViTinh;
                dgvDetail.Rows[index].Cells[3].Value = item.SLBan;
                dgvDetail.Rows[index].Cells[4].Value = item.DonGiaBan;
                dgvDetail.Rows[index].Cells[5].Value = item.ThanhTienBan;
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvProduct.CurrentCell.Selected = true;
                    txtIDp.Text = dgvProduct.Rows[e.RowIndex].Cells["ColIDp"].FormattedValue.ToString();
                    txtNamep.Text = dgvProduct.Rows[e.RowIndex].Cells["ColNamep"].FormattedValue.ToString();
                    txtType.Text = dgvProduct.Rows[e.RowIndex].Cells["ColType"].FormattedValue.ToString();
                    txtSales.Text = dgvProduct.Rows[e.RowIndex].Cells["ColSale"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvBill.CurrentCell.Selected = true;
                    txtIDb.Text = cbIDb.Text = dgvBill.Rows[e.RowIndex].Cells["ColIDb"].FormattedValue.ToString();
                    txtIDs.Text = dgvBill.Rows[e.RowIndex].Cells["ColStaff"].FormattedValue.ToString();
                    cbIDc.Text = dgvBill.Rows[e.RowIndex].Cells["ColCustomer"].FormattedValue.ToString();
                    dtpDate.Text = dgvBill.Rows[e.RowIndex].Cells["ColDate"].FormattedValue.ToString();
                    txtTotal.Text = dgvBill.Rows[e.RowIndex].Cells["ColTotal"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDetail.CurrentCell.Selected = true;
                    txtIDb.Text = dgvDetail.Rows[e.RowIndex].Cells["ColIDbd"].FormattedValue.ToString();
                    txtNamep.Text = dgvDetail.Rows[e.RowIndex].Cells["ColProduct"].FormattedValue.ToString();
                    txtType.Text = dgvDetail.Rows[e.RowIndex].Cells["ColType2"].FormattedValue.ToString();
                    txtValue.Text = dgvDetail.Rows[e.RowIndex].Cells["ColValue"].FormattedValue.ToString();
                    txtSales.Text = dgvDetail.Rows[e.RowIndex].Cells["ColSales"].FormattedValue.ToString();
                    txtPrices.Text = dgvDetail.Rows[e.RowIndex].Cells["ColPrices"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ucBill2_Load(object sender, EventArgs e)
        {
            string temp = checkS(frmLogin.valueText);
            List<SANPHAM> lstP = context.SANPHAMs.ToList();
            List<HOADON> lstB = context.HOADONs.ToList();
            List<KHACHHANG> lstC = context.KHACHHANGs.ToList();
            List<CHITIETHOADON> lstBD = context.CHITIETHOADONs.ToList();
            loadGridHD(lstB);
            loadCustomer(lstC);
            loadGridSP(lstP);
            loadGridCTHD(lstBD);
            loadDetail(lstBD);
            txtIDs.Text = temp;
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if (txtNamep.Text == "" || dtpDate.Text == "" || txtValue.Text == "" || txtSales.Text == "" || txtPrices.Text == "" ||
                cbIDb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                if (checkB(txtIDp.Text) != null)
                {
                    MessageBox.Show("Hóa đơn đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    CHITIETHOADON BD = new CHITIETHOADON()
                    {
                        MaHD = cbIDb.Text,
                        MaSP = txtIDp.Text,
                        SLBan = Convert.ToInt32(txtValue.Text),
                        DonGiaBan = Convert.ToInt32(txtSales.Text),
                        ThanhTienBan = Convert.ToInt32(txtPrices.Text)
                    };
                    context.CHITIETHOADONs.Add(BD);
                    context.SaveChanges();
                    List<CHITIETHOADON> lstBD = context.CHITIETHOADONs.ToList();
                    loadGridCTHD(lstBD);
                }
            }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnNew1_Click(object sender, EventArgs e)
        {
            List<CHITIETHOADON> lst = context.CHITIETHOADONs.ToList();
            loadGridCTHD(lst);
            dgvDetail.Rows.Clear();
        }

        private void btnList1_Click(object sender, EventArgs e)
        {
            List<CHITIETHOADON> lstBD = context.CHITIETHOADONs.ToList();
            loadGridCTHD(lstBD);
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            if (checkB(cbIDb.Text) == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                CHITIETHOADON srchhd = context.CHITIETHOADONs.FirstOrDefault(p => p.MaHD == cbIDb.Text);
                if (srchhd != null)
                {
                    List<CHITIETHOADON> lstB = context.CHITIETHOADONs.Where(p => p.MaHD == cbIDb.Text).ToList();
                    loadGridCTHD(lstB);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIDb.Text == "" || txtIDs.Text == "" || cbIDc.Text == "" || dtpDate.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                if (checkB(txtIDb.Text) != null)
                {
                    MessageBox.Show("Hóa đơn đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    HOADON hd = new HOADON()
                    {
                        MaHD = txtIDb.Text,
                        MaKH = cbIDc.Text,
                        MaNV = txtIDs.Text,
                        NgayBan = dtpDate.Value
                    };
                    context.HOADONs.Add(hd);
                    context.SaveChanges();
                    List<HOADON> lstB = context.HOADONs.ToList();
                    loadGridHD(lstB);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtIDb.Text == "" || txtIDs.Text == "" || cbIDc.Text == "" || dtpDate.Text == "" || txtTotal.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                HOADON HD = context.HOADONs.FirstOrDefault(p => p.MaHD == txtIDb.Text);
                if (HD != null)
                {
                    HD.MaHD = txtIDb.Text;
                    HD.MaNV = txtIDs.Text;
                    HD.MaKH = cbIDc.Text;
                    HD.NgayBan = dtpDate.Value;
                    HD.TongTienBan = int.Parse(txtTotal.Text);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Hóa đơn đã tồn tại!", "Thông báo!", MessageBoxButtons.OK);
                }
                List<HOADON> lstB = context.HOADONs.ToList();
                loadGridHD(lstB);
            }
        }

        int Prices()
        {
            int prices = 0;
            int value = int.Parse(txtValue.Text);
            int sales = int.Parse(txtSales.Text);
            prices += value * sales;
            txtPrices.Text = prices.ToString();
            return prices;
        }

        private void btnPrices_Click(object sender, EventArgs e)
        {
            int price = Prices();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dgvDetail.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvDetail.Rows[i].Cells[5].Value);
            }
            txtTotal.Text = sum.ToString();

            HOADON listHD = context.HOADONs.FirstOrDefault(p => p.MaHD == txtIDb.Text);
            if (listHD != null)
            {
                listHD.TongTienBan = Convert.ToInt32(txtTotal.Text);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<HOADON> lstB = context.HOADONs.ToList();
            loadGridHD(lstB);
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            if (checkB(txtIDb.Text) == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                HOADON srchhd = context.HOADONs.FirstOrDefault(p => p.MaHD == txtIDb.Text);
                if (srchhd != null)
                {
                    List<HOADON> lstB = context.HOADONs.Where(p => p.MaHD == txtIDb.Text).ToList();
                    loadGridHD(lstB);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            List<HOADON> lst = context.HOADONs.ToList();
            loadGridHD(lst);
            dgvBill.Rows.Clear();
        }
    }
}
