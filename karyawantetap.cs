using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_8
{
   public  class karyawantetap : Karyawan
    {
        public override string Nama { get; set; }
        public override string Nik { get; set; }
        public double GajiBulanan { get; set; }

        public override double TotalGaji()
        {
            return GajiBulanan;
        }

    }
}