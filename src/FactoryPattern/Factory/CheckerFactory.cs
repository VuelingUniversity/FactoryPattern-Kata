using System;
using System.Collections.Generic;

namespace FactoryPattern_Kata {
    public static class CheckerFactory {
        private static readonly Dictionary<LicenseType, IChecker> checkerCreators = new Dictionary<LicenseType, IChecker>{
        { LicenseType.NoCheck, new CheckerNoHardware() },
        { LicenseType.Check, new CheckerHardware() }
        };
        public static IChecker CreateChecker(LicenseType type) {
            return checkerCreators[type];
        }
    }
}