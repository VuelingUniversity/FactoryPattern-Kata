using FactoryPattern_Kata.Core;
using FactoryPattern_Kata.Interfaces;

namespace FactoryPattern_Kata.Services
{
	public class LicenseManager
	{
		public static bool CheckActivation(ActivationData activationData, License license)
		{
			IChecker checker = CheckerFactory.CreateChecker(license.LicenseType);
			if (checker.Check(activationData, license)) return true;
			else return false;
		}
	}
}