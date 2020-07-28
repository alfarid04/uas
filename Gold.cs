using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Gold : Bioskop
    {
        public void spesifikasi()
        {
            Console.WriteLine(" Fasilitas              : Minuman");
            Console.WriteLine("                          Popcorn");
            Console.WriteLine("                          Penonton yang tidak memiliki tiket tidak boleh masuk ke dalam bioskop");
        }
        public double JumlahTiket { get; set; }
        public double HargaTiket { get; set; }
        public double UangBayar { get; set; }
        public override double Bayar()
        {
            return JumlahTiket * HargaTiket;
        }
        public override double Kembalian()
        {
            return UangBayar - Bayar();
        }
    }
}

