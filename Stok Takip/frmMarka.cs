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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }

        SqlConnection _baglan = new SqlConnection(@"Data Source=DESKTOP-5QARI7A\SQLEXPRESS;Initial Catalog=Stok_Takip_Db;Integrated Security=True");
        bool durum;

        private void MarkaKontrol()
        {
            durum = true;

            _baglan.Open();

            SqlCommand komut = new SqlCommand("select * from markaBilgi", _baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (cmbkategori.Text == oku["kategori"].ToString() && txtmarka.Text == oku["marka"].ToString() || cmbkategori.Text == "" || txtmarka.Text == "")
                {
                    durum = false;
                }
            }
            _baglan.Close();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            if (txtmarka.Text != "" && cmbkategori.Text != "")
            {
                MarkaKontrol();
                if (durum == true)
                {
                    _baglan.Open();
                    SqlCommand komut = new SqlCommand("insert into markaBilgi values('" + txtmarka.Text + "','" + cmbkategori.Text + "')", _baglan);
                    komut.ExecuteNonQuery();
                    _baglan.Close();
                    txtmarka.Clear();
                    cmbkategori.Text = "";

                    MessageBox.Show("Marka Eklendi..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Böyle bir marka kayıt var.. ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtmarka.Clear();
                    txtmarka.Focus();
                }

            }
            else
            {
                MessageBox.Show("Marka yada  kategori Giriniz..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            kategoriGetir();
        }

        private void kategoriGetir()
        {
            _baglan.Open();
            SqlCommand komut = new SqlCommand("select * from kategoriBilgi", _baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbkategori.Items.Add(oku["kategori"].ToString());
            }
            _baglan.Close();
        }
    }
}
