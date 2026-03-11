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
    public partial class Faturalar : Form
    {
        public Faturalar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FATURABİLGİ ",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtFaturaId.Text = "";
            txtSerıNo.Text = "";
            txtSıraNo.Text = "";
            mskTrh.Text = "";
            mskSaat.Text = "";
            txtVergıDaıresı.Text = "";
            txtAlıcı.Text = "";
            txtTeslımEden.Text = "";
            txtTeslımAlan.Text = "";
        }


        private void Faturalar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (txtFtrId.Text == "")
            {
                SqlCommand komut25 = new SqlCommand("insert into TBL_FATURABİLGİ(SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", bgl.baglanti());
                komut25.Parameters.AddWithValue("@P1", txtSerıNo.Text);
                komut25.Parameters.AddWithValue("@P2", txtSıraNo.Text);
                komut25.Parameters.AddWithValue("@P3", mskTrh.Text);
                komut25.Parameters.AddWithValue("@P4", mskSaat.Text);
                komut25.Parameters.AddWithValue("@P5", txtVergıDaıresı.Text);
                komut25.Parameters.AddWithValue("@P6", txtAlıcı.Text);
                komut25.Parameters.AddWithValue("@P7", txtTeslımEden.Text);
                komut25.Parameters.AddWithValue("@P8", txtTeslımAlan.Text);
                komut25.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgileri Sisteme Kaydedildi " , "BİLGİ " , MessageBoxButtons.OK ,MessageBoxIcon.Information);
                listele();
        
              

            }
            if (txtFtrId.Text!="")
            {
                double miktar, tutar, fiyat;
                fiyat=Convert.ToDouble(txtFıyat.Text);
                miktar = Convert.ToDouble(textEdit1.Text);
                
                SqlCommand komut2 = new SqlCommand("insert  into TBL_FATURADETAY(URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) VALUES (@P1,@P2,@P3,@P4,@P5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@P1", txtUrunAdı.Text);
                komut2.Parameters.AddWithValue("@P2", textEdit1.Text);
                komut2.Parameters.AddWithValue("@P3", txtFıyat.Text);
                komut2.Parameters.AddWithValue("@P4", txtTutar.Text);
                komut2.Parameters.AddWithValue("@P5", txtFtrId.Text);

            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                txtFaturaId.Text = dr["FATURABILGIID"].ToString();
                txtSerıNo.Text = dr["SERI"].ToString();
                txtSıraNo.Text = dr["SIRANO"].ToString();
                mskTrh.Text = dr["TARIH"].ToString();
                mskSaat.Text = dr["SAAT"].ToString();
                txtVergıDaıresı.Text = dr["VERGIDAIRE"].ToString();
                txtAlıcı.Text = dr["ALICI"].ToString();
                txtTeslımEden.Text = dr["TESLIMEDEN"].ToString();
                txtTeslımAlan.Text = dr["TESLIMALAN"].ToString();
                

            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete TBL_FATURABİLGİ WHERE ID =@P1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@P1", txtFaturaId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Fatura Bilgisi Sistemden Başarıyla Silindi " , "BİLGİ ", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update TBL_FATURABİLGİ SET SERI=@P1,SIRANO=@P2,TARIH=@P3,SAAT=@P4,VERGIDAIRE=@P5,ALICI=@P6,TESLIMEDEN=@P7,TESLIMALAN=@P8, WHERE FATURABILGIID = @P9", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@P1", txtSerıNo.Text);
            komutguncelle.Parameters.AddWithValue("@P2", txtSıraNo.Text);
            komutguncelle.Parameters.AddWithValue("@P3", mskTrh.Text);
            komutguncelle.Parameters.AddWithValue("@P4", mskSaat.Text);
            komutguncelle.Parameters.AddWithValue("@P5", txtVergıDaıresı.Text);
            komutguncelle.Parameters.AddWithValue("@P6", txtAlıcı.Text);
            komutguncelle.Parameters.AddWithValue("@P7", txtTeslımEden.Text);
            komutguncelle.Parameters.AddWithValue("@P8", txtTeslımAlan.Text);
            komutguncelle.Parameters.AddWithValue("@P9", txtFaturaId.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Fatura Bilgileri Başarıyla Güncellendi" , "BİLGİ " , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDetay fr = new FrmFaturaUrunDetay();   
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                fr.id = dr["FATURABILGIID"].ToString();


            }
            fr.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
