using System;
 
namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
         //initializing Variables
        string letterGrade;
        int gpaPoint = 0;

        //Setting up loop
        char cont = 'y';
        while (cont == 'y') {

        //Getting user input and storing in variable
        Console.WriteLine("Plese input a letter grade:");
        letterGrade = Console.ReadLine();

      //Setting gpa point value based on input
      switch (letterGrade)
      {
        case "A":
           gpaPoint = 4; 
        break;
  
        case "B":
           gpaPoint = 3; 
        break;
  
        case "C":
            gpaPoint = 2;
        break;
  
        case "D":
            gpaPoint = 1;
        break;
  
        case "F":
            gpaPoint = 0;
        break;
  
        default:
           Console.WriteLine("Wrong Letter Grade!");
        break;
  
       }
      
       //Print result
       Console.WriteLine("GPA Point: " + gpaPoint);
    }
            
        }
    }
}
