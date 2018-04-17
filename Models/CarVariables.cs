using System.Collections.Generic;

namespace CarDealership.Models
{
  public class CarVariables
  {
    private string _make;
    private string _model;
    private string _year;
    private string _price;

    public CarVariables(string make, string model, string year, string price)
      {
        _make = make;
        _model = model;
        _year = year;
        _price = price;

      }
    public static List<CarVariables> _instances = new List<CarVariables> {};

    public string GetMake()
    {
      return _make;
    }

    public void SetMake(string newMake)
    {
      _make = newMake;
    }

    public string GetModel()
    {
      return _model;
    }

    public void SetModel(string newModel)
    {
      _model = newModel;
    }

    public string GetYear()
    {
      return _year;
    }

    public void SetYear(string newYear)
    {
      _year = newYear;
    }

    public string GetPrice()
    {
      return _price;
    }

    public void SetPrice(string newPrice)
    {
      _price = newPrice;
    }

    public static List<CarVariables> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
  }
}
