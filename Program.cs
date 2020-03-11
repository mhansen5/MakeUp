using System;

namespace MakeUp
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput = "";
            string numberinput;
            int result = 0;
            bool a = true;

            Console.WriteLine("Michael Hansen = 36");
            Console.WriteLine("Please enter your first name and press enter to continue:");

            userinput = Console.ReadLine();

            do
            {
                Console.WriteLine("Please enter an integer between 3 & 6 and press enter to continue:");
                numberinput = Console.ReadLine();

                if (numberinput == "3" || numberinput == "4" || numberinput == "5" || numberinput == "6")
                {
                    result = int.Parse(numberinput);
                    myMethod(userinput, result);
                    a = false;
                }

                else
                {
                    Console.WriteLine("Invalid input, please select an integer between 3 & 6:");
                }
            }
            while (a);
            {
                Console.Write("Press enter to quit");
                Console.Read();
            }
        }

        static void myMethod(string name, int num)
        {
            for (var i = 0; i <= num; i++)
            {
                Console.WriteLine(name);
                Console.WriteLine(num);
            }

        }
    }
}

  

