using SaberMart.EntityData;
using SaberMart.Others;
using SaberMart.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaberMart.UI.User_control.Admin.Report
{
    public partial class ucProductrp : UserControl
    {
        EntityDB context = new EntityDB();

        public ucProductrp()
        {
            InitializeComponent();
        }

        

        private void ucProductrp_Load(object sender, EventArgs e)
        {
            List<SANPHAM> lstP = context.SANPHAMs.ToList();
            List<CHITIETHOADON> lstBr = context.CHITIETHOADONs.ToList();
            List<SoldProductReport> lstsp = new List<SoldProductReport>();
            foreach (var item in lstP)
            {
                SoldProductReport spr = new SoldProductReport();
                spr.MaSP = item.MaSP;
                spr.TenSP = item.TenSP;
                spr.DonViTinh = item.DonViTinh;
                spr.SLTon = (int)item.SLTon;
                //spr.SLBan = (int)lstBr.SLBan;
                lstsp.Add(spr);
                crProduct pr = new crProduct();
                pr.SetDataSource(lstsp);
                crvProduct.ReportSource = pr;
            }
        }   
    }
}
