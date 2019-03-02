using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuilderPatternExample;
using Moq;

namespace BuilderPatternExampleTests
{
    public class HouseBuilderTests
    {
        private HouseBuilder _houseBuilder;
        private Mock<IFloorBuilder> _floorBuilderMock;
        private Mock<IRoofBuilder> _roofBuilderMock;
        private Mock<IWindowBuilder> _windowBuilderMock;
        private Window _mockWindow;
        private Floor _mockFloor;
        private Roof _mockRoof;

        [TestInitialize]
        public void Setup()
        {
            _mockWindow = new Window();
            _mockRoof = new Roof();
            _mockFloor = new Floor();

            _houseBuilder = new HouseBuilder();
        }
    }
}
