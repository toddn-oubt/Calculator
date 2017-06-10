using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

/*
 * 1) Assignment 1.1: Calculator with While Loop :
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator
{
 class Program
 {

 public static void Main(string[] args)
 {
 // Creating local variables
 int userOption = 0;
 int firstNumber = 0;
 int secondNumber = 0;
 int result = 0;
 // End Local Variables
 //Display the menu
 while (userOption != 6)
 {
 userOption = DisplayMenu();
 if (userOption == 6)
 return;
 // Get the Numbers
 Console.WriteLine("Please input the first number and hit the enter key");
 firstNumber = getNumber();
 Console.WriteLine("Please input the Second number and hit the enter
key");
 secondNumber = getNumber();
 //Take action
 if (userOption == 1) //Addtion
 {
 result = firstNumber + secondNumber;
 }
 else if (userOption == 2) // Subtraction
 {
 result = firstNumber - secondNumber;
 }
 else if (userOption == 3) // Multiplication
 {
 result = firstNumber * secondNumber;
 }
 else if (userOption == 4) // Division
 {
 try
{
 result = firstNumber / secondNumber;
 }
catch
 {
 result = 0;
 }
 }
 else if (userOption == 5) // Modulus
 {
 result = firstNumber % secondNumber;
 }
 else
 {
 // Take no Action
 }
 // Print the result
 Console.WriteLine("The result of your action is :" + result);
 }
 //End Display menu
 }
 private static int getNumber()
 {
 try
 {
 // get the number and parse the result
 int number = int.Parse(Console.ReadLine());
 return number;
 } catch
 {
 // if there is an Error, catch it and return 0
 Console.WriteLine("Error in input");
 return 0;
 }
 }
 // Return an int which represents the User's action
 private static int DisplayMenu()
 {
 Console.WriteLine("Enter the number corresponding to the action that you
would like to perform.");
 Console.WriteLine("1. Addition. " + Environment.NewLine + "2. Subtraction. "
+ Environment.NewLine + "3. Multiplication. " + Environment.NewLine + "4. Division. " +
Environment.NewLine +
 "5. Modulus. " + Environment.NewLine + "6. End the program");
 // Get the Option code
 int optionalValue;
 try
 {
 optionalValue = int.Parse(Console.ReadLine());
 }
 catch
 {
 optionalValue = 0;
 }
 return optionalValue;
 }

}



}


    2)

     
            int a; 
            int b; 
            string operation; 
            int result; 
 
            Console.WriteLine("calculator"); 
            Console.ReadLine(); 
            Console.Write("enter 1st value " ); 
            a = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("enter 2nd value " ); 
            b = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("enter operation ( +,-,*,/) "); 
            operation = Console.ReadLine(); 
            if (operation == "+") 
            { 
                result = a + b; 
                Console.WriteLine(a + " + " + b + " = " + result); 
                Console.ReadLine(); 
            } 
            else if (operation == "-") 
            { 
               result = a - b; 
                Console.WriteLine(a + " - " + b + " = " + result); 
                Console.ReadLine(); 
            } 
            else if (operation == "*") 
            { 
                result = a * b; 
                Console.WriteLine(a + " * " + b + " = " + result); 
                Console.ReadLine(); 
            } 
            else if (operation == "/") 
            { 
                result = a / b; 
                Console.WriteLine(a + " / " + b + " = " + result); 
                Console.ReadLine(); 
            } 
            
        }


    3)

     namespace ConsoleApp4
{ 
  class Program
{ 
    static void Main(string[] args)
    {
        int Num1;
        int Num2;                   
        string operation;
        string mark;
        int result;

        Console.WriteLine("Hello, welcome to Kamit's basic calculator!");
        Console.ReadLine();
        do
        {
            Console.Write("Enter the first number: ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Now enter your second number: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ok now enter your operation ( x , / , +, -) ");
            operation = Console.ReadLine();

            if (operation == "x")
            {
                result = Num1 * Num2;
                Console.WriteLine(Num1 + " x " + Num2 + " = " + result);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                result = Num1 / Num2;
                Console.WriteLine(Num1 + " / " + Num2 + " = " + result);
                Console.ReadLine();
            }
            else if (operation == "+")
            {
                result = Num1 + Num2;
                Console.WriteLine(Num1 + " + " + Num2 + " = " + result);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                result = Num1 - Num2;
                Console.WriteLine(Num1 + " - " + Num2 + " = " + result);
                Console.ReadLine();
            }
            Console.Write("Do you want to perform next operation, please enter (y,n)");
            mark = Console.ReadLine();
        }
        while (mark == "y");
        }
                }

}


    */
