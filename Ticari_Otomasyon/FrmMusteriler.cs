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
        void musterilistele()
        {
            DataTable dt =new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERİLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select Sehir From TBL_İLLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit1.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }

        void musteritemizle()
        {
            textEdit2.Text = "";
            textEdit7.Text = "";
            textEdit8.Text = "";
            textEdit10.Text = "";
            textEdit11.Text = "";
            maskedTextBox1.Text = "";
            textEdit1.Text = "";
            comboBoxEdit1.Text = "";
            comboBoxEdit2.Text = "";
            textEdit12.Text = "";
            textEdit13.Text = "";
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

            musterilistele();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            musteritemizle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komutmusteriekle = new SqlCommand("insert into TBL_MUSTERİLER  (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10", bgl.baglanti());
            komutmusteriekle.Parameters.AddWithValue("@p1", textEdit2.Text);
            komutmusteriekle.Parameters.AddWithValue("@p2", textEdit7.Text);
            komutmusteriekle.Parameters.AddWithValue("@p3", textEdit8.Text);
            komutmusteriekle.Parameters.AddWithValue("@p4", textEdit10.Text);
            komutmusteriekle.Parameters.AddWithValue("@p5", textEdit11.Text);
            komutmusteriekle.Parameters.AddWithValue("@p6", maskedTextBox1.Text);
            komutmusteriekle.Parameters.AddWithValue("@p7", textEdit1.Text);
            komutmusteriekle.Parameters.AddWithValue("@p8", comboBoxEdit1.Text);
            komutmusteriekle.Parameters.AddWithValue("@p9", comboBoxEdit2.Text);
            komutmusteriekle.Parameters.AddWithValue("@p10", textEdit12.Text);
            komutmusteriekle.Parameters.AddWithValue("@p11", textEdit13.Text);
            komutmusteriekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Başarıyla Eklendi ", "BİLGİ " , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            musteritemizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!= null)
            {
                //textEdit2.Text = dr["FİRMAID"].ToString();
                //textEdit7.Text = dr["AD"].ToString();
                //textEdit8.Text = dr["SEKTOR"].ToString();
                //textEdit10.Text = dr["YETKILIADSOYAD"].ToString();
                //textEdit11.Text = dr["YETKILISTATU"].ToString();
                //maskedTextBox1.Text = dr["YETKILITC"].ToString();
                //maskedTextBox2.Text = dr["TELEFON1"].ToString();
                //maskedTextBox3.Text = dr["TELEFON2"].ToString();
                //maskedTextBox4.Text = dr["TELEFON3"].ToString();
                //textEdit12.Text = dr["FAX"].ToString();
                //textEdit13.Text = dr["MAIL"].ToString();
                //comboBoxEdit1.Text = dr["IL"].ToString();
                //comboBoxEdit2.Text = dr["ILCE"].ToString();
                //comboBoxEdit2.Text = dr["ILCE"].ToString();
                //textEdit14.Text = dr["VERGIDAIRE"].ToString();
                //textEdit14.Text = dr["VERGIDAIRE"].ToString();
                //richTextBox5.Text = dr["ADRES"].ToString();

            }
        }
    }
}
