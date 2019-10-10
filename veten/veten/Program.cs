using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veten
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            char[,] array = new char[n , n];
            ClearArray(array,n);
            DrawH(array, n);
            PrintArray(array, n);
            
        }
        public static void DrawH(char[,]arr,int n)
        {
            for (int i = 0; i<n;i++)
            {
                arr[i,0] = 'H';
                arr[n / 2-1, i] = 'H';
                arr[i, n-1] = 'H';
            }
                    
        }
        public static void ClearArray(char[,]arr,int n)
        {
            for (int i=0;i<n;i++)
            {
                for (int j = 0;j<n;j++)
                {
                    arr[i, j] = ' ';
                }
            }
        }
        public static void PrintArray(char[,] arr, int n)
        {
            for (int i=0; i<n;i++)
            {
                for (int j = 0; j<n;j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
