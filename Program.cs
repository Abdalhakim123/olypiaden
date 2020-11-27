using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Äpplen ?:");
            int Applen = int.Parse(Console.ReadLine());
            Console.WriteLine("Päron ?:");
            int Paron = int.Parse(Console.ReadLine());

            Applen = Applen * 7;
            Paron = Paron * 13;

            if (Paron < Applen)
            {
                Console.WriteLine("Axel");
            }
            else if (Paron > Applen)
            {
                Console.WriteLine("Petra");
            }
            else
            {
                Console.WriteLine("Lika");
            }
        }
    }
}
