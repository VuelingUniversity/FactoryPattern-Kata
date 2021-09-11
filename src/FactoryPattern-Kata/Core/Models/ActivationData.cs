using System;

namespace FactoryPattern_Kata
{
	public class ActivationData
	{
		public DateTime Date;
		public string HardwareId;

		public ActivationData(DateTime date, string hardwareId)
		{
			Date = date;
			HardwareId = hardwareId;
		}
	}
}