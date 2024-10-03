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

        }
    }
}
