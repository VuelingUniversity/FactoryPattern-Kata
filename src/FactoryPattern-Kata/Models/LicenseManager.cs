namespace FactoryPattern_Kata
{
	public class LicenseManager
	{
		public static bool CheckActivation(ActivationData activationData, License license)
		{
			//change the solution so the following code will work instead of the uncommented one , lines 12-30, that should be gone )
			IChecker checker = CheckerFactory.CreateChecker(license.LicenseType);
			return checker.Check(activationData, license);
		}
	}
}