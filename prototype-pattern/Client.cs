namespace prototype_pattern
{
    public class Client
    {
        public Client()
        {
            var roadBike1 = new RoadBike() { BikeId = 1, BikeBrand = "SWorks", BikePrice = 2000, BikeGearsNumber = 18 };
            var roadBike2 = roadBike1.Clone();
            roadBike2.BikeGearsNumber = 21;
        }
    }
}
