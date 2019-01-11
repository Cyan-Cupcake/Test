using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            String input = Console.ReadLine();  // Grabs a user input. Must be assigned a type(string, bool, int) and a variable. [Type Variable]
            Console.Write("What is your dick size? (Whole Number): ");
            int Dsize = Convert.ToInt32(Console.ReadLine()); // How to change inputs to int.
            Console.Write("Random non-whole number: ");
            double num3 = Convert.ToDouble(Console.ReadLine()); // input to any number (whole or not whole)

            Console.Clear(); //Clears everything on the console. duhhhh
            Console.WriteLine("Your name is " + input);
            Console.WriteLine("Your dick size is: " + Dsize + " Inche(s)");
            if (Dsize == 10)
            {
                Console.WriteLine("DAMN YOUR DICK IS BIG!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("TINY DICC");
            }

            Console.ReadLine(); //Adds a wait function that need a key press to continue.

            string F = "fuckoff"; // String will store text.
            bool truefalse = false; // Bool = Boolan will store True or False only.
            int X = 0; // Int = Intager which stores only numbers.
            X = 1 * 2;
            if (truefalse == true)
            { 
                // If/else statement replaces if/than statement.
                // == equals to
                // != does not equal to
                // <= less than or equal to
                // >= ^ but greater
                // >  less then
                // <  greater then
                // && use this if you want more than 1 check in a state meant.
                //ie. {x != 5 && x > 2} <--- this would mean it's true if x is greater then 2 but if it is any numbers but 5
                Console.WriteLine("It was True");
                Console.WriteLine(X);
                Console.WriteLine(F);
            }
            else
            {
                Console.WriteLine("it was false");
            }
            Console.WriteLine(num3);
            Console.WriteLine("It works!");

            Console.WriteLine("It worked with git hub?");
            //Did it tho? To make a change with github I just have to go to changes and make the change with sync.
            //Then to load the github you can just sync or if with a new computer/new project you have to clone it from github first.
            //making a thing.
            Console.ReadLine();
        }
        
    }
}

