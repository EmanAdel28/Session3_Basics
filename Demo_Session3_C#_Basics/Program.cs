using System.Diagnostics;
using System.Linq.Expressions;

namespace Demo_Session3_C__Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value Type Casting
            #region Implicit Casting - Safe Casting
            //int X = 4;
            //long Y = X;

            #endregion

            #region Explicit Casting - UnSafe Casting
            //long X = 101010101010;
            //int Y;
            //checked
            //{
            //    Y = (int)X;
            //}
            //Console.WriteLine(Y);
            #endregion

            #region Parse [Convert from String to any Datatype]
            //int Number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Data");
            //Console.WriteLine("Enter Name : ");
            //string Name = Console.ReadLine();

            //Console.WriteLine("Enter Age : ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Salary : ");
            //double Salary = double.Parse(Console.ReadLine());
            #endregion

            #region Convert [Convert From any datatype to any datatype]
            int Age = Convert.ToInt32(Console.ReadLine());
            double Salary = Convert.ToDouble(Console.ReadLine());
            #endregion
            #endregion

            #region Operators
            #region Unary Operators [++ , --]
            //int X = 5;

            //Console.WriteLine(++X);
            //Console.WriteLine(X++);

            //Console.WriteLine(--X);
            //Console.WriteLine(X--);
            //Console.WriteLine(X);
            #endregion

            #region Binary Operator
            //int Sum, Mul, Sub, Div, Mod;

            //int A = 10;
            //int B = 5;

            //Sum = A + B; 
            //Sub = A - B;
            //Div = A / B;
            //Mul = A * B;
            //Mod = A % B;
            //Console.WriteLine(Sum);
            #endregion

            #region Assignment Operator
            //X = 10;
            //X += 10;
            //X -= 10;
            //X *= 10;
            //X /= 10;
            //X %= 10;
            #endregion

            #region Relational Operator
            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A == B);
            //Console.WriteLine(A < B);
            #endregion

            #region Logical Operator [Short Circute]

            Console.WriteLine(true && false);

            //true && true  => true
            //true && false => false
            //false && true => false
            //false && false => false

            Console.WriteLine(true || false);

            //true || true  => true
            //true || false => true
            //false || true => true
            //false || false => false
            #endregion

            #region Bitwise Operator [Long Circute]

            Console.WriteLine(true & false);

            //true & true  => true
            //true & false => false
            //false & true => false
            //false & false => false

            Console.WriteLine(true | false);

            //true | true  => true
            //true | false => true
            //false | true => true
            //false | false => false
            #endregion

            #region Ternary Operator [Conditional Operator]

            //String Message  = X > 4 ? "X Greater Than 4" : "X Less Than 4"
            #endregion
            #endregion

            #region Operator Periorety
            //1- Unary Operator[PreFif]
            //2- ( )
            //3- * / %
            //4- + -
            #endregion

            #region String Formating
            // Equation = X + Y = Result
            // Equation = 10 + 5 = 15

            int X = 5;
            int Y = 10;
            int Result = X + Y;

            //Console.WriteLine("Equation : " + X + " + " + Y + " = " + Result);
            ///// String => Immutable Datatype

            #region 1. Composite Format
            string Message = string.Format("Equation = {0} + {1} = {2}", X, Y, Result);
            Console.WriteLine(Message);
            Console.WriteLine("Equation = {0} + {1} = {2}", X, Y, Result);
            #endregion

            #region 2. String Manipolition
            // string Interpolation => $
         
            Console.WriteLine($"Equation = {X} + {Y} = {Result}");
            #endregion


            #endregion

            #region IF Else - Switch Case
            //Console.WriteLine("Enter Month Number");
            //int MonthNumber = int.Parse(Console.ReadLine());

            // 1 => Month is Jan
            // 2 => Month is Feb
            // 3 => Month is Mar
            //  Invalid Input

            //if (MonthNumber == 1)
            //    Console.WriteLine("Month is Jan");
            //else if (MonthNumber == 2)
            //    Console.WriteLine("Month is Feb");
            //else if (MonthNumber == 3)
            //    Console.WriteLine("Month is Mar");
            //else
            //    Console.WriteLine("Invalid Input");


            //switch(MonthNumber)
            //    {
            //    case 1:
            //        Console.WriteLine("Month is Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Month is Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Month is Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Input");
            //        break;
            //}

            #endregion

            #region GOTO
            //Console.WriteLine("Enter Option");
            //int option = int.Parse(Console.ReadLine());

            // 3000 => "Option 01" , "Option 02" , "Option 03"
            // 2000 => "Option 01" , "Option 02" 
            // 1000 => "Option 01" 

            //switch(option)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 03");
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("Option 02");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("Option 01");
            //        break;

            //}



            #endregion

            #region Evaluation of Switch Case
            #region C# 06
            int age = int.Parse(Console.ReadLine());

            switch(age)
            {
                case > 22:
                    Console.WriteLine("Age Greater than 22");
                    break;
                case < 22:
                    Console.WriteLine("Age less than 22");
                    break;
                default:
                    Console.WriteLine("Age Equale 22");
                    break;



            }
            #endregion
            #region C# 07
            object obj = new object();
            obj = 22;
            switch (obj)
            {
                case  int Number when Number >10 && Number < 20:
                    Console.WriteLine($"{Number} is int");
                    break;
                case string Name:
                    Console.WriteLine($"{Name} is String");
                    break;
                case bool Flag:
                    Console.WriteLine($"{Flag} is bool");
                    break;
            }
            #endregion
            #region C# 08
            Console.WriteLine("Enter Option");
            int option = int.Parse(Console.ReadLine());

            String Mess = option switch
            {
                1 => "Option 01",
                2 => "Option 02",
                3 => "Option 03",
                _ => "Invalid"

            };
            Console.WriteLine(Mess);
            #endregion
            #region C# 09
            { Age: > 22 and <25}
            { Age: > 25 or < 23}
            { Age: not 25}  

            #endregion
            #endregion


        }
    }
}
