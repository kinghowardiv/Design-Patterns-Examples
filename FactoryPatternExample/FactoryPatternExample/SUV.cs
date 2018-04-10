

namespace FactoryPatternExample
{
    public class SUV : IAutomobile
    {
        public bool CanAttachTrailer()
        {
            return false;
        }

        public string GetLicensePlate()
        {
            return "LDJ4632";
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
