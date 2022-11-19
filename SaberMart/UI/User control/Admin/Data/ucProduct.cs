using SaberMart.EntityData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SaberMart.UI.User_control.Admin.Data
{
    public partial class ucProduct : UserControl
    {
        EntityDB context = new EntityDB();

        public ucProduct()
        {
            InitializeComponent();
        }

        private void loadNCC (List<NHACUNGCAP> lstC)
        {
            cbIDc.DataSource = lstC;
            cbIDc.DisplayMember = "MaNCC";
            cbIDc.ValueMember = "MaNCC";
        }

        private void loadLSP(List<NHOMSANPHAM> lstP)
        {
            cbIDg.DataSource = lstP;
            cbIDg.DisplayMember = "MaNhom";
            cbIDg.ValueMember = "MaNhom";
        }

        private string checkP(string ID)
        {
            List<SANPHAM> lstS = context.SANPHAMs.ToList();
            foreach (var ck in lstS)
            {
                if (ID.Equals(ck.MaSP))
                {
                    return ck.MaSP;
                }
            }
            return null;
        }       

        private void loadGridProduct(List<SANPHAM> lstP)
        {
            dgvProduct.Rows.Clear();
            foreach (var item in lstP)
            {
                int index = dgvProduct.Rows.Add();
                dgvProduct.Rows[index].Cells[0].Value = item.MaSP;
                dgvProduct.Rows[index].Cells[1].Value = item.TenSP;
                dgvProduct.Rows[index].Cells[2].Value = item.DonViTinh;
                dgvProduct.Rows[index].Cells[3].Value = item.NHOMSANPHAM.TenNhom;
                dgvProduct.Rows[index].Cells[4].Value = item.NHACUNGCAP.TenNCC;
                dgvProduct.Rows[index].Cells[5].Value = item.SLTon;
                dgvProduct.Rows[index].Cells[6].Value = item.GiaBan;
                dgvProduct.Rows[index].Cells[7].Value = item.GiaNhap;
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
                    txtNameg.Text = dgvProduct.Rows[e.RowIndex].Cells["ColGroup"].FormattedValue.ToString();
                    txtNamec.Text = dgvProduct.Rows[e.RowIndex].Cells["ColCompany"].FormattedValue.ToString();
                    txtValue.Text = dgvProduct.Rows[e.RowIndex].Cells["ColStorage"].FormattedValue.ToString();
                    txtSales.Text = dgvProduct.Rows[e.RowIndex].Cells["ColSales"].FormattedValue.ToString();
                    txtPrices.Text = dgvProduct.Rows[e.RowIndex].Cells["ColPrices"].FormattedValue.ToString();
                    var item = context.SANPHAMs.FirstOrDefault(p => p.TenSP == txtNamep.Text);
                    byte[] arr = item.PicSP;
                    MemoryStream ms = new MemoryStream(arr);
                    picProduct.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void loadGridGroup (List<NHOMSANPHAM> lstG)
        {
            dgvGroup.Rows.Clear();
            foreach(var item in lstG)
            {
                int index = dgvGroup.Rows.Add();
                dgvGroup.Rows[index].Cells[0].Value = item.MaNhom;
                dgvGroup.Rows[index].Cells[1].Value = item.TenNhom;
            }           
        }

        private void loadGridCompany (List<NHACUNGCAP> lstC)
        {
            dgvCompany.Rows.Clear();
            foreach(var item in lstC)
            {
                int index = dgvCompany.Rows.Add();
                dgvCompany.Rows[index].Cells[0].Value = item.MaNCC;
                dgvCompany.Rows[index].Cells[1].Value = item.TenNCC;
            }
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {
            List<SANPHAM> sp = context.SANPHAMs.ToList();
            List<NHACUNGCAP> ncc = context.NHACUNGCAPs.ToList();
            List<NHOMSANPHAM> nsp = context.NHOMSANPHAMs.ToList();
            loadGridProduct(sp);
            loadGridGroup(nsp);
            loadGridCompany(ncc);
            loadLSP(nsp);
            loadNCC(ncc);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbIDc.Text == "" || cbIDg.Text == "" || txtNameg.Text == "" || txtIDp.Text == "" || txtNamep.Text == "" ||
                txtType.Text == "" || txtSales.Text == "" || txtPrices.Text == "" || txtValue.Text == "" || picProduct.Image == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            try
            {
                if (checkP(txtIDp.Text) != null)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại!", "Thông báo!", MessageBoxButtons.OK);
                }
                else
                {
                    Image img = Image.FromFile(picProduct.ImageLocation);
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    SANPHAM addsp = new SANPHAM()
                    {
                        MaSP = txtIDp.Text,
                        TenSP = txtNamep.Text,
                        MaNCC = cbIDc.Text,
                        MaNhom = cbIDg.Text,
                        DonViTinh = txtType.Text,
                        SLTon = int.Parse(txtValue.Text),
                        GiaBan = int.Parse(txtSales.Text),
                        GiaNhap = int.Parse(txtPrices.Text),
                        PicSP = ms.ToArray()
                    };
                    context.SANPHAMs.Add(addsp);
                    context.SaveChanges();
                    List<SANPHAM> lstP = context.SANPHAMs.ToList();
                    loadGridProduct(lstP);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkP(txtIDp.Text) == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                SANPHAM delsp = context.SANPHAMs.FirstOrDefault(p => p.MaSP == txtIDp.Text);
                if (delsp != null)
                {
                    if (MessageBox.Show("Bạn muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.SANPHAMs.Remove(delsp);
                        context.SaveChanges();
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<SANPHAM> lstP = context.SANPHAMs.ToList();
                        loadGridProduct(lstP);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cbIDc.Text == "" || cbIDg.Text == "" || txtNameg.Text == "" || txtIDp.Text == "" || txtNamep.Text == "" ||
                txtType.Text == "" || txtSales.Text == "" || txtPrices.Text == "" || txtValue.Text == "" || picProduct.Image == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                Image img = Image.FromFile(picProduct.ImageLocation);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                SANPHAM Upsp = context.SANPHAMs.FirstOrDefault(p => p.MaSP == txtIDp.Text);
                if (Upsp != null)
                {
                    Upsp.MaSP = txtIDp.Text;
                    Upsp.TenSP = txtNamep.Text;
                    Upsp.MaNCC = cbIDc.Text;
                    Upsp.MaNhom = cbIDg.Text;
                    Upsp.NHOMSANPHAM.TenNhom = txtNameg.Text;
                    Upsp.DonViTinh = txtType.Text;
                    Upsp.SLTon = int.Parse(txtValue.Text);
                    Upsp.GiaBan = int.Parse(txtSales.Text);
                    Upsp.GiaNhap = int.Parse(txtPrices.Text);
                    Upsp.PicSP = ms.ToArray();
                    
                }
                List<SANPHAM> lstP = context.SANPHAMs.ToList();
                loadGridProduct(lstP);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<SANPHAM> lstP = context.SANPHAMs.ToList();
            loadGridProduct(lstP);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkP(txtIDp.Text) == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                SANPHAM srchsp = context.SANPHAMs.FirstOrDefault(p => p.MaSP == txtIDp.Text);
                if (srchsp != null)
                {
                    List<SANPHAM> lstP = context.SANPHAMs.Where(p => p.MaSP == txtIDp.Text).ToList();
                    loadGridProduct(lstP);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvGroup.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvGroup.CurrentCell.Selected = true;
                    cbIDg.Text = dgvGroup.Rows[e.RowIndex].Cells["ColGroupID"].FormattedValue.ToString();
                    txtNameg.Text = dgvGroup.Rows[e.RowIndex].Cells["ColGroupName"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dgvCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCompany.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvCompany.CurrentCell.Selected = true;
                    cbIDc.Text = dgvCompany.Rows[e.RowIndex].Cells["ColCompanyID"].FormattedValue.ToString();
                    txtNamec.Text = dgvCompany.Rows[e.RowIndex].Cells["ColCompanyName"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void picProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picProduct.ImageLocation = dlg.FileName;
            }
        }
    }
}
