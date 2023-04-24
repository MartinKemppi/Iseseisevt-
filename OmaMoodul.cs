using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtöö
{
    internal class OmaMoodul
    {
        public static void Palindrom()
        {
            {
                Console.WriteLine("Siseta tekst, et kontrollida kas see on palindroom");
                string str = Console.ReadLine();
                bool isPalindrome = IsPalindrome(str);
                Console.WriteLine("'{0}' - {1} palindroom.", str, isPalindrome ? "" : "ei ole");
            }

            static bool IsPalindrome(string str)
            {
                str = str.Replace(" ", "").ToLower();

                for (int i = 0; i < str.Length / 2; i++)
                {
                    if (str[i] != str[str.Length - i - 1])
                    {
                        return false;
                    }
                }

                return true;
            }
            Console.WriteLine();
        }

        public static void Kalk()
        {
            {
                int[,] matrix = 
            {
            {  1,  2,  3,  4 },
            { -1, -2,  0,  -3 },
            {  -4, -5, -6, 9 },
            {  5,  6,  7,  8 }
            };

                int postulemus = 0;
                int negtulemus = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] > 0)
                        {
                            postulemus++;
                        }
                        else if (matrix[i, j] < 0)
                        {
                            negtulemus++;
                        }
                        else
                        {
                            Console.WriteLine("0 element on ({0}, {1})", i, j);
                        }
                    }
                }
                Console.WriteLine("Positiivse numbrite arv: {0}", postulemus);
                Console.WriteLine("Negatiivse numbrite arv: {0}", negtulemus);
            }
            Console.WriteLine();
        }

        public static void Sorteerimine()
        {
            Console.WriteLine("Sisesta tekst:");
            string input = Console.ReadLine();
           
            char[] sortedChars = input.ToCharArray();
            Array.Sort(sortedChars);

            string reversedSortedString = new string(sortedChars);
            char[] reversedChars = reversedSortedString.ToCharArray();
            Array.Reverse(reversedChars);
            reversedSortedString = new string(reversedChars);

            Console.WriteLine("Sisestatud tekst: {0}", input);
            Console.WriteLine("Sorteeritud tekst: {0}", new string(sortedChars));
            Console.WriteLine("Ümberpööratud sorteeritud tekst: {0}", reversedSortedString);
            Console.WriteLine();
        }
    }
}
