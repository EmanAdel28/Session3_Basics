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
            Console.WriteLine("Enter Number :");
            int Num = int.Parse(Console.ReadLine());

            if (Num < 0)
                Console.WriteLine("It Is Negative Number");
            else
                Console.WriteLine("It Is Positive Number");


            #endregion
        }
    }
}
