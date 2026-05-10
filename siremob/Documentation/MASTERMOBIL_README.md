# Master Mobil - Dokumentasi

## Deskripsi
Master Mobil adalah modul untuk mengelola data kendaraan dalam aplikasi SiReMob. Modul ini menyediakan fitur CRUD lengkap (Create, Read, Update, Delete) dengan interface yang user-friendly.

## Fitur Utama

### 1. **Tambah Data Mobil**
- Klik tombol "Tambah" setelah mengisi semua field
- ID Mobil dan Plat Nomor harus unik
- Upload foto mobil melalui tombol "Browse"
- Status default: "Tersedia"

### 2. **Ubah Data Mobil**
- Klik baris data di tabel untuk memilih data yang akan diubah
- Ubah field yang diperlukan
- Klik tombol "Ubah" untuk menyimpan perubahan

### 3. **Hapus Data Mobil**
- Pilih data yang akan dihapus dari tabel
- Klik tombol "Hapus" dan konfirmasi penghapusan
- Data akan dihapus dari database

### 4. **Cari Data Mobil**
- Masukkan kata kunci pencarian (ID, Plat Nomor, atau Merk)
- Klik tombol "Cari" untuk mencari data
- Biarkan field kosong dan klik "Cari" untuk menampilkan semua data

### 5. **Tampilan Data**
- Tabel menampilkan semua data mobil
- Klik baris untuk memilih data dan menampilkannya di form input
- Preview foto mobil ditampilkan di panel kiri

## Database

### Struktur Tabel Mobil
```sql
CREATE TABLE Mobil (
    id_mobil CHAR(3) PRIMARY KEY,
    platnomor VARCHAR(15) UNIQUE NOT NULL,
    merk VARCHAR(50),
    tipe VARCHAR(50),
    tahun YEAR,
    warna VARCHAR(20),
    hargasewaperhari DECIMAL(18,2),
    statusmobil VARCHAR(20) DEFAULT 'Tersedia', 
    foto VARCHAR(255) 
);
```

### Penjelasan Field
- **id_mobil**: Kode unik mobil (3 karakter) - Primary Key
- **platnomor**: Nomor plat kendaraan (UNIQUE)
- **merk**: Merek/brand mobil
- **tipe**: Tipe/model mobil
- **tahun**: Tahun pembuatan mobil
- **warna**: Warna mobil
- **hargasewaperhari**: Harga sewa per hari (DECIMAL)
- **statusmobil**: Status ketersediaan (Tersedia/Tidak Tersedia/Dalam Perbaikan)
- **foto**: Path/lokasi file foto mobil

## Validasi

### Validasi Input
1. Semua field wajib diisi kecuali foto
2. ID Mobil harus 3 karakter
3. ID Mobil dan Plat Nomor harus unik
4. Harga harus berupa angka

### Tipe File Foto
Format yang didukung: JPG, JPEG, PNG, BMP

## Status Mobil

Status mobil dapat memiliki nilai:
- **Tersedia**: Mobil siap untuk disewa
- **Tidak Tersedia**: Mobil sedang disewa
- **Dalam Perbaikan**: Mobil sedang dalam proses perbaikan

## Warna Interface

Aplikasi menggunakan skema warna modern:
- **Header (Dark Blue)**: RGB(0, 45, 90)
- **Panel Input (Blue)**: RGB(72, 143, 174)
- **Button (Teal)**: RGB(102, 205, 170)
- **Background (Light Green)**: RGB(200, 230, 201)

## Tombol Fungsi

| Tombol | Fungsi |
|--------|--------|
| **Browse** | Memilih file foto mobil |
| **Tambah** | Menambah data mobil baru |
| **Ubah** | Mengubah data mobil yang dipilih |
| **Hapus** | Menghapus data mobil yang dipilih |
| **Batal** | Membersihkan form input |
| **Cari** | Mencari data berdasarkan keyword |

## Cara Penggunaan

### Menambah Mobil Baru
1. Kosongkan form dengan klik "Batal"
2. Isi semua field (ID Mobil, Plat Nomor, Merk, Tipe, Tahun, Warna, Harga, Status)
3. Klik "Browse" untuk memilih foto (opsional)
4. Klik tombol "Tambah"
5. Jika berhasil, data akan ditambahkan ke tabel

### Mengubah Data Mobil
1. Klik baris data mobil di tabel yang ingin diubah
2. Ubah field yang diperlukan
3. Untuk mengubah foto, klik "Browse" lagi
4. Klik tombol "Ubah"
5. Jika berhasil, data akan diperbarui

### Menghapus Data Mobil
1. Klik baris data mobil di tabel yang ingin dihapus
2. Klik tombol "Hapus"
3. Konfirmasi penghapusan
4. Data akan dihapus dari tabel

### Mencari Data
1. Masukkan keyword di field "Cari" (cari berdasarkan ID, Plat Nomor, atau Merk)
2. Klik tombol "Cari"
3. Hasil pencarian akan ditampilkan di tabel
4. Untuk menampilkan semua data, kosongkan field "Cari" dan klik "Cari"

## Catatan
- Semua operasi CRUD tersimpan langsung ke database
- Konfirmasi akan ditampilkan untuk operasi Hapus
- Preview foto ditampilkan di panel kiri untuk mobil yang dipilih
