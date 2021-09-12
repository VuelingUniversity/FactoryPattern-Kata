using FactoryPattern_Kata.Core;
using FactoryPattern_Kata.Interfaces;
using System.Linq;

namespace FactoryPattern_Kata
{
	public class CheckerHardware : IChecker
	{
		public bool Check(ActivationData activationData, License licenseData)
        {
            if (activationData.Date > licenseData.MaxActivations)
                return false;
            else if (licenseData.Activations.Count != licenseData.LimitOfActivations)
                return true;
            else if (!licenseData.Activations.Contains(activationData.HardwareId))
                return false;
            return true;
        }
	}
}