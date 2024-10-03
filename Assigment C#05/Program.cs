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

            #region Q2
            //Explain the difference between passing(Reference type parameters) by value and
            //by reference then write a suitable c# example.



            //In passing(Reference type parameters) by value any if we chage the array (reference type)
            //that change happend on new array stcakform so it will give accurate anser but if you want
            // to use smothing from the array it will happend on the orginal array before
            // any changing in fuction becouse that changed happedn on the array in the function
            //happend on a copy from the array not the orginal array

            //In passing(Reference type parameters) by ref any if we chage the array (reference type)
            //the changed happend on the orginal array 


            ////example for passing(Reference type parameters) by value :-
            //---------------------------------------------------------
            // static int SumArray(int[] Arr)
            //{
            //    int sum = 0;
            //    Arr = new int[] { 4, 5, 6 };
            //    for(int i=0; i<Arr.Length; i++)
            //        sum += Arr[i];
            //    return sum;

            //} 

            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers)); // 15
            //Console.WriteLine(Numbers[0]); // 1


            //example for passing(Reference type parameters) by refernce:-
            //-----------------------------------------------------------

            //static int SumArraybyref(ref int[] Arr)
            //{
            //    int sum = 0;
            //    Arr = new int[] { 4, 5, 6 };
            //    for(int i=0; i<Arr.Length; i++)
            //       sum += Arr[i];
            //    return sum;
            //}

            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArraybyref(ref Numbers)); // 15
            //Console.WriteLine(Numbers[0]); // 4

            #endregion
        }
    }
}
