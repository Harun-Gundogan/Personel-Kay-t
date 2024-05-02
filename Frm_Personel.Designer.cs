namespace Personel_Kayıt
{
    partial class Frm_Personel
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grp_Per_Kayit = new System.Windows.Forms.GroupBox();
            this.lbl_Rd = new System.Windows.Forms.Label();
            this.lbl_Maas = new System.Windows.Forms.Label();
            this.rd_Erkek = new System.Windows.Forms.RadioButton();
            this.rd_Kadin = new System.Windows.Forms.RadioButton();
            this.mtxt_Maas = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Meslek = new System.Windows.Forms.Label();
            this.cmb_Sehir = new System.Windows.Forms.ComboBox();
            this.lbl_Durum = new System.Windows.Forms.Label();
            this.txt_Meslek = new System.Windows.Forms.TextBox();
            this.lbl_Sehir = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.grp_Islem = new System.Windows.Forms.GroupBox();
            this.btn_Raporlar = new System.Windows.Forms.Button();
            this.btn_Grafik = new System.Windows.Forms.Button();
            this.btn_Istatislik = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.grp_Kayit = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perCinsiyetDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelProjeDataSet1 = new Personel_Kayıt.PersonelProjeDataSet1();
            this.tbl_PersonelTableAdapter = new Personel_Kayıt.PersonelProjeDataSet1TableAdapters.Tbl_PersonelTableAdapter();
            this.grp_Per_Kayit.SuspendLayout();
            this.grp_Islem.SuspendLayout();
            this.grp_Kayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelProjeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Per_Kayit
            // 
            this.grp_Per_Kayit.Controls.Add(this.lbl_Rd);
            this.grp_Per_Kayit.Controls.Add(this.lbl_Maas);
            this.grp_Per_Kayit.Controls.Add(this.rd_Erkek);
            this.grp_Per_Kayit.Controls.Add(this.rd_Kadin);
            this.grp_Per_Kayit.Controls.Add(this.mtxt_Maas);
            this.grp_Per_Kayit.Controls.Add(this.lbl_Meslek);
            this.grp_Per_Kayit.Controls.Add(this.cmb_Sehir);
            this.grp_Per_Kayit.Controls.Add(this.lbl_Durum);
            this.grp_Per_Kayit.Controls.Add(this.txt_Meslek);
            this.grp_Per_Kayit.Controls.Add(this.lbl_Sehir);
            this.grp_Per_Kayit.Controls.Add(this.txt_Soyad);
            this.grp_Per_Kayit.Controls.Add(this.lbl_Soyad);
            this.grp_Per_Kayit.Controls.Add(this.txt_Ad);
            this.grp_Per_Kayit.Controls.Add(this.lbl_Ad);
            this.grp_Per_Kayit.Controls.Add(this.txt_Id);
            this.grp_Per_Kayit.Controls.Add(this.lbl_Id);
            this.grp_Per_Kayit.Location = new System.Drawing.Point(11, 10);
            this.grp_Per_Kayit.Name = "grp_Per_Kayit";
            this.grp_Per_Kayit.Size = new System.Drawing.Size(400, 349);
            this.grp_Per_Kayit.TabIndex = 18;
            this.grp_Per_Kayit.TabStop = false;
            this.grp_Per_Kayit.Text = "Personel Kayıt";
            // 
            // lbl_Rd
            // 
            this.lbl_Rd.AutoSize = true;
            this.lbl_Rd.Location = new System.Drawing.Point(63, 296);
            this.lbl_Rd.Name = "lbl_Rd";
            this.lbl_Rd.Size = new System.Drawing.Size(78, 24);
            this.lbl_Rd.TabIndex = 20;
            this.lbl_Rd.Text = "Cinsiyet";
            this.lbl_Rd.Visible = false;
            this.lbl_Rd.TextChanged += new System.EventHandler(this.lbl_Rd_TextChanged);
            // 
            // lbl_Maas
            // 
            this.lbl_Maas.AutoSize = true;
            this.lbl_Maas.Location = new System.Drawing.Point(77, 188);
            this.lbl_Maas.Name = "lbl_Maas";
            this.lbl_Maas.Size = new System.Drawing.Size(59, 24);
            this.lbl_Maas.TabIndex = 15;
            this.lbl_Maas.Text = "Maaş:";
            // 
            // rd_Erkek
            // 
            this.rd_Erkek.AutoSize = true;
            this.rd_Erkek.Location = new System.Drawing.Point(241, 217);
            this.rd_Erkek.Name = "rd_Erkek";
            this.rd_Erkek.Size = new System.Drawing.Size(79, 28);
            this.rd_Erkek.TabIndex = 7;
            this.rd_Erkek.TabStop = true;
            this.rd_Erkek.Text = "Erkek";
            this.rd_Erkek.UseVisualStyleBackColor = true;
            this.rd_Erkek.CheckedChanged += new System.EventHandler(this.rd_Bekar_CheckedChanged);
            // 
            // rd_Kadin
            // 
            this.rd_Kadin.AutoSize = true;
            this.rd_Kadin.Location = new System.Drawing.Point(155, 217);
            this.rd_Kadin.Name = "rd_Kadin";
            this.rd_Kadin.Size = new System.Drawing.Size(80, 28);
            this.rd_Kadin.TabIndex = 6;
            this.rd_Kadin.TabStop = true;
            this.rd_Kadin.Text = "Kadın";
            this.rd_Kadin.UseVisualStyleBackColor = true;
            this.rd_Kadin.CheckedChanged += new System.EventHandler(this.rd_Evli_CheckedChanged);
            // 
            // mtxt_Maas
            // 
            this.mtxt_Maas.Location = new System.Drawing.Point(154, 181);
            this.mtxt_Maas.Mask = "000000";
            this.mtxt_Maas.Name = "mtxt_Maas";
            this.mtxt_Maas.Size = new System.Drawing.Size(166, 32);
            this.mtxt_Maas.TabIndex = 5;
            this.mtxt_Maas.ValidatingType = typeof(int);
            // 
            // lbl_Meslek
            // 
            this.lbl_Meslek.AutoSize = true;
            this.lbl_Meslek.Location = new System.Drawing.Point(63, 259);
            this.lbl_Meslek.Name = "lbl_Meslek";
            this.lbl_Meslek.Size = new System.Drawing.Size(74, 24);
            this.lbl_Meslek.TabIndex = 11;
            this.lbl_Meslek.Text = "Meslek:";
            // 
            // cmb_Sehir
            // 
            this.cmb_Sehir.FormattingEnabled = true;
            this.cmb_Sehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin (İçel)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmb_Sehir.Location = new System.Drawing.Point(155, 145);
            this.cmb_Sehir.Name = "cmb_Sehir";
            this.cmb_Sehir.Size = new System.Drawing.Size(166, 32);
            this.cmb_Sehir.TabIndex = 4;
            // 
            // lbl_Durum
            // 
            this.lbl_Durum.AutoSize = true;
            this.lbl_Durum.Location = new System.Drawing.Point(63, 219);
            this.lbl_Durum.Name = "lbl_Durum";
            this.lbl_Durum.Size = new System.Drawing.Size(78, 24);
            this.lbl_Durum.TabIndex = 9;
            this.lbl_Durum.Text = "Cinsiyet";
            // 
            // txt_Meslek
            // 
            this.txt_Meslek.Location = new System.Drawing.Point(155, 251);
            this.txt_Meslek.Name = "txt_Meslek";
            this.txt_Meslek.Size = new System.Drawing.Size(165, 32);
            this.txt_Meslek.TabIndex = 8;
            // 
            // lbl_Sehir
            // 
            this.lbl_Sehir.AutoSize = true;
            this.lbl_Sehir.Location = new System.Drawing.Point(79, 152);
            this.lbl_Sehir.Name = "lbl_Sehir";
            this.lbl_Sehir.Size = new System.Drawing.Size(59, 24);
            this.lbl_Sehir.TabIndex = 6;
            this.lbl_Sehir.Text = "Şehir:";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(155, 109);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(166, 32);
            this.txt_Soyad.TabIndex = 3;
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Location = new System.Drawing.Point(70, 116);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(68, 24);
            this.lbl_Soyad.TabIndex = 4;
            this.lbl_Soyad.Text = "Soyad:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(155, 73);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(166, 32);
            this.txt_Ad.TabIndex = 2;
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(99, 80);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(39, 24);
            this.lbl_Ad.TabIndex = 2;
            this.lbl_Ad.Text = "Ad:";
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Location = new System.Drawing.Point(155, 37);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(166, 32);
            this.txt_Id.TabIndex = 1;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(107, 44);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(31, 24);
            this.lbl_Id.TabIndex = 16;
            this.lbl_Id.Text = "Id:";
            // 
            // grp_Islem
            // 
            this.grp_Islem.Controls.Add(this.btn_Raporlar);
            this.grp_Islem.Controls.Add(this.btn_Grafik);
            this.grp_Islem.Controls.Add(this.btn_Istatislik);
            this.grp_Islem.Controls.Add(this.btn_Guncelle);
            this.grp_Islem.Controls.Add(this.btn_Sil);
            this.grp_Islem.Controls.Add(this.btn_Kaydet);
            this.grp_Islem.Controls.Add(this.btn_Listele);
            this.grp_Islem.Location = new System.Drawing.Point(416, 10);
            this.grp_Islem.Name = "grp_Islem";
            this.grp_Islem.Size = new System.Drawing.Size(215, 349);
            this.grp_Islem.TabIndex = 19;
            this.grp_Islem.TabStop = false;
            this.grp_Islem.Text = "İşlemler";
            // 
            // btn_Raporlar
            // 
            this.btn_Raporlar.Location = new System.Drawing.Point(20, 207);
            this.btn_Raporlar.Name = "btn_Raporlar";
            this.btn_Raporlar.Size = new System.Drawing.Size(150, 39);
            this.btn_Raporlar.TabIndex = 21;
            this.btn_Raporlar.Text = "Raporlar";
            this.btn_Raporlar.UseVisualStyleBackColor = true;
            this.btn_Raporlar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Grafik
            // 
            this.btn_Grafik.Location = new System.Drawing.Point(20, 296);
            this.btn_Grafik.Name = "btn_Grafik";
            this.btn_Grafik.Size = new System.Drawing.Size(150, 39);
            this.btn_Grafik.TabIndex = 15;
            this.btn_Grafik.Text = "Grafikler";
            this.btn_Grafik.UseVisualStyleBackColor = true;
            this.btn_Grafik.Click += new System.EventHandler(this.btn_Grafik_Click);
            // 
            // btn_Istatislik
            // 
            this.btn_Istatislik.Location = new System.Drawing.Point(20, 251);
            this.btn_Istatislik.Name = "btn_Istatislik";
            this.btn_Istatislik.Size = new System.Drawing.Size(150, 39);
            this.btn_Istatislik.TabIndex = 14;
            this.btn_Istatislik.Text = "İstatislik";
            this.btn_Istatislik.UseVisualStyleBackColor = true;
            this.btn_Istatislik.Click += new System.EventHandler(this.btn_Istatislik_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(20, 162);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(150, 39);
            this.btn_Guncelle.TabIndex = 12;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(18, 117);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(150, 39);
            this.btn_Sil.TabIndex = 11;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(20, 73);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(150, 39);
            this.btn_Kaydet.TabIndex = 10;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(20, 28);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(150, 39);
            this.btn_Listele.TabIndex = 9;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // grp_Kayit
            // 
            this.grp_Kayit.Controls.Add(this.dataGridView1);
            this.grp_Kayit.Location = new System.Drawing.Point(11, 364);
            this.grp_Kayit.Name = "grp_Kayit";
            this.grp_Kayit.Size = new System.Drawing.Size(916, 291);
            this.grp_Kayit.TabIndex = 2;
            this.grp_Kayit.TabStop = false;
            this.grp_Kayit.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIdDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perCinsiyetDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(910, 260);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIdDataGridViewTextBoxColumn
            // 
            this.perIdDataGridViewTextBoxColumn.DataPropertyName = "Per_Id";
            this.perIdDataGridViewTextBoxColumn.HeaderText = "Per_Id";
            this.perIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perIdDataGridViewTextBoxColumn.Name = "perIdDataGridViewTextBoxColumn";
            this.perIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "Per_Ad";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "Per_Ad";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "Per_Soyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "Per_Soyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "Per_Sehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "Per_Sehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "Per_Maas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "Per_Maas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perCinsiyetDataGridViewCheckBoxColumn
            // 
            this.perCinsiyetDataGridViewCheckBoxColumn.DataPropertyName = "Per_Cinsiyet";
            this.perCinsiyetDataGridViewCheckBoxColumn.HeaderText = "Per_Cinsiyet";
            this.perCinsiyetDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perCinsiyetDataGridViewCheckBoxColumn.Name = "perCinsiyetDataGridViewCheckBoxColumn";
            this.perCinsiyetDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "Per_Meslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "Per_Meslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelProjeDataSet1;
            // 
            // personelProjeDataSet1
            // 
            this.personelProjeDataSet1.DataSetName = "PersonelProjeDataSet1";
            this.personelProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(938, 667);
            this.Controls.Add(this.grp_Kayit);
            this.Controls.Add(this.grp_Islem);
            this.Controls.Add(this.grp_Per_Kayit);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_Personel";
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_Per_Kayit.ResumeLayout(false);
            this.grp_Per_Kayit.PerformLayout();
            this.grp_Islem.ResumeLayout(false);
            this.grp_Kayit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelProjeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Per_Kayit;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.ComboBox cmb_Sehir;
        private System.Windows.Forms.Label lbl_Durum;
        private System.Windows.Forms.TextBox txt_Meslek;
        private System.Windows.Forms.Label lbl_Sehir;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.RadioButton rd_Kadin;
        private System.Windows.Forms.Label lbl_Meslek;
        private System.Windows.Forms.RadioButton rd_Erkek;
        private System.Windows.Forms.GroupBox grp_Islem;
        private System.Windows.Forms.Button btn_Istatislik;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_Grafik;
        private System.Windows.Forms.GroupBox grp_Kayit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Maas;
        private System.Windows.Forms.MaskedTextBox mtxt_Maas;
        private System.Windows.Forms.Label lbl_Rd;
        private System.Windows.Forms.Button btn_Raporlar;
        private PersonelProjeDataSet1 personelProjeDataSet1;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelProjeDataSet1TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perCinsiyetDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
    }
}

