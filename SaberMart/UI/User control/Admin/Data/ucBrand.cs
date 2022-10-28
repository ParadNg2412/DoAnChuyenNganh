using SaberMart.DataEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaberMart.UI.User_control.Admin.Data
{
    public partial class ucBrand : UserControl
    {
        EntityDB context = new EntityDB();

        public ucBrand()
        {
            InitializeComponent();
        }

        private string checkB(string ID)
        {
            List<NHACUNGCAP> lstB = context.NHACUNGCAPs.ToList();
            foreach (var ck in lstB)
            {
                if (ID.Equals(ck.MaNCC))
                {
                    return ck.MaNCC;
                }
            }
            return null;
        }

        private void loadGridView(List<NHACUNGCAP> lstB)
        {
            dgvBrand.Rows.Clear();
            foreach(var item in lstB)
            {
                int index = dgvBrand.Rows.Add();
                dgvBrand.Rows[index].Cells[0].Value = item.MaNCC;
                dgvBrand.Rows[index].Cells[1].Value = item.TenNCC;
                dgvBrand.Rows[index].Cells[2].Value = item.SDT;
                dgvBrand.Rows[index].Cells[3].Value = item.DiaChi;
            }
        }

        private void ucBrand_Load(object sender, EventArgs e)
        {
            List<NHACUNGCAP> ncc = context.NHACUNGCAPs.ToList();
            loadGridView(ncc);
        }

        private void dgvBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dgvBrand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvBrand.CurrentCell.Selected = true;
                    txtIDb.Text = dgvBrand.Rows[e.RowIndex].Cells["ColIDb"].FormattedValue.ToString();
                    txtNameb.Text = dgvBrand.Rows[e.RowIndex].Cells["ColNameb"].FormattedValue.ToString();
                    txtPhone.Text = dgvBrand.Rows[e.RowIndex].Cells["ColPhone"].FormattedValue.ToString();
                    txtAddress.Text = dgvBrand.Rows[e.RowIndex].Cells["ColAddress"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIDb.Text == "" || txtNameb.Text == "" || txtPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please enter full information!", "Notification!", MessageBoxButtons.OK);
            }
            try
            {
                if (checkB(txtIDb.Text) != null)
                {
                    MessageBox.Show("Brand already exist!", "Notification", MessageBoxButtons.OK);
                }
                else
                {
                    NHACUNGCAP addncc = new NHACUNGCAP()
                    {
                        MaNCC = txtIDb.Text,
                        TenNCC = txtNameb.Text,
                        SDT = txtPhone.Text,
                        DiaChi = txtAddress.Text
                    };
                    context.NHACUNGCAPs.Add(addncc);
                    context.SaveChanges();
                    List<NHACUNGCAP> lstB = context.NHACUNGCAPs.ToList();
                    loadGridView(lstB);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkB(txtIDb.Text) == null)
            {
                MessageBox.Show("Brand cannot be found!", "Notification!", MessageBoxButtons.OK);
            }
            else
            {
                NHACUNGCAP delncc = context.NHACUNGCAPs.FirstOrDefault(p => p.MaNCC == txtIDb.Text);
                if (delncc != null)
                {
                    if (MessageBox.Show("Do you want to remove?", "Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.NHACUNGCAPs.Remove(delncc);
                        context.SaveChanges();
                        MessageBox.Show("Remove successfull!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<NHACUNGCAP> lstS = context.NHACUNGCAPs.ToList();
                        loadGridView(lstS);
                    }
                }
                else
                {
                    MessageBox.Show("Brand cannot be found!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtIDb.Text == "" || txtNameb.Text == "" || txtPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please enter full information!", "Notification!", MessageBoxButtons.OK);
            }
            else
            {
                NHACUNGCAP Upncc = context.NHACUNGCAPs.FirstOrDefault(p => p.MaNCC == txtIDb.Text);
                if (Upncc != null)
                {
                    Upncc.MaNCC = txtIDb.Text;
                    Upncc.TenNCC = txtNameb.Text;
                    Upncc.SDT = txtPhone.Text;
                    Upncc.DiaChi = txtAddress.Text;
                    context.SaveChanges();
                }
                List<NHACUNGCAP> lstB = context.NHACUNGCAPs.ToList();
                loadGridView(lstB);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<NHACUNGCAP> lstB = context.NHACUNGCAPs.ToList();
            loadGridView(lstB);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkB(txtIDb.Text) == null)
            {
                MessageBox.Show("Brand cannot be found!", "Notification!", MessageBoxButtons.OK);
            }
            else
            {
                NHACUNGCAP srchncc = context.NHACUNGCAPs.FirstOrDefault(p => p.MaNCC == txtIDb.Text);
                if (srchncc != null)
                {
                    List<NHACUNGCAP> lstB = context.NHACUNGCAPs.Where(p => p.MaNCC == txtIDb.Text).ToList();
                    loadGridView(lstB);
                }
                else
                {
                    MessageBox.Show("Brand cannot be found!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
