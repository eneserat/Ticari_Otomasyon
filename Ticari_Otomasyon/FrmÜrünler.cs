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
    public partial class FrmÜrünler : Form
    {
        public FrmÜrünler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }   

        private void FrmÜrünler_Load(object sender, EventArgs e)
        {
            listele();
            

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(mskYil.Text));
            komut.Parameters.AddWithValue("@p5", int.Parse(nudAdet.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text));
            komut.Parameters.AddWithValue("@p8", rtbDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close(); 
            MessageBox.Show("Ürün Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("Select * From TBL_URUNLER where ID=@p1", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", gridView1.GetFocusedRowCellValue("ID").ToString());
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            txtID.Text = dt.Rows[0][0].ToString();
            txtAd.Text = dt.Rows[0][1].ToString();
            txtMarka.Text = dt.Rows[0][2].ToString();
            txtModel.Text = dt.Rows[0][3].ToString();
            mskYil.Text = dt.Rows[0][4].ToString();
            nudAdet.Text = dt.Rows[0][5].ToString();
            txtAlisFiyat.Text = dt.Rows[0][6].ToString();
            txtSatisFiyat.Text = dt.Rows[0][7].ToString();
            rtbDetay.Text = dt.Rows[0][8].ToString();
            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
         

        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("Delete From TBL_URUNLER where ID=@p1", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", txtID.Text);
            sqlCommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("Update TBL_URUNLER set URUNAD=@p1,MARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALISFIYAT=@p6,SATISFIYAT=@p7,DETAY=@p8 where ID=@p9", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", txtAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtMarka.Text);

            sqlCommand.Parameters.AddWithValue("@p3", txtModel.Text);
            sqlCommand.Parameters.AddWithValue("@p4", decimal.Parse(mskYil.Text));
            sqlCommand.Parameters.AddWithValue("@p5", int.Parse(nudAdet.Text));
            sqlCommand.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text));
            sqlCommand.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text));
            sqlCommand.Parameters.AddWithValue("@p8", rtbDetay.Text);
            sqlCommand.Parameters.AddWithValue("@p9", txtID.Text);
            sqlCommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
