using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtöö
{
    internal class Mein
    {
        public static void Main(string[] args)
        //4 var
        {
            while (true)
            {
                Console.WriteLine("Sisesta number ülesanne valimiseks:\n 1) - Kontrollib kas sõna on palindroom või mitte\n 2) - Ruutmatriks\n 3) - Sorteerimine sisend\n 4) - Välju");
                string vastus = Console.ReadLine();

                if (vastus == "1")
                {
                    OmaMoodul.Palindrom();
                }
                else if (vastus == "2")
                {
                    OmaMoodul.Kalk();
                }
                else if (vastus == "3")
                {
                    OmaMoodul.Sorteerimine();
                }
                else if (vastus == "4")
                {
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Kirjuta ainult need numbrid, mis on ettevalmistatud");
                }
            }
        }
    }
}