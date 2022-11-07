using DevExpress.Office.Utils;
using Microsoft.SqlServer.Management.Smo;
using SaberMart.EntityData;
using SaberMart.UI.User_control.Admin.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Filtering.ExcelFilterOptions;

namespace SaberMart.UI.User_control.Admin
{
    public partial class ucBill : UserControl
    {
        EntityDB context = new EntityDB();
        
        public ucBill()
        {
            InitializeComponent();
        }

        public void loadCustomer (List<KHACHHANG> lstC)
        {
            cbIDc.DataSource = lstC;
            cbIDc.DisplayMember = "MaKH";
            cbIDc.ValueMember = "MaKH";
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

        private string checkB (string ID)
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

        private string checkP (string ID)
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
                dgvProduct.Rows[index].Cells[2].Value = item.GiaBan;
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
                dgvDetail.Rows[index].Cells[2].Value = item.SLBan;
                dgvDetail.Rows[index].Cells[3].Value = item.DonGiaBan;
                dgvDetail.Rows[index].Cells[4].Value = item.ThanhTienBan;
            }
        }

        private void ucBill_Load(object sender, EventArgs e)
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
            txtIDs.Text = temp;
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvBill.CurrentCell.Selected = true;
                    txtIDb.Text = dgvBill.Rows[e.RowIndex].Cells["ColIDb"].FormattedValue.ToString();
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

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvProduct.CurrentCell.Selected = true;
                    txtIDp.Text = dgvProduct.Rows[e.RowIndex].Cells["ColIDp"].FormattedValue.ToString();
                    txtNamep.Text = dgvProduct.Rows[e.RowIndex].Cells["ColNamep"].FormattedValue.ToString();
                    txtSales.Text = dgvProduct.Rows[e.RowIndex].Cells["ColSale"].FormattedValue.ToString();
                    var item = context.SANPHAMs.FirstOrDefault(p => p.MaSP == txtIDp.Text);
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
                    txtIDb2.Text = dgvDetail.Rows[e.RowIndex].Cells["ColIDbd"].FormattedValue.ToString();
                    txtNamep.Text = dgvDetail.Rows[e.RowIndex].Cells["ColProduct"].FormattedValue.ToString();
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

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if(txtNamep.Text == "" || txtValue.Text == "" || txtSales.Text == "" || txtPrices.Text == "" ||
                txtIDb2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                if(checkB(txtIDp.Text) != null)
                {
                    MessageBox.Show("Hóa đơn đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    CHITIETHOADON BD = new CHITIETHOADON()
                    {
                        MaHD = txtIDb2.Text,
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
            
            //if(lstHD != null)
            //{
            //    lstHD.TongTienBan = Convert.ToInt32(txtTotal.Text);
            //}
            
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (checkB(txtIDb2.Text) == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                CHITIETHOADON BD = context.CHITIETHOADONs.FirstOrDefault(p => p.MaHD == txtIDb2.Text);
                if(BD != null)
                {
                    if (MessageBox.Show("Bạn muốn xóa hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.CHITIETHOADONs.Remove(BD);
                        context.SaveChanges();
                        MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<CHITIETHOADON> lstBD = context.CHITIETHOADONs.ToList();
                        loadGridCTHD(lstBD);
                    }
                }
                
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo!", MessageBoxButtons.OK);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIDb.Text == "" || txtIDs.Text == "" || cbIDc.Text == "" || dtpDate.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                if(checkB(txtIDb.Text) != null)
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

        private void btnNew1_Click(object sender, EventArgs e)
        {
            List<CHITIETHOADON> lst = context.CHITIETHOADONs.ToList();
            loadGridCTHD(lst);
            dgvDetail.Rows.Clear();
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
                if(HD != null)
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //int sum = 0;
            //int price = Prices();
            //int value = int.Parse(txtValue.Text);
            //if (txtIDb.Text == "")
            //{
            //    MessageBox.Show("Vui lòng nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    if(sum == price)
            //    {
            //        sum += Prices();
            //        txtTotal.Text = sum.ToString();
            //    }
            //    else
            //    {
            //        sum += value * price;
            //        txtTotal.Text = sum.ToString();
            //    }
            //}

        }

        private void btnPrices_Click(object sender, EventArgs e)
        {
            int price = Prices();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CHITIETHOADON BD = context.CHITIETHOADONs.FirstOrDefault(p => p.MaHD == txtIDb.Text);
            if (BD != null)
            {
                MessageBox.Show("Hãy Xóa Chi Tiết Hóa Đơn Trước Khi Xóa Hóa Đơn!", "Thông Báo");
            }
            else
            {
                HOADON hd = context.HOADONs.FirstOrDefault(p => p.MaHD == txtIDb.Text);
                context.HOADONs.Remove(hd);
                context.SaveChanges();
                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<HOADON> lstB = context.HOADONs.ToList();
                loadGridHD(lstB);
            }
        }
    }
}
