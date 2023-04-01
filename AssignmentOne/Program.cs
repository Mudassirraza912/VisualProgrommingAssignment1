using System;

class AssignmentOne
{
    static void Main(string[] args)
    {
        QuestionSixteen();
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

    static void QuestionSeven() {
        int number = 0;
        Console.WriteLine("Enter a number for printing table");
        var num = Console.ReadLine();
        if(int.TryParse(num, out number)) {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} x {i} = {int.Parse(num) * i} \n");
            }
        }else {
            Console.WriteLine("Invalid input. Retry");
            QuestionSeven();
        }
    }

    static void QuestionTen() {
        int currentYear = DateTime.Now.Year;
        int count = 0;
        while(count < 20) {
            if(DateTime.IsLeapYear(currentYear)) {
                Console.WriteLine(currentYear);
                count++;
            };
            currentYear++;
        }
    }

    static void QuestionEleven() {
        int[] myArray = new int[] { 1, 2, 34, 5, 6 };
        int largest = myArray[0];
        for(int i =1; i < myArray.Length; i++) {
            if (myArray[i] > largest) {
                largest = myArray[i];
            }
        }
        Console.WriteLine($"Largest number is in a list {largest}");
    }

    static void QuestionTwelve()
    {
        int[] list = new int[] { 1, 2, 3, 4, 5 };
        string rev = "";
        for (int i = list.Length - 1; i >= 0; i--)
        {
            rev += $" {list[i]},";
        }
        Console.WriteLine($"Reverse of list is {rev}");
    }

    static void QuestionThirteen() {
        string[] list = new string[] { "Mudassir", "Haris", "Faraz", "Wirad"};
        Console.WriteLine("Whom are you searching for?");
        var item = Console.ReadLine();
        string result = "";
        for(int i=0; i < list.Length; i++) {
            if(item == list[i]) {
                Console.WriteLine($"{list[i]} is found in a list at {i} position");
                return;
            }
        }
        Console.WriteLine($"Oooops {item} is not in a list");
    }

    static void QuestionFourteen()
    {
        int[] list = new int[] { 1,2,3,4,5,6,7,8,9,10 };
        string oddList = "";
        for (int i =0; i < list.Length; i++)
        {
            if(i%2 != 0) {
                oddList += $" {list[i]},";
            }
        }
        Console.WriteLine($"Elements in Odd position in list is {oddList}");
    }

    static void QuestionFifteen()
    {
        int[] list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int result = 0;
        for (int i = 0; i < list.Length; i++)
        {
            result += list[i];
        }
        Console.WriteLine($"The sum of the list item is {result}");
    }

    static void QuestionSixteen() {
        Console.WriteLine("Enter a word to check if it Palindrome or not");
        var input = Console.ReadLine().ToLower();
        string reverse = "";
        for(int i= input.Length - 1; i >=0; i--) {
            reverse += input[i];
        };
        if(reverse == input) {
            Console.WriteLine($"{input} is Palindrome");
        }else {
            Console.WriteLine($"{input} is not Palindrome");
        }
    }

}
