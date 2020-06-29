using System;

namespace T3Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Crab Shack please pick from the following list.");
            Console.WriteLine("1. Crab Salad");
            Console.WriteLine("2. House Salad");
            Console.WriteLine("3. Crab Cakes");
            Console.WriteLine("4. Crabby Pattie");
            Console.WriteLine("5. Crab Taco");
            string option = Console.ReadLine();
            switch (option){
                case "1":
                    Console.WriteLine("You selected Crab Salad");
                    break;
                default:
                    Console.WriteLine("Sorry, we're all out");
                    break;
            }
                    
        }
    }
}
