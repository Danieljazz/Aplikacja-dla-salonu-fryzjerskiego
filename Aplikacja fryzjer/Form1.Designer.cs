namespace Aplikacja_fryzjer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_nazwisko = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_godz = new System.Windows.Forms.Label();
            this.txt_imie = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.fryzjerDataSet = new Aplikacja_fryzjer.fryzjerDataSet();
            this.tabela1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabela1TableAdapter = new Aplikacja_fryzjer.fryzjerDataSetTableAdapters.Tabela1TableAdapter();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Imie = new System.Windows.Forms.Label();
            this.Nazwisko = new System.Windows.Forms.Label();
            this.Tel = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_znjd = new System.Windows.Forms.Button();
            this.btn_usun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_wizyty = new System.Windows.Forms.Button();
            this.btn_szuk_nazw = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_ndch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fryzjerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabela1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(937, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("CityBlueprint", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 156);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(269, 20);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.Value = new System.DateTime(2019, 12, 30, 21, 1, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dateTimePicker2.Layout += new System.Windows.Forms.LayoutEventHandler(this.dateTimePicker2_Layout);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(920, 32);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(223, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Zapisz wizyte";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_nazwisko
            // 
            this.txt_nazwisko.Location = new System.Drawing.Point(181, 332);
            this.txt_nazwisko.Name = "txt_nazwisko";
            this.txt_nazwisko.Size = new System.Drawing.Size(100, 20);
            this.txt_nazwisko.TabIndex = 14;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(181, 372);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 15;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.BackColor = System.Drawing.Color.Transparent;
            this.lbl_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_data.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_data.Location = new System.Drawing.Point(363, 52);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(61, 13);
            this.lbl_data.TabIndex = 16;
            this.lbl_data.Text = "Data wizyty";
            this.lbl_data.Click += new System.EventHandler(this.lbl_data_Click);
            // 
            // lbl_godz
            // 
            this.lbl_godz.AutoSize = true;
            this.lbl_godz.BackColor = System.Drawing.Color.Transparent;
            this.lbl_godz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_godz.Location = new System.Drawing.Point(150, 230);
            this.lbl_godz.Name = "lbl_godz";
            this.lbl_godz.Size = new System.Drawing.Size(77, 13);
            this.lbl_godz.TabIndex = 17;
            this.lbl_godz.Text = "Godzina wizyty";
            // 
            // txt_imie
            // 
            this.txt_imie.Location = new System.Drawing.Point(181, 293);
            this.txt_imie.Name = "txt_imie";
            this.txt_imie.Size = new System.Drawing.Size(100, 20);
            this.txt_imie.TabIndex = 18;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(920, 74);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(223, 23);
            this.btn_edit.TabIndex = 19;
            this.btn_edit.Text = "Edycja";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // fryzjerDataSet
            // 
            this.fryzjerDataSet.DataSetName = "fryzjerDataSet";
            this.fryzjerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabela1BindingSource
            // 
            this.tabela1BindingSource.DataMember = "Tabela1";
            this.tabela1BindingSource.DataSource = this.fryzjerDataSet;
            // 
            // tabela1TableAdapter
            // 
            this.tabela1TableAdapter.ClearBeforeFill = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.monthCalendar1.Font = new System.Drawing.Font("Stylus BT", 21.75F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Location = new System.Drawing.Point(12, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 21;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // Imie
            // 
            this.Imie.AutoSize = true;
            this.Imie.BackColor = System.Drawing.Color.Transparent;
            this.Imie.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Imie.ForeColor = System.Drawing.Color.Black;
            this.Imie.Location = new System.Drawing.Point(74, 292);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(45, 18);
            this.Imie.TabIndex = 23;
            this.Imie.Text = "Imię";
            // 
            // Nazwisko
            // 
            this.Nazwisko.AutoSize = true;
            this.Nazwisko.BackColor = System.Drawing.Color.Transparent;
            this.Nazwisko.Location = new System.Drawing.Point(64, 335);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(53, 13);
            this.Nazwisko.TabIndex = 24;
            this.Nazwisko.Text = "Nazwisko";
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.BackColor = System.Drawing.Color.Transparent;
            this.Tel.Location = new System.Drawing.Point(64, 375);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(79, 13);
            this.Tel.TabIndex = 25;
            this.Tel.Text = "Numer telefonu";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(835, 579);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(96, 13);
            this.Status.TabIndex = 26;
            this.Status.Text = "Status połączenia:";
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(293, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Data wizyty:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(64, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Godzina wizyty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(67, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "ID Wizyty";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(181, 412);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 31;
            // 
            // btn_znjd
            // 
            this.btn_znjd.Location = new System.Drawing.Point(920, 118);
            this.btn_znjd.Name = "btn_znjd";
            this.btn_znjd.Size = new System.Drawing.Size(223, 23);
            this.btn_znjd.TabIndex = 33;
            this.btn_znjd.Text = "Znajdź";
            this.btn_znjd.UseVisualStyleBackColor = true;
            this.btn_znjd.Click += new System.EventHandler(this.btn_znjd_Click);
            // 
            // btn_usun
            // 
            this.btn_usun.Location = new System.Drawing.Point(920, 157);
            this.btn_usun.Name = "btn_usun";
            this.btn_usun.Size = new System.Drawing.Size(223, 23);
            this.btn_usun.TabIndex = 34;
            this.btn_usun.Text = "Usuń wizytę";
            this.btn_usun.UseVisualStyleBackColor = true;
            this.btn_usun.Click += new System.EventHandler(this.btn_usun_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(531, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 267);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_wizyty
            // 
            this.btn_wizyty.Location = new System.Drawing.Point(296, 26);
            this.btn_wizyty.Name = "btn_wizyty";
            this.btn_wizyty.Size = new System.Drawing.Size(130, 23);
            this.btn_wizyty.TabIndex = 36;
            this.btn_wizyty.Text = "Wizyty na:";
            this.btn_wizyty.UseVisualStyleBackColor = true;
            this.btn_wizyty.Click += new System.EventHandler(this.btn_wizyty_Click);
            // 
            // btn_szuk_nazw
            // 
            this.btn_szuk_nazw.Location = new System.Drawing.Point(920, 199);
            this.btn_szuk_nazw.Name = "btn_szuk_nazw";
            this.btn_szuk_nazw.Size = new System.Drawing.Size(223, 23);
            this.btn_szuk_nazw.TabIndex = 37;
            this.btn_szuk_nazw.Text = "Szukaj po nazwisku";
            this.btn_szuk_nazw.UseVisualStyleBackColor = true;
            this.btn_szuk_nazw.Click += new System.EventHandler(this.btn_szuk_nazw_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_ndch
            // 
            this.btn_ndch.Location = new System.Drawing.Point(920, 241);
            this.btn_ndch.Name = "btn_ndch";
            this.btn_ndch.Size = new System.Drawing.Size(223, 23);
            this.btn_ndch.TabIndex = 40;
            this.btn_ndch.Text = "Nadchodzące";
            this.btn_ndch.UseVisualStyleBackColor = true;
            this.btn_ndch.Click += new System.EventHandler(this.btn_ndch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 594);
            this.Controls.Add(this.btn_ndch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_szuk_nazw);
            this.Controls.Add(this.btn_wizyty);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_usun);
            this.Controls.Add(this.btn_znjd);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_imie);
            this.Controls.Add(this.lbl_godz);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_nazwisko);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Zakład Fryzjerski by Daniel Jazdzewski";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fryzjerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabela1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_nazwisko;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_godz;
        private System.Windows.Forms.TextBox txt_imie;
        private System.Windows.Forms.Button btn_edit;
        private fryzjerDataSet fryzjerDataSet;
        private System.Windows.Forms.BindingSource tabela1BindingSource;
        private fryzjerDataSetTableAdapters.Tabela1TableAdapter tabela1TableAdapter;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label Imie;
        private System.Windows.Forms.Label Nazwisko;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_znjd;
        private System.Windows.Forms.Button btn_usun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_wizyty;
        private System.Windows.Forms.Button btn_szuk_nazw;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_ndch;
    }
}

