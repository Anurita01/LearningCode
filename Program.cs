namespace ConsoleApp1
{
    internal class Program
    {
        public Program()
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("I am learning C#");

            
            //Print the sum of 139 + 345
            Console.WriteLine(139 + 345);

            //Print a string
            string name = "John";
            Console.WriteLine(name);

            //Print the sum of 2 numbers using variables
            Console.WriteLine("let's get the sum of two numbers - 45 & 6");
            int num1 = 45;
            int num2 = 6;
            Console.WriteLine("The Total is");
            Console.WriteLine(num1 + num2);

            //If else 
            Console.WriteLine("Please choose one of the following numbers : 1, 2, 3");
            string mychoice = Console.ReadLine();
            if (mychoice == "1")
            {
                Console.WriteLine("You've won a car");
            }
            else if (mychoice == "2")
            {
                Console.WriteLine("You've won a bike");
            }
            else if (mychoice == "3")
            {
                Console.WriteLine("You've won gift card");
            }
            else
            {
                Console.WriteLine("Sorry, that was not a valid choice");
            }
            Console.ReadLine();





        }

       
    }
}