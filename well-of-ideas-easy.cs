using System;
using System.Linq;

public class Kata
{
  public static string Well(string[] x)
  {
    var goodCount = x.Count(item => item == "good");
    
    if(goodCount > 2)
      {
      return ("I smell a series!");
      }
    else if (goodCount > 0 && goodCount <= 2)
      {
      return ("Publish!");
      }
    
      return "Fail!";
  }
}
