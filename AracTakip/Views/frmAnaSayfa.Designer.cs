namespace AracTakip
{
    partial class frmAnaSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtModel = new TextBox();
            txtFiyat = new TextBox();
            grdAracListesi = new DataGridView();
            BtnGuncelle = new Button();
            BtnSil = new Button();
            BtnEkle = new Button();
            BtnTemizle = new Button();
            cbMarka = new ComboBox();
            dtUretimTarihi = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdAracListesi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(384, 237);
            label1.Name = "label1";
            label1.Size = new Size(421, 46);
            label1.TabIndex = 0;
            label1.Text = "ARAÇ EKLEME İŞLEMLERİ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.car;
            pictureBox1.Location = new Point(476, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(345, 303);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 2;
            label2.Text = "MARKA :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(345, 359);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 3;
            label3.Text = "MODEL :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(272, 417);
            label4.Name = "label4";
            label4.Size = new Size(169, 28);
            label4.TabIndex = 4;
            label4.Text = "ÜRETİM TARİHİ :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(367, 476);
            label5.Name = "label5";
            label5.Size = new Size(74, 28);
            label5.TabIndex = 5;
            label5.Text = "FİYAT :";
            // 
            // txtModel
            // 
            txtModel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtModel.Font = new Font("Segoe UI", 15F);
            txtModel.Location = new Point(447, 356);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(380, 34);
            txtModel.TabIndex = 7;
            // 
            // txtFiyat
            // 
            txtFiyat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFiyat.Font = new Font("Segoe UI", 15F);
            txtFiyat.Location = new Point(447, 473);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(380, 34);
            txtFiyat.TabIndex = 9;
            // 
            // grdAracListesi
            // 
            grdAracListesi.AllowUserToAddRows = false;
            grdAracListesi.AllowUserToDeleteRows = false;
            grdAracListesi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdAracListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdAracListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAracListesi.Location = new Point(15, 596);
            grdAracListesi.MultiSelect = false;
            grdAracListesi.Name = "grdAracListesi";
            grdAracListesi.ReadOnly = true;
            grdAracListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdAracListesi.Size = new Size(1124, 251);
            grdAracListesi.TabIndex = 10;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnGuncelle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BtnGuncelle.Image = Properties.Resources.refresh;
            BtnGuncelle.ImageAlign = ContentAlignment.MiddleRight;
            BtnGuncelle.Location = new Point(602, 524);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(189, 47);
            BtnGuncelle.TabIndex = 11;
            BtnGuncelle.Text = "GÜNCELLE";
            BtnGuncelle.TextAlign = ContentAlignment.MiddleLeft;
            BtnGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnSil
            // 
            BtnSil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnSil.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BtnSil.Image = Properties.Resources.delete;
            BtnSil.ImageAlign = ContentAlignment.MiddleRight;
            BtnSil.Location = new Point(384, 524);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(189, 45);
            BtnSil.TabIndex = 12;
            BtnSil.Text = "SİL";
            BtnSil.TextAlign = ContentAlignment.MiddleLeft;
            BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnEkle
            // 
            BtnEkle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnEkle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BtnEkle.Image = Properties.Resources.transport;
            BtnEkle.ImageAlign = ContentAlignment.MiddleRight;
            BtnEkle.Location = new Point(165, 523);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(189, 45);
            BtnEkle.TabIndex = 13;
            BtnEkle.Text = "EKLE";
            BtnEkle.TextAlign = ContentAlignment.MiddleLeft;
            BtnEkle.UseVisualStyleBackColor = true;
            // 
            // BtnTemizle
            // 
            BtnTemizle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnTemizle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BtnTemizle.Image = Properties.Resources.mop;
            BtnTemizle.ImageAlign = ContentAlignment.MiddleRight;
            BtnTemizle.Location = new Point(821, 524);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(189, 47);
            BtnTemizle.TabIndex = 14;
            BtnTemizle.Text = "TEMİZLE";
            BtnTemizle.TextAlign = ContentAlignment.MiddleLeft;
            BtnTemizle.UseVisualStyleBackColor = true;
            // 
            // cbMarka
            // 
            cbMarka.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbMarka.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMarka.Font = new Font("Segoe UI", 15F);
            cbMarka.Location = new Point(447, 300);
            cbMarka.Name = "cbMarka";
            cbMarka.Size = new Size(380, 36);
            cbMarka.TabIndex = 15;
            // 
            // dtUretimTarihi
            // 
            dtUretimTarihi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtUretimTarihi.Font = new Font("Segoe UI", 15F);
            dtUretimTarihi.Location = new Point(447, 412);
            dtUretimTarihi.Name = "dtUretimTarihi";
            dtUretimTarihi.Size = new Size(380, 34);
            dtUretimTarihi.TabIndex = 16;
            // 
            // frmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 859);
            Controls.Add(dtUretimTarihi);
            Controls.Add(cbMarka);
            Controls.Add(BtnTemizle);
            Controls.Add(BtnEkle);
            Controls.Add(BtnSil);
            Controls.Add(BtnGuncelle);
            Controls.Add(grdAracListesi);
            Controls.Add(txtFiyat);
            Controls.Add(txtModel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmAnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARAÇ TAKİP";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdAracListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtModel;
        private TextBox txtFiyat;
        private DataGridView grdAracListesi;
        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnEkle;
        private Button BtnTemizle;
        private ComboBox cbMarka;
        private DateTimePicker dtUretimTarihi;
    }
}
