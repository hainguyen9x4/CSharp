using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PracticeProj
{
  class XmlSerializerTest
  {
    public void Method01()
    {
      CartItem2 cart = new CartItem2(1, 10, 10);
      FileStream fs = new FileStream("SerializedXMLData", FileMode.Create);
      XmlSerializer xs = new XmlSerializer(typeof(CartItem2));
      xs.Serialize(fs, cart);
      fs.Close();
    }
    public void Method02()
    {
      FileStream fs = new FileStream("SerializedXMLData", FileMode.Open);
      XmlSerializer xs = new XmlSerializer(typeof(CartItem2));
      CartItem2 cart = (CartItem2)xs.Deserialize(fs);
      Console.Write(cart);
      fs.Close();
    }
  }
  [Serializable]
  public class CartItem2
  {
    [XmlAttribute]public int productId;
    public int price;
    public int quantity;
    [XmlIgnore] public int price2;
    public CartItem2()
    { }
      public CartItem2(int id, int p, int q)
    {
      productId = id;
      price = p;
      quantity = q;
    }
    public void OnDeserialization(object sender)
    {
      price2 = price + price / 10;
    }
    public override string ToString()
    {
      return $"ID:{productId}| Price:{price} | Quantity:{quantity}| Price2:{price2} ";
    }
  }
}
