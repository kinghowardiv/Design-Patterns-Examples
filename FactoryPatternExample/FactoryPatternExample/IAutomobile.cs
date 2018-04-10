
namespace FactoryPatternExample
{
    public interface IAutomobile
    {
        string GetMake();
        string GetModel();
        string GetLicensePlate();
        bool HasFourWheelDrive();
        bool CanAttachTrailer();
    }
}
