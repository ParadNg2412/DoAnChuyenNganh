using DevExpress.Text.Interop;
using Microsoft.SqlServer.Management.Smo;
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
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace SaberMart.UI.User_control.Staff
{
    public partial class ucProduct2 : UserControl
    {
        EntityDB context = new EntityDB();

        public ucProduct2()
        {
            InitializeComponent();
        }

        public void loadProduct(List<SANPHAM> lstP)
        {
            cbID.DataSource = lstP;
            cbID.DisplayMember = "MaSP";
            cbID.ValueMember = "MaSP";
        }

        public void loadProduct2(List<SANPHAM> lstP)
        {
            cbType.DataSource = lstP;
            cbType.DisplayMember = "DonViTinh";
            cbType.ValueMember = "DonViTinh";
        }

        private string checkP (string ID)
        {
            List<SANPHAM> lstP = context.SANPHAMs.ToList();
            foreach (var ck in lstP)
            {
                if (ID.Equals(ck.MaSP))
                {
                    return ck.MaSP;
                }
            }
            return null;
        }

        private void loadGridView (List<SANPHAM> lstP)
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

        private void ucProduct2_Load(object sender, EventArgs e)
        {
            List<SANPHAM> lstP = context.SANPHAMs.ToList();
            loadProduct(lstP);
            loadProduct2(lstP);
            loadGridView(lstP);
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvProduct.CurrentCell.Selected = true;
                    cbID.Text = dgvProduct.Rows[e.RowIndex].Cells["ColIDp"].FormattedValue.ToString();
                    txtName.Text = dgvProduct.Rows[e.RowIndex].Cells["ColNamep"].FormattedValue.ToString();
                    cbType.Text = dgvProduct.Rows[e.RowIndex].Cells["ColType"].FormattedValue.ToString();
                    txtSales.Text = dgvProduct.Rows[e.RowIndex].Cells["ColSales"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpLoadPicture_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<SANPHAM> lstP = context.SANPHAMs.ToList();
            loadGridView(lstP);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            List<SANPHAM> lstP = context.SANPHAMs.ToList();
            loadGridView(lstP);
            dgvProduct.Rows.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkP(cbID.Text) == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                SANPHAM srchsp = context.SANPHAMs.FirstOrDefault(p => p.MaSP == cbID.Text);
                if (srchsp != null)
                {
                    List<SANPHAM> lstP = context.SANPHAMs.Where(p => p.MaSP == cbID.Text).ToList();
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
