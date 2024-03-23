using modul5_1302220063;

using System;

namespace modul5_1302220063
{
    class Penjumlahan<T>
    {
        public dynamic JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic x = angka1;
            dynamic y = angka2;
            dynamic z = angka3;

            return x + y + z;

        }
    }
}


class Program
{
    public void Main(string[] args)
    {
        Console.WriteLine("Masukan angka: ");
        int input = Convert.ToInt32(Console.ReadLine());

        Penjumlahan <int> JumlahTigaAngka = new Penjumlahan<int>();
        Console.WriteLine(JumlahTigaAngka.JumlahTigaAngka(13, 02, 22));


    }
}