using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public string Description;

  public Car(string makeModel, int price, int miles, string description)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Description = description;
  }

  public bool WorthBuying(int maxPrice)
  {
    return (Price < maxPrice);
  }

  public bool WorthDriving(int maxMileage)
  {
      return (Miles < maxMileage);
  }

    public static string showCarToUser(string carToShow, List<Car> Cars)
    {
        if (carToShow == "volkswagen")
        {
            Console.WriteLine(Cars[0].Description);
            return Cars[0].Description;
        }
        else if (carToShow == "yugo")
        {
            Console.WriteLine(Cars[1].Description);
            return Cars[1].Description;
        }
        else if (carToShow == "ford")
        {
            Console.WriteLine(Cars[2].Description);
            return Cars[2].Description;
        }
        else
        {
            Console.WriteLine(Cars[3].Description);
            return Cars[3].Description;
        }
    }


}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "oldest shitty car");
    Car yugo = new Car("1980 Yugo Koral", 700, 56000, "old shitty car");
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "older shitty car");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "shitty car");


    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };
    Console.WriteLine("Which car would you like to see info on?");
    string carToShow = Console.ReadLine();
    Car.showCarToUser(carToShow,Cars);

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);
    Console.WriteLine("Enter desired maximum mileage: ");
    string stringMaxMileage = Console.ReadLine();
    int maxMileage = int.Parse(stringMaxMileage);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice) && automobile.WorthDriving(maxMileage))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    if (CarsMatchingSearch.Count == 0)
    {
        Console.WriteLine("You need mo scrilla");
    }
    else
    {
        foreach (Car automobile in CarsMatchingSearch)
        {
            Console.WriteLine(automobile.MakeModel);
            Console.WriteLine(automobile.Description);
        }
    }

  }
}