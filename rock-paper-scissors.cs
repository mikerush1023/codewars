using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{

    public string Rps(string p1, string p2)
    {

        if (p1 == "rock")
        {
            if (p2 == "scissors")
                return "Player 1 won!";

            if (p2 == "paper")
                return "Player 2 won!";
        }
        if (p1 == "paper")
        {
            if (p2 == "rock")
                return "Player 1 won!";

            if (p2 == "scissors")
                return "Player 2 won!";
        }
        if (p1 == "scissors")
        {
            if (p2 == "paper")
                return "Player 1 won!";

            if (p2 == "rock")
                return "Player 2 won!";
        }
              if (p1 == p2)
        {
            return "Draw!";
        }
      return null;

    }
}
