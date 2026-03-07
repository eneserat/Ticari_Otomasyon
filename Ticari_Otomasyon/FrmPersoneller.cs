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
using DevExpress.XtraRichEdit.API.RichTextBox;

namespace Ticari_Otomasyon
{
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Personel()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_PERSONELLER" , bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select Sehir From TBL_İLLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbPrsnIL.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            txtPrsnlId.Text = "";
            txtPrsnlAd.Text = "";
            txtPrsnlSoyad.Text = "";
            mskPrsnlTlfn.Text = "";
            txtPrsnlMaıl.Text = "";
            cmbPrsnIL.Text = "";
            cmbPrsnlIlce.Text = "";
            txtPrsnlAdres.Text = "";
            txtPrsnlGorev.Text = "";

        }


        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
      
        


        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            Personel();
            sehirListesi();
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut20 = new SqlCommand("insert into TBL_PERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut20.Parameters.AddWithValue("@p1", txtPrsnlAd.Text);
            komut20.Parameters.AddWithValue("@p2",txtPrsnlSoyad.Text);
            komut20.Parameters.AddWithValue("@p3",mskPrsnlTlfn.Text);
            komut20.Parameters.AddWithValue("@p4",mskPrsnlTc.Text);
            komut20.Parameters.AddWithValue("@p5",txtPrsnlMaıl.Text);
            komut20.Parameters.AddWithValue("@p6",cmbPrsnIL.Text);
            komut20.Parameters.AddWithValue("@p7",cmbPrsnlIlce.Text);
            komut20.Parameters.AddWithValue("@p8",txtPrsnlAdres.Text);
            komut20.Parameters.AddWithValue("@p9",txtPrsnlGorev.Text);
            komut20.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Sisteme Kaydedildi", "BİLGİ" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Personel();

        }

        private void cmbPrsnIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPrsnlIlce.Properties.Items.Clear();
            SqlCommand sqlCommand = new SqlCommand("Select İLCE From TBL_İLCELER Where Sehir=@p1 ", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", cmbPrsnIL.SelectedIndex + 1);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                cmbPrsnlIlce.Properties.Items.Add(reader[0]);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut21 = new SqlCommand("Delete From TBL_PERSONELLER WHERE ID=@p1 ", bgl.baglanti());
            komut21.Parameters.AddWithValue("@p1", txtPrsnlAd.Text);
            komut21.Parameters.AddWithValue("@p2", txtPrsnlSoyad.Text);
            komut21.Parameters.AddWithValue("@p3", mskPrsnlTlfn.Text);
            komut21.Parameters.AddWithValue("@p4", mskPrsnlTc.Text);
            komut21.Parameters.AddWithValue("@p5", txtPrsnlMaıl.Text);
            komut21.Parameters.AddWithValue("@p6", cmbPrsnIL.Text);
            komut21.Parameters.AddWithValue("@p7", cmbPrsnlIlce.Text);
            komut21.Parameters.AddWithValue("@p8", txtPrsnlAdres.Text);
            komut21.Parameters.AddWithValue("@p9", txtPrsnlGorev.Text);
            komut21.ExecuteNonQuery();

            if (string.IsNullOrEmpty(txtPrsnlId.Text))
            {
                MessageBox.Show("Lütfen silinecek Personel ID'sini girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz ?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlCommand komut = new SqlCommand(
                    "DELETE FROM TBL_PERSONELLER WHERE ID=@p1",
                    bgl.baglanti()
                );
                komut.Parameters.AddWithValue("@p1", txtPrsnlId.Text);

                komut.ExecuteNonQuery();
                MessageBox.Show("Personel sistemden silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("Select * From TBL_PERSONELLER where ID=@p1", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", gridView1.GetFocusedRowCellValue("ID").ToString());
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            txtPrsnlId.Text = dt.Rows[0][0].ToString();
            txtPrsnlSoyad.Text = dt.Rows[0][1].ToString();
            mskPrsnlTlfn.Text = dt.Rows[0][2].ToString();
            mskPrsnlTc.Text = dt.Rows[0][3].ToString();
            txtPrsnlMaıl.Text = dt.Rows[0][4].ToString();
            cmbPrsnIL.Text = dt.Rows[0][5].ToString();
            cmbPrsnlIlce.Text = dt.Rows[0][6].ToString();
            txtPrsnlAdres.Text = dt.Rows[0][7].ToString();
            txtPrsnlGorev.Text = dt.Rows[0][8].ToString();
         
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlCommand komut31 = new SqlCommand("Update From TBL_PERSONELLER Set AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4,MAIL= @p5,IL=@p6,ILCE=@p6,ADRES=@p7,GOREV=@p8 WHERE ID =@p8", bgl.baglanti());
            komut31.Parameters.AddWithValue("@p1", txtPrsnlAd.Text);
            komut31.Parameters.AddWithValue("@p2", txtPrsnlSoyad.Text);
            komut31.Parameters.AddWithValue("@p3", mskPrsnlTlfn.Text);
            komut31.Parameters.AddWithValue("@p4", mskPrsnlTc.Text);
            komut31.Parameters.AddWithValue("@p5", txtPrsnlMaıl.Text);
            komut31.Parameters.AddWithValue("@p6", cmbPrsnIL.Text);
            komut31.Parameters.AddWithValue("@p7", cmbPrsnlIlce.Text);
            komut31.Parameters.AddWithValue("@p8", txtPrsnlAdres.Text);
            komut31.Parameters.AddWithValue("@p8", txtPrsnlGorev.Text);
            komut31.ExecuteNonQuery();  
            MessageBox.Show("Personel Bilgisi Güncellendi ", "BİLGİ ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
