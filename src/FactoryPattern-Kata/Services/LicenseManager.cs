namespace FactoryPattern_Kata
{
	public class LicenseManager
	{
		public static bool CheckActivation(ActivationData activationData, License license)
		{
			// Using CheckerFactory.CreateChecker, and depends of licenseType, creates new Hardware or Non-Hardware
			var observer = CheckerFactory.CreateChecker(license.LicenseType);
			// Using method Check (from IChecker) and return true-false depends of observer...
			bool isChecked = observer.Check(activationData, license);
			return isChecked;
		}
	}
}