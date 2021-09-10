using System;

namespace FactoryPattern_Kata
{
	public static class CheckerFactory
	{
		//helper line
		//private static readonly Dictionary<LicenseType, IChecker> checker_creators = new Dictionary<LicenseType, IChecker> { { LicenseType.NoCheck, new CheckerNoHardware() }, { LicenseType.Check, new CheckerHardware() } };

		public static IChecker CreateChecker(LicenseType type)
		{
			throw new NotImplementedException();
		}
	}
}