using System;
using System.Collections.Generic;
namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining the variables we are going to use
            string num1;
            string num2;
            string num3;
            List<int> numbers = new List<int>();
            int lowestVal;

            //getting user input as a string and assigning it to variables
            Console.WriteLine("Please input the first num:");
            num1  = Console.ReadLine();
            
            Console.WriteLine("Please input the second num:");       
            num2  = Console.ReadLine();
            
            Console.WriteLine("Please input the third num:");     
            num3  = Console.ReadLine();

            //Converting our variables from string to int
            int num1Int = Convert.ToInt16(num1);
            int num2Int = Convert.ToInt16(num2);
            int num3Int = Convert.ToInt16(num3);

            //Adding variables to our list
            numbers.Add(num1Int);
            numbers.Add(num2Int);
            numbers.Add(num3Int);

            //Sorting our list 'numbers' in ascending order
            numbers.Sort();

            //grabbing the first item in the list and assigning it to a variable
            lowestVal = numbers[0];

            //printing result
            Console.WriteLine("\nThe smallest value is: " + lowestVal);

        

    
        }
    }
}
