
namespace Stok_Takip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefon1 = new System.Windows.Forms.TextBox();
            this.txtAdSoyad1 = new System.Windows.Forms.TextBox();
            this.txtTc1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtToplam_fiyat1 = new System.Windows.Forms.TextBox();
            this.txtSatis_Fiyat1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMiktar1 = new System.Windows.Forms.TextBox();
            this.txtUrunAd1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBarkodNo1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.btnS_Liste = new System.Windows.Forms.Button();
            this.btnU_Liste = new System.Windows.Forms.Button();
            this.btnU_Ekle = new System.Windows.Forms.Button();
            this.btnM_Liste = new System.Windows.Forms.Button();
            this.btnM_Ekle = new System.Windows.Forms.Button();
            this.dgvlistele = new System.Windows.Forms.DataGridView();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.btnSatis_Yap = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatis_Iptal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGenel_Toplam = new System.Windows.Forms.Label();
            this.lblsatis = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistele)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Controls.Add(this.txtTelefon1);
            this.groupBox1.Controls.Add(this.txtAdSoyad1);
            this.groupBox1.Controls.Add(this.txtTc1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşter işlemleri";
            // 
            // txtTelefon1
            // 
            this.txtTelefon1.Location = new System.Drawing.Point(114, 92);
            this.txtTelefon1.Name = "txtTelefon1";
            this.txtTelefon1.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon1.TabIndex = 6;
            // 
            // txtAdSoyad1
            // 
            this.txtAdSoyad1.Location = new System.Drawing.Point(114, 60);
            this.txtAdSoyad1.Name = "txtAdSoyad1";
            this.txtAdSoyad1.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad1.TabIndex = 5;
            // 
            // txtTc1
            // 
            this.txtTc1.Location = new System.Drawing.Point(114, 28);
            this.txtTc1.Name = "txtTc1";
            this.txtTc1.Size = new System.Drawing.Size(100, 20);
            this.txtTc1.TabIndex = 2;
            this.txtTc1.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tc :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox2.Controls.Add(this.txtToplam_fiyat1);
            this.groupBox2.Controls.Add(this.txtSatis_Fiyat1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMiktar1);
            this.groupBox2.Controls.Add(this.txtUrunAd1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBarkodNo1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(992, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satış işlemleri";
            // 
            // txtToplam_fiyat1
            // 
            this.txtToplam_fiyat1.Location = new System.Drawing.Point(123, 165);
            this.txtToplam_fiyat1.Name = "txtToplam_fiyat1";
            this.txtToplam_fiyat1.Size = new System.Drawing.Size(100, 20);
            this.txtToplam_fiyat1.TabIndex = 17;
            // 
            // txtSatis_Fiyat1
            // 
            this.txtSatis_Fiyat1.Location = new System.Drawing.Point(123, 133);
            this.txtSatis_Fiyat1.Name = "txtSatis_Fiyat1";
            this.txtSatis_Fiyat1.Size = new System.Drawing.Size(100, 20);
            this.txtSatis_Fiyat1.TabIndex = 13;
            this.txtSatis_Fiyat1.TextChanged += new System.EventHandler(this.txtSatis_Fiyat_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Toplam fiyat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(26, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Satış fiyat:";
            // 
            // txtMiktar1
            // 
            this.txtMiktar1.Location = new System.Drawing.Point(123, 99);
            this.txtMiktar1.Name = "txtMiktar1";
            this.txtMiktar1.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar1.TabIndex = 12;
            this.txtMiktar1.Text = "1";
            this.txtMiktar1.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);
            // 
            // txtUrunAd1
            // 
            this.txtUrunAd1.Location = new System.Drawing.Point(123, 67);
            this.txtUrunAd1.Name = "txtUrunAd1";
            this.txtUrunAd1.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAd1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Barkod No:";
            // 
            // txtBarkodNo1
            // 
            this.txtBarkodNo1.Location = new System.Drawing.Point(123, 35);
            this.txtBarkodNo1.Name = "txtBarkodNo1";
            this.txtBarkodNo1.Size = new System.Drawing.Size(100, 20);
            this.txtBarkodNo1.TabIndex = 7;
            this.txtBarkodNo1.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ürün Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adet :";
            // 
            // btnKategori
            // 
            this.btnKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategori.Location = new System.Drawing.Point(632, 447);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(105, 52);
            this.btnKategori.TabIndex = 6;
            this.btnKategori.Text = "Kategori Ekleme";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaEkle.Location = new System.Drawing.Point(508, 447);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(105, 52);
            this.btnMarkaEkle.TabIndex = 5;
            this.btnMarkaEkle.Text = "Marka Ekleme";
            this.btnMarkaEkle.UseVisualStyleBackColor = true;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // btnS_Liste
            // 
            this.btnS_Liste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS_Liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnS_Liste.Location = new System.Drawing.Point(298, 19);
            this.btnS_Liste.Name = "btnS_Liste";
            this.btnS_Liste.Size = new System.Drawing.Size(101, 64);
            this.btnS_Liste.TabIndex = 4;
            this.btnS_Liste.Text = "Satış  Listeleme";
            this.btnS_Liste.UseVisualStyleBackColor = true;
            this.btnS_Liste.Click += new System.EventHandler(this.btnS_Liste_Click);
            // 
            // btnU_Liste
            // 
            this.btnU_Liste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU_Liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnU_Liste.Location = new System.Drawing.Point(152, 40);
            this.btnU_Liste.Name = "btnU_Liste";
            this.btnU_Liste.Size = new System.Drawing.Size(105, 52);
            this.btnU_Liste.TabIndex = 3;
            this.btnU_Liste.Text = "Ürün Listeleme";
            this.btnU_Liste.UseVisualStyleBackColor = true;
            this.btnU_Liste.Click += new System.EventHandler(this.btnU_Liste_Click);
            // 
            // btnU_Ekle
            // 
            this.btnU_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnU_Ekle.Location = new System.Drawing.Point(27, 40);
            this.btnU_Ekle.Name = "btnU_Ekle";
            this.btnU_Ekle.Size = new System.Drawing.Size(105, 52);
            this.btnU_Ekle.TabIndex = 2;
            this.btnU_Ekle.Text = "Ürün Ekleme";
            this.btnU_Ekle.UseVisualStyleBackColor = true;
            this.btnU_Ekle.Click += new System.EventHandler(this.btnU_Ekle_Click);
            // 
            // btnM_Liste
            // 
            this.btnM_Liste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM_Liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnM_Liste.Location = new System.Drawing.Point(118, 40);
            this.btnM_Liste.Name = "btnM_Liste";
            this.btnM_Liste.Size = new System.Drawing.Size(105, 52);
            this.btnM_Liste.TabIndex = 1;
            this.btnM_Liste.Text = "Müşteri Listeleme";
            this.btnM_Liste.UseVisualStyleBackColor = true;
            this.btnM_Liste.Click += new System.EventHandler(this.btnM_Liste_Click);
            // 
            // btnM_Ekle
            // 
            this.btnM_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnM_Ekle.Location = new System.Drawing.Point(7, 40);
            this.btnM_Ekle.Name = "btnM_Ekle";
            this.btnM_Ekle.Size = new System.Drawing.Size(105, 52);
            this.btnM_Ekle.TabIndex = 0;
            this.btnM_Ekle.Text = "Müşteri Ekleme";
            this.btnM_Ekle.UseVisualStyleBackColor = true;
            this.btnM_Ekle.Click += new System.EventHandler(this.btnM_Ekle_Click);
            // 
            // dgvlistele
            // 
            this.dgvlistele.AllowUserToAddRows = false;
            this.dgvlistele.AllowUserToDeleteRows = false;
            this.dgvlistele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlistele.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvlistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistele.Location = new System.Drawing.Point(284, 12);
            this.dgvlistele.Name = "dgvlistele";
            this.dgvlistele.ReadOnly = true;
            this.dgvlistele.Size = new System.Drawing.Size(673, 385);
            this.dgvlistele.TabIndex = 3;
            this.dgvlistele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistele_CellClick);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSiparisEkle.Location = new System.Drawing.Point(37, 19);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(101, 64);
            this.btnSiparisEkle.TabIndex = 5;
            this.btnSiparisEkle.Text = "Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.BtnSiparisEkle_Click);
            // 
            // btnSatis_Yap
            // 
            this.btnSatis_Yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis_Yap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSatis_Yap.Location = new System.Drawing.Point(535, 19);
            this.btnSatis_Yap.Name = "btnSatis_Yap";
            this.btnSatis_Yap.Size = new System.Drawing.Size(101, 64);
            this.btnSatis_Yap.TabIndex = 6;
            this.btnSatis_Yap.Text = "Satış Yap";
            this.btnSatis_Yap.UseVisualStyleBackColor = true;
            this.btnSatis_Yap.Click += new System.EventHandler(this.btnSatis_Yap_Click);
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(177, 19);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(101, 64);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Satış Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatis_Iptal
            // 
            this.btnSatis_Iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis_Iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSatis_Iptal.Location = new System.Drawing.Point(414, 19);
            this.btnSatis_Iptal.Name = "btnSatis_Iptal";
            this.btnSatis_Iptal.Size = new System.Drawing.Size(101, 64);
            this.btnSatis_Iptal.TabIndex = 8;
            this.btnSatis_Iptal.Text = "Satış Tümü  İptal";
            this.btnSatis_Iptal.UseVisualStyleBackColor = true;
            this.btnSatis_Iptal.Click += new System.EventHandler(this.btnSatis_Iptal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(533, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Genel Toplam:";
            // 
            // lblGenel_Toplam
            // 
            this.lblGenel_Toplam.AutoSize = true;
            this.lblGenel_Toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenel_Toplam.Location = new System.Drawing.Point(657, 414);
            this.lblGenel_Toplam.Name = "lblGenel_Toplam";
            this.lblGenel_Toplam.Size = new System.Drawing.Size(26, 18);
            this.lblGenel_Toplam.TabIndex = 9;
            this.lblGenel_Toplam.Text = "00";
            // 
            // lblsatis
            // 
            this.lblsatis.AutoSize = true;
            this.lblsatis.Location = new System.Drawing.Point(768, 419);
            this.lblsatis.Name = "lblsatis";
            this.lblsatis.Size = new System.Drawing.Size(13, 13);
            this.lblsatis.TabIndex = 10;
            this.lblsatis.Text = "0";
            this.lblsatis.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnM_Ekle);
            this.groupBox3.Controls.Add(this.btnM_Liste);
            this.groupBox3.Location = new System.Drawing.Point(22, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 152);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteri Yönetim Panosu";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnU_Ekle);
            this.groupBox4.Controls.Add(this.btnU_Liste);
            this.groupBox4.Location = new System.Drawing.Point(973, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 110);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ürün Yönetimi Panosu";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnS_Liste);
            this.groupBox5.Controls.Add(this.btnSatis_Iptal);
            this.groupBox5.Controls.Add(this.btnSatis_Yap);
            this.groupBox5.Controls.Add(this.btnSil);
            this.groupBox5.Controls.Add(this.btnSiparisEkle);
            this.groupBox5.Location = new System.Drawing.Point(284, 517);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(654, 107);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Satış Yöneti Panosu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1258, 640);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMarkaEkle);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.lblsatis);
            this.Controls.Add(this.lblGenel_Toplam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvlistele);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Stok Takip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistele)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon1;
        private System.Windows.Forms.TextBox txtAdSoyad1;
        private System.Windows.Forms.TextBox txtTc1;
        private System.Windows.Forms.TextBox txtToplam_fiyat1;
        private System.Windows.Forms.TextBox txtSatis_Fiyat1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMiktar1;
        private System.Windows.Forms.TextBox txtUrunAd1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBarkodNo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnU_Liste;
        private System.Windows.Forms.Button btnU_Ekle;
        private System.Windows.Forms.Button btnM_Liste;
        private System.Windows.Forms.Button btnM_Ekle;
        private System.Windows.Forms.DataGridView dgvlistele;
        private System.Windows.Forms.Button btnS_Liste;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Button btnSatis_Yap;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatis_Iptal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGenel_Toplam;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.Label lblsatis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

