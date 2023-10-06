using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace Lab_Number_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            for (int i = 0; i < 5;) //This runs the loop until someone answers that they do not want to play again//
                                    // if the user answers 'yes' at the end the loop will run again//

            { 
           
             Console.WriteLine("Thank you " + name + ". Please enter a whole number from 1 through 100.");
                
             int number = int.Parse(Console.ReadLine());
             Console.WriteLine("It looks like you entered " + number);
                   

                bool odd = number % 2 > 0;// this helps determine if the number is even or odd so we can prove true or false statements//
                bool even = number % 2 == 0;

                if (number < 60 && odd)
                {
                    Console.WriteLine(number + " is odd and less than 60.");
                }
                else if (number >= 2 && number <= 24 && even)
                {
                    Console.WriteLine(number + " is even and less than 25.");
                }
                else if (number >= 26 && number <= 60 && even)
                {
                    Console.WriteLine(number + " is even and between 26 and 60 inclusive.");
                }
                else if (number > 60 && even)
                {
                    Console.WriteLine(number + " is even and greater than 60.");
                }
                else
                {
                    Console.WriteLine(number + " is odd and greater than 60.");
                }

                Console.WriteLine("Do you want to play again " + name + ", yes or no?");
                string answer = (Console.ReadLine());
                if (answer == "no")
                {
                    Console.WriteLine("FINE " + name + " we're done here!");
                    break;
                    
                }
                 else
                    Console.WriteLine(" :) ");
            }
        }
    }
    }
