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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_NOTLAR  ",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle ()
        {
            txtNotId.Text = "";
            maskedTarıh.Text = "";
            maskedSaat.Text = "";
            txtBaslık.Text = "";
            rchDetay.Text = "";
            txtOlusturan.Text = "";

        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into TBL_NOTLAR (NOTTARİH,NOTSAAT,NOTBASLIK,NOTDETAY,NOTOLUSTURAN ,NOTHITAP) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", txtNotId.Text);
            komutekle.Parameters.AddWithValue("@p2", maskedTarıh.Text);
            komutekle.Parameters.AddWithValue("@p3", maskedSaat.Text);
            komutekle.Parameters.AddWithValue("@p4", txtBaslık.Text);
            komutekle.Parameters.AddWithValue("@p5", rchDetay.Text);
            komutekle.Parameters.AddWithValue("@p6", txtOlusturan.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Not Sisteme Başarıla Eklendi " ,"BİLGİ ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtNotId.Text = dr["NOTID"].ToString();
                maskedTarıh.Text = dr["NOTTARİH"].ToString();
                maskedSaat.Text = dr["NOTSAAT"].ToString();
                txtBaslık.Text = dr["NOTBASLIK"].ToString();
                rchDetay.Text = dr["NOTDETAY"].ToString();
                txtOlusturan.Text = dr["NOTOLUSTURAN"].ToString();
                txtHıtap.Text = dr["NOTHITAP"].ToString() ;





            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           SqlCommand notsil = new SqlCommand("Delete TBL_NOTLAR WHERE NOTID = @P1",bgl.baglanti());
            notsil.Parameters.AddWithValue("@P1", txtNotId.Text);
            notsil.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Not Sistemden Başarıyla Silindi " , "BİLGİ " , MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlCommand notguncelle = new SqlCommand("Update TBL_NOTLAR set NOTTARİH=@P1,NOTSAAT=@P2,NOTBASLIK=@P3,NOTDETAY=@P4,NOTOLUSTURAN=@P5,NOTHITAP=@P6 WHERE NOTID=@P7", bgl.baglanti());
            notguncelle.Parameters.AddWithValue("@P1", maskedTarıh.Text);
            notguncelle.Parameters.AddWithValue("@P2", maskedSaat.Text);
            notguncelle.Parameters.AddWithValue("@P3", txtBaslık.Text);
            notguncelle.Parameters.AddWithValue("@P4", rchDetay.Text);
            notguncelle.Parameters.AddWithValue("@P5", txtOlusturan.Text);
            notguncelle.Parameters.AddWithValue("@P6", txtHıtap.Text);
            notguncelle.Parameters.AddWithValue("@P7", txtNotId.Text);
            notguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Not Sistemde Başarıyla Güncellendi " , "BİLGİ  " , MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay fr = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                fr.metin = dr["NOTDETAY"].ToString();
                

            }
            fr.Show();
        }
    }
}
