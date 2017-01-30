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
            Assert.AreEqual(0.00m, TestShim(157.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.02m, TestShim(157.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(182.92m, TestShim(866.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(182.93m, TestShim(866.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(182.96m, TestShim(866.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(182.97m, TestShim(866.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(232.53m, TestShim(1180.00m, niCode, PayPeriods.Weekly, 2017));

            Assert.AreEqual(0.00m, TestShim(314.04m, niCode, PayPeriods.Fortnightly, 2017));
            Assert.AreEqual(0.02m, TestShim(314.05m, niCode, PayPeriods.Fortnightly, 2017));
            Assert.AreEqual(365.59m, TestShim(1731.04m, niCode, PayPeriods.Fortnightly, 2017));
            Assert.AreEqual(365.60m, TestShim(1731.05m, niCode, PayPeriods.Fortnightly, 2017));
            Assert.AreEqual(365.63m, TestShim(1731.29m, niCode, PayPeriods.Fortnightly, 2017));
            Assert.AreEqual(365.64m, TestShim(1731.30m, niCode, PayPeriods.Fortnightly, 2017));
            Assert.AreEqual(494.20m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2017));

            Assert.AreEqual(0.00m, TestShim(628.04m, niCode, PayPeriods.FourWeekly, 2017));
            Assert.AreEqual(0.02m, TestShim(628.05m, niCode, PayPeriods.FourWeekly, 2017));
            Assert.AreEqual(731.17m, TestShim(3462.04m, niCode, PayPeriods.FourWeekly, 2017));
            Assert.AreEqual(731.18m, TestShim(3462.05m, niCode, PayPeriods.FourWeekly, 2017));
            Assert.AreEqual(731.21m, TestShim(3462.29m, niCode, PayPeriods.FourWeekly, 2017));
            Assert.AreEqual(731.22m, TestShim(3462.30m, niCode, PayPeriods.FourWeekly, 2017));
            Assert.AreEqual(950.47m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2017));
            
            Assert.AreEqual(0.00m, TestShim(680.04m, niCode, PayPeriods.Monthly, 2017));
            Assert.AreEqual(0.02m, TestShim(680.05m, niCode, PayPeriods.Monthly, 2017));
            Assert.AreEqual(792.06m, TestShim(3750.04m, niCode, PayPeriods.Monthly, 2017));
            Assert.AreEqual(792.07m, TestShim(3750.05m, niCode, PayPeriods.Monthly, 2017));
            Assert.AreEqual(792.10m, TestShim(3750.29m, niCode, PayPeriods.Monthly, 2017));
            Assert.AreEqual(792.11m, TestShim(3750.30m, niCode, PayPeriods.Monthly, 2017));
            Assert.AreEqual(1068.56m, TestShim(5500m, niCode, PayPeriods.Monthly, 2017));

            // B
            niCode = 'B';
            Assert.AreEqual(0.00m, TestShim(157.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.01m, TestShim(157.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.01m, TestShim(157.10m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.02m, TestShim(157.11m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(139.32m, TestShim(866.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(139.33m, TestShim(866.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(139.36m, TestShim(866.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(139.37m, TestShim(866.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(188.93m, TestShim(1180m, niCode, PayPeriods.Weekly, 2017));

            // C
            niCode = 'C';
            Assert.AreEqual(0.00m, TestShim(157.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.01m, TestShim(157.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(97.84m, TestShim(866.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(97.85m, TestShim(866.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(141.17m, TestShim(1180m, niCode, PayPeriods.Weekly, 2017));

            // H
            niCode = 'H';
            Assert.AreEqual(0.00m, TestShim(157.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.01m, TestShim(157.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.08m, TestShim(866.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.09m, TestShim(866.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.12m, TestShim(866.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.13m, TestShim(866.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(134.69m, TestShim(1180m, niCode, PayPeriods.Weekly, 2017));

            // J
            niCode = 'J';
            Assert.AreEqual(0.00m, TestShim(157.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.01m, TestShim(157.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.04m, TestShim(157.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.05m, TestShim(157.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(112.02m, TestShim(866.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(112.03m, TestShim(866.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(112.06m, TestShim(866.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(112.07m, TestShim(866.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(161.63m, TestShim(1180m, niCode, PayPeriods.Weekly, 2017));

            // M
            niCode = 'M';
            Assert.AreEqual(0.00m, TestShim(157.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.01m, TestShim(157.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.08m, TestShim(866.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.09m, TestShim(866.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.12m, TestShim(866.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(85.13m, TestShim(866.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(134.69m, TestShim(1180m, niCode, PayPeriods.Weekly, 2017));

            // J
            niCode = 'Z';
            Assert.AreEqual(0.00m, TestShim(157.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(0.01m, TestShim(157.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(14.18m, TestShim(866.04m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(14.19m, TestShim(866.05m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(14.22m, TestShim(866.29m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(14.23m, TestShim(866.30m, niCode, PayPeriods.Weekly, 2017));
            Assert.AreEqual(63.79m, TestShim(1180m, niCode, PayPeriods.Weekly, 2017));
        }
    }
}
