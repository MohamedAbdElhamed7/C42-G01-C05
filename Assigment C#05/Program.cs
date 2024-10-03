namespace Assigment_C_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Explain the difference between passing (Value type parameters) by value
            //and by reference then write a suitable c# example.

            // at passing value type parameter by value when ClR call or running function
            // clr make stack frame for this function this stackframe having all parameters and local variable
            // and after fuction done stack frame will delete and and any changes happen at stack frame
            // that already delete  so there is no change happend 

            // at passing value type parameter by Reference when ClR call or running function
            // clr make stack frame for this function this stackframe but function will work
            // on  varible at main fuction not stackfrme bec it send refernce not a copy as bassing by value

            //example on passing by vlaue 
            //static void swapbyvalue(int x, int y)
            //{
            //    int temp = x;
            //    x = y;
            //    y = temp;
            //}


            //int a = 10; int b = 20;

            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}");
            //Console.WriteLine("after swap function by value");
            //swapbyvalue(a, b);
            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}");


            ////example on passing by ref :-

            //static void swapbyref(ref int x, ref int y)
            //{
            //    int temp = x;
            //    x = y;
            //    y = temp;
            //}


            //a = 10; b = 20;
            //Console.WriteLine("\n");
            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}");
            //Console.WriteLine("after swap function by ref");
            //swapbyref(ref a, ref b);
            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}");


            #endregion
        }
    }
}
