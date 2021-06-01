using System;
using System.Linq;
using abstract_factory_pattern;
using builder_pattern;
using factory_pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [TestClass]
    public class PrototypeTests
    {
        [TestMethod]
        public void Bike_Clone_Successfully()
        {

            prototype_pattern.RoadBike bike = new prototype_pattern.RoadBike()
            {
                BikeId = 1,
                BikeBrand = "Cervello",
                BikeGearsNumber = 21,
                BikePrice = 5000
            };

            var cloneBike = bike.Clone();
            Assert.IsTrue(cloneBike != bike);

            cloneBike.BikeBrand = "Bianchi";
            Assert.IsTrue(cloneBike.BikeBrand != bike.BikeBrand);

        }
    }
}
