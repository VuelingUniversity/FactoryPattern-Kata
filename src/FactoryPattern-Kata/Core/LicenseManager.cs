using System.Collections.Generic;

namespace FactoryPattern_Kata
{
	public interface IChecker
	{
		bool Check(ActivationData activation_data, License license_data);
	}

	public class CheckerFactory
	{


		public static IChecker CreateChecker(LicenseType type)
		{
			
		}
	}

	public class CheckerHardware : IChecker
	{

	}

	public class CheckerNoHardware : IChecker
	{

	}

	public class LicenseManager
	{
		public static bool CheckActivation(ActivationData activationData, License license)
		{
			var checker = CheckerFactory.CreateChecker(license.LicenseType);

			return checker.Check(activationData, license);
		}
	}
}