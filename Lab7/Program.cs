//Grading ID: K1791
//Lab 7
//8 November 2020
//CIS 199-02
//This lab makes use of a void method to do calculations 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args) //Since this is static, the method can be directly called, and because it is void, the main method doesn't return anything
        {
            bool isThisTrue = false; //Boolean value, is equal to false
            int x; //Your standard x variable
            
           
            
            do //A do loop
            {
                
                Console.WriteLine("Enter how big you want the pattern to be "); //Writes a message so the user knows what to do
                isThisTrue = int.TryParse(Console.ReadLine(), out x) && x > 0; //Using tryparse to make sure what the user entered is an integer AND greater than 0.

                
                ShowSquareOfStars(x); // Passing the user input into the  ShowSquareOfStars method
            } while (!isThisTrue); // Run the loop until the boolean is true
        }

        public static void ShowSquareOfStars(int numStars) //Void method, again the main doesn't return anything
        {
            
            for (int  i = 1; i  <= numStars; i++) // The loop executes until i is less than or equal to numStars


            { 
                
                
                
                for (int j = 1; j <= numStars; j++) //loop till i is less than or equal to numStars
                    Console.Write("*"); //Writes * as specified above
                    
                
                
                Console.Write("\n"); // Goes to a newline
            }
        }
    }

}
