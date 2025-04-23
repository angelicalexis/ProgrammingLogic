namespace Lab6;

using System;

class Car
{
  public string model;
  public string color;
  public int year;

  // Example method to display car details. You can use this as an example for the other methods.
  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }

  // Problem 1
  public void Start()
  {
    Console.WriteLine("The car is starting.");
  }

  // Problem 2
  public void Drive(int miles)
  {
    Console.WriteLine("The car drove " + miles);
  }

  // Problem 3
  public string GetDescription()
  {
    return $"{year} {color} {model}";
  }

  // Problem 4
  public string Repaint(string newColor)
  {
    color = newColor;
    return $"The car had been repainted {color}";
  }
}

class Program
{
  static void Main(string[] args)
  {
    // Creating a Car object and assigning values to its properties
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;

    myCar.Display(); // Calling the Display method
    
    // Problem 1
    myCar.Start();

    // Problem 2
    myCar.Drive(50);

    // Problem 3
    string carDescription = myCar.GetDescription();
    Console.WriteLine(carDescription);

    // Problem 4
    string carRepaint = myCar.Repaint("Red");
    Console.WriteLine(carRepaint);

    myCar.Display();


  }
}