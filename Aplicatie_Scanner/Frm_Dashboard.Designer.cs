namespace Aplicatie_Scanner
{
    partial class Frm_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Dashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            Data = new DataGridViewTextBoxColumn();
            Timp = new DataGridViewTextBoxColumn();
            Locatie_Actuala = new DataGridViewTextBoxColumn();
            Furnizor = new DataGridViewTextBoxColumn();
            Numar_Aviz = new DataGridViewTextBoxColumn();
            Numar_Receptie = new DataGridViewTextBoxColumn();
            Numar_Bustean = new DataGridViewTextBoxColumn();
            Lungime = new DataGridViewTextBoxColumn();
            Diametru_Net = new DataGridViewTextBoxColumn();
            Calitate = new DataGridViewTextBoxColumn();
            Data_Transfer = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            newCalendar1 = new NewCalendar();
            Search = new Button();
            checkBoxFurnizor = new CheckBox();
            label1 = new Label();
            cbFurnizor = new ComboBox();
            label2 = new Label();
            cbZonaSelectie = new ComboBox();
            cbCalitate = new ComboBox();
            checkBoxCalitate = new CheckBox();
            btnPrintCSV = new Button();
            CheckBoxReceptie = new CheckBox();
            tbReceptie = new TextBox();
            checkBoxIntervalOrar = new CheckBox();
            numericUpDownStart = new NumericUpDown();
            numericUpDownEnd = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnd).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(754, 483);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(46, 51, 100);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Data, Timp, Locatie_Actuala, Furnizor, Numar_Aviz, Numar_Receptie, Numar_Bustean, Lungime, Diametru_Net, Calitate, Data_Transfer });
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.Location = new Point(9, 12);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(835, 336);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Data
            // 
            Data.FillWeight = 80F;
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // Timp
            // 
            Timp.FillWeight = 80F;
            Timp.HeaderText = "Timp";
            Timp.Name = "Timp";
            // 
            // Locatie_Actuala
            // 
            Locatie_Actuala.HeaderText = "Locatie Actuala";
            Locatie_Actuala.Name = "Locatie_Actuala";
            // 
            // Furnizor
            // 
            Furnizor.HeaderText = "Furnizor";
            Furnizor.Name = "Furnizor";
            // 
            // Numar_Aviz
            // 
            Numar_Aviz.HeaderText = "Numar Aviz";
            Numar_Aviz.Name = "Numar_Aviz";
            // 
            // Numar_Receptie
            // 
            Numar_Receptie.HeaderText = "Numar Receptie";
            Numar_Receptie.Name = "Numar_Receptie";
            // 
            // Numar_Bustean
            // 
            Numar_Bustean.HeaderText = "Numar Bustean";
            Numar_Bustean.Name = "Numar_Bustean";
            // 
            // Lungime
            // 
            Lungime.FillWeight = 50F;
            Lungime.HeaderText = "L";
            Lungime.Name = "Lungime";
            // 
            // Diametru_Net
            // 
            Diametru_Net.FillWeight = 50F;
            Diametru_Net.HeaderText = "D";
            Diametru_Net.Name = "Diametru_Net";
            // 
            // Calitate
            // 
            Calitate.FillWeight = 60F;
            Calitate.HeaderText = "Calitate";
            Calitate.Name = "Calitate";
            // 
            // Data_Transfer
            // 
            Data_Transfer.HeaderText = "Data Transfer";
            Data_Transfer.Name = "Data_Transfer";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // newCalendar1
            // 
            newCalendar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            newCalendar1.BackColor = Color.FromArgb(46, 51, 100);
            newCalendar1.FirstDayOfWeek = Day.Monday;
            newCalendar1.Font = new Font("Nirmala UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            newCalendar1.Location = new Point(9, 359);
            newCalendar1.Margin = new Padding(0);
            newCalendar1.MaxSelectionCount = 365;
            newCalendar1.Name = "newCalendar1";
            newCalendar1.TabIndex = 37;
            newCalendar1.TitleBackColor = Color.White;
            // 
            // Search
            // 
            Search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Search.BackColor = Color.FromArgb(46, 51, 100);
            Search.FlatAppearance.BorderColor = Color.White;
            Search.FlatStyle = FlatStyle.Flat;
            Search.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Search.ForeColor = Color.White;
            Search.Location = new Point(9, 522);
            Search.Name = "Search";
            Search.Size = new Size(213, 50);
            Search.TabIndex = 38;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            // 
            // checkBoxFurnizor
            // 
            checkBoxFurnizor.AutoSize = true;
            checkBoxFurnizor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxFurnizor.ForeColor = Color.White;
            checkBoxFurnizor.Location = new Point(243, 419);
            checkBoxFurnizor.Name = "checkBoxFurnizor";
            checkBoxFurnizor.Size = new Size(81, 24);
            checkBoxFurnizor.TabIndex = 39;
            checkBoxFurnizor.Text = "Furnizor";
            checkBoxFurnizor.UseVisualStyleBackColor = true;
            checkBoxFurnizor.CheckedChanged += checkBoxFurnizor_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(237, 396);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 40;
            label1.Text = "Cautare Dupa:";
            // 
            // cbFurnizor
            // 
            cbFurnizor.FormattingEnabled = true;
            cbFurnizor.Location = new Point(330, 420);
            cbFurnizor.Name = "cbFurnizor";
            cbFurnizor.Size = new Size(139, 23);
            cbFurnizor.TabIndex = 41;
            cbFurnizor.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(237, 364);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 42;
            label2.Text = "Locatie:";
            // 
            // cbZonaSelectie
            // 
            cbZonaSelectie.FormattingEnabled = true;
            cbZonaSelectie.Items.AddRange(new object[] { "Etichete Generate", "Depozit", "Linie Productie 1", "Linie Productie 2", "Linie Productie 3" });
            cbZonaSelectie.Location = new Point(306, 363);
            cbZonaSelectie.Name = "cbZonaSelectie";
            cbZonaSelectie.Size = new Size(163, 23);
            cbZonaSelectie.TabIndex = 43;
            cbZonaSelectie.SelectedIndexChanged += cbZonaSelectie_SelectedIndexChanged;
            // 
            // cbCalitate
            // 
            cbCalitate.FormattingEnabled = true;
            cbCalitate.Location = new Point(330, 450);
            cbCalitate.Name = "cbCalitate";
            cbCalitate.Size = new Size(139, 23);
            cbCalitate.TabIndex = 45;
            cbCalitate.Visible = false;
            // 
            // checkBoxCalitate
            // 
            checkBoxCalitate.AutoSize = true;
            checkBoxCalitate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxCalitate.ForeColor = Color.White;
            checkBoxCalitate.Location = new Point(243, 449);
            checkBoxCalitate.Name = "checkBoxCalitate";
            checkBoxCalitate.Size = new Size(79, 24);
            checkBoxCalitate.TabIndex = 44;
            checkBoxCalitate.Text = "Calitate";
            checkBoxCalitate.UseVisualStyleBackColor = true;
            checkBoxCalitate.CheckedChanged += checkBoxCalitate_CheckedChanged;
            // 
            // btnPrintCSV
            // 
            btnPrintCSV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrintCSV.BackColor = Color.FromArgb(46, 51, 100);
            btnPrintCSV.FlatAppearance.BorderColor = Color.White;
            btnPrintCSV.FlatStyle = FlatStyle.Flat;
            btnPrintCSV.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrintCSV.ForeColor = Color.White;
            btnPrintCSV.Location = new Point(237, 522);
            btnPrintCSV.Name = "btnPrintCSV";
            btnPrintCSV.Size = new Size(232, 50);
            btnPrintCSV.TabIndex = 46;
            btnPrintCSV.Text = "Print\r\nCSV";
            btnPrintCSV.UseVisualStyleBackColor = false;
            btnPrintCSV.Visible = false;
            btnPrintCSV.Click += btnPrintCSV_Click;
            // 
            // CheckBoxReceptie
            // 
            CheckBoxReceptie.AutoSize = true;
            CheckBoxReceptie.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBoxReceptie.ForeColor = Color.White;
            CheckBoxReceptie.Location = new Point(487, 419);
            CheckBoxReceptie.Name = "CheckBoxReceptie";
            CheckBoxReceptie.Size = new Size(86, 24);
            CheckBoxReceptie.TabIndex = 47;
            CheckBoxReceptie.Text = "Receptie";
            CheckBoxReceptie.UseVisualStyleBackColor = true;
            CheckBoxReceptie.CheckedChanged += CheckBoxReceptie_CheckedChanged;
            // 
            // tbReceptie
            // 
            tbReceptie.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbReceptie.Location = new Point(572, 418);
            tbReceptie.Name = "tbReceptie";
            tbReceptie.Size = new Size(120, 23);
            tbReceptie.TabIndex = 48;
            tbReceptie.TextChanged += tbReceptie_TextChanged;
            // 
            // checkBoxIntervalOrar
            // 
            checkBoxIntervalOrar.AutoSize = true;
            checkBoxIntervalOrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIntervalOrar.ForeColor = Color.White;
            checkBoxIntervalOrar.Location = new Point(243, 483);
            checkBoxIntervalOrar.Name = "checkBoxIntervalOrar";
            checkBoxIntervalOrar.Size = new Size(110, 24);
            checkBoxIntervalOrar.TabIndex = 49;
            checkBoxIntervalOrar.Text = "Interval Orar";
            checkBoxIntervalOrar.UseVisualStyleBackColor = true;
            checkBoxIntervalOrar.CheckedChanged += checkBoxIntervalOrar_CheckedChanged;
            // 
            // numericUpDownStart
            // 
            numericUpDownStart.Enabled = false;
            numericUpDownStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownStart.Location = new Point(350, 483);
            numericUpDownStart.Margin = new Padding(0);
            numericUpDownStart.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDownStart.Name = "numericUpDownStart";
            numericUpDownStart.Size = new Size(51, 29);
            numericUpDownStart.TabIndex = 53;
            numericUpDownStart.TextAlign = HorizontalAlignment.Center;
            numericUpDownStart.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // numericUpDownEnd
            // 
            numericUpDownEnd.Enabled = false;
            numericUpDownEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownEnd.Location = new Point(417, 483);
            numericUpDownEnd.Margin = new Padding(0);
            numericUpDownEnd.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDownEnd.Name = "numericUpDownEnd";
            numericUpDownEnd.Size = new Size(51, 29);
            numericUpDownEnd.TabIndex = 54;
            numericUpDownEnd.TextAlign = HorizontalAlignment.Center;
            numericUpDownEnd.Value = new decimal(new int[] { 22, 0, 0, 0 });
            // 
            // Frm_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(867, 574);
            Controls.Add(numericUpDownEnd);
            Controls.Add(numericUpDownStart);
            Controls.Add(checkBoxIntervalOrar);
            Controls.Add(tbReceptie);
            Controls.Add(CheckBoxReceptie);
            Controls.Add(btnPrintCSV);
            Controls.Add(cbCalitate);
            Controls.Add(checkBoxCalitate);
            Controls.Add(cbZonaSelectie);
            Controls.Add(label2);
            Controls.Add(cbFurnizor);
            Controls.Add(label1);
            Controls.Add(checkBoxFurnizor);
            Controls.Add(Search);
            Controls.Add(newCalendar1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Dashboard";
            FormClosing += Frm_Dashboard_FormClosing;
            Load += Frm_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NewCalendar newCalendar1;
        private Button Search;
        private CheckBox checkBoxFurnizor;
        private Label label1;
        private ComboBox cbFurnizor;
        private Label label2;
        private ComboBox cbZonaSelectie;
        private ComboBox cbCalitate;
        private CheckBox checkBoxCalitate;
        private Button btnPrintCSV;
        private CheckBox CheckBoxReceptie;
        private TextBox tbReceptie;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Timp;
        private DataGridViewTextBoxColumn Locatie_Actuala;
        private DataGridViewTextBoxColumn Furnizor;
        private DataGridViewTextBoxColumn Numar_Aviz;
        private DataGridViewTextBoxColumn Numar_Receptie;
        private DataGridViewTextBoxColumn Numar_Bustean;
        private DataGridViewTextBoxColumn Lungime;
        private DataGridViewTextBoxColumn Diametru_Net;
        private DataGridViewTextBoxColumn Calitate;
        private DataGridViewTextBoxColumn Data_Transfer;
        private CheckBox checkBoxIntervalOrar;
        private NumericUpDown numericUpDownStart;
        private NumericUpDown numericUpDownEnd;
    }

}

