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
            int maxnumber = 21; // sets the higest number the program can guess it has to be 1 higher than max number you want computer to guess computer can guess
            bool validchoice;

            int minnumber = 1;  // sets the lowest number the program can guess
            bool guessing = true; // used to tell if the while loop should be run
            string choice = "1";
            

            Console.WriteLine("Think of a number between " + minnumber +  " and " + (maxnumber - 1) +". \nPress any key when done"); // This tells the player the numbers set above. The - 1 in this is because the the max number it guesses is 1 less than the max number
            Console.ReadKey();
            while (guessing) // runs loop until guessing is set to true
            {
                Computerschoice = random.Next(minnumber , maxnumber);
                guess++;
                Console.WriteLine("\nIs your number " + Computerschoice);
                Console.WriteLine("1: This is your number");
                Console.WriteLine("2: My number is less than the number shown");
                Console.WriteLine("3: My number is greater than the number shown");
                validchoice = false; // used for while loop to tell game if choice is valid
                while (!validchoice)
                {
                  choice = Console.ReadLine();
                    if (choice == "1" || choice == "2" || choice == "3")
                    {
                        validchoice = true; //tells game the choice is valid 
                    }
                    else if (!validchoice) // used to know if the choice is valid
                    {
                        Console.WriteLine("please pick a valid choice");
                    }
                    
                }
                
                if (choice == "1")
                {
                    Console.WriteLine("The computer guessed your number in " + guess + " tries.");
                    guessing = false; // sets guessing to false so the loop ends
                    Console.ReadKey();

                }
                else if (choice == "2")
                {
                    maxnumber = Computerschoice - 1;
                    if (minnumber > maxnumber)
                    {
                        Console.WriteLine("You cheated. The computer has found out in " + guess + " guesses");
                        guessing = false;
                        Console.ReadKey();
                        
                    }
                }
                else if (choice == "3")
                {
                    minnumber = Computerschoice + 1;
                    if ( (maxnumber - 1) < minnumber)
                    {
                        Console.WriteLine("You cheated. The computer has found out in " + guess + " guesses");
                        guessing = false;
                        Console.ReadKey();
                        
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
