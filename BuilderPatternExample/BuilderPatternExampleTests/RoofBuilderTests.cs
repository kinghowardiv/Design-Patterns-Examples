using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuilderPatternExample;

namespace BuilderPatternExampleTests
{
    [TestClass]
    public class RoofBuilderTests
    {
        private RoofBuilder _roofBuilder;

        [TestInitialize]
        public void Setup()
        {
            _roofBuilder = new RoofBuilder();
        }

        [TestMethod]
        public void BuildFloorTest()
        {
            var expectedLength = 5;
            var expectedWidth = 5;
            var expectedHeight = 5;
            var roof = _roofBuilder.BuildRoof(expectedLength, expectedWidth, expectedHeight);

            Assert.IsNotNull(roof);
            Assert.AreEqual(roof.Length, expectedLength);
            Assert.AreEqual(roof.Width, expectedWidth);
            Assert.AreEqual(roof.Height, expectedHeight);
        }
    }
}