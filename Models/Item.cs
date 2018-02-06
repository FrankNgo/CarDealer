
using System.Collections.Generic;
using System;


namespace ToDoList.Models
{
  public class Item
  {

    public string _makeModel;
    public int _price;
    public int _miles;

    private static List<Item> _instances = new List<Item> {};

    public Item (string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }
    public string GetmakeModel()
    {
      return _makeModel;
    }

    public void SetmakeModel(string newmakeModel)
    {
      _makeModel = newmakeModel;
    }
    public int Getprice()
    {
      return _price;
    }
    public void Setprice(int newprice)
    {
      _price = newprice;
    }
    public int Getmiles()
    {
      return _miles;
    }

    public void Setmiles(int newmiles)
    {
      _miles = newmiles;
    }


    public static List<Item> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
