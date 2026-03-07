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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void giderlistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*From TBL_GİDERLER",bgl.baglanti());   
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut33 = new SqlCommand("insert into TBL_GİDERLER(AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
            komut33.Parameters.AddWithValue("@p1", cmbGıderAy.Text);
            komut33.Parameters.AddWithValue("@p2", cmbGıderYıl.Text);
            komut33.Parameters.AddWithValue("@p3", txtElektrık.Text);
            komut33.Parameters.AddWithValue("@p4", txtSu.Text);
            komut33.Parameters.AddWithValue("@p5", decimal.Parse(txtDogalgaz.Text));
            komut33.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
            komut33.Parameters.AddWithValue("@p7", decimal.Parse(txtMaaslar.Text));
            komut33.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
            komut33.Parameters.AddWithValue("@p9", rchNotlar.Text);
            komut33.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Giderler Sisteme Başarıyla Kaydedildi " , "BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();

        }
        void temizle()
        {
            txtGıderId.Text = "";
            cmbGıderAy.Text = "";
            cmbGıderYıl.Text = "";
            txtElektrık.Text = "";
            txtSu.Text = "";
            txtDogalgaz.Text = "";
            txtInternet.Text = "";
            txtMaaslar.Text = "";
            txtEkstra.Text = "";
            rchNotlar.Text = "";

        }
        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            giderlistesi();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                txtGıderId.Text = dr["ID"].ToString();
                cmbGıderAy.Text= dr["AY"].ToString();
                cmbGıderYıl.Text= dr["YIL"].ToString();
                txtElektrık.Text= dr["ELEKTRIK"].ToString();
                txtSu.Text= dr["SU"].ToString();
                txtDogalgaz.Text= dr["DOGALGAZ"].ToString();
                txtInternet.Text= dr["INTERNET"].ToString();
                txtMaaslar.Text= dr["MAASLAR"].ToString();
                txtEkstra.Text= dr["EKSTRA"].ToString();
                rchNotlar.Text= dr["NOTLAR"].ToString();


            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From TBL_GİDERLER WHERE ID = @p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtGıderId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            giderlistesi();
            MessageBox.Show("Gider Listeden Silindi ", "BİLGİ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();

            
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("update TBL_GİDERLER Set AY=@p1,YIL=@p2,ELEKTRIK=@p3,SU=@p4,DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,NOTLAR=@p9 where ID =@p10", bgl.baglanti());
            cmd2.Parameters.AddWithValue("@p1", cmbGıderAy.Text);
            cmd2.Parameters.AddWithValue("@p2", cmbGıderYıl.Text);
            cmd2.Parameters.AddWithValue("@p3", decimal.Parse(txtElektrık.Text));
            cmd2.Parameters.AddWithValue("@p4", decimal.Parse(txtSu.Text));
            cmd2.Parameters.AddWithValue("@p5", decimal.Parse(txtDogalgaz.Text));
            cmd2.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
            cmd2.Parameters.AddWithValue("@p7", decimal.Parse(txtMaaslar.Text));
            cmd2.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
            cmd2.Parameters.AddWithValue("@p9", rchNotlar.Text);
            cmd2.Parameters.AddWithValue("@p10", txtGıderId.Text);
        
            cmd2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Giderler Listesi Güncellendi " , "BİLGİ ", MessageBoxButtons.OK,MessageBoxIcon.Information);
            giderlistesi();
            temizle();


        }
    }
}
