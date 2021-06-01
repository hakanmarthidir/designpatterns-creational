using System;
using System.Linq;
using abstract_factory_pattern;
using builder_pattern;
using factory_pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void BikeBuilder_Create_Successfully()
        {

            BikeBuildManager bikeBuildManager = new BikeBuildManager(new BikeBuilder());

            var proBike = bikeBuildManager.PrepareProBike();
            var proParts = proBike.GetBikeParts();

            Assert.IsTrue(proParts.Contains("Tire"));

        }
    }
}
