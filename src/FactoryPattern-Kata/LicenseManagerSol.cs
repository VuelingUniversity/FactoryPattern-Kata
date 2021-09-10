using System.Collections.Generic;

namespace FactoryPattern_Kata
{
	public interface IChecker
	{
		bool Check(ActivationData activation_data, License license_data);
	}

	public class CheckerFactory
	{
		private static readonly Dictionary<LicenseType, IChecker> checker_creators = new Dictionary<LicenseType, IChecker>
			{
				{ LicenseType.NoCheck, new CheckerNoHardware() },
				{ LicenseType.Check, new CheckerHardware() }
			};

		public static IChecker CreateChecker(LicenseType type)
		{
			return checker_creators[type];
		}
	}

	public class CheckerHardware : IChecker
	{
		public bool Check(ActivationData activation_data, License license_data)
		{
			if (activation_data.Date > license_data.MaxActivationDate)
				return false;

			if (license_data.Activations.Count == license_data.LimitOfActivations)
			{
				if (!license_data.Activations.Contains(activation_data.HardwareId))
					return false;
			}

			return true;
		}
	}

	public class CheckerNoHardware : IChecker
	{
		public bool Check(ActivationData activation_data, License license_data)
		{
			if (activation_data.Date > license_data.MaxActivationDate)
				return false;

			return true;
		}
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
