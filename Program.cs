// See https://aka.ms/new-console-template for more information


using System;
using System.ComponentModel.Design;
using System.Numerics;

// first namespace 
namespace ConsoleApp1
{
    //Main Class 
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;

            Console.BackgroundColor = ConsoleColor.Blue;

            string appName = "Number Guesser"; 
            string appVersion = "1.0.0";
            string appAuthor = "Vampeyer";



            Console.WriteLine("  {0} Version {1} Author {2} ", appName , appVersion , appAuthor);
            //resets color to default at this line

            Console.ResetColor();





            string firstString = "First string";
            string introtext = " My name here on line 17  ";
            string thename = "Vampeyer";
            int age = 543;






            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.BackgroundColor = ConsoleColor.Yellow;


            Console.WriteLine("*****Good morning! , How are you today  ?  **** ");
            string firstGreetingText = Console.ReadLine();
            //read line means it waits for input , and is set to the firstGreetingText var
            Console.WriteLine(" Oh that is just wonderful then ! ,  I am glad you are doing  {0} , I am good as well , thanks for asking ! - {1}   ", firstGreetingText, thename);



            //sets background
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;


            // writes out luine to the console 
            Console.WriteLine("hello World this is my first interpolated string in C# my {0}", firstString);
            Console.WriteLine(" {0} is {1} and my age is {2}  ", introtext, thename, age);
            //resets color to default at this line

            Console.ResetColor();


            //sets background
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.BackgroundColor = ConsoleColor.Magenta;

            Console.WriteLine(" Written text   ");

            Console.WriteLine("Here we goooo  -  whats your name  ?   ");

            // here the console is breaked and the input is prompted and  set to a simple string 
            // the input for the console here will be simpleString.

            Console.ResetColor();
            // requests input for text , and sets that value to simpleString .
            string simpleString = Console.ReadLine();

            Console.WriteLine(" Well alrighty then there Mr. or Ms.  " + simpleString + "  Lets get started shall we ...  ");


            // prompts for input again  

            string simpleString2 = Console.ReadLine();
            Console.WriteLine(" Helloo  " + simpleString2 + " what brings you here today ?  Are you feeling sexy ? Are you in power over your life ?   ");
            Console.WriteLine("First we need to pick a special number  , pick a number 1 - 99 ");


            // set some basic number type variables 
            int specialnumber = 59;
            int guess = 0;



            while (guess != specialnumber)
            {
              


                    // Get users input 
                    string input2 = Console.ReadLine(); /// pauses the loop and asks for input 
                    //  Cast to int and put into integer variable 
                   

                if (!int.TryParse(input2 , out guess) ) {  
                 Console.WriteLine( " Enter a number  ");
                
                }



                    guess = Int32.Parse(input2);

                if (guess != specialnumber)
                {
                    Console.ForegroundColor
                        = ConsoleColor.Red;


                    Console.WriteLine(input2 + "  is your number , but not the special number !  - keep guessing  ");
                }


   
                    
                }
            Console.WriteLine(" Your special  NUMBER  is {0} ", specialnumber);

        }

        }
    }




//Console.WriteLine("Hello, World!");
