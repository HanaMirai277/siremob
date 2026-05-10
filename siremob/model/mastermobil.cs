using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siremob.model
{
    internal class mastermobil
    {
        private string _id_mobil;
        private string _platnomor;
        private string _merk;
        private string _tipe;
        private int _tahun;
        private string _warna;
        private decimal _hargasewaperhari;
        private string _statusmobil;
        private string _foto;

        public string id_mobil
        {
            get { return _id_mobil; }
            set { _id_mobil = value; }
        }

        public string platnomor
        {
            get { return _platnomor; }
            set { _platnomor = value; }
        }

        public string merk
        {
            get { return _merk; }
            set { _merk = value; }
        }

        public string tipe
        {
            get { return _tipe; }
            set { _tipe = value; }
        }

        public int tahun
        {
            get { return _tahun; }
            set { _tahun = value; }
        }

        public string warna
        {
            get { return _warna; }
            set { _warna = value; }
        }

        public decimal hargasewaperhari
        {
            get { return _hargasewaperhari; }
            set { _hargasewaperhari = value; }
        }

        public string statusmobil
        {
            get { return _statusmobil; }
            set { _statusmobil = value; }
        }

        public string foto
        {
            get { return _foto; }
            set { _foto = value; }
        }
    }
}
