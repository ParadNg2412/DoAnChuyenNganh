using DevExpress.XtraEditors.Filtering.Templates;
using SaberMart.EntityData;
using SaberMart.Others;
using SaberMart.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SaberMart.UI.User_control.Admin.Report
{
    public partial class ucBillrp : UserControl
    {
        EntityDB context = new EntityDB();

        public ucBillrp()
        {
            InitializeComponent();
        }

        private void ucBillrp_Load(object sender, EventArgs e)
        {
            List <CHITIETHOADON> lstB = context.CHITIETHOADONs.ToList();
            List<BillReport> lstbr = new List<BillReport>();
            foreach (var item in lstB)
            {
                BillReport hdrp = new BillReport();
                hdrp.MaHD = item.MaHD;
                hdrp.TenSP = item.SANPHAM.TenSP;
                hdrp.DonViTinh = item.SANPHAM.DonViTinh;
                hdrp.SLBan = Convert.ToInt32(item.SLBan);
                hdrp.DonGiaBan = Convert.ToInt32(item.DonGiaBan);
                hdrp.ThanhTienBan = Convert.ToInt32(item.ThanhTienBan);
                lstbr.Add(hdrp);
                crBill br = new crBill();
                br.SetDataSource(lstbr);
                crvBill.ReportSource = br;
            }
        }
    }
}
