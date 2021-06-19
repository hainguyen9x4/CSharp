using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PracticeProj
{
  class TestBinaryFormatterSerialization
  {
    public void Method01()
    {
      CartItem cart = new CartItem(1, 10, 10);
      FileStream fs = new FileStream("SerializedStringData", FileMode.Create);
      BinaryFormatter bf = new BinaryFormatter();
      bf.Serialize(fs, cart);
      fs.Close();
    }
    public void Method02()
    {
      FileStream fs = new FileStream("SerializedStringData", FileMode.Open);
      BinaryFormatter bf = new BinaryFormatter();
      CartItem cart = (CartItem)bf.Deserialize(fs);
      fs.Close();
      Console.WriteLine(cart);
    }
  }
  [Serializable]
  class CartItem: IDeserializationCallback
  {
    public int productId;
    public int price;
    public int quantity;
    [NonSerialized] public int price2;
    [OptionalField] public int price3;
    public CartItem(int id, int p, int q)
    {
      productId = id;
      price = p;
      quantity = q;
    }
    public void OnDeserialization(object sender)
    {
      price2 = price + price/10;
    }
    public override string ToString()
    {
      return $"ID:{productId}| Price:{price} | Quantity:{quantity}| Price2:{price2}| Price3:{price3} ";
    }
  }

}
