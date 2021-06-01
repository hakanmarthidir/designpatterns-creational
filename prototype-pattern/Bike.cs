using System;

namespace prototype_pattern
{
    public abstract class Bike
    {
        public int BikeId { get; set; }
        public string BikeBrand { get; set; }
        public double BikePrice { get; set; }
        public byte BikeGearsNumber { get; set; }

        public abstract Bike Clone();
    }

    public class RoadBike : Bike
    {
        public override Bike Clone()
        {
            return (Bike)this.MemberwiseClone();
        }
    }
}
