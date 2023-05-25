namespace Aplicatie_Scanner
{
    partial class Frm_Printer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Printer));
            btn_print = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            cbFurnizor = new ComboBox();
            lblFurnizor = new Label();
            lblNrAviz = new Label();
            tbNrAviz = new TextBox();
            tbDiametruBrut = new TextBox();
            lblDiametru = new Label();
            lblCalitate = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblPrinterDbError = new Label();
            label3 = new Label();
            lblNrReceptie = new Label();
            label4 = new Label();
            lblLungime = new Label();
            btnPreview = new Button();
            pictureBox1 = new PictureBox();
            lbLungime = new ListBox();
            btnStartReceptie = new Button();
            btnStopReceptie = new Button();
            lbCalitate = new ListBox();
            tbNrReceptie = new TextBox();
            label5 = new Label();
            rtbComentariu = new RichTextBox();
            lblReceptiePornita = new Label();
            tbID = new TextBox();
            groupBox1 = new GroupBox();
            pbRomply = new PictureBox();
            tbIndexBustean = new TextBox();
            lblIndexBustean = new Label();
            BtnIndexBustean = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRomply).BeginInit();
            SuspendLayout();
            // 
            // btn_print
            // 
            btn_print.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_print.BackColor = Color.FromArgb(46, 51, 100);
            btn_print.FlatStyle = FlatStyle.Flat;
            btn_print.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_print.ForeColor = Color.Black;
            btn_print.Location = new Point(573, 176);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(290, 89);
            btn_print.TabIndex = 35;
            btn_print.Text = "Print";
            btn_print.UseVisualStyleBackColor = false;
            btn_print.Visible = false;
            btn_print.Click += button_print_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(754, 483);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.No;
            label2.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 25);
            label2.Name = "label2";
            label2.Size = new Size(174, 30);
            label2.TabIndex = 39;
            label2.Text = "Eticheta Curenta";
            // 
            // cbFurnizor
            // 
            cbFurnizor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbFurnizor.BackColor = Color.White;
            cbFurnizor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFurnizor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbFurnizor.FormattingEnabled = true;
            cbFurnizor.Location = new Point(318, 72);
            cbFurnizor.Name = "cbFurnizor";
            cbFurnizor.Size = new Size(249, 29);
            cbFurnizor.TabIndex = 40;
            cbFurnizor.SelectedIndexChanged += cbFurnizor_SelectedIndexChanged;
            cbFurnizor.SelectionChangeCommitted += cbFurnizor_SelectionChangeCommitted;
            // 
            // lblFurnizor
            // 
            lblFurnizor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFurnizor.AutoSize = true;
            lblFurnizor.Cursor = Cursors.No;
            lblFurnizor.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFurnizor.ForeColor = Color.White;
            lblFurnizor.Location = new Point(318, 55);
            lblFurnizor.Name = "lblFurnizor";
            lblFurnizor.Size = new Size(59, 17);
            lblFurnizor.TabIndex = 41;
            lblFurnizor.Text = "Furnizor";
            // 
            // lblNrAviz
            // 
            lblNrAviz.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNrAviz.AutoSize = true;
            lblNrAviz.Cursor = Cursors.No;
            lblNrAviz.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNrAviz.ForeColor = Color.White;
            lblNrAviz.Location = new Point(318, 104);
            lblNrAviz.Name = "lblNrAviz";
            lblNrAviz.Size = new Size(80, 17);
            lblNrAviz.TabIndex = 44;
            lblNrAviz.Text = "Numar Aviz";
            // 
            // tbNrAviz
            // 
            tbNrAviz.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbNrAviz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNrAviz.Location = new Point(318, 121);
            tbNrAviz.Name = "tbNrAviz";
            tbNrAviz.Size = new Size(249, 29);
            tbNrAviz.TabIndex = 45;
            // 
            // tbDiametruBrut
            // 
            tbDiametruBrut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDiametruBrut.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tbDiametruBrut.Location = new Point(319, 337);
            tbDiametruBrut.Name = "tbDiametruBrut";
            tbDiametruBrut.Size = new Size(81, 43);
            tbDiametruBrut.TabIndex = 47;
            tbDiametruBrut.TextChanged += tbDiametruBrut_TextChanged;
            tbDiametruBrut.KeyDown += tbDiametruBrut_KeyDown;
            tbDiametruBrut.KeyPress += tbDiametruBrut_KeyPress;
            // 
            // lblDiametru
            // 
            lblDiametru.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDiametru.AutoSize = true;
            lblDiametru.Cursor = Cursors.No;
            lblDiametru.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiametru.ForeColor = Color.White;
            lblDiametru.Location = new Point(313, 317);
            lblDiametru.Name = "lblDiametru";
            lblDiametru.Size = new Size(96, 17);
            lblDiametru.TabIndex = 48;
            lblDiametru.Text = "Diametru Brut";
            // 
            // lblCalitate
            // 
            lblCalitate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCalitate.AutoSize = true;
            lblCalitate.Cursor = Cursors.No;
            lblCalitate.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCalitate.ForeColor = Color.White;
            lblCalitate.Location = new Point(164, 317);
            lblCalitate.Name = "lblCalitate";
            lblCalitate.Size = new Size(55, 17);
            lblCalitate.TabIndex = 50;
            lblCalitate.Text = "Calitate";
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // lblPrinterDbError
            // 
            lblPrinterDbError.AutoSize = true;
            lblPrinterDbError.Cursor = Cursors.No;
            lblPrinterDbError.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrinterDbError.ForeColor = Color.Red;
            lblPrinterDbError.Location = new Point(15, 5);
            lblPrinterDbError.Name = "lblPrinterDbError";
            lblPrinterDbError.Size = new Size(46, 17);
            lblPrinterDbError.TabIndex = 52;
            lblPrinterDbError.Text = "Error !";
            lblPrinterDbError.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Cursor = Cursors.No;
            label3.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(322, 25);
            label3.Name = "label3";
            label3.Size = new Size(150, 30);
            label3.TabIndex = 54;
            label3.Text = "Date Generale";
            // 
            // lblNrReceptie
            // 
            lblNrReceptie.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNrReceptie.AutoSize = true;
            lblNrReceptie.Cursor = Cursors.No;
            lblNrReceptie.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNrReceptie.ForeColor = Color.White;
            lblNrReceptie.Location = new Point(317, 155);
            lblNrReceptie.Name = "lblNrReceptie";
            lblNrReceptie.Size = new Size(106, 17);
            lblNrReceptie.TabIndex = 57;
            lblNrReceptie.Text = "Numar Receptie";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Cursor = Cursors.No;
            label4.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 286);
            label4.Name = "label4";
            label4.Size = new Size(147, 30);
            label4.TabIndex = 59;
            label4.Text = "Date Receptie";
            // 
            // lblLungime
            // 
            lblLungime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLungime.AutoSize = true;
            lblLungime.Cursor = Cursors.No;
            lblLungime.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLungime.ForeColor = Color.White;
            lblLungime.Location = new Point(15, 317);
            lblLungime.Name = "lblLungime";
            lblLungime.Size = new Size(62, 17);
            lblLungime.TabIndex = 61;
            lblLungime.Text = "Lungime";
            // 
            // btnPreview
            // 
            btnPreview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPreview.BackColor = Color.FromArgb(46, 51, 100);
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreview.ForeColor = Color.Transparent;
            btnPreview.Location = new Point(573, 176);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(290, 89);
            btnPreview.TabIndex = 64;
            btnPreview.Text = "Previzualizare";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(0, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 447);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lbLungime
            // 
            lbLungime.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lbLungime.FormattingEnabled = true;
            lbLungime.ItemHeight = 31;
            lbLungime.Location = new Point(15, 337);
            lbLungime.Name = "lbLungime";
            lbLungime.Size = new Size(143, 190);
            lbLungime.TabIndex = 67;
            lbLungime.SelectedIndexChanged += lbLungime_SelectedIndexChanged;
            // 
            // btnStartReceptie
            // 
            btnStartReceptie.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartReceptie.BackColor = Color.FromArgb(46, 51, 100);
            btnStartReceptie.FlatStyle = FlatStyle.Flat;
            btnStartReceptie.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartReceptie.ForeColor = Color.Chartreuse;
            btnStartReceptie.Location = new Point(573, 72);
            btnStartReceptie.Name = "btnStartReceptie";
            btnStartReceptie.Size = new Size(142, 89);
            btnStartReceptie.TabIndex = 68;
            btnStartReceptie.Text = "Start\r\nReceptie";
            btnStartReceptie.UseVisualStyleBackColor = false;
            btnStartReceptie.Click += btnStartReceptie_Click;
            // 
            // btnStopReceptie
            // 
            btnStopReceptie.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStopReceptie.BackColor = Color.FromArgb(46, 51, 100);
            btnStopReceptie.FlatStyle = FlatStyle.Flat;
            btnStopReceptie.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnStopReceptie.ForeColor = Color.Red;
            btnStopReceptie.Location = new Point(721, 72);
            btnStopReceptie.Name = "btnStopReceptie";
            btnStopReceptie.Size = new Size(142, 89);
            btnStopReceptie.TabIndex = 69;
            btnStopReceptie.Text = "Stop\nReceptie";
            btnStopReceptie.UseVisualStyleBackColor = false;
            btnStopReceptie.Click += btnStopReceptie_Click;
            // 
            // lbCalitate
            // 
            lbCalitate.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lbCalitate.FormattingEnabled = true;
            lbCalitate.ItemHeight = 31;
            lbCalitate.Location = new Point(164, 337);
            lbCalitate.Name = "lbCalitate";
            lbCalitate.Size = new Size(143, 190);
            lbCalitate.TabIndex = 72;
            lbCalitate.SelectedIndexChanged += lbCalitate_SelectedIndexChanged;
            // 
            // tbNrReceptie
            // 
            tbNrReceptie.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbNrReceptie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNrReceptie.Location = new Point(317, 172);
            tbNrReceptie.Name = "tbNrReceptie";
            tbNrReceptie.Size = new Size(249, 29);
            tbNrReceptie.TabIndex = 58;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Cursor = Cursors.No;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(317, 205);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 74;
            label5.Text = "Comentariu";
            // 
            // rtbComentariu
            // 
            rtbComentariu.Location = new Point(317, 225);
            rtbComentariu.Name = "rtbComentariu";
            rtbComentariu.Size = new Size(249, 40);
            rtbComentariu.TabIndex = 75;
            rtbComentariu.Text = "";
            // 
            // lblReceptiePornita
            // 
            lblReceptiePornita.AutoSize = true;
            lblReceptiePornita.Cursor = Cursors.No;
            lblReceptiePornita.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblReceptiePornita.ForeColor = Color.Red;
            lblReceptiePornita.Location = new Point(573, 25);
            lblReceptiePornita.Name = "lblReceptiePornita";
            lblReceptiePornita.Size = new Size(171, 30);
            lblReceptiePornita.TabIndex = 76;
            lblReceptiePornita.Text = "Receptie Oprita!";
            // 
            // tbID
            // 
            tbID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbID.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbID.Location = new Point(39, 243);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(235, 22);
            tbID.TabIndex = 77;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbRomply);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(10, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 150);
            groupBox1.TabIndex = 78;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // pbRomply
            // 
            pbRomply.Image = Properties.Resources.logo_romply_merops_1_1600;
            pbRomply.Location = new Point(153, 18);
            pbRomply.Name = "pbRomply";
            pbRomply.Size = new Size(118, 23);
            pbRomply.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRomply.TabIndex = 79;
            pbRomply.TabStop = false;
            // 
            // tbIndexBustean
            // 
            tbIndexBustean.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tbIndexBustean.Location = new Point(430, 337);
            tbIndexBustean.Name = "tbIndexBustean";
            tbIndexBustean.Size = new Size(72, 43);
            tbIndexBustean.TabIndex = 79;
            tbIndexBustean.TextChanged += tbIndexBustean_TextChanged;
            tbIndexBustean.KeyPress += tbIndexBustean_KeyPress;
            // 
            // lblIndexBustean
            // 
            lblIndexBustean.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblIndexBustean.AutoSize = true;
            lblIndexBustean.Cursor = Cursors.No;
            lblIndexBustean.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIndexBustean.ForeColor = Color.White;
            lblIndexBustean.Location = new Point(418, 317);
            lblIndexBustean.Name = "lblIndexBustean";
            lblIndexBustean.Size = new Size(99, 17);
            lblIndexBustean.TabIndex = 80;
            lblIndexBustean.Text = "Index Bustean ";
            // 
            // BtnIndexBustean
            // 
            BtnIndexBustean.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnIndexBustean.BackColor = Color.FromArgb(46, 51, 100);
            BtnIndexBustean.FlatStyle = FlatStyle.Flat;
            BtnIndexBustean.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnIndexBustean.ForeColor = Color.Black;
            BtnIndexBustean.Location = new Point(318, 438);
            BtnIndexBustean.Name = "BtnIndexBustean";
            BtnIndexBustean.Size = new Size(185, 89);
            BtnIndexBustean.TabIndex = 81;
            BtnIndexBustean.Text = "Urmatorul Bustean\r\n+ \r\nPrint";
            BtnIndexBustean.UseVisualStyleBackColor = false;
            BtnIndexBustean.Visible = false;
            BtnIndexBustean.Click += BtnIndexBustean_Click;
            // 
            // Frm_Printer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(867, 574);
            Controls.Add(BtnIndexBustean);
            Controls.Add(lblIndexBustean);
            Controls.Add(tbIndexBustean);
            Controls.Add(groupBox1);
            Controls.Add(tbID);
            Controls.Add(lblReceptiePornita);
            Controls.Add(rtbComentariu);
            Controls.Add(label5);
            Controls.Add(lbCalitate);
            Controls.Add(btnStopReceptie);
            Controls.Add(btnStartReceptie);
            Controls.Add(lbLungime);
            Controls.Add(btnPreview);
            Controls.Add(lblLungime);
            Controls.Add(label4);
            Controls.Add(tbNrReceptie);
            Controls.Add(lblNrReceptie);
            Controls.Add(label3);
            Controls.Add(lblPrinterDbError);
            Controls.Add(lblCalitate);
            Controls.Add(lblDiametru);
            Controls.Add(tbDiametruBrut);
            Controls.Add(tbNrAviz);
            Controls.Add(lblNrAviz);
            Controls.Add(lblFurnizor);
            Controls.Add(cbFurnizor);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(btn_print);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Printer";
            Text = "Frm_Printer";
            Load += Frm_Printer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbRomply).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_print;
        private PictureBox pictureBox2;
        private Label label2;
        private ComboBox cbFurnizor;
        private Label lblFurnizor;
        private Label lblNrAviz;
        private TextBox tbNrAviz;
        private TextBox tbDiametruBrut;
        private Label lblDiametru;
        private Label lblCalitate;
        private System.Windows.Forms.Timer timer1;
        private Label lblPrinterDbError;
        private Label label3;
        private TextBox tbNrReceptie;
        private Label lblNrReceptie;
        private Label label4;
        private Label lblLungime;
        private Button btnPreview;
        private PictureBox pictureBox1;
        private ListBox lbLungime;
        private Button btnStartReceptie;
        private Button btnStopReceptie;
        private TextBox tbNrReceptieCurenta;
        private Label label1;
        private ListBox lbCalitate;
        private Label label5;
        private RichTextBox rtbComentariu;
        private Label lblReceptiePornita;
        private TextBox tbID;
        private GroupBox groupBox1;
        private PictureBox pbRomply;
        private TextBox tbIndexBustean;
        private Label lblIndexBustean;
        private Button BtnIndexBustean;
    }
}