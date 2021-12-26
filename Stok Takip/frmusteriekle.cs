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
    public partial class frmusteriekle : Form
    {
        public frmusteriekle()
        {
            InitializeComponent();
        }

        void TextTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        SqlConnection _baglan = new SqlConnection(@"Data Source=DESKTOP-5QARI7A\SQLEXPRESS;Initial Catalog=Stok_Takip_Db;Integrated Security=True");

        private void btnMuster_Ekle_Click(object sender, EventArgs e)
        {
            if (txtTc.Text != "" && txtAd_Soyad.Text != "" && txtTelefon.Text != "" && txtAdres.Text != "" && txtMail.Text != "")
            {
                _baglan.Open();
                SqlCommand komut = new SqlCommand("insert into musteri values(@tc,@adsoyad,@telefon,@adres,@eposta)", _baglan);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAd_Soyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@eposta", txtMail.Text);
                komut.ExecuteNonQuery();
                _baglan.Close();
                MessageBox.Show("Müşteri Başarıyla Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları doldurunuz..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }


        }

        private void frmusteriekle_Load(object sender, EventArgs e)
        {

        }
    }
}
