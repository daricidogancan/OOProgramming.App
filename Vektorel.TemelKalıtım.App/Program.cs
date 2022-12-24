using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.TemelKalıtım.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan = new Hayvan();
            Kopek kopek = new Kopek();
            Balik balik = new Balik();

            balik.Habitat = "Su";

            Console.WriteLine(balik.Habitat);
            Console.ReadKey();  
        }
    }




}
