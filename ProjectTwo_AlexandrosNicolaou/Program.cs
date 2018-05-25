﻿using System;
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
            string playAgain = "";
            do
            {
                //Starting and ending numbers
                Console.WriteLine("input your starting number");
                int min = int.Parse(Console.ReadLine());
                Console.WriteLine("input your ending number ");
                int max = int.Parse(Console.ReadLine());

                //jackpot
                double jackpot = 23.01;
                Console.WriteLine("The jackpot is $" + jackpot);

                //guess 6 number array
                Console.WriteLine("Guess six lucky numbers");
                int[] luckyNumber = new int[6];
                for (int i = 0; i < luckyNumber.Length; i++)
                {
                    luckyNumber[i] = int.Parse(Console.ReadLine());
                    while (luckyNumber[i] < min || luckyNumber[i] > max)
                    {
                        Console.WriteLine("number is invalid \ninput a number between {0} and {1}", min, max);
                        luckyNumber[i] = int.Parse(Console.ReadLine());
                    }
                }

                //random lucky numbers array
                int[] luckyRandom = new int[6];
                Random r = new Random();
                for (int i = 0; i < luckyRandom.Length; i++)
                {
                    luckyRandom[i] = r.Next(min, max);
                }
                for (int i = 0; i < luckyRandom.Length; i++)
                {
                    Console.WriteLine("Lucky number: " + luckyRandom[i]);
                }

                //correct guesses
                int correctGuess = 0;
                for (int i = 0; i < luckyRandom.Length; i++)
                {
                    if (luckyRandom[i] == luckyNumber[i])
                    {
                        correctGuess = correctGuess + 1;
                    }
                }
                Console.WriteLine("you guessed {0} correctly!", correctGuess);

                //how much did the user win
                double prize;
                switch (correctGuess)
                {
                    case 1:
                        prize = jackpot / 6;
                        Console.WriteLine("you won $" + prize);
                        break;
                    case 2:
                        prize = jackpot / 5;
                        Console.WriteLine("you won $" + prize);
                        break;
                    case 3:
                        prize = jackpot / 4;
                        Console.WriteLine("you won $" + prize);
                        break;
                    case 4:
                        prize = jackpot / 3;
                        Console.WriteLine("you won $" + prize);
                        break;
                    case 5:
                        prize = jackpot / 2;
                        Console.WriteLine("you won $" + prize);
                        break;
                    case 6:
                        prize = jackpot / 1;
                        Console.WriteLine("you won $" + prize);
                        break;
                    case 0:
                        Console.WriteLine("better luck next time");
                        break;
                }

                //play again?
                Console.WriteLine("do you wish to play again?");
                playAgain = Console.ReadLine();
            } while ( playAgain != "no");
            Console.WriteLine("thanks for playing!");
                    
                    
        }
    }
}
