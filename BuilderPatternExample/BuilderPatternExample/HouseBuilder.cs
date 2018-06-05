

namespace BuilderPatternExample
{
    public interface IHouseBuilder
    {
        House BuildHouse();
    }

    public class HouseBuilder : IHouseBuilder
    {
        private readonly IFloorBuilder _floorBuilder;
        private readonly IWindowBuilder _windowBuilder;
        private readonly IRoofBuilder _roofBuilder;

        public HouseBuilder(IFloorBuilder floorBuilder, IRoofBuilder roofBuilder, IWindowBuilder windowBuilder)
        {
            _floorBuilder = floorBuilder;
            _roofBuilder = roofBuilder;
            _windowBuilder = windowBuilder;
        }

        public House BuildHouse()
        {
            var floor = _floorBuilder.BuildFloor(2);
            var window = _windowBuilder.BuildWindow(5, 5);
            var roof = _roofBuilder.BuildRoof(10, 10, 10);

            var house = new House(window, floor, roof);


            return house;
        }
    }
}
