using System;
using System.Collections.Generic;
using System.Linq;


namespace BagOLoot.Actions
{
  public class UpdateDelivery
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      Console.Clear();
      Console.WriteLine ("Choose child");

      var children = book.GetChildren().ToArray();
      foreach (Child child in children)
      {
          Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
      }

      Console.Write ("> ");
      string childName = Console.ReadLine();
      Child kid = book.GetChild(children[int.Parse(childName)-1].name);
      Console.WriteLine("Have the toys been delivered?");
      Console.WriteLine("******************************");
      Console.WriteLine("1. Yes");
      Console.WriteLine("2. No");
      Console.WriteLine ("");
      Console.Write ("> ");
      string deliveryStatusChosen = Console.ReadLine();
      if (int.Parse(deliveryStatusChosen) == 1)
      {
        kid.delivered = true;
      } else
      {
          kid.delivered = false;
      }
      book.SetDeliveryUpdate(kid);
    }
  }
}