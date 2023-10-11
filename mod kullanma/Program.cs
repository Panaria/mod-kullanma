using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod_kullanma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcının girdiği sayınının 7'ye ve 5'e tam bölünüp bölünemediğini bulan programı yazınız.

            int sayi;

            Console.WriteLine("Sayı Giriniz");
            sayi = int.Parse(Console.ReadLine());

            if (sayi % 7 == 0 && sayi % 5 == 0)
            {
                Console.WriteLine("Sayı 5'e ve 7'ye tam bölünür.");
            }
            else
            {
                Console.WriteLine("Sayı 5'e ve 7'ye tam bölünemez.");
            }
            Console.ReadLine();
        }
    }
}
