using System;

namespace ClassExercise
{
    public class Transport
    {
        public int MaximumLimitSpeed;
        public int CapacityPeople;
        public Boolean Fly;
        public Boolean Land;
        public Boolean Navigate;
    }

    public class AirTransport: Transport
    {        
        public decimal MaximumHeight;

        public AirTransport()
        {
            base.Fly = true;
            base.Land = true;
            base.Navigate = false;
        }
    }

    public class LandTransport: Transport
    {
        public int Wheels;

        public LandTransport()
        {
            base.Fly = false;
            base.Land = true;
            base.Navigate = false;
        }
    }

    public class AquaticTransport: Transport
    {
        public AquaticTransport()
        {
            base.Fly = false;
            base.Land = false;
            base.Navigate = true;
        }
    }

    public class Toyota : LandTransport { }

    public class ElectricFlyingCar : AirTransport { }

    public class Boat : AquaticTransport { }

    public class Boeing : AirTransport { }

}
