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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void kullanicilistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_ADMINGIRIS",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            kullanicilistele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_ADMINGIRIS values (@p1,@p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtklncad.Text);
            komut.Parameters.AddWithValue("@p2", txtsıfre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("YENİ ADMİN BAŞARIYLA SİSTEME KAYDEDİLDİ " , "BİLGİ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            kullanicilistele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                txtklncad.Text=dr["Kullanıcı Ad"].ToString();
                txtsıfre.Text = dr["Şifre"].ToString() ;

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_ADMINGIRIS set Kullanıcı Ad = @P1, Şifre=@P2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtklncad.Text);
            komut.Parameters.AddWithValue("@P2", txtsıfre.Text);
            komut.ExecuteNonQuery ();
            bgl.baglanti() .Close();
            MessageBox.Show("GİRİŞ BİLGİLERİ BAŞARIYLA GÜNCELLENDİ ", "BİLGİ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            kullanicilistele();
        }
    }
}
