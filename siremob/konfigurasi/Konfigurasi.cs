using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace siremob.konfigurasi
{
    abstract class Konfigurasi
    {
        public abstract int EksekusiNonQuery(string query);
        public abstract DataTable EksekusiQuery(string query);
    }
}
