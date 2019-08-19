using System;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
      public class Program
      {
            public static void Main(string[] args)
            {

                  Console.Clear();
                  Console.WriteLine("Hello World");
                  GameService gameService = new GameService();
                  gameService.newUser = newUser();
                  System.Console.WriteLine("Welcome, Login please");
                  {
                        Console.Write("Name:");
                        string name = Console.ReadLine().ToLower();
                        if (gameService.Login(name))
                        {
                              System.Console.WriteLine($"Ready...?{app.Activeuser.Name}");
                              loggedOut = false;
                        }
                        else
                        {
                              Console.Clear();
                              System.Console.WriteLine("Invalid Credentials");
                        }
                  }
                  gameService.Setup();
                  gameService.StartGame();
            }
      }
}
