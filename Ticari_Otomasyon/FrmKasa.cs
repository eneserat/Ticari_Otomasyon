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
using DevExpress.Charts;
namespace Ticari_Otomasyon
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void musterihareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("Exec MusteriHareketler",bgl.baglanti());
            dr.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void fatura()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dr3 = new SqlDataAdapter("Select * From TBL_GİDERLER", bgl.baglanti());
            dr3.Fill(dt);
            gridControl2.DataSource = dt;
        }
        void sufaturası()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dr4 = new SqlDataAdapter("Select SU From TBL_GİDERLER ", bgl.baglanti());
            dr4.Fill(dt);
            gridControl4.DataSource = dt;
        }
        public string ad; 
        void firmahareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dr2 = new SqlDataAdapter("Exec FIRMAHAREKETLER", bgl.baglanti());
            dr2.Fill(dt);
            gridControl3.DataSource = dt;
        }
       
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            lblAktifKullanici.Text = ad;
            musterihareket();
            firmahareket();
            fatura();
            sufaturası();

            SqlCommand komuttoplam = new SqlCommand("Select Sum (Tutar) From  TBL_FATURADETAY ", bgl.baglanti());
            SqlDataReader dr = komuttoplam.ExecuteReader();
            if (dr.Read())
            {
                lblKasaToplam.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            SqlCommand komut20 = new SqlCommand("Select MAASLAR From TBL_GİDERLER order by ID  asc", bgl.baglanti());
            SqlDataReader dr1 = komut20.ExecuteReader();
            if (dr1.Read())
            {
                lblPersonelMaas.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();
            SqlCommand komut21 = new SqlCommand("Select Count(*) From TBL_MUSTERİLER", bgl.baglanti());
            SqlDataReader dr2= komut21.ExecuteReader();
            if (dr2.Read())
            {
                lblMusteriSayisi.Text = dr2[0].ToString();
            }
            bgl.baglanti().Close();
            SqlCommand komut22 = new SqlCommand("Select Count(*) From TBL_FİRMALAR ", bgl.baglanti());
            SqlDataReader dr3=  komut22.ExecuteReader();    
            if (dr3.Read())
            {
                lblFirmaSayisi.Text = dr3[0].ToString();
            }
            bgl.baglanti().Close();
            SqlCommand komut23 = new SqlCommand("Select Count (*) From TBL_İLLER", bgl.baglanti());
            SqlDataReader dr4= komut23.ExecuteReader();
            if (dr4.Read())
            {
                lblSehirSayisi.Text = dr4[0].ToString();
            }
            bgl.baglanti() .Close();    
            SqlCommand komut24=new SqlCommand("Select Count (*) From TBL_PERSONELLER ", bgl.baglanti());
            SqlDataReader dr5= komut24.ExecuteReader();
            if (dr5.Read())
            {
                lblPersonelSayisi.Text=dr5[0].ToString();
            }
            bgl.baglanti() .Close();
            SqlCommand komut25= new SqlCommand("Select Sum(Adet) From TBL_URUNLER",bgl.baglanti()) ;
            SqlDataReader dr6= komut25.ExecuteReader();
            if (dr6.Read())
            {
                lblStokSayisi.Text=dr6[0].ToString();   
            }
            bgl.baglanti() .Close();
            SqlCommand komut10 = new SqlCommand("Select top 4 AY,ELEKTRIK From TBL_GİDERLER order by ID DESC ", bgl.baglanti());
            SqlDataReader dr7= komut10.ExecuteReader();
            while (dr7.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr7[0], dr7[1]));

            }
            bgl.baglanti().Close();
            SqlCommand komut11 = new SqlCommand("Select top 4 AY, SU From TBL_GİDERLER order by ID DESC ", bgl.baglanti());
            SqlDataReader dr8= komut11.ExecuteReader();
            while (dr8.Read())
            {
                chartControl2.Series["Su Faturası"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr8[0], dr8[1]));

            }
            bgl.baglanti().Close() ;
        }

        private void lblToplamOdeme_Click(object sender, EventArgs e)
        {

        }
    }
}
