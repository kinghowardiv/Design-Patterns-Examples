

using System;

namespace FactoryPatternExample
{
    public class Truck : IAutomobile
    {
        public bool CanAttachTrailer()
        {
            return true;
        }

        public string GetLicensePlate()
        {
            return "L678RT30";
        }

        public string GetMake()
        {
            return "make info";
        }

        public string GetModel()
        {
            return "make info";
        }

        public bool HasFourWheelDrive()
        {
            return true;
        }
    }
}
