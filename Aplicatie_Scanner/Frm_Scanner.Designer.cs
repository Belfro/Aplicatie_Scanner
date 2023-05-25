namespace Aplicatie_Scanner
{
    partial class Frm_Scanner
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Scanner));
            pictureBox2 = new PictureBox();
            cboDevice = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            tbGUIDScanat = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Btn_Disconnect = new Button();
            lblDiametruNet = new Label();
            lblLungime = new Label();
            label4 = new Label();
            tbNrReceptie = new TextBox();
            lblNrReceptie = new Label();
            tbNrBucati = new TextBox();
            lblNrBucati = new Label();
            label3 = new Label();
            lblCalitate = new Label();
            lblDiametru = new Label();
            tbDiametruBrut = new TextBox();
            tbNrAviz = new TextBox();
            lblNrAviz = new Label();
            lblFurnizor = new Label();
            tbLungime = new TextBox();
            tbFurnizor = new TextBox();
            tbCalitate = new TextBox();
            btnModifica = new Button();
            lblLocatieNoua = new Label();
            cbLocatieNoua = new ComboBox();
            tbLocatieCurenta = new TextBox();
            lblLocatieCurenta = new Label();
            panel1 = new Panel();
            checkboxScanare = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // cboDevice
            // 
            cboDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDevice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboDevice.Location = new Point(28, 37);
            cboDevice.Name = "cboDevice";
            cboDevice.Size = new Size(327, 29);
            cboDevice.TabIndex = 36;
            cboDevice.SelectedIndexChanged += cboDevice_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(46, 51, 100);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 126, 249);
            button1.Location = new Point(664, 77);
            button1.Name = "button1";
            button1.Size = new Size(176, 58);
            button1.TabIndex = 37;
            button1.Text = "Pornire\r\nCamera";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Trigger_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(46, 51, 100);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(-57, -42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 505);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tbGUIDScanat
            // 
            tbGUIDScanat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbGUIDScanat.Location = new Point(28, 506);
            tbGUIDScanat.Name = "tbGUIDScanat";
            tbGUIDScanat.ReadOnly = true;
            tbGUIDScanat.Size = new Size(327, 26);
            tbGUIDScanat.TabIndex = 39;
            tbGUIDScanat.TextAlign = HorizontalAlignment.Center;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Btn_Disconnect
            // 
            Btn_Disconnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Disconnect.BackColor = Color.FromArgb(46, 51, 100);
            Btn_Disconnect.FlatAppearance.BorderColor = Color.Black;
            Btn_Disconnect.FlatStyle = FlatStyle.Flat;
            Btn_Disconnect.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Disconnect.ForeColor = Color.FromArgb(192, 0, 0);
            Btn_Disconnect.Location = new Point(664, 141);
            Btn_Disconnect.Name = "Btn_Disconnect";
            Btn_Disconnect.Size = new Size(176, 58);
            Btn_Disconnect.TabIndex = 40;
            Btn_Disconnect.Text = "Deconectare";
            Btn_Disconnect.UseVisualStyleBackColor = false;
            Btn_Disconnect.Click += Btn_Disconnect_Click;
            // 
            // lblDiametruNet
            // 
            lblDiametruNet.Anchor = AnchorStyles.Left;
            lblDiametruNet.AutoSize = true;
            lblDiametruNet.Cursor = Cursors.No;
            lblDiametruNet.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiametruNet.ForeColor = Color.White;
            lblDiametruNet.Location = new Point(564, 433);
            lblDiametruNet.Name = "lblDiametruNet";
            lblDiametruNet.Size = new Size(38, 17);
            lblDiametruNet.TabIndex = 80;
            lblDiametruNet.Text = "Net: ";
            lblDiametruNet.Click += lblDiametruNet_Click;
            // 
            // lblLungime
            // 
            lblLungime.Anchor = AnchorStyles.Left;
            lblLungime.AutoSize = true;
            lblLungime.Cursor = Cursors.No;
            lblLungime.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLungime.ForeColor = Color.White;
            lblLungime.Location = new Point(366, 364);
            lblLungime.Name = "lblLungime";
            lblLungime.Size = new Size(62, 17);
            lblLungime.TabIndex = 79;
            lblLungime.Text = "Lungime";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Cursor = Cursors.No;
            label4.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(372, 325);
            label4.Name = "label4";
            label4.Size = new Size(147, 30);
            label4.TabIndex = 77;
            label4.Text = "Date Receptie";
            // 
            // tbNrReceptie
            // 
            tbNrReceptie.Anchor = AnchorStyles.Left;
            tbNrReceptie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNrReceptie.Location = new Point(365, 226);
            tbNrReceptie.Name = "tbNrReceptie";
            tbNrReceptie.ReadOnly = true;
            tbNrReceptie.Size = new Size(194, 29);
            tbNrReceptie.TabIndex = 76;
            tbNrReceptie.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNrReceptie
            // 
            lblNrReceptie.Anchor = AnchorStyles.Left;
            lblNrReceptie.AutoSize = true;
            lblNrReceptie.Cursor = Cursors.No;
            lblNrReceptie.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNrReceptie.ForeColor = Color.White;
            lblNrReceptie.Location = new Point(365, 209);
            lblNrReceptie.Name = "lblNrReceptie";
            lblNrReceptie.Size = new Size(106, 17);
            lblNrReceptie.TabIndex = 75;
            lblNrReceptie.Text = "Numar Receptie";
            // 
            // tbNrBucati
            // 
            tbNrBucati.Anchor = AnchorStyles.Left;
            tbNrBucati.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNrBucati.Location = new Point(365, 179);
            tbNrBucati.Name = "tbNrBucati";
            tbNrBucati.ReadOnly = true;
            tbNrBucati.Size = new Size(194, 29);
            tbNrBucati.TabIndex = 74;
            tbNrBucati.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNrBucati
            // 
            lblNrBucati.Anchor = AnchorStyles.Left;
            lblNrBucati.AutoSize = true;
            lblNrBucati.Cursor = Cursors.No;
            lblNrBucati.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNrBucati.ForeColor = Color.White;
            lblNrBucati.Location = new Point(365, 162);
            lblNrBucati.Name = "lblNrBucati";
            lblNrBucati.Size = new Size(92, 17);
            lblNrBucati.TabIndex = 73;
            lblNrBucati.Text = "Numar Bucati";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Cursor = Cursors.No;
            label3.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(369, 33);
            label3.Name = "label3";
            label3.Size = new Size(150, 30);
            label3.TabIndex = 72;
            label3.Text = "Date Generale";
            // 
            // lblCalitate
            // 
            lblCalitate.Anchor = AnchorStyles.Left;
            lblCalitate.AutoSize = true;
            lblCalitate.Cursor = Cursors.No;
            lblCalitate.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCalitate.ForeColor = Color.White;
            lblCalitate.Location = new Point(366, 457);
            lblCalitate.Name = "lblCalitate";
            lblCalitate.Size = new Size(55, 17);
            lblCalitate.TabIndex = 71;
            lblCalitate.Text = "Calitate";
            // 
            // lblDiametru
            // 
            lblDiametru.Anchor = AnchorStyles.Left;
            lblDiametru.AutoSize = true;
            lblDiametru.Cursor = Cursors.No;
            lblDiametru.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiametru.ForeColor = Color.White;
            lblDiametru.Location = new Point(365, 411);
            lblDiametru.Name = "lblDiametru";
            lblDiametru.Size = new Size(96, 17);
            lblDiametru.TabIndex = 69;
            lblDiametru.Text = "Diametru Brut";
            // 
            // tbDiametruBrut
            // 
            tbDiametruBrut.Anchor = AnchorStyles.Left;
            tbDiametruBrut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbDiametruBrut.Location = new Point(364, 427);
            tbDiametruBrut.Name = "tbDiametruBrut";
            tbDiametruBrut.ReadOnly = true;
            tbDiametruBrut.Size = new Size(194, 29);
            tbDiametruBrut.TabIndex = 68;
            tbDiametruBrut.TextAlign = HorizontalAlignment.Center;
            // 
            // tbNrAviz
            // 
            tbNrAviz.Anchor = AnchorStyles.Left;
            tbNrAviz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNrAviz.Location = new Point(365, 130);
            tbNrAviz.Name = "tbNrAviz";
            tbNrAviz.ReadOnly = true;
            tbNrAviz.Size = new Size(194, 29);
            tbNrAviz.TabIndex = 67;
            tbNrAviz.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNrAviz
            // 
            lblNrAviz.Anchor = AnchorStyles.Left;
            lblNrAviz.AutoSize = true;
            lblNrAviz.Cursor = Cursors.No;
            lblNrAviz.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNrAviz.ForeColor = Color.White;
            lblNrAviz.Location = new Point(365, 113);
            lblNrAviz.Name = "lblNrAviz";
            lblNrAviz.Size = new Size(80, 17);
            lblNrAviz.TabIndex = 66;
            lblNrAviz.Text = "Numar Aviz";
            // 
            // lblFurnizor
            // 
            lblFurnizor.Anchor = AnchorStyles.Left;
            lblFurnizor.AutoSize = true;
            lblFurnizor.Cursor = Cursors.No;
            lblFurnizor.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFurnizor.ForeColor = Color.White;
            lblFurnizor.Location = new Point(365, 63);
            lblFurnizor.Name = "lblFurnizor";
            lblFurnizor.Size = new Size(59, 17);
            lblFurnizor.TabIndex = 65;
            lblFurnizor.Text = "Furnizor";
            // 
            // tbLungime
            // 
            tbLungime.Anchor = AnchorStyles.Left;
            tbLungime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbLungime.Location = new Point(364, 381);
            tbLungime.Name = "tbLungime";
            tbLungime.ReadOnly = true;
            tbLungime.Size = new Size(194, 29);
            tbLungime.TabIndex = 81;
            tbLungime.TextAlign = HorizontalAlignment.Center;
            // 
            // tbFurnizor
            // 
            tbFurnizor.Anchor = AnchorStyles.Left;
            tbFurnizor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbFurnizor.Location = new Point(364, 83);
            tbFurnizor.Name = "tbFurnizor";
            tbFurnizor.ReadOnly = true;
            tbFurnizor.Size = new Size(194, 29);
            tbFurnizor.TabIndex = 82;
            tbFurnizor.TextAlign = HorizontalAlignment.Center;
            // 
            // tbCalitate
            // 
            tbCalitate.Anchor = AnchorStyles.Left;
            tbCalitate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbCalitate.Location = new Point(364, 474);
            tbCalitate.Name = "tbCalitate";
            tbCalitate.ReadOnly = true;
            tbCalitate.Size = new Size(194, 29);
            tbCalitate.TabIndex = 83;
            tbCalitate.TextAlign = HorizontalAlignment.Center;
            // 
            // btnModifica
            // 
            btnModifica.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModifica.BackColor = Color.FromArgb(46, 51, 100);
            btnModifica.FlatAppearance.BorderColor = Color.Black;
            btnModifica.FlatStyle = FlatStyle.Flat;
            btnModifica.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifica.ForeColor = Color.White;
            btnModifica.Location = new Point(664, 325);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(176, 58);
            btnModifica.TabIndex = 84;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = false;
            btnModifica.Visible = false;
            btnModifica.Click += btnModifica_Click;
            // 
            // lblLocatieNoua
            // 
            lblLocatieNoua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLocatieNoua.AutoSize = true;
            lblLocatieNoua.Cursor = Cursors.No;
            lblLocatieNoua.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLocatieNoua.ForeColor = Color.White;
            lblLocatieNoua.Location = new Point(664, 268);
            lblLocatieNoua.Name = "lblLocatieNoua";
            lblLocatieNoua.Size = new Size(93, 17);
            lblLocatieNoua.TabIndex = 85;
            lblLocatieNoua.Text = "Locatie Noua:";
            lblLocatieNoua.Visible = false;
            // 
            // cbLocatieNoua
            // 
            cbLocatieNoua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbLocatieNoua.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLocatieNoua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbLocatieNoua.FormattingEnabled = true;
            cbLocatieNoua.Location = new Point(664, 290);
            cbLocatieNoua.Name = "cbLocatieNoua";
            cbLocatieNoua.Size = new Size(176, 29);
            cbLocatieNoua.TabIndex = 86;
            cbLocatieNoua.Visible = false;
            // 
            // tbLocatieCurenta
            // 
            tbLocatieCurenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbLocatieCurenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbLocatieCurenta.Location = new Point(663, 236);
            tbLocatieCurenta.Name = "tbLocatieCurenta";
            tbLocatieCurenta.ReadOnly = true;
            tbLocatieCurenta.Size = new Size(177, 29);
            tbLocatieCurenta.TabIndex = 87;
            tbLocatieCurenta.TextAlign = HorizontalAlignment.Center;
            // 
            // lblLocatieCurenta
            // 
            lblLocatieCurenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLocatieCurenta.AutoSize = true;
            lblLocatieCurenta.Cursor = Cursors.No;
            lblLocatieCurenta.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLocatieCurenta.ForeColor = Color.White;
            lblLocatieCurenta.Location = new Point(663, 216);
            lblLocatieCurenta.Name = "lblLocatieCurenta";
            lblLocatieCurenta.Size = new Size(108, 17);
            lblLocatieCurenta.TabIndex = 88;
            lblLocatieCurenta.Text = "Locatie Curenta:";
            lblLocatieCurenta.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(26, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 431);
            panel1.TabIndex = 89;
            // 
            // checkboxScanare
            // 
            checkboxScanare.AutoSize = true;
            checkboxScanare.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            checkboxScanare.Location = new Point(666, 406);
            checkboxScanare.Name = "checkboxScanare";
            checkboxScanare.Size = new Size(136, 42);
            checkboxScanare.TabIndex = 90;
            checkboxScanare.Text = "Activare Mutare\r\nContinua";
            checkboxScanare.UseVisualStyleBackColor = true;
            checkboxScanare.CheckedChanged += checkboxScanare_CheckedChanged;
            // 
            // Frm_Scanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(867, 574);
            Controls.Add(checkboxScanare);
            Controls.Add(panel1);
            Controls.Add(lblLocatieCurenta);
            Controls.Add(tbLocatieCurenta);
            Controls.Add(cbLocatieNoua);
            Controls.Add(lblLocatieNoua);
            Controls.Add(btnModifica);
            Controls.Add(tbCalitate);
            Controls.Add(tbFurnizor);
            Controls.Add(tbLungime);
            Controls.Add(lblDiametruNet);
            Controls.Add(lblLungime);
            Controls.Add(label4);
            Controls.Add(tbNrReceptie);
            Controls.Add(lblNrReceptie);
            Controls.Add(tbNrBucati);
            Controls.Add(lblNrBucati);
            Controls.Add(label3);
            Controls.Add(lblCalitate);
            Controls.Add(lblDiametru);
            Controls.Add(tbDiametruBrut);
            Controls.Add(tbNrAviz);
            Controls.Add(lblNrAviz);
            Controls.Add(lblFurnizor);
            Controls.Add(Btn_Disconnect);
            Controls.Add(cboDevice);
            Controls.Add(button1);
            Controls.Add(tbGUIDScanat);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Scanner";
            Text = "Frm_Scanner";
            FormClosing += Frm_Scanner_FormClosing;
            Load += Frm_Scanner_Load;
            Leave += Frm_Scanner_Leave;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private ComboBox cboDevice;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox tbGUIDScanat;
        private System.Windows.Forms.Timer timer1;
        private Button Btn_Disconnect;
        private Label lblDiametruNet;
        private Label lblLungime;
        private Label label4;
        private TextBox tbNrReceptie;
        private Label lblNrReceptie;
        private TextBox tbNrBucati;
        private Label lblNrBucati;
        private Label label3;
        private Label lblCalitate;
        private Label lblDiametru;
        private TextBox tbDiametruBrut;
        private TextBox tbNrAviz;
        private Label lblNrAviz;
        private Label lblFurnizor;
        private TextBox tbLungime;
        private TextBox tbFurnizor;
        private TextBox tbCalitate;
        private Button btnModifica;
        private Label lblLocatieNoua;
        private ComboBox cbLocatieNoua;
        private TextBox tbLocatieCurenta;
        private Label lblLocatieCurenta;
        private Panel panel1;
        private CheckBox checkboxScanare;
    }
}