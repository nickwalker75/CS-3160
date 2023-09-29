using System;
using BPlayer;

namespace MainApp
{
  public class app
  {      
    public static void Main(string[] args)
    {
      BasketballPlayer player;
      player = getPlayer();
      Console.WriteLine($"{player.fn} {player.ln}");

      BasketballPlayer p1, p2, p3;

      p1 = getPlayer();
      p2 = getPlayer();
      p3 = getPlayer();
  
	    Console.WriteLine(p1 + " (L=" + p1.Length() + ")");
      Console.WriteLine(p2 + " (L=" + p2.Length() + ")");
      Console.WriteLine(p3 + " (L=" + p3.Length() + ")");

    }

    private static BasketballPlayer getPlayer()
    {
      string fn, ln;
      BasketballPlayer p;
      Console.Write("\nFirst name? \t");
      fn = Console.ReadLine();
      Console.Write("Last name? \t");
      ln = Console.ReadLine();

      p = new BasketballPlayer();
      p.fn = fn;
      p.ln = ln;
      return p;
    }
  }//app
}//MainApp