using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siremob.model
{
    internal class masterpelanggan
    {
        private string _id_pelanggan;
        private string _nik;
        private string _nama;
        private string _no_hp;
        private string _alamat;
        private string _no_sim;

        public string id_pelanggan
        {
            get { return _id_pelanggan; }
            set { _id_pelanggan = value; }
        }

        public string nik
        {
            get { return _nik; }
            set { _nik = value; }
        }

        public string nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string no_hp
        {
            get { return _no_hp; }
            set { _no_hp = value; }
        }

        public string alamat
        {
            get { return _alamat; }
            set { _alamat = value; }
        }

        public string no_sim
        {
            get { return _no_sim; }
            set { _no_sim = value; }
        }
    }
}
