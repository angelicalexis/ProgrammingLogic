namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
    
        // Problem 1

        for (int a = 1; a <= 10; a ++)
        {
            Console.WriteLine(a);
        }

        // Problem 2

        for (int b = 2; b <= 20; b += 2)
        {
            if (b % 2 == 0)
            {
                Console.WriteLine(b);
            }
        }
    
        // Problem 3

        int i = 5;
        while (i > 0)
        {
            Console.WriteLine(i);
            i--;
        }    

        // Problem 4

        int number;
        do
        {
            Console.WriteLine("Enter a number greater than 100: ");
            number = Convert.ToInt32(Console.ReadLine());
        }
        while (number < 100);

        // Problem 5

        int c = 10;
        while (c <= 1000)
        {
            Console.WriteLine(c);
            c += 10;
        }

        // Problem 6

         for (int d = 1; d <= 10; d++)
        {
            for (int j = 1; j <= d; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    
    }
}
