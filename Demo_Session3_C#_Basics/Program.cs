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


            #endregion

        }
    }
}
