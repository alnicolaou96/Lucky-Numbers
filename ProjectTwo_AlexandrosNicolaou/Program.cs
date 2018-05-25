using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo_AlexandrosNicolaou
{
    class Program
    {
        static void Main(string[] args)
        {

            //Starting and ending numbers
            Console.WriteLine("input your starting number");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("input your ending number ");
            int max = int.Parse(Console.ReadLine());

            //guess 6 number array
            Console.WriteLine("Guess six lucky numbers");
            int[] luckyNumber = new int[6];
            for(int i=0 ; i < luckyNumber.Length; i++)
            {
                luckyNumber[i] = int.Parse(Console.ReadLine());
                while (luckyNumber[i]<min||luckyNumber[i]>max)
                {
                    Console.WriteLine("number is invalid \ninput a number between {0} and {1}",min,max);
                    luckyNumber[i] = int.Parse(Console.ReadLine());
                }            
            }
        }
    }
}
