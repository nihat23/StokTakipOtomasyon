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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection _baglan = new SqlConnection(@"Data Source=DESKTOP-5QARI7A\SQLEXPRESS;Initial Catalog=Stok_Takip_Db;Integrated Security=True");
        DataSet tablo = new DataSet();


        private void GenelToplamHesap()
        {
            try
            {
                _baglan.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from sepet", _baglan);
                lblGenel_Toplam.Text = komut.ExecuteScalar() + "TL";
                _baglan.Close();


            }
            catch (Exception)
            {

            }
        }

        private void Sepetlistesi()
        {
            _baglan.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", _baglan);
            adtr.Fill(tablo, "sepet");
            dgvlistele.DataSource = tablo.Tables["sepet"];
            //dgvlistele.Columns[0].Visible = false;// colum gizleme
            //dgvlistele.Columns[1].Visible = false;
            //dgvlistele.Columns[2].Visible = false;
            //dgvlistele.Columns[3].Visible = false;

            _baglan.Close();
        }

        private void btnM_Ekle_Click(object sender, EventArgs e)
        {
            frmusteriekle musteriekle = new frmusteriekle();
            musteriekle.ShowDialog();

        }

        private void btnM_Liste_Click(object sender, EventArgs e)
        {
            frmusteriListeleme MusteriListele = new frmusteriListeleme();
            MusteriListele.ShowDialog();

        }

        private void btnU_Ekle_Click(object sender, EventArgs e)
        {
            frmUrunEkleme urunekle = new frmUrunEkleme();
            urunekle.ShowDialog();

        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();

        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();

        }

        private void btnU_Liste_Click(object sender, EventArgs e)
        {
            frmUrunListeleme U_Listeleme = new frmUrunListeleme();
            U_Listeleme.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sepetlistesi();
            GenelToplamHesap();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc1.Text == "")
            {
                txtAdSoyad1.Clear();
                txtTelefon1.Clear();
            }

            _baglan.Open();
            SqlCommand komut = new SqlCommand("select * from musteri where tc like '" + txtTc1.Text + "'", _baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtAdSoyad1.Text = oku["adsoyad"].ToString();
                txtTelefon1.Text = oku["telefon"].ToString();
            }
            _baglan.Close();

        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();

            _baglan.Open();

            SqlCommand komut = new SqlCommand("select * from urun where barkodno like '" + txtBarkodNo1.Text + "'", _baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtUrunAd1.Text = oku["urunad"].ToString();
                txtSatis_Fiyat1.Text = oku["satisfiyat"].ToString();
            }
            _baglan.Close();
        }

        private void Temizle()
        {
            if (txtBarkodNo1.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktar1)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }


        bool durum;

        private void BarkodKonrol()
        {
            durum = true;

            _baglan.Open();
            SqlCommand komut = new SqlCommand("select * from sepet", _baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (txtBarkodNo1.Text == oku["barkodno"].ToString())
                {
                    durum = false;

                }
            }
            _baglan.Close();



        }

        private void BtnSiparisEkle_Click(object sender, EventArgs e)
        {
            if (txtTc1.Text != "" && txtAdSoyad1.Text != "" && txtTc1.Text != "" && txtBarkodNo1.Text != "" && txtUrunAd1.Text != "" && txtMiktar1.Text != "" && txtSatis_Fiyat1.Text != "" && txtToplam_fiyat1.Text != "")
            {
                BarkodKonrol();

                if (durum == true)
                {
                    _baglan.Open();
                    SqlCommand komut = new SqlCommand("insert into sepet  values(@tc,@adsoyad,@telefon,@barkodno,@urunad,@miktar,@satisfiyat,@toplamfiyat,@tarih)", _baglan);

                    komut.Parameters.AddWithValue("@tc", txtTc1.Text);
                    komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad1.Text);
                    komut.Parameters.AddWithValue("@telefon", txtTelefon1.Text);
                    komut.Parameters.AddWithValue("@barkodno", txtBarkodNo1.Text);
                    komut.Parameters.AddWithValue("@urunad", txtUrunAd1.Text);
                    komut.Parameters.AddWithValue("@miktar", Convert.ToInt32(txtMiktar1.Text));
                    komut.Parameters.AddWithValue("@satisfiyat", Convert.ToDecimal(txtSatis_Fiyat1.Text));
                    komut.Parameters.AddWithValue("@toplamfiyat", Convert.ToDecimal(txtToplam_fiyat1.Text));
                    komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToShortDateString());
                    komut.ExecuteNonQuery();

                    _baglan.Close();
                    MessageBox.Show("Sepede Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tablo.Clear();

                    Sepetlistesi();
                    GenelToplamHesap();
                    Temizle();
                }
                else
                {
                    _baglan.Open();

                    SqlCommand komut2 = new SqlCommand("update sepet set miktar=miktar+'" + int.Parse(txtMiktar1.Text) + "' where barkodno='" + txtBarkodNo1.Text + "'", _baglan);
                    komut2.ExecuteNonQuery();

                    SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyat=miktar*satisfiyat where barkodno='" + txtBarkodNo1.Text + "'", _baglan);
                    komut3.ExecuteNonQuery();

                    _baglan.Close();

                    MessageBox.Show("Sepede Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tablo.Clear();
                    Sepetlistesi();
                    GenelToplamHesap();
                    Temizle();

                }

            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }



        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplam_fiyat1.Text = (Convert.ToInt32(txtMiktar1.Text) * Convert.ToDecimal(txtSatis_Fiyat1.Text)).ToString();
            }
            catch (Exception)
            {

                // MessageBox.Show("Hata Yaptınız","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void txtSatis_Fiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplam_fiyat1.Text = (Convert.ToInt32(txtMiktar1.Text) * Convert.ToDecimal(txtSatis_Fiyat1.Text)).ToString();
            }
            catch (Exception)
            {

                // MessageBox.Show("Hata Yaptınız","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Silmek istediginizden eminmisiniz..", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (cvp == DialogResult.Yes)
            {
                if (Convert.ToInt32(lblsatis.Text) == 0)
                {
                    MessageBox.Show("Silinecek Satır bulunamadı..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
                else
                {
                    _baglan.Open();
                    SqlCommand komut = new SqlCommand("delete from sepet where id = @aydi", _baglan);
                    komut.Parameters.AddWithValue("@aydi", dgvlistele.CurrentRow.Cells[0].Value);
                    komut.ExecuteNonQuery();
                    _baglan.Close();
                    tablo.Clear();
                    Sepetlistesi();
                    MessageBox.Show("Kayıt Sepette  Başarıyla Silindi..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblsatis.Text = "0";

                    GenelToplamHesap();

                }

            }
        }

        private void dgvlistele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblsatis.Text = dgvlistele.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSatis_Iptal_Click(object sender, EventArgs e)
        {

            DialogResult cvp = MessageBox.Show("Kayıtlar Tümüyle silinecek  Silmek istediginizden eminmisiniz..", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (cvp == DialogResult.Yes)
            {
                _baglan.Open();
                SqlCommand komut = new SqlCommand("delete from sepet ", _baglan);//where id = @aydi
                                                                                 //komut.Parameters.AddWithValue("@aydi", dgvlistele.CurrentRow.Cells[0].Value);
                komut.ExecuteNonQuery();
                _baglan.Close();
                tablo.Clear();
                Sepetlistesi();
                MessageBox.Show("Kayıtlar Tümüyle silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenelToplamHesap();

            }
        }

        private void btnS_Liste_Click(object sender, EventArgs e)
        {
            frmlSatisListeleme satisListeleme = new frmlSatisListeleme();
            satisListeleme.ShowDialog();

        }

        private void btnSatis_Yap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvlistele.RowCount; i++)
            {
                _baglan.Open();
                SqlCommand komut1 = new SqlCommand("insert into satis  values(@tc,@adsoyad,@telefon,@barkodno,@urunad,@miktar,@satisfiyat,@toplamfiyat,@tarih)", _baglan);

                komut1.Parameters.AddWithValue("@tc", txtTc1.Text);
                komut1.Parameters.AddWithValue("@adsoyad", txtAdSoyad1.Text);
                komut1.Parameters.AddWithValue("@telefon", txtTelefon1.Text);
                komut1.Parameters.AddWithValue("@barkodno", dgvlistele.Rows[i].Cells["barkodno"].Value.ToString());
                komut1.Parameters.AddWithValue("@urunad", dgvlistele.Rows[i].Cells["urunad"].Value.ToString());
                komut1.Parameters.AddWithValue("@miktar", Convert.ToInt32(dgvlistele.Rows[i].Cells["miktar"].Value.ToString()));
                komut1.Parameters.AddWithValue("@satisfiyat", Convert.ToDecimal(dgvlistele.Rows[i].Cells["satisfiyat"].Value.ToString()));
                komut1.Parameters.AddWithValue("@toplamfiyat", Convert.ToDecimal(dgvlistele.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                komut1.Parameters.AddWithValue("@tarih", DateTime.Now.ToShortDateString());
                komut1.ExecuteNonQuery();

                SqlCommand komut2 = new SqlCommand("update urun set miktar=miktar-'" + int.Parse(dgvlistele.Rows[i].Cells["miktar"].Value.ToString()) + "' where barkodno='" + dgvlistele.Rows[i].Cells["barkodno"].Value.ToString() + "'", _baglan);//çıkarma
                komut2.ExecuteNonQuery();

                _baglan.Close();
            }
            _baglan.Open();
            SqlCommand komut = new SqlCommand("delete from sepet ", _baglan);//where id = @aydi
                                                                             //komut.Parameters.AddWithValue("@aydi", dgvlistele.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            _baglan.Close();

            tablo.Clear();
            Sepetlistesi();
            MessageBox.Show("Miktar Stoktan düşürüldü", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GenelToplamHesap();
        }
    }
}
