using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siremob.model
{
    public static class Session
    {
        public static string IdPetugas { get; set; }
        public static string NamaPetugas { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; } // 'Karyawan', 'Admin', 'Owner'
        
        public static void Clear()
        {
            IdPetugas = null;
            NamaPetugas = null;
            Username = null;
            Role = null;
        }
    }
}
