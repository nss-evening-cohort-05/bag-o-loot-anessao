using System;
using System.Collections.Generic;
using System.Linq;


namespace BagOLoot.Actions
{
  public class DeliveryReport
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      Console.Clear();
      var children = book.GetChildren().ToArray();
      foreach (Child child in children)
      {
          var deliveryStatus = "";
          if (child.delivered) {
              deliveryStatus = "Delivered";
          } else
          {
            deliveryStatus = "Undelivered";
          }
          Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name} - Status: {deliveryStatus}");
          var toys = bag.GetToysForChild(child).ToArray();
        
        foreach (var item in toys)
        {
            Console.WriteLine($"   {Array.IndexOf(toys,item)+1}. {item.name}");
        }
      }
      Console.WriteLine("**************************************");
      Console.WriteLine("Press any key to go back to main menu");
      Console.ReadLine();
    }
  }
}