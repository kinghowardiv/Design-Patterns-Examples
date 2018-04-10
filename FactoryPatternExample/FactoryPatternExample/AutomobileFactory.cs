

using System.Collections.Generic;
using System.Linq;

namespace FactoryPatternExample
{
    public interface IAutomobileFactory
    {
        IAutomobile GetAutomobile(bool shouldHaveFourWheelDrive, bool shouldAttachTrailer);
    }

    public class AutomobileFactory : IAutomobileFactory
    {
        private IAutomobile[] _autoMobiles;

        public AutomobileFactory(IAutomobile[] autoMobiles)
        {
            _autoMobiles = autoMobiles;
        }

        public IAutomobile GetAutomobile(bool shouldHaveFourWheelDrive, bool shouldAttachTrailer)
        {
            return _autoMobiles.Where(x=>x.HasFourWheelDrive().Equals(shouldHaveFourWheelDrive) && x.CanAttachTrailer() == shouldAttachTrailer).FirstOrDefault();
        }
    }


}
