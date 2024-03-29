﻿using SaberMart.EntityData;
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

namespace SaberMart.UI.User_control.Admin.Data
{
    public partial class ucStorage : UserControl
    {
        EntityDB context = new EntityDB();

        public ucStorage()
        {
            InitializeComponent();
        }

        public void loadCompany(List<NHACUNGCAP> lstC)
        {
            cbIDc.DataSource = lstC;
            cbIDc.DisplayMember = "MaNCC";
            cbIDc.ValueMember = "MaNCC";
        }

        public void loadDetail(List<PHIEUNHAP> lstBD)
        {
            cbIDb.DataSource = lstBD;
            cbIDb.DisplayMember = "MaPN";
            cbIDb.ValueMember = "MaPN";
        }

        public void loadStaff(List<NHANVIEN> lstS)
        {
            cbIDs.DataSource = lstS;
            cbIDs.DisplayMember = "MaNV";
            cbIDs.ValueMember = "MaNV";
        }

        private string checkB(string ID)
        {
            List<CHITIETPHIEUNHAP> lstBD = context.CHITIETPHIEUNHAPs.ToList();
            foreach (var ck in lstBD)
            {
                if (ID.Equals(ck.MaPN))
                {
                    return ck.MaPN;
                }
            }
            return null;
        }

        private string checkP(string ID)
        {
            List<CHITIETPHIEUNHAP> lstP = context.CHITIETPHIEUNHAPs.ToList();
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
                dgvProduct.Rows[index].Cells[3].Value = item.GiaNhap;
            }
        }

        private void loadGridPN(List<PHIEUNHAP> lstB)
        {
            dgvBill.Rows.Clear();
            foreach (var item in lstB)
            {
                int index = dgvBill.Rows.Add();
                dgvBill.Rows[index].Cells[0].Value = item.MaPN;
                dgvBill.Rows[index].Cells[1].Value = item.NHANVIEN.TenNV;
                dgvBill.Rows[index].Cells[2].Value = item.NHACUNGCAP.TenNCC;
                dgvBill.Rows[index].Cells[3].Value = item.NgayNhap;
                dgvBill.Rows[index].Cells[4].Value = item.TongTienNhap;
            }
        }

        private void loadGridCTPN(List<CHITIETPHIEUNHAP> lstBD)
        {
            dgvDetail.Rows.Clear();
            foreach (var item in lstBD)
            {
                int index = dgvDetail.Rows.Add();
                dgvDetail.Rows[index].Cells[0].Value = item.MaPN;
                dgvDetail.Rows[index].Cells[1].Value = item.SANPHAM.TenSP;
                dgvDetail.Rows[index].Cells[2].Value = item.SLNhap;
                dgvDetail.Rows[index].Cells[3].Value = item.DonGiaNhap;
                dgvDetail.Rows[index].Cells[4].Value = item.ThanhTienNhap;
            }
        }

        private void Clear()
        {
            txtIDb.Text = string.Empty;
            cbIDs.Text = string.Empty;
            txtNames.Text = string.Empty;
            cbIDc.Text = string.Empty;
            txtNamec.Text = string.Empty;
            dtpDate.Text = string.Empty;
            cbIDb.Text = string.Empty;
            txtTotal.Text = "0";
            txtSales.Text = "0";
            txtPrices.Text = "0";
            txtValue.Text = "0";
        }

