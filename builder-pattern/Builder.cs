using System;
namespace builder_pattern
{

    public interface IBikeBuilder
    {
        IBikeBuilder AddFrame();
        IBikeBuilder AddTires();
        IBikeBuilder AddWheels();
        IBikeBuilder AddHandleBar();
        IBikeBuilder AddPedals();
        Bike Build();
    }

    public class BikeBuilder : IBikeBuilder
    {
        private Bike _bike = new Bike();

        public Bike Build() => _bike;

        public IBikeBuilder AddFrame()
        {
            this._bike.AddPart("Frame");
            return this;
        }

        public IBikeBuilder AddHandleBar()
        {
            this._bike.AddPart("Handlebar");
            return this;
        }

        public IBikeBuilder AddPedals()
        {
            this._bike.AddPart("Pedal");
            return this;
        }

        public IBikeBuilder AddTires()
        {
            this._bike.AddPart("Tire");
            return this;
        }

        public IBikeBuilder AddWheels()
        {
            this._bike.AddPart("Wheel");
            return this;
        }

    }

    public class BikeBuildManager
    {
        private readonly IBikeBuilder _bikeBuilder;

        public BikeBuildManager(IBikeBuilder bikeBuilder)
        {
            this._bikeBuilder = bikeBuilder;
        }

        public Bike PrepareBasicBike()
        {
            return this._bikeBuilder.AddFrame().Build();
        }

        public Bike PrepareStandartBike()
        {
            return this._bikeBuilder.AddFrame()
            .AddHandleBar()
            .AddPedals()
            .Build();
        }

        public Bike PrepareProBike()
        {
            return this._bikeBuilder.AddFrame()
            .AddHandleBar()
            .AddPedals()
            .AddTires()
            .AddWheels()
            .Build();
        }

    }
}
