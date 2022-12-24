using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusOtomasyon.App
{
    internal class Program
    {
       static  string[] yolcu = new string[34];
        static void Main(string[] args)
        {
            for (int i = 0; i < yolcu.Length; i++)
            {
                yolcu[i] = null;
            }
            bool devamEt = true;
            string yeniYolcu = "";

            while (devamEt)
            {
             
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nÇıkmak için                          =>1" +
                                        "\nBilet Almak için Devam              =>2" +
                                        "\nButun yolcu listesi için            =>3" +
                                        "\nBoş koltuk listesi için             =>4");

                    char secim = Console.ReadKey(true).KeyChar;
                    if (secim == '1')
                    {
                        devamEt = false;
                        break;
                    }
                    else if (secim == '2')
                    {
                        devamEt = true;
                        break;
                    }
                    else if (secim == '3')

                        ButunKoltuklarıListele();

                    else if (secim == '4')
                        BosKoltukListele(); 
                }
                if (devamEt )
                {
                    bool isimAl = true;
                    while (isimAl)
                    {
                        yeniYolcu = Isim();
                        if (IsimUygunMU(yeniYolcu))
                        {
                            isimAl = false;
                        }
                        else
                        {
                            Console.WriteLine("\nİsminiz harflerden oluşmalı...\n");
                        }

                    }


                    Console.WriteLine("Kaç numaralı koltugu istiyosunuz?  <=");
                    int istenilenKoltuk = Convert.ToInt16(Console.ReadLine()) - 1;
                    bool koltukUygun = false;
                    if (KoltukBosMu(istenilenKoltuk))
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine((istenilenKoltuk + 1) + " numaralı koltugu " +
                        yeniYolcu + " satın almıstır");
                        yolcu[istenilenKoltuk] = yeniYolcu;

                    }
                    else
                    {
                        while (!koltukUygun)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nİstemis oldugunuz koltuk dolu\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nBos koltukları listelemek icin     =>1" +
                                              "\nbutun koltukları listelemek için   =>2");
                            string secim = Console.ReadLine();
                            if (secim == "1")
                            {
                                BosKoltukListele();
                            }
                            else if (secim == "2")
                            {
                                ButunKoltuklarıListele();
                            }
                            while (true)
                            {

                                Console.WriteLine("\nBoş bir koltuk seçiniz \t: ");
                                istenilenKoltuk = Convert.ToInt16(Console.ReadLine()) - 1;
                                if (KoltukBosMu(istenilenKoltuk))
                                {
                                    koltukUygun = true;
                                    break;
                                }


                            }

                            Console.ForegroundColor = ConsoleColor.Green;


                            Console.WriteLine((istenilenKoltuk + 1) + " numaralı koltugu " +
                            yeniYolcu + " satın almıstır");
                            yolcu[istenilenKoltuk] = yeniYolcu;

                        }
                    } 

                }

            }




        }
        static void Baslik()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\t\tKoltuk No:\tYolcu:\t\tKoltuk No:\tYolcu:");
            Console.WriteLine("\t\t------:\t------\t\t------\t------");
    
        }
        static string Isim()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Bir İsim Soyisim Giriniz:");
            return Console.ReadLine();  
        }
        static bool IsimUygunMU(string adSoyad)
        {
            bool durum=true;
            for (int i = 0; i < adSoyad.Length; i++)
            {
                if (!(char.IsLetter(adSoyad[i])|| adSoyad[i]==' '))
                {
                    durum = false;
                    break;  
                }

            }
            return durum;   
        }
        static bool KoltukBosMu(int koltukNo)
        {
            if (yolcu[koltukNo] == null)
                return true;
            else return false;
        }
        static void BosKoltukListele()
        {
            Baslik();
            for (int i = 0; i < yolcu.Length; i+=2)
            {
                if (yolcu[i]==null)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\t\t   " + (i + 1) + "." + "\t\tBOŞ" + "\t\t");

                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t\t   " + (i + 1) + "." + "\t\tDOLU" + "\t\t");
                }
                if (yolcu[i+1]==null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write((i + 2) + "." + "\t\tBOŞ");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write((i + 2) + "." + "\t\tDOLU");

                }
                Console.WriteLine("");


            }
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void ButunKoltuklarıListele()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Baslik();
            for (int i = 0; i < yolcu.Length; i += 2)
            {
                if (yolcu[i] == null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\t\t   " + (i + 1) + "." + "\t\tBOŞ" + "\t\t");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t\t   " + (i + 1) + "." + "\t\t" + yolcu[i] + "\t");
                }
                if (yolcu[i + 1] == null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write((i + 2) + "." + "\t\tBOŞ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write((i + 2) + "." + "\t\t" + yolcu[i + 1]);
                }
                Console.WriteLine("");
            }
        }

    }
}
