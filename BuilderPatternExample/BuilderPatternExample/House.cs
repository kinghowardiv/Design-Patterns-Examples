

namespace BuilderPatternExample
{
    public class House
    {
        private readonly Window _window;
        private readonly Floor _floor;
        private readonly Roof _roof;

        public House(Window window, Floor floor, Roof roof)
        {
            _window = window;
            _floor = floor;
            _roof = roof;
        }
    }
}
