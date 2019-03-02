using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuilderPatternExample;

namespace BuilderPatternExampleTests
{
    [TestClass]
    public class WindowBuilderTests
    {
        private WindowBuilder _windowBuilder;

        [TestInitialize]
        public void Setup()
        {
            _windowBuilder = new WindowBuilder();
        }

        [TestMethod]
        public void BuildFloorTest()
        {
            var expectedLength = 5;
            var expectedWidth = 5;
            var window = _windowBuilder.BuildWindow(expectedLength, expectedWidth);

            Assert.IsNotNull(window);
            Assert.AreEqual(window.Length, expectedLength);
            Assert.AreEqual(window.Width, expectedWidth);
        }
    }
}