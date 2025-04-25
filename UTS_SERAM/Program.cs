using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace UTS_SERAM
{
    class Program
    {
        static void Main(string[] args)
        {
            perpustakaan manajemenbuku = new perpustakaan();
            manajemenbuku.informasiperpus();

            
            {
                Console.WriteLine("PILIH MENU INI DULU GAN:");
                Console.WriteLine("1. NAMBAH BUKU");
                Console.WriteLine("2. TAMPILKAN SEMUA BUKU");
                Console.WriteLine("3. CARI BUKU");
                Console.WriteLine("4. UBAH BUKU");
                Console.WriteLine("5. Hapus Buku");
                Console.WriteLine("6. EXIT");
                Console.Write("Pilihan Anda: ");
                int pilihmana = int.Parse(Console.ReadLine());

                if (pilihmana == 1)
                {

                    Console.Write("ID Buku: ");
                    string id = Console.ReadLine();

                    Console.Write("Judul Buku: "); 
                    string judul = Console.ReadLine();

                    Console.Write("Penulis: "); 
                    string author = Console.ReadLine();

                    Console.Write("Tahun Terbit: "); 
                    int year = int.Parse(Console.ReadLine());
                
                   
                }
                else if (pilihmana == 2)
                {
                    //perpustakaan.DisplayBooks()
                }

                else if (pilihmana == 3)
                {
                    Console.Write("Masukkan Judul Buku: "); 
                    string inputjudul = Console.ReadLine();
                }

                else if (pilihmana == 4)
                {
                    Console.Write("Masukin ID Buku yang mau diubah: ");
                    string id = Console.ReadLine();
                    Console.Write("Judul Baru: "); 
                    string judul = Console.ReadLine();
                    Console.Write("Penulis Baru: "); 
                    string penulis = Console.ReadLine();
                    Console.Write("Tahun Terbit Baru: "); 
                    int tahun= int.Parse(Console.ReadLine());

                }
                else if(pilihmana == 5)
                {
                    Console.Write("ID Buku yang ingin dihapus: ");
                    string id = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Goodbye Sir");
                }

            }
        }
    }
}
class Book
{
    public string id;
    public string judul;
    public string penulis;
    public int tahun;
    public bool status;

    public Book(string id, string judul, string penulis, int tahun, bool status)
    {
        this.id = id;
        this.judul = judul;
        this.penulis= penulis;
        this.tahun = tahun;
        this.status = true; 
    }

    public void infobuku()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Judul: {judul}");
        Console.WriteLine($"Penulis: {penulis}");
        Console.WriteLine($"Tahun: {tahun}");
    }
}

class perpustakaan : manajemenbuku
{
    public string nama_perpustakaan = "UPA PERPUSTAKAAN UNIVERSITAS JEMBER";
    public string alamat_perpustakaan= "JL KALIMANTAN NOMOR 1";

    public void informasiperpus()
    {
        Console.WriteLine($"NAMA: {nama_perpustakaan}");
        Console.WriteLine($"ALAMAT: {alamat_perpustakaan}");
    }
}

// Kelas Manajer Buku
class manajemenbuku
{
    private List<Book> daftarbuku = new List<Book>();

  
}


    