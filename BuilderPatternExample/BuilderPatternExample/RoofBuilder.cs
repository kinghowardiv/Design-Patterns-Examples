
using System;
using System.Threading;

namespace BuilderPatternExample
{
    public interface IRoofBuilder
    {
        Roof BuildRoof(int length, int width, int height);
    }

    public class RoofBuilder : IRoofBuilder
    {
        public Roof BuildRoof(int length, int width, int height)
        {
            var roof = new Roof();
            roof.Length = length;
            roof.Height = height;
            roof.Width = width;

            Console.WriteLine(string.Format("Built a roof with a length of {0}, a width of {1} and a height of {2}", length, width, height));
            Thread.Sleep(1000);

            return roof;
        }
    }
}
