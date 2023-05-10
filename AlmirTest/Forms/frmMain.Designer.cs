namespace AlmirTest
{
    partial class frmMain
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
            this.dgvZaposleniciPrisustva = new System.Windows.Forms.DataGridView();
            this.Zaposlenik_VrstaPrisustvaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prisustvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbZaposlenici = new System.Windows.Forms.ComboBox();
            this.cmbVrstePrisustva = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajPrekoKalendara = new System.Windows.Forms.Button();
            this.btnIzbrisiPrekoKalendara = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mpK_Calendar1 = new MPK_Calendar.MPK_Calendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleniciPrisustva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposleniciPrisustva
            // 
            this.dgvZaposleniciPrisustva.AllowUserToAddRows = false;
            this.dgvZaposleniciPrisustva.AllowUserToDeleteRows = false;
            this.dgvZaposleniciPrisustva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZaposleniciPrisustva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposleniciPrisustva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zaposlenik_VrstaPrisustvaID,
            this.Datum,
            this.Prisustvo,
            this.Delete});
            this.dgvZaposleniciPrisustva.Location = new System.Drawing.Point(45, 119);
            this.dgvZaposleniciPrisustva.MultiSelect = false;
            this.dgvZaposleniciPrisustva.Name = "dgvZaposleniciPrisustva";
            this.dgvZaposleniciPrisustva.ReadOnly = true;
            this.dgvZaposleniciPrisustva.RowHeadersWidth = 51;
            this.dgvZaposleniciPrisustva.RowTemplate.Height = 24;
            this.dgvZaposleniciPrisustva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposleniciPrisustva.Size = new System.Drawing.Size(574, 265);
            this.dgvZaposleniciPrisustva.TabIndex = 0;
            this.dgvZaposleniciPrisustva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZaposleniciPrisustva_CellContentClick);
            this.dgvZaposleniciPrisustva.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvZaposleniciPrisustva_CellFormatting);
            this.dgvZaposleniciPrisustva.SelectionChanged += new System.EventHandler(this.dgvZaposleniciPrisustva_SelectionChanged);
            // 
            // Zaposlenik_VrstaPrisustvaID
            // 
            this.Zaposlenik_VrstaPrisustvaID.DataPropertyName = "Zaposlenik_VrstaPrisustvaID";
            this.Zaposlenik_VrstaPrisustvaID.HeaderText = "Zaposlenik_VrstaPrisustvaID";
            this.Zaposlenik_VrstaPrisustvaID.MinimumWidth = 6;
            this.Zaposlenik_VrstaPrisustvaID.Name = "Zaposlenik_VrstaPrisustvaID";
            this.Zaposlenik_VrstaPrisustvaID.ReadOnly = true;
            this.Zaposlenik_VrstaPrisustvaID.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Prisustvo
            // 
            this.Prisustvo.DataPropertyName = "Naziv";
            this.Prisustvo.HeaderText = "Prisustvo";
            this.Prisustvo.MinimumWidth = 6;
            this.Prisustvo.Name = "Prisustvo";
            this.Prisustvo.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 40F;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // cmbZaposlenici
            // 
            this.cmbZaposlenici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZaposlenici.FormattingEnabled = true;
            this.cmbZaposlenici.Location = new System.Drawing.Point(45, 71);
            this.cmbZaposlenici.Name = "cmbZaposlenici";
            this.cmbZaposlenici.Size = new System.Drawing.Size(218, 24);
            this.cmbZaposlenici.TabIndex = 1;
            this.cmbZaposlenici.SelectedIndexChanged += new System.EventHandler(this.cmbZaposlenici_SelectedIndexChanged);
            // 
            // cmbVrstePrisustva
            // 
            this.cmbVrstePrisustva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrstePrisustva.FormattingEnabled = true;
            this.cmbVrstePrisustva.Location = new System.Drawing.Point(397, 69);
            this.cmbVrstePrisustva.Name = "cmbVrstePrisustva";
            this.cmbVrstePrisustva.Size = new System.Drawing.Size(222, 24);
            this.cmbVrstePrisustva.TabIndex = 2;
            this.cmbVrstePrisustva.SelectedIndexChanged += new System.EventHandler(this.cmbVrstePrisustva_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zaposlenik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vrsta prisustva:";
            // 
            // btnDodajPrekoKalendara
            // 
            this.btnDodajPrekoKalendara.BackColor = System.Drawing.Color.Lime;
            this.btnDodajPrekoKalendara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPrekoKalendara.Location = new System.Drawing.Point(702, 396);
            this.btnDodajPrekoKalendara.Name = "btnDodajPrekoKalendara";
            this.btnDodajPrekoKalendara.Size = new System.Drawing.Size(198, 47);
            this.btnDodajPrekoKalendara.TabIndex = 7;
            this.btnDodajPrekoKalendara.Text = "Dodaj prisustvo";
            this.btnDodajPrekoKalendara.UseVisualStyleBackColor = false;
            this.btnDodajPrekoKalendara.Click += new System.EventHandler(this.btnDodajPrekoKalendara_Click);
            // 
            // btnIzbrisiPrekoKalendara
            // 
            this.btnIzbrisiPrekoKalendara.BackColor = System.Drawing.Color.Red;
            this.btnIzbrisiPrekoKalendara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiPrekoKalendara.Location = new System.Drawing.Point(947, 396);
            this.btnIzbrisiPrekoKalendara.Name = "btnIzbrisiPrekoKalendara";
            this.btnIzbrisiPrekoKalendara.Size = new System.Drawing.Size(215, 47);
            this.btnIzbrisiPrekoKalendara.TabIndex = 8;
            this.btnIzbrisiPrekoKalendara.Text = "Izbriši prisustvo";
            this.btnIzbrisiPrekoKalendara.UseVisualStyleBackColor = false;
            this.btnIzbrisiPrekoKalendara.Click += new System.EventHandler(this.btnIzbrisiPrekoKalendara_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(644, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Zaposlenik:";
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaposlenik.Location = new System.Drawing.Point(806, 28);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(0, 32);
            this.lblZaposlenik.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(170, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Odsutan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Prisutan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(270, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Na bolovanju";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(411, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Na godišnjem";
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzvjestaj.Location = new System.Drawing.Point(45, 429);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(574, 44);
            this.btnIzvjestaj.TabIndex = 21;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AlmirTest.Properties.Resources.Logo_png;
            this.pictureBox1.Location = new System.Drawing.Point(996, 475);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(560, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Vikend";
            // 
            // mpK_Calendar1
            // 
            this.mpK_Calendar1.AbbreviateWeekDayHeader = true;
            this.mpK_Calendar1.ActiveMonthColor = System.Drawing.Color.White;
            this.mpK_Calendar1.ApptFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.mpK_Calendar1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mpK_Calendar1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.mpK_Calendar1.BoldedDateFontColor = System.Drawing.Color.Red;
            this.mpK_Calendar1.BoldedDates = new System.DateTime[0];
            this.mpK_Calendar1.DisplayWeekendsDarker = true;
            this.mpK_Calendar1.GridColor = System.Drawing.Color.Black;
            this.mpK_Calendar1.HeaderColor = System.Drawing.Color.LightSteelBlue;
            this.mpK_Calendar1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mpK_Calendar1.InactiveMonthColor = System.Drawing.Color.Silver;
            this.mpK_Calendar1.intDay = 4;
            this.mpK_Calendar1.intMonth = 5;
            this.mpK_Calendar1.intYear = 2023;
            this.mpK_Calendar1.Location = new System.Drawing.Point(649, 71);
            this.mpK_Calendar1.Name = "mpK_Calendar1";
            this.mpK_Calendar1.NoApptFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mpK_Calendar1.NonselectedDayFontColor = System.Drawing.Color.Black;
            this.mpK_Calendar1.SelectedDate = new System.DateTime(2023, 5, 8, 0, 0, 0, 0);
            this.mpK_Calendar1.SelectedDayColor = System.Drawing.Color.LightSteelBlue;
            this.mpK_Calendar1.SelectedDayFontColor = System.Drawing.Color.White;
            this.mpK_Calendar1.ShowCurrentMonthInDay = false;
            this.mpK_Calendar1.ShowGrid = true;
            this.mpK_Calendar1.ShowPrevNextButton = true;
            this.mpK_Calendar1.Size = new System.Drawing.Size(560, 313);
            this.mpK_Calendar1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(147, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "   ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(248, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(45, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "   ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(387, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "   ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(537, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "   ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 546);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mpK_Calendar1);
            this.Controls.Add(this.btnIzbrisiPrekoKalendara);
            this.Controls.Add(this.btnDodajPrekoKalendara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVrstePrisustva);
            this.Controls.Add(this.cmbZaposlenici);
            this.Controls.Add(this.dgvZaposleniciPrisustva);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija prisustva";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleniciPrisustva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposleniciPrisustva;
        private System.Windows.Forms.ComboBox cmbZaposlenici;
        private System.Windows.Forms.ComboBox cmbVrstePrisustva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajPrekoKalendara;
        private System.Windows.Forms.Button btnIzbrisiPrekoKalendara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaposlenik_VrstaPrisustvaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prisustvo;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private MPK_Calendar.MPK_Calendar mpK_Calendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
    }
}

