using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            var checkLocations = 0;
            var directions = File.ReadAllLines("c://AdventOfCode2015Day03PussleInput.txt");
            //Console.WriteLine(directions);
            string sign = "";
            for (int positionInDirection = 0; positionInDirection <= directions.Length; positionInDirection++)
            {
                try
                {
                    sign = Convert.ToString(directions[positionInDirection]);
                }
                catch (IndexOutOfRangeException)
                {

                    throw;
                }
                switch (sign)
                {
                    case "^":
                        santasPosition.Yrow++;
                        break;
                    case "<":
                        santasPosition.Xcolumn--;
                        break;
                    case ">":
                        santasPosition.Xcolumn++;
                        break;
                    case "v":
                        santasPosition.Yrow--;
                        break;
                    default:
                        break;
                }
                for (int i = 0; i <= visitedHouses.Count; i++)
                {
                    if (santasPosition.Yrow == visitedHouses[i].Yrow)
                    {
                        if (santasPosition.Xcolumn == visitedHouses[i].Xcolumn)
                        {
                            checkLocations++;
                        }
                            //numberOfHousesVisited++;
                    }

                }
                visitedHouses.Add(santasPosition);


                //IEnumerable<Location> haveSantaVisitedThisHouseBefore = from Xcolumn in visitedHouses where visitedHouses.  .Xcolumn.any()

                //var housesInXcoloum = visitedHouses.SingleOrDefault();
                //var haveSantaVisitedThisHouseBefore = 
            }

            Console.WriteLine("Santa visited")

            //Adress foundAdress = Db.Adresses.SingleOrDefault(i => i.GuestId == searchedGuest.GuestId);
            //var directions = File.currentWorking();
        }
    }
}
