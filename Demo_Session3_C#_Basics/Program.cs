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

            #region Operators
            #region Unary Operators [++ , --]
            int X = 5;

            Console.WriteLine(++X);
            Console.WriteLine(X++);

            Console.WriteLine(--X);
            Console.WriteLine(X--);
            Console.WriteLine(X);
            #endregion
            #endregion

            #endregion
        }
    }
}
