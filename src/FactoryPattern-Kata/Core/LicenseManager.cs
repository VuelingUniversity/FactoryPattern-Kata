namespace FactoryPattern_Kata
{
	public class LicenseManager
	{
		public static bool CheckActivation(ActivationData activationData, License license)
		{
			IChecker checker = CheckerFactory.CreateChecker(license.LicenseType);
			return checker.Check(activationData, license);
		}
	}
}