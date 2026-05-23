using AracTakip.Models;

namespace AracTakip
{
    public partial class frmAnaSayfa : Form
    {
       

        public frmAnaSayfa()
        {
            InitializeComponent();


            // Marka bilgilerini combobox'a ekliyoruz.
            cbMarka.DataSource = new List<string>() { "Ford", "Fiat", "Volkswagen", "BMW", "Toyota", "Volvo", "Renalut", "Mazda", "Honda" };

            LoadData(); // Veritabanýndaki mevcut araç listesini yükler.
            CleanData(); // Formdaki input alanlarýný temizler.

            #region Olaylar

            // Butonlara týklama olaylarý ekleniyor.
            BtnEkle.Click += BtnEkle_Click;
            BtnSil.Click += BtnSil_Click;
            BtnGuncelle.Click += BtnGuncelle_Click;
            BtnTemizle.Click += BtnTemizle_Click;

            // Grid'de seçim deðiþtiðinde tetiklenen olay.
            grdAracListesi.SelectionChanged += GrdAracListesi_SelectionChanged;

            #endregion



        }

        // Formdaki input alanlarýný temizler.
        private void CleanData()
        {
            cbMarka.SelectedIndex = -1; // Combobox seçimini kaldýrýr.
            txtModel.Clear(); // Model için kullanýlan TextBox'ý temizler.
            dtUretimTarihi.Value = DateTime.Now; // Üretim tarihi için varsayýlan deðeri bugüne ayarlar.
            txtFiyat.Clear(); // Fiyat alanýný temizler.
        }

        // Veritabanýndaki araç listesini DataGridView'e yükler.
        private void LoadData()
        {
            grdAracListesi.DataSource = Veriler.Context.Araclar.ToList(); // Veritabanýndaki araçlarý liste halinde Grid'e baðlar.
        }

        // DataGridView'de bir satýr seçildiðinde tetiklenir.
        private void GrdAracListesi_SelectionChanged(object? sender, EventArgs e)
        {
            if (grdAracListesi.SelectedRows.Count > 0) // Seçilen satýr var mý kontrolü.
            {
                int id = (int)grdAracListesi.SelectedRows[0].Cells["Id"].Value; // Seçilen aracýn ID'sini alýr.
                var secilenArac = Veriler.Context.Araclar.Find(id); // Veritabanýndan ilgili ID'ye sahip aracý bulur.

                if (secilenArac != null) // Araç bulunduysa bilgileri form alanlarýna doldurur.
                {
                    cbMarka.SelectedItem = secilenArac.Marka; // Marka bilgisi.
                    txtModel.Text = secilenArac.Model; // Model bilgisi.
                    dtUretimTarihi.Value = secilenArac.ÜretimTarihi; // Üretim tarihi.
                    txtFiyat.Text = secilenArac.Fiyat.ToString(); // Fiyat bilgisi.
                }
            }
        }

        // Temizleme butonuna týklanýldýðýnda tetiklenir.
        private void BtnTemizle_Click(object? sender, EventArgs e)
        {
            CleanData(); // Formdaki tüm alanlarý temizler.
            MessageBox.Show("Form temizlendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // Kullanýcýya bilgi mesajý gösterir.
        }

        // Güncelleme iþlemi için kullanýlan metod.
        private void BtnGuncelle_Click(object? sender, EventArgs e)
        {
            if (grdAracListesi.SelectedRows.Count == 0) // Güncellenecek bir araç seçilmiþ mi kontrolü.
            {
                MessageBox.Show("Güncellemek için bir araç seçmelisiniz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)grdAracListesi.SelectedRows[0].Cells["Id"].Value; // Seçilen aracýn ID'sini alýr.
            var guncellenecekArac = Veriler.Context.Araclar.Find(id); // Veritabanýndan ilgili aracý bulur.

            if (guncellenecekArac != null)
            {
                guncellenecekArac.Marka = cbMarka.SelectedItem?.ToString() ?? guncellenecekArac.Marka; // Marka bilgisini günceller (Null kontrolü).
                guncellenecekArac.Model = txtModel.Text; // Model bilgisini günceller.
                guncellenecekArac.ÜretimTarihi = dtUretimTarihi.Value.Date; // Üretim tarihini günceller.
                guncellenecekArac.Fiyat = decimal.Parse(txtFiyat.Text); // Fiyat bilgisini günceller.

                try
                {
                    Veriler.Context.SaveChanges(); // Deðiþiklikleri kaydeder.
                    LoadData(); // Grid'i günceller.
                    MessageBox.Show("Araç baþarýyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanData(); // Formu temizler.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); // Hata mesajý gösterir.
                }
            }
            else
            {
                MessageBox.Show("Seçilen araç bulunamadý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); // Araç bulunamazsa hata mesajý gösterir.
            }
        }

        // Silme iþlemi için kullanýlan metod.
        private void BtnSil_Click(object? sender, EventArgs e)
        {
            try
            {
                if (grdAracListesi.SelectedRows.Count == 0) // Silinecek bir araç seçilmiþ mi kontrolü.
                {
                    MessageBox.Show("Silmek için bir araç seçmelisiniz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = (int)grdAracListesi.SelectedRows[0].Cells["Id"].Value; // Seçilen aracýn ID'sini alýr.
                var silinecekArac = Veriler.Context.Araclar.Find(id); // Veritabanýndan aracý bulur.

                if (silinecekArac != null)
                {
                    var sonuc = MessageBox.Show("Seçtiðiniz veriler silinecek. Emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
                    if (sonuc == DialogResult.Yes)
                    {
                        Veriler.Context.Araclar.Remove(silinecekArac); // Aracý veritabanýndan kaldýrýr.
                        Veriler.Context.SaveChanges(); // Deðiþiklikleri kaydeder.
                        MessageBox.Show("Silme iþlemi baþarýlý!", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Information); // Baþarý mesajý gösterir.
                        LoadData(); // Grid'i günceller.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        // Ekleme iþlemi için kullanýlan metod.
        private void BtnEkle_Click(object? sender, EventArgs e)
        {
            try
            {
                if (cbMarka.SelectedItem == null) // Marka seçilmiþ mi kontrolü.
                {
                    MessageBox.Show("Lütfen bir marka seçiniz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Arac yeniKisi = new Arac()
                {
                    Marka = cbMarka.SelectedItem.ToString() ?? " ", // Marka bilgisi.
                    Model = txtModel.Text, // Model bilgisi.
                    ÜretimTarihi = dtUretimTarihi.Value.Date, // Üretim tarihi.
                    Fiyat = decimal.Parse(txtFiyat.Text) // Fiyat bilgisi.
                };

                Veriler.Context.Araclar.Add(yeniKisi); // Yeni araç eklenir.
                Veriler.Context.SaveChanges(); // Deðiþiklikler kaydedilir.

                MessageBox.Show("Araç baþarýyla eklendi!", "Kayýt", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                LoadData(); // Grid'i günceller.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }


    }
}
