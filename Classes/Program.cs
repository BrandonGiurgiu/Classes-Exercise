namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "F-150";
            myCar.Year = 2020;

            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year}");

            /* can also do it this way
             * var myCar = new Car()
             * {
             *    Make = "Ford",
             *    Model = "F-150",
             *    Year = 2020
             *  };
             *  */

        }
    }
}
