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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_ADMINGIRIS WHERE [Kullanıcı Ad]=@p1 and Şifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("HATALI KULLANICI ADI VEYA ŞİFRE ", "",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
