using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_8
{
    public class KaryawanHarian : Karyawan
    {
        public override string Nama { get; set; }
        public override string Nik { get; set; }

        public double JumlahJamKerja { get; set; }
        public double UpahPerJam { get; set; }

        public override double TotalGaji()
        {
            return JumlahJamKerja * UpahPerJam;
        }

    }
}



