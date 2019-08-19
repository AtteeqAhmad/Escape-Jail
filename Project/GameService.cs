using System.Collections.Generic;
using CastleGrimtol.Project.Interfaces;
using CastleGrimtol.Project.Models;

namespace CastleGrimtol.Project
{
      public class GameService : IGameService
      {
            public IRoom CurrentRoom { get; set; }
            public Player CurrentPlayer { get; set; }

            public void Login()
            {
class GameService
            {
                  public User ActiveUser { get; private set; }
                  private Dictionary<string, User> Users { get; set; }

                  public void AddUser(User user)
                  {
                        Users.Add(user.Name.ToLower(), user);
                  }

                  public bool Login(string name)
                  {
                        if (Users.ContainsKey(name))
                        {
                              ActiveUser = Users[name];
                              return true;
                        }
                        return false;
                  }
                  public GameService()
                  {
                        Users = new Dictionary<string, User>();
                  }
            }
      }

      public void Go(string direction)
      {
            CurrentRoom = CurrentRoom.Exits(direction)
                  }

      public void Help()
      {
            System.Console.WriteLine("Enter \"go\" and your direction to go");
            System.Console.WriteLine("Enter \"Find\" to find something helpfull");
            System.Console.WriteLine("Enter \"Keep\" and the name of the item you want to keep.");
            System.Console.WriteLine("Enter \"use\" to use the item");
            System.Console.WriteLine("Enter \"Quit\" to quit");


      }

      public void Inventory()
      {
            System.Console.WriteLine($"{CurrentPlayer.Inventory}");
      }

      public void Look()
      {
            System.Console.WriteLine($"You are in the {CurrentRoom.Name}");
            CurrentRoom.FindItems();
      }

      public void Quit()
      {
      }

      public void Reset()
      {
      }

      public void Setup()
      {
            throw new System.NotImplementedException();
            Room room1 = new Room("Captured & Blind folded", "You are Captured by FBI under false allegations, your lawyer can't reach you for a year. You have to choose your way, take a chance to escape or settle down.");
            Room room2 = new Room("Operation Room", "Here you have to make a desicion, you could die if you choose wrong option. Your options are pick up");
            Room room3 = new Room("General Room", "You are on your way, act smart and confident");
            Room room4 = new Room("Gaurd Room", "Almost there to leave facility, You just have to pretend you are leaving office for getting some work done in field");
            Room1.Exits.Add("east", room2);
            Room2.Exits.Add("west", room1);
            Room2.Exits.Add("north", room3);
            Room3.Exits.Add("south", room2);
            Room3.Exits.Add("west", room4);
            Room4.Exits.Add("east", room3);
            Room4.Exits.Add("Exit", "You are free to Go");
            Item Gun = new Item("Gun", "Black, Glock");
            room2.Items.Add(Gun);
            Item IDCard = new Item("ID Card", "Fake Name, Picture");
            room2.Items.Add(IDCard);
            Item Picture = new Item("Picture", "Glue it to Card");
            room2.Items.Add(Picture);
            // Set as Start Room Always
            CurrentRoom = Room1;

            Console.WriteLine("Success");


      }

      public void StartGame()
      {
            string greeting = "Welcome to FBI cell";
            foreach (char letter in greeting)
            {
                  System.Console.WriteLine(letter);
                  thread.sleep(100);
            }
            System.Console.clear();
            System.Console.WriteLine("You are in FBI cell");
            System.Console.WriteLine("At unknown location");
            System.Console.WriteLine("You been kept for unknown false allegations, as much you remember!......");
            if (CurrentRoom is room1)
            {
                  var CurrentRoom = (Room1)CurrentRoom;
                  System.Console.WriteLine("what are you thinking?..");
                  System.Console.WriteLine("Are you thinking of escaping?..");
                  System.Console.WriteLine("It could be risky, You could die.....Don't Do it!");
                  System.Console.WriteLine("But you can try, but you will see consequences, act smart...");
                  System.Console.WriteLine("Here is your options.....write \"help\".. if you want to escape...");
                  string[] input = System.Console.ReadLine().ToLower().Split("");
                  System.Console.Clear();
                  string command = input[0];
                  string option = "";
                  if (input.Length > 1)
                  {
                        switch (command)
                        {
                              case "go";
                                    Go(option);
                                    break;
                              case "quit":
                                    Playing = false;
                                    break;
                        }
                  }
            }
      }
      public void TakeItem(string itemName)
      {

      }

      public void UseItem(string itemName)
      {

      }
}