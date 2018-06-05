

using System;
using System.Threading;

namespace BuilderPatternExample
{
    public interface IFloorBuilder
    {
        Floor BuildFloor(int rooms);
    }

    public class FloorBuilder : IFloorBuilder
    {
        public Floor BuildFloor(int rooms)
        {
            var floor = new Floor();
            floor.Rooms = rooms;

            Console.WriteLine(string.Format("Built a floor with {0} rooms", rooms));
            Thread.Sleep(1000);

            return floor;
        }
    }
}
