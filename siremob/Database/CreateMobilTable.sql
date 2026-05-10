-- Create Mobil Table
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

-- Sample Data
INSERT INTO Mobil VALUES ('001', 'AB 1234 CD', 'Toyota', 'Avanza', 2023, 'Silver', 350000, 'Tersedia', '');
INSERT INTO Mobil VALUES ('002', 'AB 5678 EF', 'Honda', 'Civic', 2022, 'Black', 450000, 'Tersedia', '');
INSERT INTO Mobil VALUES ('003', 'AB 9012 GH', 'Daihatsu', 'Xenia', 2021, 'White', 300000, 'Tersedia', '');
