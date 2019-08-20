using System.Collections.Generic;
using CastleGrimtol.Project.Interfaces;

namespace CastleGrimtol.Project.Models
{
      public class Room : IRoom
      {
            public string Name { get; set; }
            public string Description { get; set; }
            public List<Item> Items { get; set; }
            public Dictionary<string, IRoom> Exits { get; set; }

            public Room(string name, string desc)
            {
                  Items = new List<Item>();
                  Exits = new Dictionary<string, IRoom>();
                  //TODO: assign variables
                  //TODO: Intantiate Dictionaries
            }
            public void FindItems()
            {
                  throw new System.NotImplementedException();
            }

            public void PrintExits()
            {

            }
      }
}