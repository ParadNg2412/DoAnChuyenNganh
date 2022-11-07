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
                dgvProduct.Rows[index].Cells[2].Value = item.GiaNhap;
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

        private void ucStorage_Load(object sender, EventArgs e)
        {
            List<SANPHAM> lstP = context.SANPHAMs.ToList();
            List<PHIEUNHAP> lstB = context.PHIEUNHAPs.ToList();
            List<NHACUNGCAP> lstC = context.NHACUNGCAPs.ToList();
            List<CHITIETPHIEUNHAP> lstBD = context.CHITIETPHIEUNHAPs.ToList();
            loadGridPN(lstB);
            loadCompany(lstC);
            loadGridSP(lstP);
            loadGridCTPN(lstBD);
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
                    cbIDc.Text = dgvBill.Rows[e.RowIndex].Cells["ColCompany"].FormattedValue.ToString();
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
                    //var item = context.SANPHAMs.FirstOrDefault(p => p.MaSP == txtIDp.Text);
                    //byte[] arr = item.PicSP;
                    //MemoryStream ms = new MemoryStream(arr);
                    //picProduct.Image = Image.FromStream(ms);
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
                    PHIEUNHAP pn = new PHIEUNHAP()
                    {
                        MaPN = txtIDb.Text,
                        MaNCC = cbIDc.Text,
                        MaNV = txtIDs.Text,
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
            if (txtIDb.Text == "" || txtIDs.Text == "" || cbIDc.Text == "" || dtpDate.Text == "" || txtTotal.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                PHIEUNHAP PN = context.PHIEUNHAPs.FirstOrDefault(p => p.MaPN == txtIDb.Text);
                if (PN != null)
                {
                    PN.MaPN = txtIDb.Text;
                    PN.MaNV = txtIDs.Text;
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
                txtIDb2.Text == "")
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
                        MaPN = txtIDb2.Text,
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
            if (checkB(txtIDb2.Text) == null)
            {
                MessageBox.Show("Không tìm thấy phiếu nhập!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                CHITIETPHIEUNHAP BD = context.CHITIETPHIEUNHAPs.FirstOrDefault(p => p.MaPN == txtIDb2.Text);
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

        }
    }
}
