using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//kutuphanemiz
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class frmUrunEkleme : Form
    {
        public frmUrunEkleme()
        {
            InitializeComponent();
        }

        SqlConnection _baglan = new SqlConnection(@"Data Source=DESKTOP-5QARI7A\SQLEXPRESS;Initial Catalog=Stok_Takip_Db;Integrated Security=True");
        bool durum;


        private void BarkodKontrol()
        {
            durum = true;
            _baglan.Open();
            SqlCommand komut1 = new SqlCommand("select * from urun", _baglan);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                if (txtY_Barkod.Text == oku1["barkodno"].ToString() || txtY_Barkod.Text == "")
                {
                    durum = false;

                }
            }
            _baglan.Close();

        }

        private void kategoriGetir()
        {
            _baglan.Open();
            SqlCommand komut = new SqlCommand("select * from kategoriBilgi", _baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboY_kategori.Items.Add(oku["kategori"].ToString());
            }
            _baglan.Close();
        }



        private void frmUrunEkleme_Load(object sender, EventArgs e)
        {
            kategoriGetir();

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboY_Markaa.Items.Clear();
            comboY_Markaa.Text = "";
            _baglan.Open();
            SqlCommand komut = new SqlCommand("select * from markaBilgi where kategori='" + comboY_kategori.SelectedItem + "' ", _baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboY_Markaa.Items.Add(oku["marka"].ToString());
            }
            _baglan.Close();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();
            if (durum == true)
            {
                _baglan.Open();

                SqlCommand komut = new SqlCommand("insert into urun values(@barkodno,@kategori,@marka,@urunad,@miktar,@alisfiyat,@satisfiyat,@tarih)", _baglan);
                komut.Parameters.AddWithValue("@barkodno", txtY_Barkod.Text);
                komut.Parameters.AddWithValue("@kategori", comboY_kategori.SelectedItem);
                komut.Parameters.AddWithValue("@marka", comboY_Markaa.SelectedItem);
                komut.Parameters.AddWithValue("@urunad", txtY_UrunAdi.Text);
                komut.Parameters.AddWithValue("@miktar", int.Parse(txtY_Miktar.Text));
                komut.Parameters.AddWithValue("@alisfiyat", Convert.ToDecimal(txtY_A_fiyat.Text));
                komut.Parameters.AddWithValue("@satisfiyat", Convert.ToDecimal(txtY_Satis_Fiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToShortDateString());

                komut.ExecuteNonQuery();
                _baglan.Close();

                MessageBox.Show("Ürün başarıyla Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }

                }
            }
            else
            {
                MessageBox.Show("Böyle bir Barkod No Kayıtta Var.. ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }




        }

        private void txtVarOlan_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkod.Text == "")
            {
                lblMiktar.Text = "0";

                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }
                }
            }

            _baglan.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodno like '" + txtBarkod.Text + "'", _baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtKategori.Text = oku["kategori"].ToString();
                txtMarka.Text = oku["marka"].ToString();
                txtUrunAdi.Text = oku["urunad"].ToString();
                lblMiktar.Text = oku["miktar"].ToString();
                txtAlisFiyat.Text = oku["alisfiyat"].ToString();
                txtSatisFiyat.Text = oku["satisfiyat"].ToString();

            }
            _baglan.Close();


        }

        private void btnEklee_Click(object sender, EventArgs e)
        {
            _baglan.Open();

            SqlCommand komut = new SqlCommand("update urun set miktar=miktar+'" + int.Parse(txtMiktar.Text) + "' where barkodno='" + txtBarkod.Text + "'", _baglan);
            komut.ExecuteNonQuery();
            _baglan.Close();

            MessageBox.Show("Var olan ürüne ekleme yapıldı..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
            }
        }
    }
}
