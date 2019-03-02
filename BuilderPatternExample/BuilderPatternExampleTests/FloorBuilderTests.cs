using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuilderPatternExample;

namespace BuilderPatternExampleTests
{
    [TestClass]
    public class FloorBuilderTests
    {
        private FloorBuilder _floorBuilder;

        [TestInitialize]
        public void Setup()
        {
            _floorBuilder = new FloorBuilder();
        }

        [TestMethod]
        public void BuildFloorTest()
        {
            var expectedNumberOfRooms = 5;
            var floor = _floorBuilder.BuildFloor(expectedNumberOfRooms);

            Assert.IsNotNull(floor);
            Assert.AreEqual(floor.Rooms, expectedNumberOfRooms);
        }
    }
}