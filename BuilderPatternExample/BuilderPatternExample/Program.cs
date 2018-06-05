

using System;
using System.Threading;

namespace BuilderPatternExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var houseBuilder = new HouseBuilder(new FloorBuilder(), new RoofBuilder(), new WindowBuilder());

            var house = houseBuilder.BuildHouse();

            Console.WriteLine(string.Format("Successfully built a house!"));
            Thread.Sleep(5000);
        }
    }
}