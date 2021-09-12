namespace FactoryPattern_Kata
{
	public class CheckerNoHardware : IChecker
	{
		public bool Check(ActivationData activationData, License license)
        {
			if (activationData.Date > license.MaxActivations)
				return false;

			return true;
        }
	}
}