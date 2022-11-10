using SaberMart.EntityData;
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

        private void loadNCC (List<NHACUNGCAP> lstC)
        {
            cbIDc.DataSource = lstC;
            cbIDc.DisplayMember = "MaNCC";
            cbIDc.ValueMember = "MaNCC";
        }

        private void loadLSP(List<SANPHAM> lstP)
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

        private void loadGridView2 (List<NHACUNGCAP> lstC)
        {
            dgvCompany.Rows.Clear();
            foreach (var item in lstC)
            {
                int index = dgvCompany.Rows.Add();
                dgvCompany.Rows[index].Cells[0].Value = item.MaNCC;
                dgvCompany.Rows[index].Cells[1].Value = item.TenNCC;
            }
        }

        private void dgvCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCompany.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvCompany.CurrentCell.Selected = true;
                    cbIDc.Text = dgvCompany.Rows[e.RowIndex].Cells["ColIDc"].FormattedValue.ToString();
                    txtNamec.Text = dgvCompany.Rows[e.RowIndex].Cells["ColNamec"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void loadGridView(List<SANPHAM> lstP)
        {
            dgvProduct.Rows.Clear();
            foreach (var item in lstP)
            {
                int index = dgvProduct.Rows.Add();
                //dgvProduct.Rows[index].Cells[0].Value = item.PicSP;
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

                    var item = context.SANPHAMs.FirstOrDefault(p => p.MaSP == txtIDp.Text);
                    //byte[] imaged = (byte[])dgvProduct.Rows[e.RowIndex].Cells["ColImage"].FormattedValue;
                    //string arr = item.PicSP;
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


        private void ucProduct_Load(object sender, EventArgs e)
        {
            List<SANPHAM> sp = context.SANPHAMs.ToList();
            List<NHACUNGCAP> ncc = context.NHACUNGCAPs.ToList();
            loadGridView(sp);
            loadGridView2(ncc);
            loadLSP(sp);
            loadNCC(ncc);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbIDc.Text == "" || cbIDg.Text == "" || txtNameg.Text == "" || txtIDp.Text == "" || txtNamep.Text == "" ||
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
                        TenSP = txtNamep.Text,
                        MaNCC = cbIDc.Text,
                        MaNhom = cbIDg.Text,
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
            if (cbIDc.Text == "" || cbIDg.Text == "" || txtNameg.Text == "" || txtIDp.Text == "" || txtNamep.Text == "" ||
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
                    Upsp.MaNCC = txtNamec.Text;
                    Upsp.MaNhom = cbIDg.Text;
                    Upsp.NHOMSANPHAM.TenNhom = txtNameg.Text;
                    Upsp.DonViTinh = txtType.Text;
                    Upsp.SLTon = int.Parse(txtValue.Text);
                    Upsp.GiaBan = int.Parse(txtSales.Text);
                    Upsp.GiaNhap = int.Parse(txtPrices.Text);
                    //Upsp.PicSP = Byte[](picProduct.Image);
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
