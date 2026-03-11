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
using DevExpress.XtraCharts;

namespace Ticari_Otomasyon
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(
               "SELECT URUNAD, SUM(Adet) AS Miktar FROM TBL_URUNLER GROUP BY URUNAD",
               bgl.baglanti()
           );
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

          
           

            
            SqlCommand komut = new SqlCommand(
                "SELECT URUNAD, SUM(Adet) AS Miktar FROM TBL_URUNLER GROUP BY URUNAD",
                bgl.baglanti()
            );
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                string urun = dr["URUNAD"].ToString();
                int miktar = Convert.ToInt32(dr["Miktar"]);
                chartControl1.Series[0].Points.AddPoint(urun, miktar);
            }

            dr.Close();
            bgl.baglanti().Close();

           
            chartControl1.Series[0].Label.TextPattern = "{A}: {V:n0} ({VP:p0})";

            //
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            chartControl1.RefreshData();



        }
    }
}
