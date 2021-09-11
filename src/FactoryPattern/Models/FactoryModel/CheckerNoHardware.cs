namespace FactoryPattern_Kata {
    public class CheckerNoHardware : IChecker {
        public bool Check(ActivationData activationData, License licenseData) {
            if(activationData.Date > licenseData.MaxActivations) {
                return false;
            } else {
                return true;
            }
        }
    }
}