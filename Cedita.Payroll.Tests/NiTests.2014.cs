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
            Assert.AreEqual(0.00m, TestShim(153.04m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.02m, TestShim(153.05m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(159.19m, TestShim(770.04m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(159.21m, TestShim(770.05m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(168.22m, TestShim(805.04m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(168.23m, TestShim(805.05m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(168.26m, TestShim(805.29m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(168.27m, TestShim(805.30m, 'A', PayPeriods.Weekly, 2014));
            Assert.AreEqual(227.47m, TestShim(1180.00m, 'A', PayPeriods.Weekly, 2014));

            // B
            Assert.AreEqual(0.00m, TestShim(153.04m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.01m, TestShim(153.05m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.01m, TestShim(153.10m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.02m, TestShim(153.11m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(121.24m, TestShim(770.04m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(121.25m, TestShim(770.05m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(121.25m, TestShim(770.10m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(121.26m, TestShim(770.11m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(128.12m, TestShim(805.04m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(128.13m, TestShim(805.05m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(128.16m, TestShim(805.29m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(128.17m, TestShim(805.30m, 'B', PayPeriods.Weekly, 2014));
            Assert.AreEqual(187.37m, TestShim(1180.00m, 'B', PayPeriods.Weekly, 2014));

            // C
            Assert.AreEqual(0.00m, TestShim(153.04m, 'C', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.01m, TestShim(153.05m, 'C', PayPeriods.Weekly, 2014));
            Assert.AreEqual(85.15m, TestShim(770.04m, 'C', PayPeriods.Weekly, 2014));
            Assert.AreEqual(85.16m, TestShim(770.05m, 'C', PayPeriods.Weekly, 2014));
            Assert.AreEqual(89.98m, TestShim(805.04m, 'C', PayPeriods.Weekly, 2014));
            Assert.AreEqual(89.99m, TestShim(805.05m, 'C', PayPeriods.Weekly, 2014));
            Assert.AreEqual(141.73m, TestShim(1180.00m, 'C', PayPeriods.Weekly, 2014));

            // J
            Assert.AreEqual(0.00m, TestShim(153.04m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.01m, TestShim(153.05m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.04m, TestShim(153.29m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(0.05m, TestShim(153.30m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(97.49m, TestShim(770.04m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(97.50m, TestShim(770.05m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(97.53m, TestShim(770.29m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(97.54m, TestShim(770.30m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(103.02m, TestShim(805.04m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(103.03m, TestShim(805.05m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(103.06m, TestShim(805.29m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(103.07m, TestShim(805.30m, 'J', PayPeriods.Weekly, 2014));
            Assert.AreEqual(162.27m, TestShim(1180.00m, 'J', PayPeriods.Weekly, 2014));

            // Fortnightly
            Assert.AreEqual(0.00m, TestShim(306.04m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(0.02m, TestShim(306.05m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(318.37m, TestShim(1540.04m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(318.39m, TestShim(1540.05m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(336.69m, TestShim(1611.04m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(336.70m, TestShim(1611.05m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(336.73m, TestShim(1611.29m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(336.74m, TestShim(1611.30m, 'A', PayPeriods.Fortnightly, 2014));
            Assert.AreEqual(484.26m, TestShim(2545.00m, 'A', PayPeriods.Fortnightly, 2014));

            // FourWeekly
            Assert.AreEqual(0.00m, TestShim(612.04m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(0.02m, TestShim(612.05m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(636.74m, TestShim(3080.04m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(636.76m, TestShim(3080.05m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(673.12m, TestShim(3221.04m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(673.13m, TestShim(3221.05m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(673.16m, TestShim(3221.29m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(673.17m, TestShim(3221.30m, 'A', PayPeriods.FourWeekly, 2014));
            Assert.AreEqual(930.50m, TestShim(4850.00m, 'A', PayPeriods.FourWeekly, 2014));
            
            // Monthly
            Assert.AreEqual(0.00m, TestShim(663.04m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(0.02m, TestShim(663.05m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(689.89m, TestShim(3337.04m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(689.91m, TestShim(3337.05m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(729.11m, TestShim(3489.04m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(729.12m, TestShim(3489.05m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(729.15m, TestShim(3489.29m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(729.16m, TestShim(3489.30m, 'A', PayPeriods.Monthly, 2014));
            Assert.AreEqual(1046.85m, TestShim(5500.00m, 'A', PayPeriods.Monthly, 2014));
        }
    }
}
