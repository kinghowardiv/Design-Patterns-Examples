

using System;
using System.Threading;

namespace BuilderPatternExample
{
    public interface IWindowBuilder
    {
        Window BuildWindow(int length, int width);
    }

    public class WindowBuilder : IWindowBuilder
    {
        public Window BuildWindow(int length, int width)
        {
            var window = new Window();
            window.Length = length;
            window.Width = width;

            Console.WriteLine(string.Format("Built a window with a length of {0} and a height of {1}", length, width));
            Thread.Sleep(1000);

            return window;
        }
    }
}
