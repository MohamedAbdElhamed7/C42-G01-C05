namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing & UnBoxing

            //Boxing: Casting From Value Type To Refrence Type
            //UnBoxing: Casting From Refrence Type To Value Type

            //Object o1;
            //o1 = "Ahmed"; //casting from object to String
            //o1 = 1; //casting from refrence type to value type (BoXING)
            //o1 = 'A'; //casting from refrence type to value type (BoXING)

            //int x = 10;
            //object obj = x; //Boxing [safe casting]
            //obj = new object (10)
            //parent ==> child
            //Animal ==> Dog (dog is an animal)


            //Ex of UnBoxing :-
            //object objo2 = 10;
            //int y = (int) obj; //UnBoxing Casting [UnSafe]
            //if the object is not an int (Invlaid cast Exception) 
            //Dog ==> (Dog) Animal (Animal is a Dog) [not safe]
            #endregion

            #region Nullable Value Type
            //Null as a value is valid only with reference type

            //int x = null //invlaid
            //int? y = null //valid
            //int? y => (?) allow int + null

            // Nullable <int> Number ;  //int? Number; ==> Syntax Sugar

            //int x = 10;
            //int? y = x; // valid // Safe implicit casting


            //int? Number01 = null; 
            //int? Number02 = (int)Numbeer01; //Explicit casting
            //unsafe cating
            //invalid opreation exception

            //-------------------------------------------------------------//
            //Example2 :-

            //int? k= null;
            //int l;
            ////l=(int)k; //unsafe // to make safe u have to use condition 

            //if(k!=null)
            //{

            //    l = (int)k;
            //}
            //else
            //    l= 0;

            ////OR

            //if (k.HasValue)
            //{ 
            //    l=k.Value;
            //}
            //else
            //    l= 0; 

            ////OR
            //l=k.HasValue ? k.Value : 0;
            //l=k !=null ?(int) k : 0;    



            #endregion

            #region Nullable Refrence Type
            ////Null is Deafult value of refrence type 

            //String Message = "Hi";
            //Message = null; //valid with Warning 
            //Message = null!; // (!) null forgiveness opreator ; 

            //String? Message02 = null; //vaild without warning





            #endregion

            #region Null propragation opreator

            //    int[] Numbers = default;

            //    for (int i = 0; (Numbers !=null)&&(i<Numbers.Length); i++)
            //        Console.WriteLine(Numbers[i]);

            ////OR

            //    for(int i=0; i<Numbers?.Length; i++)
            //        Console.WriteLine(Numbers[i]);

            ////code maintence by making it not checking if array = null ever iteration

            //    if (Numbers != null)
            //    {
            //        for (int i = 0; i < Numbers.Length; i++)
            //            Console.WriteLine(Numbers[i]);
            //    }


            #endregion

        }
    }
}
