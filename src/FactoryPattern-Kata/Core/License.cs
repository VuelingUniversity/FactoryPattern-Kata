using System;
using System.Collections.Generic;

namespace FactoryPattern_Kata
{
	public class License
	{
		public readonly LicenseType LicenseType;
		public readonly DateTime MaxActivationDate;
		public readonly int LimitOfActivations;
		public readonly List<string> Activations;

		public License(LicenseType licenseType, DateTime maxActivations, int limitOfActivations, List<string> activations)
		{
			LicenseType = licenseType;
			MaxActivationDate = maxActivations;
			LimitOfActivations = limitOfActivations;
			Activations = activations;
		}
	}
}