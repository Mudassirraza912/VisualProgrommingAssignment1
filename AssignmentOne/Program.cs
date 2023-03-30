class AssignmentOne
{
    static void Main(string[] args)
    {
        QuestionSix();
    }

    static void QuestionOne()
    {
        Console.WriteLine("Hello, World!");
    }

    static void QuestionTwo()
    {
        Console.WriteLine("Enter your name");
        var name = Console.ReadLine();
        Console.WriteLine($"Hello {name} Good Morning");
    }

    static void QuestionThree() {
        string[] acceptedNames = { "Alice", "Bob" };
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();

        if(Array.IndexOf(acceptedNames, name) != -1) {
            Console.WriteLine($"Hello {name} Have a good day!");
        }
    }

    static void QuestionFour() {
        int number = 0;
        bool isNumber = false;
        while(!isNumber) {
            Console.WriteLine("Enter Number to print the sum of that number from 1");
            var num = Console.ReadLine();
            if(int.TryParse(num, out number)) {
                for(int i =1; i < int.Parse(num); i++) {
                    number += i;
                }
                Console.WriteLine($"The Sum is {number}");
                isNumber = true;
            }else {
                Console.WriteLine("InValid Input");
            }

        }

    }

    static void QuestionFive()
    {
        int number = 0;
        bool isNumber = false;
        while (!isNumber)
        {
            Console.WriteLine("Enter Number to print the sum of that number which is multiples of three or five");
            var num = Console.ReadLine();
            if (int.TryParse(num, out number))
            {
                for (int i = 1; i < int.Parse(num); i++)
                {
                    if (i % 3 == 0 || i % 5 == 0) {
                        number += i;
                    }
                }
                Console.WriteLine($"The Sum is {number}");
                isNumber = true;
            }
            else
            {
                Console.WriteLine("InValid Input");
            }

        }

    }

    static void QuestionSix()
    {
        int number = 0;
        bool isNumber = false;
        while (!isNumber)
        {
            Console.WriteLine("Enter Number");
            var num = Console.ReadLine();
            if (int.TryParse(num, out number))
            {
                Console.Write("Enter 'sum' to compute the sum or 'product' to compute the product: ");
                string choice = Console.ReadLine();
                if(choice == "sum" || choice == "product") {
                    for (int i = 1; i < int.Parse(num); i++)
                    {
                       number = (choice == "sum") ? number + i : number * i;
                    }
                    Console.WriteLine($"The {choice} of 1 to {num} is {number}");
                    isNumber = true;
                }
                else {
                    Console.WriteLine("Invalid input. Please enter 'sum' or 'prod'.");
                }
            }
            else
            {
                Console.WriteLine("InValid Input");
            }

        }

    }
}
