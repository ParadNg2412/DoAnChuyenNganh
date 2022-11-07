using DevExpress.Text.Interop;
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
    public partial class ucProfit : UserControl
    {
        private List<CHITIETHOADON> tk, _temp;
        EntityDB context = new EntityDB();

        public ucProfit()
        {
            InitializeComponent();
        }

        public void loadBill(List<CHITIETHOADON> lstB)
        {
            cbIDb.DataSource = lstB;
            cbIDb.DisplayMember = "MaHD";
            cbIDb.ValueMember = "MaHD";
        }

        private void loadGridView(List<CHITIETHOADON> lstB)
        {
            dgvReceipt.Rows.Clear();
            var List = from q in lstB
                       group q by new { q.MaHD, q.NgayBan } into p
                       select new { MaHD = p.Key.MaHD, NgayBan = p.Key.NgayBan, TongTien = p.Sum(o => o.ThanhTienBan) };
            foreach (var item in List)
            {
                int index = dgvReceipt.Rows.Add();
                dgvReceipt.Rows[index].Cells[0].Value = item.MaHD;
                dgvReceipt.Rows[index].Cells[1].Value = item.NgayBan;
                dgvReceipt.Rows[index].Cells[2].Value = item.TongTien;
            }
        }

        private void ucProfit_Load(object sender, EventArgs e)
        {
            tk = context.CHITIETHOADONs.ToList();
            loadGridView(tk);
            loadBill(tk);
        }

        private void dgvReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNew1_Click(object sender, EventArgs e)
        {
            tk = context.CHITIETHOADONs.ToList();
            loadGridView(tk);
            dgvReceipt.Rows.Clear();
        }

        private void btnGridView_Click(object sender, EventArgs e)
        {
            tk = context.CHITIETHOADONs.ToList();
            loadGridView(tk);
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            int? tongTien = 0;
            foreach (var hd in tk)
            {
                if (hd.NgayBan?.ToString("MM-dd-yyyy") == dtpDay.Value.ToString("MM-dd-yyyy"))
                {
                    tongTien += hd.ThanhTienBan;
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
                    tongTien += hd.ThanhTienBan;
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
                    tongTien += hd.ThanhTienBan;
                }
            }
                
            txtTotal.Text = tongTien.ToString();
        }
    }
}
