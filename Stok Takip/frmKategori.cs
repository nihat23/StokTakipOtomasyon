using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//kutuphanemiz

namespace Stok_Takip
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();

        }


        SqlConnection _baglan = new SqlConnection(@"Data Source=DESKTOP-5QARI7A\SQLEXPRESS;Initial Catalog=Stok_Takip_Db;Integrated Security=True");
        bool durum;

        private void KatagoriKontrol()
        {
            durum = true;

            _baglan.Open();

            SqlCommand komut = new SqlCommand("select *from kategoriBilgi", _baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (txtkategori.Text == oku["kategori"].ToString() || txtkategori.Text == "")
                {
                    durum = false;

                }
            }
            _baglan.Close();


        }

        private void frmKategori_Load(object sender, EventArgs e)
        {

        }


        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (txtkategori.Text != "")
            {
                KatagoriKontrol();
                if (durum == true)
                {
                    _baglan.Open();
                    SqlCommand komut = new SqlCommand("insert into kategoriBilgi values('" + txtkategori.Text + "')", _baglan);
                    komut.ExecuteNonQuery();
                    _baglan.Close();
                    txtkategori.Clear();

                    MessageBox.Show("Kategori Eklendi..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Böyle bir katagori kayıtta var.. ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtkategori.Clear();
                    txtkategori.Focus();
                }

            }
            else
            {
                MessageBox.Show("Kategori Adını Giriniz..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
    }
}
