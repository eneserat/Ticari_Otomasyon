using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FrmÜrünler fr;
        

        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr==null)
            {
                fr=new FrmÜrünler();

            }
            fr= new FrmÜrünler();
            fr.MdiParent=this;
            fr.Show();


        }
        FrmMusteriler fr2;
        private void btnMusterıler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2==null)
            {
                fr2=new FrmMusteriler();

            }
            fr2 = new FrmMusteriler();
            fr2.MdiParent=this;
            fr2.Show();

        }
        FrmFirmalar fr3;
        private void btnFırmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null)
            {
                fr3=new FrmFirmalar();
                fr3.MdiParent=this;
                fr3.Show();

            }

        }

        FrmPersoneller fr4;

        private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4==null)
            {
                fr4=new FrmPersoneller();
                fr4.MdiParent=this;
                fr4.Show();


            }
        }
    }
}
