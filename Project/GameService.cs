using System;
using System.Collections.Generic;
using System.Threading;
using CastleGrimtol.Project.Interfaces;
using CastleGrimtol.Project.Models;

namespace CastleGrimtol.Project
{
      public class GameService : IGameService
      {
            public IRoom CurrentRoom { get; set; }
            public Player CurrentPlayer { get; set; }
            public bool Playing { get; private set; }

            //NOTE handled by setup method
            // public User ActiveUser { get; private set; }
            // private Dictionary<string, User> Users { get; set; }

            // public void AddUser(User user)
            // {
            //       Users.Add(user.Name.ToLower(), user);
            // }

            // public bool Login(string name)
            // {
            //       if (Users.ContainsKey(name))
            //       {
            //             ActiveUser = Users[name];
            //             return true;
            //       }
            //       return false;
            // }
            // public GameService()
            // {
            //       Users = new Dictionary<string, User>();
            // }
            public void Go(string direction)
            {
                  CurrentRoom = CurrentRoom.Exits[direction];
            }

            public void Help()
            {
                  System.Console.WriteLine("Enter \"go\" and your direction \"east\", \"west\", \"north\", \"south\" to go");
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
            }

            public void FindItems()
            {

            }

            public void Quit()
            {

            }

            public void Reset()
            {
            }

            public void Setup()
            {
                  Console.Write("Name:");
                  string name = Console.ReadLine().ToLower();
                  Player newPlayer = new Player();
                  System.Console.WriteLine("Welcome, Login please");
                  System.Console.WriteLine("Logined as: " + name);

                  Room room1 = new Room("Captured & Blind folded", "You are Captured by FBI under false allegations, your lawyer can't reach you for a year. You have to choose your way, take a chance to escape or settle down.");
                  Room room2 = new Room("Operations Room", "Here you have to make a desicion, you could die if you choose wrong option. Your options are pick up");
                  Room room3 = new Room("General Room", "You are on your way, act smart and confident");
                  Room room4 = new Room("Gaurd Room", "Almost there to leave facility, You just have to pretend you are leaving office for getting some work done in field");
                  Room room5 = new Room("Escaped", " YOU Escaped successfully & free!");

                  room1.Exits.Add("east", room2);
                  room2.Exits.Add("west", room1);
                  room2.Exits.Add("north", room3);
                  room3.Exits.Add("south", room2);
                  room3.Exits.Add("west", room4);
                  room4.Exits.Add("east", room3);
                  room4.Exits.Add("Exit", room5);
                  Item Gun = new Item("Gun", "Black, Glock");
                  room2.Items.Add(Gun);
                  Item IDCard = new Item("ID Card", "Fake Name, Picture");
                  room2.Items.Add(IDCard);
                  Item Picture = new Item("Picture", "Glue it to Card");
                  room2.Items.Add(Picture);
                  // Set as Start Room Always
                  CurrentRoom = room1;

                  Console.WriteLine("Success");


            }
            public void StartGame()
            {
                  string greeting = $"Welcome to FBI cell{CurrentRoom.Name}";
                  foreach (char letter in greeting)
                  {
                        System.Console.WriteLine("");
                        Thread.Sleep(100);
                        System.Console.Write("Destination Available: ");
                        CurrentRoom.PrintExits();

                  }
                  System.Console.Clear();
                  System.Console.WriteLine("You are in FBI cell");
                  foreach (char letter in greeting)

                        Console.WriteLine("........");
                  Thread.Sleep(1000);
                  System.Console.WriteLine("At unknown location");
                  Thread.Sleep(1000);
                  System.Console.WriteLine("You been kept for unknown false allegations, as much you remember!......");
                  {
                        CurrentRoom = (Room)CurrentRoom;
                        System.Console.WriteLine("what are you thinking?..");
                        System.Console.WriteLine("Are you thinking of escaping?..");
                        System.Console.WriteLine("It could be risky, You could die.....Don't Do it!");
                        System.Console.WriteLine("But you can try, but you will see consequences, act smart...");
                        System.Console.WriteLine("Here is your options.....write \"help\".. if you want to escape...");
.

                        //TODO Your game loop might start here
                        while (Playing)
                        {

                              string[] input = System.Console.ReadLine().ToLower().Split("");
                              System.Console.Clear();
                              string command = input[0];
                              string option = "";
                              if (input.Length > 1)
                              {
                                    switch (command)
                                    {
                                          case "go":
                                                Go(option);
                                                break;
                                          case "quit":
                                                Playing = false;
                                                break;
                                          default:
                                                System.Console.WriteLine("Unknown Command");
                                                break;
                                    }
                              }
                              CurrentRoom.PrintExits();

                        }
                  }
            }
            public void TakeItem(string itemName)
            {

            }

            public void UseItem(string itemName)
            {

            }

            public void GetUserInput()
            {

            }
      }
}