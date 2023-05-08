namespace AlmirTest
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
            this.dgvZaposleniciPrisustva = new System.Windows.Forms.DataGridView();
            this.Zaposlenik_VrstaPrisustvaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prisustvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbZaposlenici = new System.Windows.Forms.ComboBox();
            this.cmbVrstePrisustva = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnDodajPrekoKalendara = new System.Windows.Forms.Button();
            this.btnIzbrisiPrekoKalendara = new System.Windows.Forms.Button();
            this.mpK_Calendar1 = new MPK_Calendar.MPK_Calendar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleniciPrisustva)).BeginInit();
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
            this.dgvZaposleniciPrisustva.Location = new System.Drawing.Point(58, 117);
            this.dgvZaposleniciPrisustva.MultiSelect = false;
            this.dgvZaposleniciPrisustva.Name = "dgvZaposleniciPrisustva";
            this.dgvZaposleniciPrisustva.ReadOnly = true;
            this.dgvZaposleniciPrisustva.RowHeadersWidth = 51;
            this.dgvZaposleniciPrisustva.RowTemplate.Height = 24;
            this.dgvZaposleniciPrisustva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposleniciPrisustva.Size = new System.Drawing.Size(549, 265);
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
            this.cmbZaposlenici.Location = new System.Drawing.Point(58, 69);
            this.cmbZaposlenici.Name = "cmbZaposlenici";
            this.cmbZaposlenici.Size = new System.Drawing.Size(212, 24);
            this.cmbZaposlenici.TabIndex = 1;
            this.cmbZaposlenici.SelectedIndexChanged += new System.EventHandler(this.cmbZaposlenici_SelectedIndexChanged);
            // 
            // cmbVrstePrisustva
            // 
            this.cmbVrstePrisustva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrstePrisustva.FormattingEnabled = true;
            this.cmbVrstePrisustva.Location = new System.Drawing.Point(392, 69);
            this.cmbVrstePrisustva.Name = "cmbVrstePrisustva";
            this.cmbVrstePrisustva.Size = new System.Drawing.Size(215, 24);
            this.cmbVrstePrisustva.TabIndex = 2;
            this.cmbVrstePrisustva.SelectedIndexChanged += new System.EventHandler(this.cmbVrstePrisustva_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zaposlenik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vrsta prisustva:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Yellow;
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(619, 69);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.Visible = false;
            // 
            // btnDodajPrekoKalendara
            // 
            this.btnDodajPrekoKalendara.Location = new System.Drawing.Point(766, 414);
            this.btnDodajPrekoKalendara.Name = "btnDodajPrekoKalendara";
            this.btnDodajPrekoKalendara.Size = new System.Drawing.Size(138, 47);
            this.btnDodajPrekoKalendara.TabIndex = 7;
            this.btnDodajPrekoKalendara.Text = "Dodaj prisustvo";
            this.btnDodajPrekoKalendara.UseVisualStyleBackColor = true;
            this.btnDodajPrekoKalendara.Click += new System.EventHandler(this.btnDodajPrekoKalendara_Click);
            // 
            // btnIzbrisiPrekoKalendara
            // 
            this.btnIzbrisiPrekoKalendara.Location = new System.Drawing.Point(936, 414);
            this.btnIzbrisiPrekoKalendara.Name = "btnIzbrisiPrekoKalendara";
            this.btnIzbrisiPrekoKalendara.Size = new System.Drawing.Size(142, 47);
            this.btnIzbrisiPrekoKalendara.TabIndex = 8;
            this.btnIzbrisiPrekoKalendara.Text = "Izbrisi prisustvo";
            this.btnIzbrisiPrekoKalendara.UseVisualStyleBackColor = true;
            this.btnIzbrisiPrekoKalendara.Click += new System.EventHandler(this.btnIzbrisiPrekoKalendara_Click);
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
            this.mpK_Calendar1.Location = new System.Drawing.Point(656, 67);
            this.mpK_Calendar1.Name = "mpK_Calendar1";
            this.mpK_Calendar1.NoApptFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mpK_Calendar1.NonselectedDayFontColor = System.Drawing.Color.Black;
            this.mpK_Calendar1.SelectedDate = new System.DateTime(2023, 5, 3, 0, 0, 0, 0);
            this.mpK_Calendar1.SelectedDayColor = System.Drawing.Color.LightSteelBlue;
            this.mpK_Calendar1.SelectedDayFontColor = System.Drawing.Color.White;
            this.mpK_Calendar1.ShowCurrentMonthInDay = false;
            this.mpK_Calendar1.ShowGrid = true;
            this.mpK_Calendar1.ShowPrevNextButton = true;
            this.mpK_Calendar1.Size = new System.Drawing.Size(547, 313);
            this.mpK_Calendar1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(651, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Zaposlenik:";
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaposlenik.Location = new System.Drawing.Point(813, 26);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(0, 32);
            this.lblZaposlenik.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 502);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mpK_Calendar1);
            this.Controls.Add(this.btnIzbrisiPrekoKalendara);
            this.Controls.Add(this.btnDodajPrekoKalendara);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVrstePrisustva);
            this.Controls.Add(this.cmbZaposlenici);
            this.Controls.Add(this.dgvZaposleniciPrisustva);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija prisustva";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleniciPrisustva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposleniciPrisustva;
        private System.Windows.Forms.ComboBox cmbZaposlenici;
        private System.Windows.Forms.ComboBox cmbVrstePrisustva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnDodajPrekoKalendara;
        private System.Windows.Forms.Button btnIzbrisiPrekoKalendara;
        private MPK_Calendar.MPK_Calendar mpK_Calendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaposlenik_VrstaPrisustvaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prisustvo;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

