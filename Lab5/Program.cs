namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
    
        // Problem 1

        string[] seasons = {"Spring", "Summer", "Fall", "Winter"};
        foreach (string time in seasons)
        {
            Console.WriteLine("Season: " + time);
        }

        Console.WriteLine(" ");
        // Problem 2

        string[] days = new string[7]{
            "Monday", 
            "Tuesday", 
            "Wednesday", 
            "Thursday", 
            "Friday", 
            "Saturday", 
            "Sunday"
            };

        Console.WriteLine("Enter a number from 1 to 7:");
        int day = Convert.ToInt32(Console.ReadLine());

        if (day <= 7)
        {
            Console.WriteLine("That day is: " + days[day - 1]);
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }

        Console.WriteLine(" ");
        // Problem 3

        string[] bookName = {
            "The Seven Husbands of Evelyn Hugo",
            "Three Acts Tragedy",
            "The Chiffon Trenches: A Memoir"
        };

        string[] author = {
            "Taylor Jenkins Reid",
            "Agetha Christie",
            "Andre Leon Talley"
        };

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(bookName[i] + " by " + author[i]);
        }

        Console.WriteLine(" ");
        // Problem 4

        int[] temperatures = {65, 72, 78, 70, 68};

        Array.Sort(temperatures);

        Console.WriteLine("Sorted Temperatures: " + temperatures[0] + " " 
        + temperatures[1] + " " + temperatures[2] + " " + temperatures[3] + " " + temperatures[4] + " ");
        Console.WriteLine("Highest Temperatures: " + temperatures[4]);
        Console.WriteLine("Sorted Temperatures: " + temperatures[0]);

        Console.WriteLine(" ");
        // Problem 5

        int[] countdown = { 5, 4, 3, 2, 1 };
        
        Array.Reverse(countdown);
        
        for (int i = 0; i < countdown.Length; i++)
        {
            if (i == 0)
            {
                 Console.Write("Countdown: ");
            }
            Console.Write(countdown[i] + " ");    
        }

        Console.WriteLine(" ");

    }
}
