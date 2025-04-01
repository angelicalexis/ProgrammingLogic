namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        // Step 1

        int a = 10;
        int b = 5;
        int c = 15;

            Console.WriteLine(a > b);

            Console.WriteLine(a < c); 

            Console.WriteLine(a > b && a > c);

            Console.WriteLine(a > b || a > c);

        // Step 2

        bool isRaining = true;
        bool haveUmbrella = false;

        if (isRaining == true)
        {
            Console.WriteLine("Take an Umbrella!");
        }

        if (haveUmbrella == false)
        {
            Console.WriteLine("You're good to go!");
        }

        // Step 3

        Console.WriteLine("Please enter your age: ");

        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 5)
        {
            Console.WriteLine("Ticket is free!");
        }

        else if (age > 5 && age < 12)
        {
            Console.WriteLine("Child ticket: $5");
        }

        else if (age > 13 && age < 64)
        {
            Console.WriteLine("Standard ticket: $10");
        }

        else if (age > 65)
        {
            Console.WriteLine("Senior ticket: $6");
        }

        // Step 4

        Console.WriteLine("Enter a number day of the week: ");

        int day = Convert.ToInt32(Console.ReadLine());
        
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid Day!");
                break;
        }


    }
}
