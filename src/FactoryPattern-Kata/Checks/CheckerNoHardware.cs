using FactoryPattern_Kata.Core;
using FactoryPattern_Kata.Interfaces;

namespace FactoryPattern_Kata.Checks
{
	public class CheckerNoHardware : IChecker
	{
		public bool Check(ActivationData activationData, License licenseData)
        {
            if (activationData.Date<licenseData.MaxActivations)
            {
                return false;
            }
            return true;
        }
	}
}