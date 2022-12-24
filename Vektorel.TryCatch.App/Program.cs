using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.TryCatch.App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string sayiString = "abc";
                byte sayiInt = Convert.ToByte(sayiString);
            }
            catch (Exception ex)
            {
                // hatayı fırlatır.
                Console.WriteLine("Hata mesajı: " + ex.Message); // hata içinde mesajı gösterir
                Console.WriteLine("Lütfen 0-255 aralığında bir tam sayı değeri giriniz.");
                if (ex is FormatException)
                {
                    Console.WriteLine("Lütfen sadece sayısal değer giriniz");
                }
                else if (ex is OverflowException)
                {
                    Console.WriteLine("Lütfen sadece 0-255 aralığında bir tam sayı değeri giriniz");
                }
            }


            Console.ReadKey();
        }
    }
}
