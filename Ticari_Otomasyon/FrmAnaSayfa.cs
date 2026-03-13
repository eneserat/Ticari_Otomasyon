using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ticari_Otomasyon
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void stoklar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select URUNAD ,Sum(ADET) as  'ADET' From TBL_URUNLER group by URUNAD having Sum(ADET)<=200 order by Sum (ADET)",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select top 5 NOTTARİH,NOTSAAT,NOTBASLIK,NOTDETAY,NOTOLUSTURAN,NOTHITAP From TBL_NOTLAR order by NOTID Desc", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            stoklar();
            ajanda();

        }
    }
}
