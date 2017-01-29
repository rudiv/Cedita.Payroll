// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class NiTests
    {
        [TestCategory("NI Tests"), TestMethod]
        public void NationalInsurance2014()
        {
            // A
            Assert.AreEqual(0.00m, LegacyShim(153.04m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.02m, LegacyShim(153.05m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(159.19m, LegacyShim(770.04m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(159.21m, LegacyShim(770.05m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(168.22m, LegacyShim(805.04m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(168.23m, LegacyShim(805.05m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(168.26m, LegacyShim(805.29m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(168.27m, LegacyShim(805.30m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(227.47m, LegacyShim(1180.00m, 'A', PayPeriods.Weekly, 2014));

            // B
            Assert.AreEqual(0.00m, LegacyShim(153.04m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.01m, LegacyShim(153.05m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.01m, LegacyShim(153.10m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.02m, LegacyShim(153.11m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(121.24m, LegacyShim(770.04m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(121.25m, LegacyShim(770.05m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(121.25m, LegacyShim(770.10m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(121.26m, LegacyShim(770.11m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(128.12m, LegacyShim(805.04m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(128.13m, LegacyShim(805.05m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(128.16m, LegacyShim(805.29m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(128.17m, LegacyShim(805.30m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(187.37m, LegacyShim(1180.00m, 'B', PayPeriods.Weekly, 2014));

            // C
            Assert.AreEqual(0.00m, LegacyShim(153.04m, 'C', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.01m, LegacyShim(153.05m, 'C', PayPeriods.Weekly, 2014));
            Assert.AreEqual(85.15m, LegacyShim(770.04m, 'C', PayPeriods.Weekly, 2014));
            Assert.AreEqual(85.16m, LegacyShim(770.05m, 'C', PayPeriods.Weekly, 2014));
            Assert.AreEqual(89.98m, LegacyShim(805.04m, 'C', PayPeriods.Weekly, 2014));
            Assert.AreEqual(89.99m, LegacyShim(805.05m, 'C', PayPeriods.Weekly, 2014));
            Assert.AreEqual(141.73m, LegacyShim(1180.00m, 'C', PayPeriods.Weekly, 2014));

            // J
            Assert.AreEqual(0.00m, LegacyShim(153.04m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.01m, LegacyShim(153.05m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.04m, LegacyShim(153.29m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.05m, LegacyShim(153.30m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(97.49m, LegacyShim(770.04m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(97.50m, LegacyShim(770.05m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(97.53m, LegacyShim(770.29m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(97.54m, LegacyShim(770.30m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(103.02m, LegacyShim(805.04m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(103.03m, LegacyShim(805.05m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(103.06m, LegacyShim(805.29m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(103.07m, LegacyShim(805.30m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(162.27m, LegacyShim(1180.00m, 'J', PayPeriods.Weekly, 2014));

            // Fortnightly
            Assert.AreEqual(0.00m, LegacyShim(306.04m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(0.02m, LegacyShim(306.05m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(318.37m, LegacyShim(1540.04m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(318.39m, LegacyShim(1540.05m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(336.69m, LegacyShim(1611.04m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(336.70m, LegacyShim(1611.05m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(336.73m, LegacyShim(1611.29m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(336.74m, LegacyShim(1611.30m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(484.26m, LegacyShim(2545.00m, 'A', PayPeriods.Fortnightly, 2014));

            // FourWeekly
            Assert.AreEqual(0.00m, LegacyShim(612.04m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(0.02m, LegacyShim(612.05m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(636.74m, LegacyShim(3080.04m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(636.76m, LegacyShim(3080.05m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(673.12m, LegacyShim(3221.04m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(673.13m, LegacyShim(3221.05m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(673.16m, LegacyShim(3221.29m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(673.17m, LegacyShim(3221.30m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(930.50m, LegacyShim(4850.00m, 'A', PayPeriods.FourWeekly, 2014));
            
            // Monthly
            Assert.AreEqual(0.00m, LegacyShim(663.04m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(0.02m, LegacyShim(663.05m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(689.89m, LegacyShim(3337.04m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(689.91m, LegacyShim(3337.05m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(729.11m, LegacyShim(3489.04m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(729.12m, LegacyShim(3489.05m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(729.15m, LegacyShim(3489.29m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(729.16m, LegacyShim(3489.30m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(1046.85m, LegacyShim(5500.00m, 'A', PayPeriods.Monthly, 2014));
        }
    }
}
