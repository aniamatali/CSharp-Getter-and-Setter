using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public string Speed;
  public bool Availability;
  private int _year;

  public void SetYear(int NewYear)
  {
    _year = NewYear;
  }
  public int GetYear()
  {
    return _year;
  }

  public Car(string CarModel, int CarPrice, string CarInfo, int CarMiles)
  {
    MakeModel = CarModel;
    Price = CarPrice;
    Miles = CarMiles;
    Speed = CarInfo;
    Availability = true;
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car("Porsche911", 100000,"Very Fast Car" ,12000);
    Car ford = new Car("Ford F150", 30000,"Big Car" ,14000);
    Car lexus = new Car("Lexus GS350", 45000, "Semi Fast Car", 18300);
    Car bmw = new Car("BMW M4", 72000,"Fast Car" ,3400);
    Car nissan = new Car("Nissan Maxima", 20000,"Normal Car", 32000);

    porsche.SetYear(16);
    ford.SetYear(13);
    lexus.SetYear(16);
    bmw.SetYear(17);
    nissan.SetYear(16);

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, bmw, nissan };
    foreach(Car automobile in Cars)
    {
      Console.WriteLine("Make: " + automobile.MakeModel);
      Console.WriteLine("Price: " + automobile.Price);
      Console.WriteLine("Miles: " + automobile.Miles);
      Console.WriteLine("Year: " + automobile.GetYear());
      Console.WriteLine("Additional Info: " + automobile.Speed);
    }

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.Price < maxPrice)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine("Make: " + automobile.MakeModel);
      Console.WriteLine("Price: " + automobile.Price);
      Console.WriteLine("Miles: " + automobile.Miles);
      Console.WriteLine("Year: " + automobile.GetYear());
      Console.WriteLine("Additional Info: " + automobile.Speed);
    }
  }
}
