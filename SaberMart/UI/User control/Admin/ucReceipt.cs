using DevExpress.Text.Interop;
using DevExpress.XtraDiagram.Base;
using SaberMart.EntityData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaberMart.UI.User_control.Admin
{
    public partial class ucReceipt : UserControl
    {
        private List<HOADON> tk, _temp;
        EntityDB context = new EntityDB();

        public ucReceipt()
        {
            InitializeComponent();
        }

        public void loadBill(List<HOADON> lstB)
        {
            cbIDb.DataSource = lstB;
            cbIDb.DisplayMember = "MaHD";
            cbIDb.ValueMember = "MaHD";
        }

        private void loadGridView(List<HOADON> lstB)
        {
            dgvReceipt.Rows.Clear();
            foreach (var item in lstB)
            {
                int index = dgvReceipt.Rows.Add();
                dgvReceipt.Rows[index].Cells[0].Value = item.MaHD;
                dgvReceipt.Rows[index].Cells[1].Value = item.NgayBan;
                dgvReceipt.Rows[index].Cells[2].Value = item.TongTienBan;
            }
        }

        private void ucReceipt_Load(object sender, EventArgs e)
        {
            tk = context.HOADONs.ToList();
            loadGridView(tk);
            loadBill(tk);
        }

        private void dgvReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvReceipt.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvReceipt.CurrentCell.Selected = true;
                    cbIDb.Text = dgvReceipt.Rows[e.RowIndex].Cells["ColIDb"].FormattedValue.ToString();
                    dtpDate.Text = dgvReceipt.Rows[e.RowIndex].Cells["ColDate"].FormattedValue.ToString();
                    txtPrices.Text = dgvReceipt.Rows[e.RowIndex].Cells["ColPrices"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            cbIDb.Text = string.Empty;
            dtpDate.Text = string.Empty;
            txtPrices.Text = "0";
            txtTotal.Text = "0";
        }

        private void btnNew1_Click(object sender, EventArgs e)
        {
            tk = context.HOADONs.ToList();
            loadGridView(tk);
            dgvReceipt.Rows.Clear();
            Clear();
        }

        private void btnGridView_Click(object sender, EventArgs e)
        {
            tk = context.HOADONs.ToList();
            loadGridView(tk);
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            int? tongTien = 0;
            foreach (var hd in tk)
            {
                if (hd.NgayBan?.ToString("MM-dd-yyyy") == dtpDay.Value.ToString("MM-dd-yyyy"))
                {
                    tongTien += hd.TongTienBan;
                }
            }

            txtTotal.Text = tongTien.ToString();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            int? tongTien = 0;
            foreach (var hd in tk)
            {
                if (hd.NgayBan?.ToString("MM-yyyy") == dtpMonth.Value.ToString("MM-yyyy"))
                {
                    tongTien += hd.TongTienBan;
                }
            }

            txtTotal.Text = tongTien.ToString();
        }
        
        private void btnYear_Click(object sender, EventArgs e)
        {
            int? tongTien = 0;
            foreach (var hd in tk)
            {
                if (hd.NgayBan?.ToString("yyyy") == dtpYear.Value.ToString("yyyy"))
                {
                    tongTien += hd.TongTienBan;
                }
            }
                
            txtTotal.Text = tongTien.ToString();
        }
    }
}
