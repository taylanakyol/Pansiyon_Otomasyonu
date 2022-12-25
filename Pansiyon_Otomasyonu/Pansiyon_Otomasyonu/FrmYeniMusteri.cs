using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pansiyon_Otomasyonu
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-NB43UN3;Initial Catalog=Pansiyon;Integrated Security=True");


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Rekli Butonlar Boş Odaları Gösterir.");
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir.");
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);
            TimeSpan Sonuc = BuyukTarih - KucukTarih;
            label10.Text = Sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(label10.Text) * 50;
            TxtUcret.Text = ucret.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + comboBox1.Text +"','"+MskTxtTelefon.Text+ "','"+TxtMail.Text+"','"+TxtKimlikNo.Text+"','"+TxtOdaNo.Text+"','"+TxtUcret.Text+"','"+DtpGirisTarihi.Value.ToString("yyyy-MM-dd")+"','"+DtpCikisTarihi.Value.ToString("yyyy-MM-dd")+" ')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Oluşturuldu.");

        }

        private void TxtUcret_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
