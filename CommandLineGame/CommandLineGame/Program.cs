using System;

namespace Game
{
  public class Program

  {
    static void Main()
    {
      new GetPlayerInfo();
      new SceneOne();

      if (Console.ReadLine() != "")
      {
        new SceneTwoA();
      }
      else
      {
        new SceneTwoB();
      }
    }
  }
}
