// Create our container and class //
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args) // Create a main function to hold the data
        {
            //Initilise Variables//
            int fizz = 3; // For values that are multiple of this print fizz
            int buzz = 5; // For values that are multiple of this print fizz
            int i = 0; // We are going to use an i iternator, set to zero

            for (i = 0; i <= 100; i++) // Increment i to 100 then stop
            {
                if (i % fizz == 0 && i % buzz != 0) // For values that are a multiple of fizz BUT NOT buzz
                {
                    Console.WriteLine("fizz");
                }
                else if (i % fizz != 0 && i % buzz == 0) // For values that are a multiple of buzz BUT NOT fizz
                {
                    Console.WriteLine("buzz");
                }
                else if (i % fizz == 0 && i % buzz == 0) // For values that are a multiple of buzz AND fizz
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i); // Otherwise just print the number
                }
            }

            Console.WriteLine("Please press any key to exit");
            Console.ReadKey();
        }
    }
}