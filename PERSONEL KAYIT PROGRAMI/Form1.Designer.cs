
namespace PERSONEL_KAYIT_PROGRAMI
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textmeslek = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radiob = new System.Windows.Forms.RadioButton();
            this.radioe = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedtxtmaas = new System.Windows.Forms.MaskedTextBox();
            this.combosehir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.textper_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btngraphic = new System.Windows.Forms.Button();
            this.btnist = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnlist = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permedenidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblpersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet = new PERSONEL_KAYIT_PROGRAMI.personelDataSet();
            this.tbl_personelTableAdapter = new PERSONEL_KAYIT_PROGRAMI.personelDataSetTableAdapters.tbl_personelTableAdapter();
            this.lblmedeni = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textmeslek);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radiob);
            this.groupBox1.Controls.Add(this.radioe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.maskedtxtmaas);
            this.groupBox1.Controls.Add(this.combosehir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.textper_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Location = new System.Drawing.Point(39, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 415);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // textmeslek
            // 
            this.textmeslek.Location = new System.Drawing.Point(191, 334);
            this.textmeslek.Name = "textmeslek";
            this.textmeslek.Size = new System.Drawing.Size(168, 34);
            this.textmeslek.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Personel Meslek:";
            // 
            // radiob
            // 
            this.radiob.AutoSize = true;
            this.radiob.Location = new System.Drawing.Point(293, 293);
            this.radiob.Name = "radiob";
            this.radiob.Size = new System.Drawing.Size(51, 31);
            this.radiob.TabIndex = 6;
            this.radiob.TabStop = true;
            this.radiob.Text = "B";
            this.radiob.UseVisualStyleBackColor = true;
            this.radiob.CheckedChanged += new System.EventHandler(this.radiob_CheckedChanged);
            // 
            // radioe
            // 
            this.radioe.AutoSize = true;
            this.radioe.Location = new System.Drawing.Point(221, 293);
            this.radioe.Name = "radioe";
            this.radioe.Size = new System.Drawing.Size(48, 31);
            this.radioe.TabIndex = 5;
            this.radioe.TabStop = true;
            this.radioe.Text = "E";
            this.radioe.UseVisualStyleBackColor = true;
            this.radioe.CheckedChanged += new System.EventHandler(this.radioe_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Medeni Durum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Personel Maaş:";
            // 
            // maskedtxtmaas
            // 
            this.maskedtxtmaas.Location = new System.Drawing.Point(190, 246);
            this.maskedtxtmaas.Mask = "00000";
            this.maskedtxtmaas.Name = "maskedtxtmaas";
            this.maskedtxtmaas.Size = new System.Drawing.Size(167, 34);
            this.maskedtxtmaas.TabIndex = 4;
            this.maskedtxtmaas.ValidatingType = typeof(int);
            // 
            // combosehir
            // 
            this.combosehir.FormattingEnabled = true;
            this.combosehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
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
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.combosehir.Location = new System.Drawing.Point(190, 199);
            this.combosehir.Name = "combosehir";
            this.combosehir.Size = new System.Drawing.Size(167, 35);
            this.combosehir.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Personel Şehir:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(190, 154);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(168, 34);
            this.txtsoyad.TabIndex = 2;
            // 
            // textper_id
            // 
            this.textper_id.Location = new System.Drawing.Point(190, 71);
            this.textper_id.Name = "textper_id";
            this.textper_id.Size = new System.Drawing.Size(168, 34);
            this.textper_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Soyad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(190, 111);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(168, 34);
            this.txtad.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btngraphic);
            this.groupBox2.Controls.Add(this.btnist);
            this.groupBox2.Controls.Add(this.btnclean);
            this.groupBox2.Controls.Add(this.btnupdate);
            this.groupBox2.Controls.Add(this.btndel);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Controls.Add(this.btnlist);
            this.groupBox2.Location = new System.Drawing.Point(535, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 415);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem";
            // 
            // btngraphic
            // 
            this.btngraphic.Location = new System.Drawing.Point(80, 354);
            this.btngraphic.Name = "btngraphic";
            this.btngraphic.Size = new System.Drawing.Size(152, 44);
            this.btngraphic.TabIndex = 6;
            this.btngraphic.Text = "Grafikler";
            this.btngraphic.UseVisualStyleBackColor = true;
            this.btngraphic.Click += new System.EventHandler(this.btngraphic_Click);
            // 
            // btnist
            // 
            this.btnist.Location = new System.Drawing.Point(80, 304);
            this.btnist.Name = "btnist";
            this.btnist.Size = new System.Drawing.Size(152, 44);
            this.btnist.TabIndex = 5;
            this.btnist.Text = "İstatistik";
            this.btnist.UseVisualStyleBackColor = true;
            this.btnist.Click += new System.EventHandler(this.btnist_Click);
            // 
            // btnclean
            // 
            this.btnclean.Location = new System.Drawing.Point(80, 254);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(152, 44);
            this.btnclean.TabIndex = 4;
            this.btnclean.Text = "Temizle";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(80, 204);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(152, 44);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Güncelle";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(80, 154);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(152, 44);
            this.btndel.TabIndex = 2;
            this.btndel.Text = "Sil";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(80, 107);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(152, 44);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Kaydet";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(80, 57);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(152, 44);
            this.btnlist.TabIndex = 0;
            this.btnlist.Text = "Listele";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(50, 485);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1120, 244);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.persoyadDataGridViewTextBoxColumn,
            this.persehirDataGridViewTextBoxColumn,
            this.permaasDataGridViewTextBoxColumn,
            this.permedenidDataGridViewCheckBoxColumn,
            this.permeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblpersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "per_id";
            this.peridDataGridViewTextBoxColumn.HeaderText = "per_id";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 150;
            // 
            // peradDataGridViewTextBoxColumn
            // 
            this.peradDataGridViewTextBoxColumn.DataPropertyName = "per_ad";
            this.peradDataGridViewTextBoxColumn.HeaderText = "per_ad";
            this.peradDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
            this.peradDataGridViewTextBoxColumn.Width = 150;
            // 
            // persoyadDataGridViewTextBoxColumn
            // 
            this.persoyadDataGridViewTextBoxColumn.DataPropertyName = "per_soyad";
            this.persoyadDataGridViewTextBoxColumn.HeaderText = "per_soyad";
            this.persoyadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.persoyadDataGridViewTextBoxColumn.Name = "persoyadDataGridViewTextBoxColumn";
            this.persoyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // persehirDataGridViewTextBoxColumn
            // 
            this.persehirDataGridViewTextBoxColumn.DataPropertyName = "per_sehir";
            this.persehirDataGridViewTextBoxColumn.HeaderText = "per_sehir";
            this.persehirDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.persehirDataGridViewTextBoxColumn.Name = "persehirDataGridViewTextBoxColumn";
            this.persehirDataGridViewTextBoxColumn.Width = 150;
            // 
            // permaasDataGridViewTextBoxColumn
            // 
            this.permaasDataGridViewTextBoxColumn.DataPropertyName = "per_maas";
            this.permaasDataGridViewTextBoxColumn.HeaderText = "per_maas";
            this.permaasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.permaasDataGridViewTextBoxColumn.Name = "permaasDataGridViewTextBoxColumn";
            this.permaasDataGridViewTextBoxColumn.Width = 150;
            // 
            // permedenidDataGridViewCheckBoxColumn
            // 
            this.permedenidDataGridViewCheckBoxColumn.DataPropertyName = "per_medeni_d";
            this.permedenidDataGridViewCheckBoxColumn.HeaderText = "per_medeni_d";
            this.permedenidDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.permedenidDataGridViewCheckBoxColumn.Name = "permedenidDataGridViewCheckBoxColumn";
            this.permedenidDataGridViewCheckBoxColumn.Width = 150;
            // 
            // permeslekDataGridViewTextBoxColumn
            // 
            this.permeslekDataGridViewTextBoxColumn.DataPropertyName = "per_meslek";
            this.permeslekDataGridViewTextBoxColumn.HeaderText = "per_meslek";
            this.permeslekDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.permeslekDataGridViewTextBoxColumn.Name = "permeslekDataGridViewTextBoxColumn";
            this.permeslekDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblpersonelBindingSource
            // 
            this.tblpersonelBindingSource.DataMember = "tbl_personel";
            this.tblpersonelBindingSource.DataSource = this.personelDataSet;
            // 
            // personelDataSet
            // 
            this.personelDataSet.DataSetName = "personelDataSet";
            this.personelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_personelTableAdapter
            // 
            this.tbl_personelTableAdapter.ClearBeforeFill = true;
            // 
            // lblmedeni
            // 
            this.lblmedeni.AutoSize = true;
            this.lblmedeni.Location = new System.Drawing.Point(930, 380);
            this.lblmedeni.Name = "lblmedeni";
            this.lblmedeni.Size = new System.Drawing.Size(184, 27);
            this.lblmedeni.TabIndex = 124;
            this.lblmedeni.Text = "MEDENİ DURUM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1252, 740);
            this.Controls.Add(this.lblmedeni);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Personel Veri Tabanı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textmeslek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radiob;
        private System.Windows.Forms.RadioButton radioe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedtxtmaas;
        private System.Windows.Forms.ComboBox combosehir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox textper_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngraphic;
        private System.Windows.Forms.Button btnist;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private personelDataSet personelDataSet;
        private System.Windows.Forms.BindingSource tblpersonelBindingSource;
        private personelDataSetTableAdapters.tbl_personelTableAdapter tbl_personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permedenidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblmedeni;
    }
}

