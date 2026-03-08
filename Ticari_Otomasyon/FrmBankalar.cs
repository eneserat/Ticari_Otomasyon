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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void listele ()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute BankaBilgileri",bgl.baglanti());
            da.Fill (dt);
            gridControl1.DataSource= dt;


        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select Sehir From TBL_İLLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBankaIl.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }
        void firmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select FİRMAID,AD From TBL_FİRMALAR ", bgl.baglanti());
            da.Fill (dt);
            lookUpEdit1.Properties.ValueMember = "FİRMAID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
        }
        void temizle()
        {
            txtBankaId.Text = "";
            txtBankaAdı.Text = "";
            cmbBankaIl.Text  = "";
            cmbBankaIlce.Text = "";
            txtBankaAdı.Text = "";
            txtBankaSube.Text = "";
            txtIban.Text = "";
            txtHesapNumarası.Text = "";
            txtYetkılı.Text = "";
            mskTelefon.Text = "";
            mskTarıh.Text = "";
            txtHesapTuru.Text = "";
            lookUpEdit1.Text = "";
        }

        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            listele ();
            sehirListesi();
            firmaListesi();
            temizle();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1.EditValue == null)
            {
                MessageBox.Show("Lütfen bir firma seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            SqlCommand komutekle = new SqlCommand("insert into TBL_BANKALAR (BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", txtBankaAdı.Text);
            komutekle.Parameters.AddWithValue("@p2", cmbBankaIl.Text);
            komutekle.Parameters.AddWithValue("@p3", cmbBankaIlce.Text);
            komutekle.Parameters.AddWithValue("@p4", txtBankaSube.Text);
            komutekle.Parameters.AddWithValue("@p5", txtIban.Text);
            komutekle.Parameters.AddWithValue("@p6", txtHesapNumarası.Text);
            komutekle.Parameters.AddWithValue("@p7", txtYetkılı.Text);
            komutekle.Parameters.AddWithValue("@p8", mskTelefon.Text);
            komutekle.Parameters.AddWithValue("@p9", mskTarıh.Text);
            komutekle.Parameters.AddWithValue("@p10", txtHesapTuru.Text);
            komutekle.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komutekle.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgileri Sisteme Eklendi " ,"BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void mskTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtBankaId.Text = dr["ID"].ToString();
            
                txtBankaAdı.Text = dr["BANKAADI"].ToString();
                cmbBankaIl.Text = dr["IL"].ToString();
                cmbBankaIlce.Text = dr["ILCE"].ToString();
                txtBankaSube.Text = dr["SUBE"].ToString();
                txtIban.Text = dr["IBAN"].ToString();
                txtHesapNumarası.Text = dr["HESAPNO"].ToString();
                txtYetkılı.Text = dr["YETKILI"].ToString();
                mskTelefon.Text = dr["TELEFON"].ToString() ;
                mskTarıh.Text = dr["TARIH"].ToString();
                txtHesapTuru.Text = dr["HESAPTURU"].ToString();
             
              


            }
        }

        private void cmbBankaIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBankaIlce.Properties.Items.Clear();
            SqlCommand sqlCommand = new SqlCommand("Select İLCE From TBL_İLCELER Where Sehir=@p1 ", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", cmbBankaIl.SelectedIndex + 1);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                cmbBankaIlce.Properties.Items.Add(reader[0]);
            }
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            temizle();

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete From  TBL_BANKALAR where ID=@p1",bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", txtBankaId.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            temizle();
            MessageBox.Show("Banka Bilgisi Sistemden Silindi ", "BİLGİ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("update TBL_BANKALAR  set  BANKAADI=@P1,IL=@P2,ILCE=@P3,SUBE=@P4,IBAN=@P5,HESAPNO=@P6,YETKILI=@P7,TELEFON=@P8,TARIH=@P9,HESAPTURU=@P10,FIRMAID=P11 WHERE ID =@12", bgl.baglanti());
            update.Parameters.AddWithValue("@p1", txtBankaAdı.Text);
            update.Parameters.AddWithValue("@p2", cmbBankaIl.Text);
            update.Parameters.AddWithValue("@p3", cmbBankaIlce.Text);
            update.Parameters.AddWithValue("@p4", txtBankaSube.Text);
            update.Parameters.AddWithValue("@p5", txtIban.Text);
            update.Parameters.AddWithValue("@p6", txtHesapNumarası.Text);
            update.Parameters.AddWithValue("@p7", txtYetkılı.Text);
            update.Parameters.AddWithValue("@p8", mskTelefon.Text);
            update.Parameters.AddWithValue("@p9", mskTarıh.Text);
            update.Parameters.AddWithValue("@p10", txtHesapTuru.Text);
            update.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            update.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgileri Güncellendi ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            update.ExecuteNonQuery();

        }
    }
}
