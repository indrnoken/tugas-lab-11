using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_8
{
    public class sales : Karyawan
    {
    public override string Nama { get; set; }
    public override string Nik { get; set; }
    public double JumlahPenjualan { get; set; }
    public int Komisi { get; set; }
    public override double TotalGaji()
    {
        return JumlahPenjualan * Komisi;

    }

}
}
