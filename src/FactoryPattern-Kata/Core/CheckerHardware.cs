namespace FactoryPattern_Kata
{
	public class CheckerHardware : IChecker
	{
		public bool Check(ActivationData activationData, License license)
        {
			if (activationData.Date > license.MaxActivations)
				return false;

			if(license.Activations.Count >= license.LimitOfActivations)
            {
				return false;
            }

			return true;
        }
	}
}