// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class NiTests
    {
        [TestCategory("NI Tests"), TestMethod]
        public void NationalInsurance2017()
        {
            // A
            var niCode = 'A';
            Assert.AreEqual(0.00m, LegacyShim(157.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.02m, LegacyShim(157.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(182.92m, LegacyShim(866.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(182.93m, LegacyShim(866.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(182.96m, LegacyShim(866.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(182.97m, LegacyShim(866.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(232.53m, LegacyShim(1180.00m, niCode, PayPeriods.Weekly, 2017));

            Assert.AreEqual(0.00m, LegacyShim(314.04m, niCode, PayPeriods.Fortnightly, 2017));
            Assert.AreEqual(0.02m, LegacyShim(314.05m, niCode, PayPeriods.Fortnightly, 2017));
            Assert.AreEqual(365.59m, LegacyShim(1731.04m, niCode, PayPeriods.Fortnightly, 2017));
            Assert.AreEqual(365.60m, LegacyShim(1731.05m, niCode, PayPeriods.Fortnightly, 2017));
            Assert.AreEqual(365.63m, LegacyShim(1731.29m, niCode, PayPeriods.Fortnightly, 2017));
            Assert.AreEqual(365.64m, LegacyShim(1731.30m, niCode, PayPeriods.Fortnightly, 2017));
            Assert.AreEqual(494.20m, LegacyShim(2545m, niCode, PayPeriods.Fortnightly, 2017));

            Assert.AreEqual(0.00m, LegacyShim(628.04m, niCode, PayPeriods.FourWeekly, 2017));
            Assert.AreEqual(0.02m, LegacyShim(628.05m, niCode, PayPeriods.FourWeekly, 2017));
            Assert.AreEqual(731.17m, LegacyShim(3462.04m, niCode, PayPeriods.FourWeekly, 2017));
            Assert.AreEqual(731.18m, LegacyShim(3462.05m, niCode, PayPeriods.FourWeekly, 2017));
            Assert.AreEqual(731.21m, LegacyShim(3462.29m, niCode, PayPeriods.FourWeekly, 2017));
            Assert.AreEqual(731.22m, LegacyShim(3462.30m, niCode, PayPeriods.FourWeekly, 2017));
            Assert.AreEqual(950.47m, LegacyShim(4850m, niCode, PayPeriods.FourWeekly, 2017));
            
            Assert.AreEqual(0.00m, LegacyShim(680.04m, niCode, PayPeriods.Monthly, 2017));
            Assert.AreEqual(0.02m, LegacyShim(680.05m, niCode, PayPeriods.Monthly, 2017));
            Assert.AreEqual(792.06m, LegacyShim(3750.04m, niCode, PayPeriods.Monthly, 2017));
            Assert.AreEqual(792.07m, LegacyShim(3750.05m, niCode, PayPeriods.Monthly, 2017));
            Assert.AreEqual(792.10m, LegacyShim(3750.29m, niCode, PayPeriods.Monthly, 2017));
            Assert.AreEqual(792.11m, LegacyShim(3750.30m, niCode, PayPeriods.Monthly, 2017));
            Assert.AreEqual(1068.56m, LegacyShim(5500m, niCode, PayPeriods.Monthly, 2017));

            // B
            niCode = 'B';
            Assert.AreEqual(0.00m, LegacyShim(157.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.01m, LegacyShim(157.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.01m, LegacyShim(157.10m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.02m, LegacyShim(157.11m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(139.32m, LegacyShim(866.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(139.33m, LegacyShim(866.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(139.36m, LegacyShim(866.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(139.37m, LegacyShim(866.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(188.93m, LegacyShim(1180m, niCode, PayPeriods.Weekly, 2017));

            // C
            niCode = 'C';
            Assert.AreEqual(0.00m, LegacyShim(157.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.01m, LegacyShim(157.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(97.84m, LegacyShim(866.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(97.85m, LegacyShim(866.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(141.17m, LegacyShim(1180m, niCode, PayPeriods.Weekly, 2017));

            // H
            niCode = 'H';
            Assert.AreEqual(0.00m, LegacyShim(157.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.01m, LegacyShim(157.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.08m, LegacyShim(866.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.09m, LegacyShim(866.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.12m, LegacyShim(866.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.13m, LegacyShim(866.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(134.69m, LegacyShim(1180m, niCode, PayPeriods.Weekly, 2017));

            // J
            niCode = 'J';
            Assert.AreEqual(0.00m, LegacyShim(157.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.01m, LegacyShim(157.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.04m, LegacyShim(157.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.05m, LegacyShim(157.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(112.02m, LegacyShim(866.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(112.03m, LegacyShim(866.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(112.06m, LegacyShim(866.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(112.07m, LegacyShim(866.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(161.63m, LegacyShim(1180m, niCode, PayPeriods.Weekly, 2017));

            // M
            niCode = 'M';
            Assert.AreEqual(0.00m, LegacyShim(157.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.01m, LegacyShim(157.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.08m, LegacyShim(866.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.09m, LegacyShim(866.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.12m, LegacyShim(866.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.13m, LegacyShim(866.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(134.69m, LegacyShim(1180m, niCode, PayPeriods.Weekly, 2017));

            // J
            niCode = 'Z';
            Assert.AreEqual(0.00m, LegacyShim(157.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.01m, LegacyShim(157.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(14.18m, LegacyShim(866.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(14.19m, LegacyShim(866.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(14.22m, LegacyShim(866.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(14.23m, LegacyShim(866.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(63.79m, LegacyShim(1180m, niCode, PayPeriods.Weekly, 2017));
        }
    }
}
