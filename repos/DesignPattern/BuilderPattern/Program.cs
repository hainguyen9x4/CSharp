using System;

namespace BuilderPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Product p = new BuilderProduct(1).CreateName("ainguye").CreatePrimaryPrice(13).Builder();
      int i = 0;
    }
  }
  
  class Product
  {
    int id;
    string name;
    int PrimaryPrice;
    public Product(BuilderProduct bd)
    {
      id = bd.id;
      name = bd.name;
      PrimaryPrice = bd.PrimaryPrice;
    }
  }
  class BuilderProduct
  {
    public int id;
    public int PrimaryPrice;
    public string name;
    public BuilderProduct(int ID)
    {
      id = ID;
    }
    public BuilderProduct CreatePrimaryPrice(int price)
    {
      this.PrimaryPrice = price;
      return this;
    }
    public BuilderProduct CreateName(string name)
    {
      this.name = name;
      return this;
    }
    public Product Builder()
    {
      return new Product(this);
    }
  }
}
