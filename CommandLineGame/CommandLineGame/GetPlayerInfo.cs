using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineGame
{
  class GetPlayerInfo
  {
    public GetPlayerInfo()
    {
      Console.Write("Name:\t");
      string name = Console.ReadLine();

      Console.Write("Age:\t");
      int age = Convert.ToInt32(Console.ReadLine());

      if (age < 12)
      {
        Console.WriteLine("\nThis game may contain content not suitable for individuals under the age of 12. Continue at your own risk \n\nDo you wish to continue(Y or N):");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "y" || choice.ToLower() == "yes")
        {
          Console.WriteLine("\nVery Well");
        }
        else
        {
          Console.WriteLine("\nGoodbye");
        }
      }
    }
  }
}
