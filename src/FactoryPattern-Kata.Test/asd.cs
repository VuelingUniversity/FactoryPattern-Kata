using System;
using System.Collections.Generic;
using Xunit;

namespace FactoryPattern_Kata
{
    public class SampleTests
    {
        private List<string> hardwareIdList = new List<string>() { "4D:DD:4E:44:B3:D3", "58:D9:A5:D5:5A:6F", "CD:7B:A6:CC:D7:54" };

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
        public void Check_activation_returns_false_with_no_hardware_check_and_expired()
        {
            var licenseData = new License(
                    LicenseType.NoCheck,
                    new DateTime(2019, 4, 30),
                    0,
                    hardwareIdList);
            var activationData = new ActivationData(new DateTime(2019, 5, 24), "71:32:82:AE:2C:C6");

            var result = LicenseManager.CheckActivation(activationData, licenseData);

            Assert.False(result);
        }

        public void Check_activation_returns_true_with_hardware_check()
        {
            var licenseData = new License(
                    LicenseType.Check,
                    new DateTime(2019, 12, 31),
                    10,
                    hardwareIdList);
            var activationData = new ActivationData(new DateTime(2019, 5, 24), "71:32:82:AE:2C:C6");

            var result = LicenseManager.CheckActivation(activationData, licenseData);

            Assert.True(result);
        }


        public void Check_activation_returns_false_with_hardware_check_and_expired()
        {
            var licenseData = new License(
                    LicenseType.Check,
                    new DateTime(2019, 4, 30),
                    10,
                    hardwareIdList);
            var activationData = new ActivationData(new DateTime(2019, 5, 24), "71:32:82:AE:2C:C6");

            var result = LicenseManager.CheckActivation(activationData, licenseData);

            Assert.False(result);
        }

        public void Check_activation_returns_false_with_hardware_check_and_maximum_activations_reached()
        {
            var licenseData = new License(
                    LicenseType.Check,
                    new DateTime(2019, 12, 31),
                    3,
                    hardwareIdList);
            var activationData = new ActivationData(new DateTime(2019, 5, 24), "71:32:82:AE:2C:C6");

            var result = LicenseManager.CheckActivation(activationData, licenseData);

            Assert.False(result);
        }

        public void Check_activation_returns_true_with_hardware_check_and_maximum_activations_reached_but_already_active()
        {
            var licenseData = new License(
                    LicenseType.Check,
                    new DateTime(2019, 12, 31),
                    3,
                    hardwareIdList);
            var activationData = new ActivationData(new DateTime(2019, 5, 24), "4D:DD:4E:44:B3:D3");

            var result = LicenseManager.CheckActivation(activationData, licenseData);

            Assert.True(result);
        }

    }
}