        private void ucStorage_Load(object sender, EventArgs e)
        {
            List<SANPHAM> lstP = context.SANPHAMs.ToList();
            List<PHIEUNHAP> lstB = context.PHIEUNHAPs.ToList();
            List<NHACUNGCAP> lstC = context.NHACUNGCAPs.ToList();
            List<NHANVIEN> lstS = context.NHANVIENs.ToList();
            loadGridPN(lstB);
            loadDetail(lstB);
            loadCompany(lstC);
            loadStaff(lstS);
            loadGridSP(lstP);
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvBill.CurrentCell.Selected = true;
                    txtIDb.Text = dgvBill.Rows[e.RowIndex].Cells["ColIDb"].FormattedValue.ToString();
                    txtNames.Text = dgvBill.Rows[e.RowIndex].Cells["ColStaff"].FormattedValue.ToString();
                    txtNamec.Text = dgvBill.Rows[e.RowIndex].Cells["ColCompany"].FormattedValue.ToString();
                    dtpDate.Text = dgvBill.Rows[e.RowIndex].Cells["ColDate"].FormattedValue.ToString();
                    txtTotal.Text = dgvBill.Rows[e.RowIndex].Cells["ColTotal"].FormattedValue.ToString();
                    List<CHITIETPHIEUNHAP> lstB = context.CHITIETPHIEUNHAPs.Where(p => p.MaPN == cbIDb.Text).ToList();
                    loadGridCTPN(lstB);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    var item = context.SANPHAMs.FirstOrDefault(p => p.TenSP == txtNamep.Text);
                    byte[] arr = item.PicSP;
                    MemoryStream ms = new MemoryStream(arr);
                    picProduct.Image = Image.FromStream(ms);
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
                    txtIDb.Text = cbIDb.Text = dgvDetail.Rows[e.RowIndex].Cells["ColIDbd"].FormattedValue.ToString();
                    txtNamep.Text = dgvDetail.Rows[e.RowIndex].Cells["ColProduct"].FormattedValue.ToString();
                    txtValue.Text = dgvDetail.Rows[e.RowIndex].Cells["ColValue"].FormattedValue.ToString();
                    txtSales.Text = dgvDetail.Rows[e.RowIndex].Cells["ColSales"].FormattedValue.ToString();
                    txtPrices.Text = dgvDetail.Rows[e.RowIndex].Cells["ColPrices"].FormattedValue.ToString();
                    var item = context.SANPHAMs.FirstOrDefault(p => p.TenSP == txtNamep.Text);
                    byte[] arr = item.PicSP;
                    MemoryStream ms = new MemoryStream(arr);
                    picProduct.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIDb.Text == "" || cbIDs.Text == "" || cbIDc.Text == "" || dtpDate.Text == "")
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
                    PHIEUNHAP pn = new PHIEUNHAP()
                    {
                        MaPN = txtIDb.Text,
                        MaNCC = cbIDc.Text,
                        MaNV = cbIDs.Text,
                        NgayNhap = dtpDate.Value
                    };
                    context.PHIEUNHAPs.Add(pn);
                    context.SaveChanges();
                    List<PHIEUNHAP> lstB = context.PHIEUNHAPs.ToList();
                    loadGridPN(lstB);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CHITIETPHIEUNHAP BD = context.CHITIETPHIEUNHAPs.FirstOrDefault(p => p.MaPN == txtIDb.Text);
            if (BD != null)
            {
                MessageBox.Show("Hãy xóa chi tiết phiếu nhập trước khi xóa phiếu nhập!", "Thông Báo");
            }
            else
            {
                PHIEUNHAP pn = context.PHIEUNHAPs.FirstOrDefault(p => p.MaPN == txtIDb.Text);
                context.PHIEUNHAPs.Remove(pn);
                context.SaveChanges();
                MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<PHIEUNHAP> lstB = context.PHIEUNHAPs.ToList();
                loadGridPN(lstB);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtIDb.Text == "" || cbIDs.Text == "" || cbIDc.Text == "" || dtpDate.Text == "" || txtTotal.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                PHIEUNHAP PN = context.PHIEUNHAPs.FirstOrDefault(p => p.MaPN == txtIDb.Text);
                if (PN != null)
                {
                    PN.MaPN = txtIDb.Text;
                    PN.MaNV = cbIDs.Text;
                    PN.MaNCC = cbIDc.Text;
                    PN.NgayNhap = dtpDate.Value;
                    PN.TongTienNhap = int.Parse(txtTotal.Text);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Phiếu nhập đã tồn tại!", "Thông báo!", MessageBoxButtons.OK);
                }
                List<PHIEUNHAP> lstB = context.PHIEUNHAPs.ToList();
                loadGridPN(lstB);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            List<PHIEUNHAP> lst = context.PHIEUNHAPs.ToList();
            loadGridPN(lst);
            dgvBill.Rows.Clear();
            Clear();
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
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

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if (txtNamep.Text == "" || txtValue.Text == "" || txtSales.Text == "" || txtPrices.Text == "" ||
                cbIDb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                if (checkB(txtIDp.Text) != null)
                {
                    MessageBox.Show("Phiếu nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    CHITIETPHIEUNHAP BD = new CHITIETPHIEUNHAP()
                    {
                        MaPN = cbIDb.Text,
                        MaSP = txtIDp.Text,
                        SLNhap = Convert.ToInt32(txtValue.Text),
                        DonGiaNhap = Convert.ToInt32(txtSales.Text),
                        ThanhTienNhap = Convert.ToInt32(txtPrices.Text)
                    };
                    context.CHITIETPHIEUNHAPs.Add(BD);
                    context.SaveChanges();
                    List<CHITIETPHIEUNHAP> lstBD = context.CHITIETPHIEUNHAPs.ToList();
                    loadGridCTPN(lstBD);
                }

            }
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (checkB(cbIDb.Text) == null)
            {
                MessageBox.Show("Không tìm thấy phiếu nhập!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                CHITIETPHIEUNHAP BD = context.CHITIETPHIEUNHAPs.FirstOrDefault(p => p.MaPN == cbIDb.Text);
                if (BD != null)
                {
                    if (MessageBox.Show("Bạn muốn xóa phiếu nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.CHITIETPHIEUNHAPs.Remove(BD);
                        context.SaveChanges();
                        MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<CHITIETPHIEUNHAP> lstBD = context.CHITIETPHIEUNHAPs.ToList();
                        loadGridCTPN(lstBD);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập!", "Thông báo!", MessageBoxButtons.OK);
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
            List<CHITIETPHIEUNHAP> lst = context.CHITIETPHIEUNHAPs.ToList();
            loadGridCTPN(lst);
            dgvDetail.Rows.Clear();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dgvDetail.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvDetail.Rows[i].Cells[4].Value);
            }
            txtTotal.Text = sum.ToString();

            PHIEUNHAP listHD = context.PHIEUNHAPs.FirstOrDefault(p => p.MaPN == txtIDb.Text);
            if (listHD != null)
            {
                listHD.TongTienNhap = Convert.ToInt32(txtTotal.Text);
            }
        }

        private void btnList1_Click(object sender, EventArgs e)
        {
            List<CHITIETPHIEUNHAP> lstBD = context.CHITIETPHIEUNHAPs.ToList();
            loadGridCTPN(lstBD);
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            if (checkB(cbIDb.Text) == null)
            {
                MessageBox.Show("Không tìm thấy phiếu nhập!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                CHITIETPHIEUNHAP srchhd = context.CHITIETPHIEUNHAPs.FirstOrDefault(p => p.MaPN == cbIDb.Text);
                if (srchhd != null)
                {
                    List<CHITIETPHIEUNHAP> lstB = context.CHITIETPHIEUNHAPs.Where(p => p.MaPN == cbIDb.Text).ToList();
                    loadGridCTPN(lstB);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<PHIEUNHAP> lstB = context.PHIEUNHAPs.ToList();
            loadGridPN(lstB);
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            if (checkB(txtIDb.Text) == null)
            {
                MessageBox.Show("Không tìm thấy phiếu nhập!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                PHIEUNHAP srchhd = context.PHIEUNHAPs.FirstOrDefault(p => p.MaPN == txtIDb.Text);
                if (srchhd != null)
                {
                    List<PHIEUNHAP> lstB = context.PHIEUNHAPs.Where(p => p.MaPN == txtIDb.Text).ToList();
                    loadGridPN(lstB);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
