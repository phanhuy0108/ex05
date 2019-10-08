using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05a
{
    class Program
    {
        static void Main(string[] args)
        {
            Printa_zv1();
            Printz_a();
            PrintA_Z();

            while (true)
            {
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine(" " + char2code(c));
            }
        }
        public static void Printa_zv1()
        {
            for (int i = 97; i <= 122; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
        public static void Printz_a()
        {
            for (int i = 122; i >= 97; i--)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
        public static void PrintA_Z()
        {
            for (int i = 65; i <= 90; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
        public static int char2code(char c)
        {
            return (int)c;
        }
        public static bool IsUper(char c)
        {

            if ((int)c >= 65 && c <= 90)
            {
                return true;
            }
            return false;
        }
        static bool isLower(char c)
        {
            if ((int)c >= 97 && c <= 122)
                return true;
            return false;
        }
        static char changeUpPer_Lower(char c)
        {
            if ((int)c >= 65 && c <= 90)
            {
                int ch = c + 32;
                return (char)ch;
            }
            else
            {
                int ch = c - 32;
                return (char)ch;
            }
            return ' ';
        }
    }
}
