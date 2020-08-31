using System;

public class Kata
{   
  public static string NameShuffler(string str)
  {
    var firstLast = str.Split(' ');
    return $"{firstLast[1]} {firstLast[0]}";
  }
}
