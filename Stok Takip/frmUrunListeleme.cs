using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//kutuphanemız
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class frmUrunListeleme : Form
    {
        public frmUrunListeleme()
        {
            InitializeComponent();
        }

        SqlConnection _baglan = new SqlConnection(@"Data Source=DESKTOP-5QARI7A\SQLEXPRESS;Initial Catalog=Stok_Takip_Db;Integrated Security=True");
        DataSet data = new DataSet();

        private void kategoriGetir()
        {
            _baglan.Open();
            SqlCommand komut = new SqlCommand("select * from kategoriBilgi", _baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbKategori.Items.Add(oku["kategori"].ToString());
            }
            _baglan.Close();
        }



        private void frmUrunListeleme_Load(object sender, EventArgs e)
        {
            UrunListele();
            kategoriGetir();

        }

        private void UrunListele()
        {
            _baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun", _baglan);
            adtr.Fill(data, "urun");
            dataGridView1.DataSource = data.Tables["urun"];
            _baglan.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkod.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            txtKategori.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            txtMarka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            txtUrunAdi.Text = dataGridView1.CurrentRow.Cells["urunad"].Value.ToString();
            txtMiktar.Text = dataGridView1.CurrentRow.Cells["miktar"].Value.ToString();
            txtAlisFiyat.Text = dataGridView1.CurrentRow.Cells["alisfiyat"].Value.ToString();
            txtSatisFiyat.Text = dataGridView1.CurrentRow.Cells["satisfiyat"].Value.ToString();

        }

        private void btnKategoriMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBarkod.Text != "")
            {
                _baglan.Open();
                SqlCommand komut = new SqlCommand("update urun set  kategori=@kategori,marka=@marka where barkodno=@barkodno", _baglan);
                komut.Parameters.AddWithValue("@barkodno", txtBarkod.Text);
                komut.Parameters.AddWithValue("@kategori", cmbKategori.Text);
                komut.Parameters.AddWithValue("@marka", cmbMarka.Text);

                komut.ExecuteNonQuery();
                _baglan.Close();
                MessageBox.Show("Güncelleme işlemi başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data.Clear();
                UrunListele();

                foreach (Control item in Controls)
                {
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBarkod.Text != "" && txtUrunAdi.Text != "" && txtMiktar.Text != "" && txtAlisFiyat.Text != "" && txtSatisFiyat.Text != "")
            {
                _baglan.Open();
                SqlCommand komut = new SqlCommand("update urun set  urunad=@urunad,miktar=@miktar,alisfiyat=@alisfiyat,satisfiyat=@satisfiyat where barkodno=@barkodno", _baglan);
                komut.Parameters.AddWithValue("@barkodno", txtBarkod.Text);
                komut.Parameters.AddWithValue("@urunad", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktar", int.Parse(txtMiktar.Text));
                komut.Parameters.AddWithValue("@alisfiyat", Convert.ToDecimal(txtAlisFiyat.Text));
                komut.Parameters.AddWithValue("@satisfiyat", Convert.ToDecimal(txtSatisFiyat.Text));
                komut.ExecuteNonQuery();
                _baglan.Close();
                MessageBox.Show("Güncelleme işlemi başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data.Clear();
                UrunListele();

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
                MessageBox.Show("Lütfen Alanları Doldurunuz..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }



        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMarka.Items.Clear();
            cmbMarka.Text = "";
            _baglan.Open();
            SqlCommand komut = new SqlCommand("select * from markaBilgi where kategori='" + cmbKategori.SelectedItem + "' ", _baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbMarka.Items.Add(oku["marka"].ToString());
            }
            _baglan.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Silmek istediginizden eminmisiniz..", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (cvp == DialogResult.Yes)
            {
                if (Convert.ToInt32(lblSil.Text) == 0)
                {
                    MessageBox.Show("Silinecek Satır bulunamadı..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
                else
                {
                    _baglan.Open();
                    SqlCommand komut = new SqlCommand("delete from urun where id = @aydi", _baglan);
                    komut.Parameters.AddWithValue("@aydi", dataGridView1.CurrentRow.Cells[0].Value);
                    komut.ExecuteNonQuery();
                    _baglan.Close();
                    data.Clear();
                    UrunListele();
                    MessageBox.Show("Kayıt Başarıyla Silindi..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblSil.Text = "0";
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSil.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            _baglan.Open();
            DataTable tablo = new DataTable();

            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where barkodno like '%" + txtara.Text + "%'", _baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            _baglan.Close();
        }
    }
}
