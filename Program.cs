using System;
using CastleGrimtol.Project;
using CastleGrimtol.Project.Models;

namespace CastleGrimtol
{
      public class Program
      {
            public static void Main(string[] args)
            {

                  Console.Clear();
                  Console.WriteLine("Hello World");
                  GameService gameService = new GameService();
                  // gameService.newUser = new User(); USE PLAYER

                  //TODO Move this to 'setup'

                  // if (gameService.Login(name))
                  // {
                  //       System.Console.WriteLine($"Ready...?{app.Activeuser.Name}");
                  //       loggedOut = false;
                  // }
                  // else
                  // {
                  //       Console.Clear();
                  //       System.Console.WriteLine("Invalid Credentials");
                  // }

                  gameService.Setup();
                  gameService.StartGame();
            }
      }
}
