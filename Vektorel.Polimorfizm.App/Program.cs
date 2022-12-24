using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Polimorfizm.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek = new Kopek();
            Console.WriteLine(kopek.Havla());
            Kangal kangal = new Kangal();
            Console.WriteLine(kangal.Havla());
            Fino fino = new Fino();
            Console.WriteLine(fino.Havla());



            Console.ReadLine();
        }

    }


    public class Kopek 
    {
       public virtual string Havla()
        {
            return "Hav HAv";


        }
        public string Rengi { get; set; }
        public string Irk { get; set; }
    }
    public class Kangal : Kopek
    {
        public override string Havla()
        {
            return "Hıav HIAv";


        }


    }
    public class Fino:Kopek
    {
        public override string Havla()
        {
            return "Hev Hev";


        }
    }
}
