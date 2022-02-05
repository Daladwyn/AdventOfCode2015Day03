using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2015Day03
{
    class Program
    {
        class Location
        {
            public int Xcolumn { get; set; }
            public int Yrow { get; set; }
        }

        static void Main(string[] args)
        {
            var santasPosition = new Location();
            santasPosition.Xcolumn = 0;
            santasPosition.Yrow = 0;
            var visitedHouses = new List<Location>();
            visitedHouses.Add(santasPosition);
            var numberOfHousesVisited = 0;
            var directions = File.ReadAllLines("c://AdventOfCode2015Day03PussleInput.txt");
            Console.WriteLine(directions);
            //var directions = File.currentWorking();
        }
    }
}
