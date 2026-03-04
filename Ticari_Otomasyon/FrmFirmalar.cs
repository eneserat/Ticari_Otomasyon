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

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            FirmaListesi();
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
            txtYetkılıGorev.Text = dt.Rows[0][4].ToString();
            mskTc.Text= dt.Rows[0][5].ToString();
            mskTelefon1.Text = dt.Rows[0][3].ToString();
            mskTelefon2.Text = dt.Rows[0][4].ToString();
            mskTelefon3.Text = dt.Rows[0][5].ToString();
            txtFaks.Text = dt.Rows[0][6].ToString();
            Cmbil.Text = dt.Rows[0][7].ToString();
            Cmbİlce.Text = dt.Rows[0][8].ToString();
            textEdit9.Text = dt.Rows[0][9].ToString();
            richTextBox1.Text = dt.Rows[0][10].ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut11 = new SqlCommand("insert into TBL_FİRMALAR (AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3,SEKTOR) VALUES  (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17",bgl.baglanti());
            komut11.Parameters.AddWithValue("@p1", txtFirmaAd.Text);
            komut11.Parameters.AddWithValue("@p2", txtYetkılıStatu.Text);
            komut11.Parameters.AddWithValue("@p3", txtYetkılı.Text);
            komut11.Parameters.AddWithValue("@p4", mskTc.Text);
            komut11.Parameters.AddWithValue("@p5", mskTelefon1.Text);
            komut11.Parameters.AddWithValue("@p6", mskTelefon2.Text);
            komut11.Parameters.AddWithValue("@p7", mskTelefon3.Text);
            komut11.Parameters.AddWithValue("@p8", txtFaks.Text);
            komut11.Parameters.AddWithValue("@p9", Cmbil.Text);
            komut11.Parameters.AddWithValue("@p10", Cmbİlce.Text);
            komut11.Parameters.AddWithValue("@p11", textEdit9.Text);
            komut11.Parameters.AddWithValue("@p12", richTextBox1.Text);
            komut11.Parameters.AddWithValue("@p13", textEdit5.Text);
            komut11.Parameters.AddWithValue("@p14", textEdit4.Text);
            komut11.Parameters.AddWithValue("@p15", textEdit3.Text);
            komut11.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sisteme Eklendi ", "BİLGİ ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut12 = new SqlCommand("Delete From TBL_FİRMALAR WHERE ID=@p1", bgl.baglanti());
            komut12.Parameters.AddWithValue("@p1", txtİd.Text);
            komut12.Parameters.AddWithValue("@p2", txtFirmaAd.Text);
            komut12.Parameters.AddWithValue("@p3", txtYetkılıStatu.Text);
            komut12.Parameters.AddWithValue("@p4", txtYetkılı.Text);
            komut12.Parameters.AddWithValue("@p5", txtYetkılıGorev.Text);
            komut12.Parameters.AddWithValue("@p6", mskTc.Text);
            komut12.Parameters.AddWithValue("@p7", mskTelefon1.Text);
            komut12.Parameters.AddWithValue("@p8", mskTelefon2.Text);
            komut12.Parameters.AddWithValue("@p9", mskTelefon3.Text);
            komut12.Parameters.AddWithValue("@p10", txtFaks.Text);
            komut12.Parameters.AddWithValue("@p11", Cmbil.Text);
            komut12.Parameters.AddWithValue("@p12", Cmbİlce.Text);
            komut12.Parameters.AddWithValue("@p13", textEdit9.Text);
            komut12.Parameters.AddWithValue("@p14", richTextBox1.Text);
            komut12.Parameters.AddWithValue("@p15", textEdit5.Text);
            komut12.Parameters.AddWithValue("@p16", textEdit4.Text);
            komut12.Parameters.AddWithValue("@p17", textEdit3.Text);

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
    }
}
