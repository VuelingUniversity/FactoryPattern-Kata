namespace FactoryPattern_Kata
{
    public class CheckerHardware : IChecker
    {
        public bool Check(ActivationData activation_data, License license_data)
        {
            if (license_data.Activations.Count == license_data.LimitOfActivations &&
                !license_data.Activations.Contains(activation_data.HardwareId))
            {
                return false;
            }

            if(activation_data.Date > license_data.MaxActivations)
            {
                return false;
            }

            return true;
        }
    }
}