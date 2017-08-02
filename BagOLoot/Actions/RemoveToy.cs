using System;
using System.Collections.Generic;
using System.Linq;


namespace BagOLoot.Actions
{
  public class RemoveToy
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



      Console.WriteLine ("Choose toy");
      var toys = bag.GetToysForChild(kid).ToArray();
      foreach (var item in toys)
      {
          Console.WriteLine($"{Array.IndexOf(toys,item)+1}. {item.name}");
      }
      Console.Write ("> ");
      string toyId = Console.ReadLine();
      int numVal = Convert.ToInt32(toyId);
      Toy toyToDelete = toys[numVal-1];
      bag.RevokeToy(toyToDelete);
    }
  }
}