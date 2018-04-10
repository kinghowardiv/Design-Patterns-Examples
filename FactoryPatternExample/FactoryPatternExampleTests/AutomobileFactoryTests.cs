using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryPatternExample;

namespace FactoryPatternExampleTests
{
    [TestClass]
    public class AutomobileFactoryTests
    {
        private AutomobileFactory _automobileFactory;
        private SubaruOutback _subareOutbackMock;
        private SUV _suvMock;
        private Truck _truckMock;

        [TestInitialize]
        public void Setup()
        {
            _subareOutbackMock = new SubaruOutback();
            _suvMock = new SUV();
            _truckMock = new Truck();

            var autoMobiles = new IAutomobile[]
                {
                            _subareOutbackMock,
                            _suvMock,
                            _truckMock
                };

            _automobileFactory = new AutomobileFactory(autoMobiles);
        }

        [TestMethod]
        public void IfAutomobileShouldAttachTrailerAndHaveFourWheelDriveThenGetAutomobileShouldReturnTruckTest()
        {
            var actualAutomobile = _automobileFactory.GetAutomobile(true, true);

            Assert.AreEqual(actualAutomobile, _truckMock);
        }

        [TestMethod]
        public void IfAutomobileShouldNotAttachTrailerButHaveFourWheelDriveThenGetAutomobileShouldReturnSUVTest()
        {
            var actualAutomobile = _automobileFactory.GetAutomobile(true, false);

            Assert.AreEqual(actualAutomobile, _suvMock);
        }

        [TestMethod]
        public void IfAutomobileShouldAttachTrailerAndNotHaveFourWheelDriveThenGetAutomobileShouldReturnEmptyTest()
        {
            var actualAutomobile = _automobileFactory.GetAutomobile(false, true);

            Assert.AreEqual(actualAutomobile, null);
        }

        [TestMethod]
        public void IfAutomobileShouldNotAttachTrailerAndNotHaveFourWheelDriveThenGetAutomobileShouldReturnSubaruOutbackTest()
        {
            var actualAutomobile = _automobileFactory.GetAutomobile(false, false);

            Assert.AreEqual(actualAutomobile, _subareOutbackMock);
        }
    }
}
