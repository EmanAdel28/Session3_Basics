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
            long X = 101010101010;
            int Y;
            checked
            {
                Y = (int)X;
            }
            Console.WriteLine(Y);
            #endregion

            #endregion
        }
    }
}
