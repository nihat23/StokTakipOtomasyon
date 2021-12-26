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
    public partial class frmlSatisListeleme : Form
    {
        public frmlSatisListeleme()
        {
            InitializeComponent();
        }


        SqlConnection _baglan = new SqlConnection(@"Data Source=DESKTOP-5QARI7A\SQLEXPRESS;Initial Catalog=Stok_Takip_Db;Integrated Security=True");
        DataSet tablo = new DataSet();

        private void SatisListeleme()
        {
            _baglan.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis", _baglan);
            adtr.Fill(tablo, "satis");
            dataGridView1.DataSource = tablo.Tables["satis"];
            _baglan.Close();
            // dgvlistele.Columns[0].Visible = false;// colum gizleme
        } 
        private void frmlSatisListeleme_Load(object sender, EventArgs e)
        {
            SatisListeleme();

           
           // dataGridView1.Columns[0].Visible = false;// colum gizleme
          




        }
    }
}
