namespace FactoryPattern_Kata
{
    public class CheckerNoHardware : IChecker
    {
        public bool Check(ActivationData activation_data, License license_data)
        {
            if (activation_data.Date > license_data.MaxActivations)
                return false;
            else
                return true;
        }
    }
}