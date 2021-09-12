using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryPattern_Kata.Test
{
    [TestClass]
    public class SampleTests
    {
        private List<string> hardwareIdList = new List<string>() { "4D:DD:4E:44:B3:D3", "58:D9:A5:D5:5A:6F", "CD:7B:A6:CC:D7:54" };

        public void 
        {
            var licenseData = new License(
                    LicenseType.NoCheck,
                    new DateTime(2019, 12, 31),
                    0,
                    hardwareIdList);
            var activationData = new ActivationData(new DateTime(2019, 5, 24), "71:32:82:AE:2C:C6");

            var result = LicenseManager.CheckActivation(activationData, licenseData);

            Assert.True(result);
        }

        [TestMethod]
        public void Check_activation_returns_true_with_no_hardware_check_and_not_expired()
    {
            var licenseData = new License(
                   LicenseType.NoCheck,
                   new DateTime(2019, 12, 31),
                   0,
                   hardwareIdList);
            var activationData = new ActivationData(new DateTime(2019, 5, 24), "71:32:82:AE:2C:C6");

            var result = LicenseManager.CheckActivation(activationData, licenseData);

            Assert.True(result);
        }
    }
}
