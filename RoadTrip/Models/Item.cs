using System.Collections.Generic;

namespace RoadTrip.Models
{
    public class Item
    {
        public string GasTank { get; set; }
        public string RoadSideAsst { get; set; }
        public string Music { get; set; }
        public string Snacks { get; set; }
        public string Map { get; set; }
        
    
        public static List<Item> instances = new List<Item> {};

        public Item(string gasTank, string roadSideAsst, string music, string snacks, string map)
        {
            GasTank = gasTank;
            RoadSideAsst = roadSideAsst;
            Music = music;
            Snacks = snacks;
            Map = map;
            instances.Add(this);
          
        }
    }
}