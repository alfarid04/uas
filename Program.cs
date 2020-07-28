using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
        Menu:
            Console.Clear();
            List<Bioskop> listBioskop = new List<Bioskop>();
            head();
            Console.WriteLine("\n Judul Film");
            Console.WriteLine(" 1. Harry Potter");
            Console.WriteLine(" 2. Frozen 2");
            Console.WriteLine(" 3. Avenger (Endgame)");
            Console.Write("\n Pilih Film : ");
            int pilih = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (pilih)
            {
                case 1:
                    head();
                    Console.WriteLine("\t    Harry Potter");
                    tiket();
                    int menu = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (menu)
                    {
                        case 1:
                            Velvet velvet = new Velvet();
                            head();
                            Console.WriteLine("\t Harry Potter");
                            Console.WriteLine("\t    Velvet");
                            Console.Write("\n Nama Pemesan           : ");
                            velvet.Nama = Console.ReadLine();
                            Console.WriteLine(" Judul Film             : Harry Potter");
                            Console.WriteLine(" No. Bangku             : 1C - 10C");
                            Console.WriteLine(" Jam                    : 10.00 - 12.00");
                            tiketVelvet();

                            goto Menu;

                        case 2:
                            Gold gold = new Gold();
                            head();
                            Console.WriteLine("\t Harry Potter");
                            Console.WriteLine("\t    Gold");
                            Console.Write("\n Nama Pemesan           : ");
                            gold.Nama = Console.ReadLine();
                            Console.WriteLine(" Judul Film             : Harry Potter");
                            Console.WriteLine(" No. Bangku             : 1B - 10B");
                            Console.WriteLine(" Jam                    : 10.00 - 12.00");
                            tiketGold();

                            goto Menu;

                        case 3:
                            Reguler reguler = new Reguler();
                            head();
                            Console.WriteLine("\t Harry Potter");
                            Console.WriteLine("\t    Reguler");
                            Console.Write("\n Nama Pemesan           : ");
                            reguler.Nama = Console.ReadLine();
                            Console.WriteLine(" Judul Film             : Harry Potter");
                            Console.WriteLine(" No. Bangku             : 1A - 10A");
                            Console.WriteLine(" Jam                    : 10.00 - 12.00");
                            tiketReguler();

                            goto Menu;
                    }
                    break;

                case 2:
                    head();
                    Console.WriteLine("\t    Frozen 2");
                    tiket();
                    int menu2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (menu2)
                    {
                        case 1:
                            Velvet velvet = new Velvet();
                            head();
                            Console.WriteLine("\t Frozen 2");
                            Console.WriteLine("\t  Velvet");
                            Console.Write("\n Nama Pemesan           : ");
                            velvet.Nama = Console.ReadLine();
                            Console.WriteLine(" Judul Film             : Frozen 2");
                            Console.WriteLine(" No. Bangku             : 1C - 10C");
                            Console.WriteLine(" Jam                    : 13.15 - 15.10");
                            tiketVelvet();

                            goto Menu;

                        case 2:
                            Gold gold = new Gold();
                            head();
                            Console.WriteLine("\t Frozen 2");
                            Console.WriteLine("\t  Gold");
                            Console.Write("\n Nama Pemesan           : ");
                            gold.Nama = Console.ReadLine();
                            Console.WriteLine(" Judul Film             : Frozen 2");
                            Console.WriteLine(" No. Bangku             : 1B - 10B");
                            Console.WriteLine(" Jam                    : 13.15 - 15.10");
                            tiketGold();

                            goto Menu;

                        case 3:
                            Reguler reguler = new Reguler();
                            head();
                            Console.WriteLine("\t Frozen 2");
                            Console.WriteLine("\t Reguler");
                            Console.Write("\n Nama Pemesan           : ");
                            reguler.Nama = Console.ReadLine();
                            Console.WriteLine(" Judul Film             : Frozen 2");
                            Console.WriteLine(" No. Bangku             : 1A - 10A");
                            Console.WriteLine(" Jam                    : 13.15 - 15.10");
                            tiketReguler();

                            goto Menu;
                    }
                    break;

                case 3:
                    head();
                    Console.WriteLine("\t  Avenger (Endgame)  ");
                    tiket();
                    int menu3 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (menu3)
                    {
                        case 1:
                            Velvet velvet = new Velvet();
                            head();
                            Console.WriteLine("\t Avenger (Endgame)");
                            Console.WriteLine("\t      Velvet");
                            Console.Write("\n Nama Pemesan           : ");
                            velvet.Nama = Console.ReadLine();
                            Console.WriteLine(" Judul Film             : Avenger (Endgame)");
                            Console.WriteLine(" No. Bangku             : 1C - 10C");
                            Console.WriteLine(" Jam                    : 16.10 - 18.20");
                            tiketVelvet();

                            goto Menu;

                        case 2:
                            Gold gold = new Gold();
                            head();
                            Console.WriteLine("\t Avenger (Endgame)");
                            Console.WriteLine("\t       Gold");
                            Console.Write("\n Nama Pemesan           : ");
                            gold.Nama = Console.ReadLine();
                            Console.WriteLine(" Judul Film             : Avenger (Endgame)");
                            Console.WriteLine(" No. Bangku             : 1B - 10B");
                            Console.WriteLine(" Jam                    : 16.10 - 18.20");
                            tiketGold();

                            goto Menu;

                        case 3:
                            Reguler reguler = new Reguler();
                            head();
                            Console.WriteLine("\t Avenger (Endgame)");
                            Console.WriteLine("\t       Reguler");
                            Console.Write("\n Nama Pemesan           : ");
                            reguler.Nama = Console.ReadLine();
                            Console.WriteLine(" Judul Film             : Avenger (Endgame)");
                            Console.WriteLine(" No. Bangku             : 1B - 10B");
                            Console.WriteLine(" Jam                    : 16.10 - 18.20");
                            tiketReguler();

                            goto Menu;
                    }
                    break;
            }
            Console.ReadKey();
        }

        static void head()
        {
            Console.WriteLine(" ---------------------------------");
            Console.WriteLine("\t TIKET BIOSKOP XXI");
            Console.WriteLine(" ---------------------------------");
        }
        static void tiket()
        {
            Console.WriteLine("\n Pilihan Tiket");
            Console.WriteLine(" 1. Velvet");
            Console.WriteLine(" 2. Gold");
            Console.WriteLine(" 3. Reguler");
            Console.Write("\n Masukkan Tiket : ");
        }
        static void tiketVelvet()
        {
            List<Bioskop> listBioskop = new List<Bioskop>();
            Velvet velvet = new Velvet();
            velvet.spesifikasi();
            Console.WriteLine("\n Harga Tiket            : Rp.75000");
            velvet.HargaTiket = 75000;
            Console.Write(" Jumlah Pemesanan Tiket : ");
            velvet.JumlahTiket = Convert.ToDouble(Console.ReadLine());
            listBioskop.Add(velvet);
            foreach (Bioskop bioskop in listBioskop)
            {
                Console.WriteLine(" Pembayaran Tiket       : Rp.{0}", bioskop.Bayar());
            }
            Console.Write(" Uang Pembayaran        : Rp.");
            velvet.UangBayar = Convert.ToDouble(Console.ReadLine());
            foreach (Bioskop bioskop in listBioskop)
            {
                Console.WriteLine(" Uang Kembalian         : Rp.{0}", bioskop.Kembalian());
            }
            listBioskop.Add(velvet);
            Console.WriteLine("\n Terimakasih telah melakukan pembelian tiket Bioskop XXI");
            Console.WriteLine(" Selamat Menonton");
            Console.WriteLine(" Tekan ENTER untuk kembali ke Menu");
            Console.ReadKey();
        }
        static void tiketGold()
        {
            List<Bioskop> listBioskop = new List<Bioskop>();
            Gold gold = new Gold();
            gold.spesifikasi();
            Console.WriteLine("\n Harga Tiket            : Rp50000");
            gold.HargaTiket = 50000;
            Console.Write(" Jumlah Pemesanan Tiket : ");
            gold.JumlahTiket = Convert.ToDouble(Console.ReadLine());
            listBioskop.Add(gold);
            foreach (Bioskop bioskop in listBioskop)
            {
                Console.WriteLine(" Pembayaran Tiket       : Rp.{0}", bioskop.Bayar());
            }
            Console.Write(" Uang Pembayaran        : Rp.");
            gold.UangBayar = Convert.ToDouble(Console.ReadLine());
            foreach (Bioskop bioskop in listBioskop)
            {
                Console.WriteLine(" Uang Kembalian         : Rp.{0}", bioskop.Kembalian());
            }
            listBioskop.Add(gold);
            Console.WriteLine("\n Terimakasih telah melakukan pembelian tiket Bioskop XXI");
            Console.WriteLine(" Selamat Menonton");
            Console.WriteLine(" Tekan ENTER untuk kembali ke Menu");
            Console.ReadKey();

        }
        static void tiketReguler()
        {
            List<Bioskop> listBioskop = new List<Bioskop>();
            Reguler reguler = new Reguler();
            reguler.spesifikasi();
            Console.WriteLine("\n Harga Tiket            : Rp35000");
            reguler.HargaTiket = 35000;
            Console.Write(" Jumlah Pemesanan Tiket : ");
            reguler.JumlahTiket = Convert.ToDouble(Console.ReadLine());
            listBioskop.Add(reguler);
            foreach (Bioskop bioskop in listBioskop)
            {
                Console.WriteLine(" Pembayaran Tiket       : Rp.{0}", bioskop.Bayar());
            }
            Console.Write(" Uang Pembayaran        : Rp.");
            reguler.UangBayar = Convert.ToDouble(Console.ReadLine());
            foreach (Bioskop bioskop in listBioskop)
            {
                Console.WriteLine(" Uang Kembalian         : Rp.{0}", bioskop.Kembalian());
            }
            listBioskop.Add(reguler);
            Console.WriteLine("\n Terimakasih telah melakukan pembelian tiket Bioskop XXI");
            Console.WriteLine(" Selamat Menonton");
            Console.WriteLine(" Tekan ENTER untuk kembali ke Menu");
            Console.ReadKey();
        }
    }
}