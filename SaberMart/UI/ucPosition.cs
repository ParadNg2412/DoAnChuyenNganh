using DevExpress.XtraEditors;
using SaberMart.DataEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaberMart.UI
{
    public partial class ucPosition : DevExpress.XtraEditors.XtraUserControl
    {
        EntityDB context = new EntityDB();
        public ucPosition()
        {
            InitializeComponent();
        }


    }
}
