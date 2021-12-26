using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//

namespace Stok_Takip
{
    public partial class frmusteriListeleme : Form
    {
        public frmusteriListeleme()
        {
            InitializeComponent();
        }


        SqlConnection _baglan = new SqlConnection(@"Data Source=DESKTOP-5QARI7A\SQLEXPRESS;Initial Catalog=Stok_Takip_Db;Integrated Security=True");
        DataSet daSet = new DataSet();


        private void FrmusteriListeleme_Load(object sender, EventArgs e)
        {
            VerileriListele();

        }

        private void VerileriListele()
        {
            _baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from musteri", _baglan);
            adtr.Fill(daSet, "musteri");
            dgvmusteriListele.DataSource = daSet.Tables["musteri"];
            _baglan.Close();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label7.Text = dgvmusteriListele.CurrentRow.Cells["id"].Value.ToString();
            txtTc.Text = dgvmusteriListele.CurrentRow.Cells["tc"].Value.ToString();
            txtAd_Soyad.Text = dgvmusteriListele.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dgvmusteriListele.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dgvmusteriListele.CurrentRow.Cells["adres"].Value.ToString();
            txtMail.Text = dgvmusteriListele.CurrentRow.Cells["eposta"].Value.ToString();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTc.Text != "" && txtAd_Soyad.Text != "" && txtTelefon.Text != "" && txtAdres.Text != "" && txtMail.Text != "")
            {
                _baglan.Open();

                SqlCommand komut = new SqlCommand("update musteri set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,adres=@adres,eposta=@eposta where id=@id", _baglan);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(label7.Text));
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAd_Soyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@eposta", txtMail.Text);
                komut.ExecuteNonQuery();
                _baglan.Close();
                MessageBox.Show("Güncelleme yapıldı..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                daSet.Clear();
                VerileriListele();

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları doldurunuz..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }



        }

        private void brnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Silmek istediginizden eminmisiniz..", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (cvp == DialogResult.Yes)
            {
                if (Convert.ToInt32(label7.Text) == 0)
                {
                    MessageBox.Show("Silinecek Satır bulunamadı..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
                else
                {
                    _baglan.Open();
                    SqlCommand komut = new SqlCommand("delete from musteri where id = @aydi", _baglan);
                    komut.Parameters.AddWithValue("@aydi", dgvmusteriListele.CurrentRow.Cells[0].Value);
                    komut.ExecuteNonQuery();
                    _baglan.Close();
                    daSet.Clear();
                    VerileriListele();
                    MessageBox.Show("Kayıt Başarıyla Silindi..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label7.Text = "0";
                }

            }

        }

        private void dgvmusteriListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label7.Text = dgvmusteriListele.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            _baglan.Open();
            DataTable tablo = new DataTable();

            SqlDataAdapter adtr = new SqlDataAdapter("select *from musteri where tc like '%" + txtarama.Text + "%'", _baglan);
            adtr.Fill(tablo);
            dgvmusteriListele.DataSource = tablo;
            _baglan.Close();

        }
    }
}

