using System;

namespace Demo_Session3_C__Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no

            //Console.WriteLine("Enter Number :");
            //int Number = int.Parse(Console.ReadLine());

            //if (Number % 3 == 0 && Number % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");

            #endregion

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("Enter Number :");
            //int Num = int.Parse(Console.ReadLine());

            //if (Num < 0)
            //    Console.WriteLine("It Is Negative Number");
            //else
            //    Console.WriteLine("It Is Positive Number");


            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("Enter 3 integers ");
            //Console.Write("Entser Number 01 :  ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter Number 02 : ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter Number 03 : ");
            //int num3 = int.Parse(Console.ReadLine());

            //// Find the maximum and minimum values
            //int max = Math.Max(num1, Math.Max(num2, num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));

            //// Print the results
            //Console.WriteLine($"The Maximum number is: {max}");
            //Console.WriteLine($"The Minimum number is: {min}");






            #endregion

            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Entser Number ");
            //int Number = int.Parse(Console.ReadLine());

            //if (Number % 2 == 0)
            //    Console.WriteLine("Number is even");
            //else
            //    Console.WriteLine("Number is odd");




            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.Write("Enter Character : ");
            //Char Character = Char.Parse(Console.ReadLine());

            //switch (Character)
            //{
            //    case 'a' or 'A':
            //    case 'e' or 'E':
            //    case 'i' or 'I':
            //    case 'o' or 'O':
            //    case 'u' or 'U':
            //        Console.Write("Vowel");
            //        break;
            //    default:
            //        Console.Write("Consonant");
            //        break;


            //}

            #endregion

            #region 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("Entser Number ");
            //int Number = int.Parse(Console.ReadLine());

            //Console.WriteLine($"multiplication table for {Number} : ");

            //for (int i = 1 ; i<= 12 ; i++)
            //{
            //    int Mult = i * Number;
            //    Console.WriteLine($" {Number} * {i}  = {Mult}");
            //}

            #endregion

            #region 9- Write a program that takes two integers then prints the power.

            //Console.WriteLine("Entser Two Number ");

            //Console.Write("Entser  Number 01 :  ");
            //int Number1 = int.Parse(Console.ReadLine());
            //Console.Write("Entser  Number 02 :  ");
            //int Number2 = int.Parse(Console.ReadLine());
            //int Power=1;


            //for (int i = 1; i <= Number2; i++)
            //{
            //     Power = Power * Number1;

            //}


            //Console.Write($" {Number1} Power {Number2} is : {Power} ");


            #endregion

            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Console.WriteLine("Enter Mark Of Five Subject :");

            //Console.Write("Enter Mark Of Subject 01 :");
            //double Mark1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter Mark Of Subject 02 :");
            //double Mark2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter Mark Of Subject 03 :");
            //double Mark3 = double.Parse(Console.ReadLine());

            //Console.Write("Enter Mark Of Subject 04 :");
            //double Mark4 = double.Parse(Console.ReadLine());

            //Console.Write("Enter Mark Of Subject 05 :");
            //double Mark5 = double.Parse(Console.ReadLine());

            //double Total, Average, Percentage;

            //Total = Mark5 + Mark4 + Mark3 + Mark2 + Mark1;
            //Average = Total / 5;
            //Percentage = (Total / 500) * 100;

            //Console.WriteLine($"Total = {Total} ");
            //Console.WriteLine($"Average = {Average}");
            //Console.WriteLine($"Percentage = {Percentage}%");




            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month.

            //Console.Write("Enter the month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //switch(month)
            //{
            //    case 1: 
            //    case 3: 
            //    case 5: 
            //    case 7: 
            //    case 8: 
            //    case 10: 
            //    case 12:
            //        Console.WriteLine("Number of days : 31");
            //        break;

            //    case 4: 
            //    case 6: 
            //    case 9: 
            //    case 11:
            //        Console.WriteLine("Number of days : 30");
            //        break;

            //    case 2:
            //        Console.WriteLine("Number of days : 28");
            //        break;


            //}
            #endregion

            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Enter the coordinates of three points:");

            //Console.Write("Enter x1: ");
            //int x1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y1: ");
            //int y1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter x2: ");
            //int x2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y2: ");
            //int y2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter x3: ");
            //int x3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y3: ");
            //int y3 = int.Parse(Console.ReadLine());

            //// Check if the points are collinear
            //bool areCollinear = (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);

            //// Output the result
            //if (areCollinear)
            //    Console.WriteLine("The points lie on a straight line.");

            //else
            //    Console.WriteLine("The points do not lie on a straight line.");


            #endregion

            #region 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task
            //Console.Write("Enter the time taken to complete the task (in hours): ");
            //double timeTaken = double.Parse(Console.ReadLine());

            //if (timeTaken >= 2 && timeTaken <= 3)
            //    Console.WriteLine("The worker is highly efficient.");

            //else if (timeTaken > 3 && timeTaken <= 4)
            //    Console.WriteLine("increase their speed.");

            //else if (timeTaken > 4 && timeTaken <= 5)
            //    Console.WriteLine("The worker is instructed to increase their speed.");

            //else if (timeTaken > 4 && timeTaken <= 5)
            //    Console.WriteLine("The worker is provided with training to enhance their speed.");

            //else if (timeTaken > 5)
            //    Console.WriteLine("The worker is required to leave the company.");
            //else
            //    Console.WriteLine("Invalid input.");




            #endregion

            #region 21- Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int X;
            X = 10;
            int Y = X;
            Console.WriteLine($"The initial value of X = {X} ");
            Console.WriteLine($"The initial value of Y = {Y} ");

            // Modifying Value of Variable x
            X = 5;
            Console.WriteLine($"The value of X After Modifying = {X} ");
            Console.WriteLine($"The value of Y After Modifying = {Y} ");

            Console.WriteLine("************************************************");
            Console.WriteLine("Explanation What Happen");
            Console.WriteLine("When assigning one value type variable to another, a copy is made.");
            Console.WriteLine("Modifying one variable does not affect the other.Because we assigning Value not Address");
            #endregion
        }
    }
}
