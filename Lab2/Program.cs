using System;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Step 1

        int iger = 7;
        double trouble = 3.333333333333333;
        float boat = 3.3333333f;
        char acter = 'A';
        bool whool = true;
        string cheese = "I think I am pretty funny!";

        Console.WriteLine(iger);
        Console.WriteLine(trouble);
        Console.WriteLine(boat);
        Console.WriteLine(acter);
        Console.WriteLine(whool);
        Console.WriteLine(cheese);

        // Step 2

        // explicit casting
        double doubleNum = 9.78;
        int intNum = (int) doubleNum;

        Console.WriteLine("double: " + intNum);

        //convert class

        string number = Convert.ToString(iger);

        string lean = Convert.ToString(whool);

        Console.WriteLine("integer: " + number);
        Console.WriteLine("bool: " + lean);

        // Step 3

        Console.WriteLine("Please enter your name: ");

        string username = Console.ReadLine();

        Console.WriteLine("Please enter your age: ");

        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello and Welcome to " + username + ". You are " + age + " years old!");

        // Step 4

        int num1 = 73;
        int num2 = 38;

        int newNum1 = num1 + 10;
        int newNum2 = num2 + 10;

        int newNum3 = num1 - 2;
        int newNum4 = num2 - 2;

        int newNum5 = num1 * 3;
        int newNum6 = num2 * 3;

        int newNum7 = num1 / 2;
        int newNum8 = num2 / 2;

        int newNum9 = num1 % 2;
        int newNum10 = num2 % 2;


        Console.WriteLine("num1 plus 10 eaquals " + newNum1);
        Console.WriteLine("num2 plus 10 eaquals " + newNum2);

        Console.WriteLine("num1 minus 2 eaquals " + newNum3);
        Console.WriteLine("num2 minus 2 eaquals " + newNum4);

        Console.WriteLine("num1 times 3 eaquals " + newNum5);
        Console.WriteLine("num2 times 3 eaquals " + newNum6);

        Console.WriteLine("num1 divided by 2 eaquals " + newNum7);
        Console.WriteLine("num2 divided by 2 eaquals " + newNum8);

        Console.WriteLine("the remainder of num1 divied by 2 eaquals " + newNum9);
        Console.WriteLine("the remainder of num2 divided by 2 equals " + newNum10);

        // Step 5

        float titanic2 = 1.123456789f; // counted 7 places and rounded up the last decimal place 
        double mintTwins = 1.123456789d;

        Console.WriteLine(titanic2);
        Console.WriteLine(mintTwins);

        // Step 6

        int declared = 10;
        declared++;

        Console.WriteLine(declared);

        declared--;

        Console.WriteLine(declared);

    }
}