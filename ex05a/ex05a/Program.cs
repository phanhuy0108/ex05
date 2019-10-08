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
            
            while(true)
            {
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine(" "+char2code(c));
            }
        }
        public static void Printa_zv1()
        {
            for (int i = 97; i <= 122; i++)
            {
                Console.Write((char)i+" ");
            }
            Console.WriteLine();
        }
        public static void Printz_a()
        {
            for (int i=122;i>=97;i--)
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
    }
}
