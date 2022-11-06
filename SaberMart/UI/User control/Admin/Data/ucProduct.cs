using SaberMart.DataEntity;
using System;
using System.Collections.Generic;
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

        private void loadGridView(List<SANPHAM> lstP)
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
                    txtIDc.Text = dgvProduct.Rows[e.RowIndex].Cells["ColCompany"].FormattedValue.ToString();
                    txtSales.Text = dgvProduct.Rows[e.RowIndex].Cells["ColSales"].FormattedValue.ToString();
                    txtPrices.Text = dgvProduct.Rows[e.RowIndex].Cells["ColPrices"].FormattedValue.ToString();
                    picProduct.Text = dgvProduct.Rows[e.RowIndex].Cells["ColImage"].FormattedValue.ToString();
                    var item = context.SANPHAMs.FirstOrDefault(p => p.MaSP == txtIDp.Text);
                    Byte[] arr = item.PicSP;
                    MemoryStream ms = new MemoryStream(arr);
                    picProduct.Image = Image.FromStream(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnUpLoadPicture_Click(object sender, EventArgs e)
        {
            try
            {
                string filePathImage = null;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    filePathImage = openFile.FileName;
                    picProduct.Image = Image.FromFile(filePathImage.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {
            List<SANPHAM> sp = context.SANPHAMs.ToList();
            loadGridView(sp);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIDc.Text == "" || txtIDg.Text == "" || txtNameg.Text == "" || txtIDp.Text == "" || txtNamep.Text == "" ||
                txtType.Text == "" || txtSales.Text == "" || txtPrices.Text == "" || txtValue.Text == "")
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
                    SANPHAM addsp = new SANPHAM()
                    {
                        MaSP = txtIDp.Text,
                        TenSP = txtIDg.Text,
                        MaNCC = txtNamep.Text,
                        MaNhom = txtType.Text,
                        DonViTinh = txtType.Text,
                        SLTon = int.Parse(txtValue.Text),
                        GiaBan = int.Parse(txtSales.Text),
                        GiaNhap = int.Parse(txtPrices.Text)
                    };
                    context.SANPHAMs.Add(addsp);
                    context.SaveChanges();
                    List<SANPHAM> lstP = context.SANPHAMs.ToList();
                    loadGridView(lstP);
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
                        loadGridView(lstP);
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
            if (txtIDc.Text == "" || txtIDg.Text == "" || txtNameg.Text == "" || txtIDp.Text == "" || txtNamep.Text == "" ||
                txtType.Text == "" || txtSales.Text == "" || txtPrices.Text == "" || txtValue.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                SANPHAM Upsp = context.SANPHAMs.FirstOrDefault(p => p.MaSP == txtIDp.Text);
                if (Upsp != null)
                {
                    Upsp.MaSP = txtIDp.Text;
                    Upsp.TenSP = txtNamep.Text;
                    Upsp.MaNCC = txtIDc.Text;
                    Upsp.MaNhom = Upsp.NHOMSANPHAM.MaNhom = txtIDg.Text;
                    Upsp.NHOMSANPHAM.TenNhom = txtNameg.Text;
                    Upsp.DonViTinh = txtType.Text;
                    Upsp.SLTon = int.Parse(txtValue.Text);
                    Upsp.GiaBan = int.Parse(txtSales.Text);
                    Upsp.GiaNhap = int.Parse(txtPrices.Text);
                    context.SaveChanges();
                }
                List<SANPHAM> lstP = context.SANPHAMs.ToList();
                loadGridView(lstP);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<SANPHAM> lstP = context.SANPHAMs.ToList();
            loadGridView(lstP);
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
                    loadGridView(lstP);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
