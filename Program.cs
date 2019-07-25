using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uas
{
    class Program
    {
        static List<Produk> daftarProduk = new List<Produk>();
  
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]:");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch(nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;
                    case 2:
                        HapusProduk();
                        break;
                    case 3:
                        TampilProduk();
                        break;
                    case 4:
                        //keluar program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("PILIH MENU APLIKASI\n");
            Console.WriteLine("1. tambah produk\n");
            Console.WriteLine("2. hapus produk\n");
            Console.WriteLine("3. tampilkan produk\n");
            Console.WriteLine("4. keluar\n");
        }

        static void TambahProduk()
        {
            Console.Clear();
            Console.WriteLine("\nTambahkan data produk\n");
            Produk produk = new Produk();
            Console.Write("Kode produk:");
            produk.Kode = Console.ReadLine();
            Console.Write("Nama produk:");
            produk.Nama = Console.ReadLine();
            Console.Write("Harga Beli:");
            produk.HargaBeli = Console.ReadLine();
            Console.Write("Harga Jual:");
            produk.HargaJual = Console.ReadLine();

            daftarProduk.Add(produk);

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            Console.WriteLine("Hapus data produk\n");
            Console.Write("Kode produk : ");
            string kode = Console.ReadLine();
            Produk delPro = daftarProduk.SingleOrDefault(f => f.Kode == kode);
            if (daftarProduk.Contains(delPro) == true)
            {
                daftarProduk.Remove(delPro);
                Console.Write("Data produk berhasil dihapus");
            }
            else
            {
                Console.Write("Kode produk tidak ditemukan");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
            Console.WriteLine("Data Produk\n");
            int noUrut = 1;
            foreach (Produk produk in daftarProduk)
            {
                Console.WriteLine("{0}.{1},{2},{3},{4}", noUrut, produk.Kode, produk.Nama, produk.HargaBeli, produk.HargaJual);
                noUrut++;
            }
            Console.WriteLine("\ntekan enter untuk kembali ke menu");
            Console.ReadKey();
        }

    }
}
