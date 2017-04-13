using System;

namespace Game
{
  class SceneOne
  {
    public SceneOne()
    {
      Console.WriteLine(
        "\nYou and a friend are are sitting around a camp fire after spending all day on the river fishing. Suddenly a loud screeching scream echos from within the trees. You and your friend turn toward each other with a terrfied and bewildered look on your faces."
      );

      Console.WriteLine("\nFriend: 'One of us should check that out.'");

      Console.Write("Do you offer to investigate the noise? Y or N: ");
      string choice = Console.ReadLine();

      if (choice.ToLower() == "y" || choice.ToLower() == "yes")
      {
        Console.WriteLine("\nFriend: Don't worry, if anything happens to you I will be sure to take good care of your girlfriend.");
        Console.Write("Response: ");
      }
      else
      {
        Console.WriteLine("Friend: I have a number behind my back.");
        Console.Write("1 or 2: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        double randomNumber = Math.Round(random.NextDouble() + 1);

        if (number == randomNumber)
        {
          Console.WriteLine("Dang it. You got it right. If anything happens to me don't touch my stuff.");

          Console.WriteLine("\nPress enter to continue...");
        }

        else
        {
          Console.WriteLine("\nFriend: Wrong, it was " + randomNumber + ". Don't worry, if anything happens to you I will be sure to take good care of your girlfriend.");
          Console.Write("Response: ");
        }
      }
    }
  }
}