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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void FirmaListesi()
        { 
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FİRMALAR ",bgl.baglanti());
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
                Cmbil.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            txtİd.Text = "";
            txtFirmaAd.Text = "";
            txtYetkılıStatu.Text = "";
            txtYetkılı.Text = "";
            mskTc.Text = "";
            mskTelefon1.Text = "";
            mskTelefon2.Text = "";
            mskTelefon3.Text = "";
            txtFaks.Text = "";
            textEdit6.Text = "";
            Cmbil.Text = "";
            Cmbİlce.Text = "";
            textEdit9.Text = "";
            richTextBox1.Text = "";
            textEdit5.Text = "";
            textEdit4.Text = "";
            textEdit3.Text = "";
            textEdit1.Text = "";
            txtFirmaAd.Focus();













        }
        void kodaciklamalar()
        {
            SqlCommand komut13 = new SqlCommand("Select FIRMAKOD1 from TBL_KODLAR", bgl.baglanti());
            SqlDataReader dr = komut13.ExecuteReader();
            while (dr.Read())
            {
                richTextBox2.Text = dr[0].ToString();

            }
            bgl.baglanti().Close();
        }


        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            FirmaListesi();
            sehirListesi();
            temizle();
            kodaciklamalar();
            this.Size = new Size(1770, 977);



        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("Select * From TBL_FİRMALAR where ID=@p1", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", gridView1.GetFocusedRowCellValue("ID").ToString());
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            txtİd.Text = dt.Rows[0][0].ToString();
            txtFirmaAd.Text = dt.Rows[0][1].ToString();
            txtYetkılıStatu.Text = dt.Rows[0][2].ToString();
            txtYetkılı.Text=dt.Rows[0][3].ToString();
            mskTc.Text= dt.Rows[0][4].ToString();
            mskTelefon1.Text = dt.Rows[0][5].ToString();
            mskTelefon2.Text = dt.Rows[0][6].ToString();
            mskTelefon3.Text = dt.Rows[0][7].ToString();
            txtFaks.Text = dt.Rows[0][8].ToString();
            textEdit6.Text=dt.Rows[0][9].ToString();
            Cmbil.Text = dt.Rows[0][10].ToString();
            Cmbİlce.Text = dt.Rows[0][11].ToString();
            textEdit9.Text = dt.Rows[0][12].ToString();
            richTextBox1.Text = dt.Rows[0][13].ToString();
            textEdit5.Text=dt.Rows[0][14].ToString();
            textEdit4.Text=dt.Rows[0][15].ToString();
            textEdit3.Text=dt.Rows[0][16].ToString();
            textEdit1.Text=dt.Rows[0][17].ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut11 = new SqlCommand("insert into TBL_FİRMALAR (AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3,SEKTOR) VALUES  (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)",bgl.baglanti());
            komut11.Parameters.AddWithValue("@p1", txtFirmaAd.Text);
            komut11.Parameters.AddWithValue("@p2", txtYetkılıStatu.Text);
            komut11.Parameters.AddWithValue("@p3", txtYetkılı.Text);
            komut11.Parameters.AddWithValue("@p4", mskTc.Text);
            komut11.Parameters.AddWithValue("@p5", mskTelefon1.Text);
            komut11.Parameters.AddWithValue("@p6", mskTelefon2.Text);
            komut11.Parameters.AddWithValue("@p7", mskTelefon3.Text);
            komut11.Parameters.AddWithValue("@p8", txtFaks.Text);
            komut11.Parameters.AddWithValue("@p9", textEdit6.Text);
            komut11.Parameters.AddWithValue("@p10", Cmbil.Text);
            komut11.Parameters.AddWithValue("@p11", Cmbİlce.Text);
            komut11.Parameters.AddWithValue("@p12", textEdit9.Text);
            komut11.Parameters.AddWithValue("@p13", richTextBox1.Text);
            komut11.Parameters.AddWithValue("@p14", textEdit5.Text);
            komut11.Parameters.AddWithValue("@p15", textEdit4.Text);
            komut11.Parameters.AddWithValue("@p16", textEdit3.Text);
            komut11.Parameters.AddWithValue("@p17", textEdit1.Text);
            komut11.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sisteme Eklendi ", "BİLGİ ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            FirmaListesi();
            temizle();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut12 = new SqlCommand("Delete From TBL_FİRMALAR WHERE ID=@p1", bgl.baglanti());
            komut12.Parameters.AddWithValue("@p1", txtİd.Text);
            komut12.Parameters.AddWithValue("@p2", txtFirmaAd.Text);
            komut12.Parameters.AddWithValue("@p3", txtYetkılıStatu.Text);
            komut12.Parameters.AddWithValue("@p4", txtYetkılı.Text);
            komut12.Parameters.AddWithValue("@p5", mskTc.Text);
            komut12.Parameters.AddWithValue("@p6", mskTelefon1.Text);
            komut12.Parameters.AddWithValue("@p7", mskTelefon2.Text);
            komut12.Parameters.AddWithValue("@p8", mskTelefon3.Text);
            komut12.Parameters.AddWithValue("@p9", txtFaks.Text);
            komut12.Parameters.AddWithValue("@p10", textEdit6.Text);
            komut12.Parameters.AddWithValue("@p11", Cmbil.Text);
            komut12.Parameters.AddWithValue("@p12", Cmbİlce.Text);
            komut12.Parameters.AddWithValue("@p13", textEdit9.Text);
            komut12.Parameters.AddWithValue("@p14", richTextBox1.Text);
            komut12.Parameters.AddWithValue("@p15", textEdit5.Text);
            komut12.Parameters.AddWithValue("@p16", textEdit4.Text);
            komut12.Parameters.AddWithValue("@p17", textEdit3.Text);
            komut12.Parameters.AddWithValue("@p18", textEdit1.Text);

            if (string.IsNullOrEmpty(txtİd.Text))
            {
                MessageBox.Show("Lütfen silinecek Firma ID'sini girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (MessageBox.Show("Gerçekten silmek istiyor musunuz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlCommand komut = new SqlCommand(
                    "DELETE FROM TBL_FİRMALAR WHERE ID=@p1",
                    bgl.baglanti()
                );
                komut.Parameters.AddWithValue("@p1", txtİd.Text);

                komut.ExecuteNonQuery();
                MessageBox.Show("Firma sistemden silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbİlce.Properties.Items.Clear();
            SqlCommand sqlCommand = new SqlCommand("Select İLCE From TBL_İLCELER Where Sehir=@p1 ", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", Cmbil.SelectedIndex + 1);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Cmbİlce.Properties.Items.Add(reader[0]);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut14 = new SqlCommand("Update TBL_FİRMALAR set  AD=@p1,YETKILISTATU=@p2,YETKILIADSOYAD=@p3,YETKILITC=@p4,TELEFON1=@p5,TELEFON2=@p6,TELEFON3=@p7,MAIL=@p8,FAX=@p9,IL=@p10,ILCE=@p11,VERGIDAIRE=@p12,ADRES=@p13,OZELKOD1=@p14,OZELKOD2=@p15,OZELKOD3=@p16,SEKTOR=@17 WHERE ID=@p18" , bgl.baglanti());
            komut14.Parameters.AddWithValue("@p1", txtFirmaAd.Text);
            komut14.Parameters.AddWithValue("@p2", txtYetkılıStatu.Text);
            komut14.Parameters.AddWithValue("@p3", txtYetkılı.Text);
            komut14.Parameters.AddWithValue("@p4", mskTc.Text);
            komut14.Parameters.AddWithValue("@p5", mskTelefon1.Text);
            komut14.Parameters.AddWithValue("@p6", mskTelefon2.Text);
            komut14.Parameters.AddWithValue("@p7", mskTelefon3.Text);
            komut14.Parameters.AddWithValue("@p8", txtFaks.Text);
            komut14.Parameters.AddWithValue("@p9", textEdit6.Text);
            komut14.Parameters.AddWithValue("@p10", Cmbil.Text);
            komut14.Parameters.AddWithValue("@p11", Cmbİlce.Text);
            komut14.Parameters.AddWithValue("@p12", textEdit9.Text);
            komut14.Parameters.AddWithValue("@p13", richTextBox1.Text);
            komut14.Parameters.AddWithValue("@p14", textEdit5.Text);
            komut14.Parameters.AddWithValue("@p15", textEdit4.Text);
            komut14.Parameters.AddWithValue("@p16", textEdit3.Text);
            komut14.Parameters.AddWithValue("@p17", textEdit1.Text);
            MessageBox.Show("Firma Bilgileri Güncellendi","BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Information);




        }
    }
}
