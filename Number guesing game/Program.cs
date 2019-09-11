using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_guesing_game
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {

            int guess = 0; // tells game how many tries it takes for the computer to guess
            int Computerschoice; //used to store the computers guess 
            int maxnumber = 21; // sets the higest number the program can guess it has to be 1 highe
            
            int minnumber = 1;  // sets the lowest number the program can guess
            bool guessing = true; // used to tell if the while loop should be run
            string choice;
            

            Console.WriteLine("Think of a number between " + minnumber +  " and " + (maxnumber - 1) +". \nPress any key when done");
            Console.ReadKey();
            while (guessing)
            {
                Computerschoice = random.Next(minnumber , maxnumber);
                guess++;
                Console.WriteLine("Is your number " + Computerschoice);
                Console.WriteLine("1: This is your number");
                Console.WriteLine("2: My number is less than the number shown");
                Console.WriteLine("3: My number is greater than the number shown");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("The computer guessed your number in " + guess + " tries.");
                    guessing = false;
                    Console.ReadKey();

                }
                else if (choice == "2")
                {
                    maxnumber = Computerschoice - 1;
                    if (minnumber >= maxnumber)
                    {
                        Console.WriteLine("You cheated. The computer has found out in " + guess + " guesses");
                        guessing = false;
                        Console.ReadKey();
                        break;
                    }
                }
                else if (choice == "3")
                {
                    minnumber = Computerschoice + 1;
                    if (minnumber >= maxnumber)
                    {
                        Console.WriteLine("You cheated. The computer has found out in " + guess + " guesses");
                        guessing = false;
                        Console.ReadKey();
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
