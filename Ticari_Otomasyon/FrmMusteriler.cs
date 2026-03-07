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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERİLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select Sehir From TBL_İLLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                cmbIL.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }
        void ilcelistesi()
        {
            SqlCommand komut = new SqlCommand("Select İlce From TBL_İLCELER",bgl.baglanti());   
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbILCE.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            
            SqlCommand komut2 = new SqlCommand("insert into TBL_MUSTERİLER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",bgl.baglanti()) ;
            komut2.Parameters.AddWithValue("@p1", txtMustAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtMustSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskTelefonBir.Text);
            komut2.Parameters.AddWithValue("@p4", mskTelefonİki.Text);
            komut2.Parameters.AddWithValue("@p5", mskTC.Text);
            komut2.Parameters.AddWithValue("@p6", txtMustMaıl.Text);
            komut2.Parameters.AddWithValue("@p7", cmbIL.Text);
            komut2.Parameters.AddWithValue("@p8",cmbILCE.Text);
            komut2.Parameters.AddWithValue("@p9", richTextBox1.Text);
            komut2.Parameters.AddWithValue("@p10", txtVergi.Text);  
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);






        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
            this.Size = new Size(1942, 1102); 
        }

        private void cmbIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbILCE.Properties.Items.Clear();
            SqlCommand sqlCommand = new SqlCommand("Select İLCE From TBL_İLCELER Where Sehir=@p1 ",bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", cmbIL.SelectedIndex+1);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read()) 
            {
                cmbILCE.Properties.Items.Add(reader[0]);
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("Select * From TBL_MUSTERİLER where ID=@p1", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", gridView1.GetFocusedRowCellValue("ID").ToString());
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            txtMustID.Text = dt.Rows[0][0].ToString();
            txtMustAd.Text = dt.Rows[0][1].ToString();
            txtMustSoyad.Text = dt.Rows[0][2].ToString();
            mskTelefonBir.Text = dt.Rows[0][3].ToString();
            mskTelefonİki.Text = dt.Rows[0][4].ToString();
            mskTC.Text = dt.Rows[0][5].ToString();
            txtMustMaıl.Text = dt.Rows[0][6].ToString();
            cmbIL.Text = dt.Rows[0][7].ToString();
            cmbILCE.Text = dt.Rows[0][8].ToString();
            richTextBox1.Text = dt.Rows[0][9].ToString();
            txtVergi.Text=dt.Rows[0][10].ToString();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete From TBL_MUSTERİLER Where ID =@p1 ",bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", txtMustID.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtMustAd.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtMustSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p4", mskTelefonBir.Text);
            sqlCommand.Parameters.AddWithValue("@p5", mskTelefonİki.Text);
            sqlCommand.Parameters.AddWithValue("@p6", mskTC.Text);
            sqlCommand.Parameters.AddWithValue("@p7", cmbIL.Text);
            sqlCommand.Parameters.AddWithValue("@p8", cmbILCE.Text);
            sqlCommand.Parameters.AddWithValue("@p9", txtMustID.Text);
            sqlCommand.Parameters.AddWithValue("@p10", richTextBox1.Text);
            sqlCommand.Parameters.AddWithValue("@p11", txtVergi.Text);

            if (string.IsNullOrEmpty(txtMustID.Text))
            {
                MessageBox.Show("Lütfen silinecek müşteri ID'sini girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (MessageBox.Show("Gerçekten silmek istiyor musunuz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                SqlCommand komut = new SqlCommand(
                    "DELETE FROM TBL_MUSTERİLER WHERE ID=@p1",
                    bgl.baglanti()
                );
                komut.Parameters.AddWithValue("@p1", txtMustID.Text); 

                komut.ExecuteNonQuery(); 
                MessageBox.Show("Müşteri sistemden silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

  

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Update TBL_MUSTERİLER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TELEFON2=@p4,TC=@p5,MAIL=@p6,IL=@p7,ILCE=@p8,ADRES=@p9,VERGIDAIRE=@p10 where ID = @p11", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", txtMustAd.Text);
            komut1.Parameters.AddWithValue("@p2", txtMustSoyad.Text);
            komut1.Parameters.AddWithValue("@p3", mskTelefonBir.Text);
            komut1.Parameters.AddWithValue("@p4", mskTelefonİki.Text);
            komut1.Parameters.AddWithValue("@p5", mskTC.Text);
            komut1.Parameters.AddWithValue("@p6", cmbIL.Text);
            komut1.Parameters.AddWithValue("@p7", cmbILCE.Text);
            komut1.Parameters.AddWithValue("@p8", txtMustID.Text);
            komut1.Parameters.AddWithValue("@p9", richTextBox1.Text);
            komut1.Parameters.AddWithValue("@p10", txtVergi.Text);
            komut1.Parameters.AddWithValue("@p11", txtMustID.Text);
            MessageBox.Show("Müşteri Bilgileri Güncelledi" , "BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
