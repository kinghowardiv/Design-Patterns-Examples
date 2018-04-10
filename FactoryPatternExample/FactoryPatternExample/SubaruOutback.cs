

namespace FactoryPatternExample
{
    public class SubaruOutback : IAutomobile
    {
        public bool CanAttachTrailer()
        {
            return false;
        }

        public string GetLicensePlate()
        {
            return "A85843HB";
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
            return false;
        }
    }
}
