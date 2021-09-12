using System.Linq;

namespace FactoryPattern_Kata
{
	public class CheckerHardware : IChecker
	{
		public bool Check(ActivationData activationData, License licenseData)
        {
            if (licenseData.Activations.Count == licenseData.LimitOfActivations
                    && !licenseData.Activations.Contains(activationData.HardwareId))
            {
                return false;
            }
            if (activationData.Date<licenseData.MaxActivations)
            {
                return false;
            }
            return true;
        }
	}
}