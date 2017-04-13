using System;

namespace Game
{
  public class GetPlayerInfo
  {
    public GetPlayerInfo()
    {
      Console.Write("Name: ");
      string name = Console.ReadLine();
      Console.WriteLine("Hello " + name + "!");

      Console.Write("\nAge: ");
      int age = Convert.ToInt32(Console.ReadLine());

      if (age < 12)
      {
        Console.WriteLine("\nThis game may contain content not suitable for individuals under the age of 12...Continue at your own risk.");
        Console.Write("Do you wish to continue(Y or N): ");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "y" || choice.ToLower() == "yes")
        {
          Console.WriteLine("Very Well");
        }
        else
        {
          Console.WriteLine("Goodbye");
          Environment.Exit(0);
        }
      }
    }
  }
}
