// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class NiTests
    {
        [TestCategory("NI Tests"), TestMethod]
        public void NationalInsurance2015()
        {
            // A
            var niCode = 'A';
            Assert.AreEqual(0.00m, TestShim(155.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.01m, TestShim(155.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.12m, TestShim(156.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.14m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(158.53m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(158.55m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(170.14m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(170.15m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(170.18m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(170.19m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(227.81m, TestShim(1180.00m, niCode, PayPeriods.Weekly, 2015));

            Assert.AreEqual(0.00m, TestShim(310.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.01m, TestShim(310.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.24m, TestShim(312.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(0.26m, TestShim(312.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(317.06m, TestShim(1540.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(317.08m, TestShim(1540.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(340.54m, TestShim(1631.04m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(340.55m, TestShim(1631.05m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(340.58m, TestShim(1631.29m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(340.59m, TestShim(1631.30m, niCode, PayPeriods.Fortnightly, 2015));
            Assert.AreEqual(484.95m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2015));

            Assert.AreEqual(0.00m, TestShim(620.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.01m, TestShim(620.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.48m, TestShim(624.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(0.50m, TestShim(624.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(634.13m, TestShim(3080.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(634.15m, TestShim(3080.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(680.83m, TestShim(3261.04m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(680.84m, TestShim(3261.05m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(680.87m, TestShim(3261.29m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(680.88m, TestShim(3261.30m, niCode, PayPeriods.FourWeekly, 2015));
            Assert.AreEqual(931.89m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2015));
            
            Assert.AreEqual(0.00m, TestShim(672.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.01m, TestShim(672.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.48m, TestShim(676.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(0.50m, TestShim(676.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(687.02m, TestShim(3337.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(687.04m, TestShim(3337.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(737.33m, TestShim(3532.04m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(737.34m, TestShim(3532.05m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(737.37m, TestShim(3532.29m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(737.38m, TestShim(3532.30m, niCode, PayPeriods.Monthly, 2015));
            Assert.AreEqual(1048.27m, TestShim(5500m, niCode, PayPeriods.Monthly, 2015));

            // B
            niCode = 'B';
            Assert.AreEqual(0.00m, TestShim(155.10m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.01m, TestShim(155.11m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.06m, TestShim(156.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.07m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(120.71m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(120.72m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(120.72m, TestShim(770.10m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(120.73m, TestShim(770.11m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(129.55m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(129.56m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(129.59m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(129.60m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(187.22m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            // C
            niCode = 'C';
            Assert.AreEqual(0.00m, TestShim(156.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.01m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(84.73m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(84.74m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(90.94m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(90.95m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(141.31m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            // D
            niCode = 'D';
            Assert.AreEqual(0.00m, TestShim(112.17m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.18m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.42m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.02m, TestShim(112.43m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.06m, TestShim(155.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.05m, TestShim(155.06m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.98m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.96m, TestShim(156.06m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(126.96m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(126.98m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(138.57m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(138.58m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(138.61m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(138.62m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(196.24m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            // E
            niCode = 'E';
            Assert.AreEqual(0.00m, TestShim(112.17m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.18m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.46m, TestShim(155.10m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.45m, TestShim(155.11m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.43m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.42m, TestShim(156.06m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(98.35m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(98.36m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(98.36m, TestShim(770.10m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(98.37m, TestShim(770.11m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(107.19m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(107.20m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(107.23m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(107.24m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(164.86m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            // I
            niCode = 'I';
            Assert.AreEqual(0.00m, TestShim(112.17m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.18m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.42m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.02m, TestShim(112.43m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.06m, TestShim(155.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.05m, TestShim(155.06m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.96m, TestShim(156.17m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-1.97m, TestShim(156.18m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(15.58m, TestShim(400m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(42.22m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(42.23m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(47.62m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(47.63m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(47.66m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(47.67m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(105.29m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            // J
            niCode = 'J';
            Assert.AreEqual(0.00m, TestShim(155.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.01m, TestShim(155.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.02m, TestShim(156.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.03m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(97.03m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(97.04m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(97.07m, TestShim(770.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(97.08m, TestShim(770.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(104.14m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(104.15m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(104.18m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(104.19m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(161.81m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            // I
            niCode = 'K';
            Assert.AreEqual(0.00m, TestShim(112.17m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.18m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.42m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.02m, TestShim(112.43m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.07m, TestShim(155.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.06m, TestShim(155.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.07m, TestShim(156.17m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.08m, TestShim(156.18m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-5.49m, TestShim(400m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-10.67m, TestShim(770.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-10.66m, TestShim(770.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-9.77m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-9.76m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-9.73m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-9.72m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(47.90m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            // L
            niCode = 'L';
            Assert.AreEqual(0.00m, TestShim(112.17m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.18m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.01m, TestShim(112.42m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-0.02m, TestShim(112.43m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.07m, TestShim(155.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.06m, TestShim(155.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.07m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(-2.06m, TestShim(156.06m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(74.07m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(74.08m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(74.11m, TestShim(770.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(74.12m, TestShim(770.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(81.18m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(81.19m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(81.22m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(81.23m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(138.85m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            // M
            niCode = 'M';
            Assert.AreEqual(0.00m, TestShim(155.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.01m, TestShim(155.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(73.80m, TestShim(770.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(73.81m, TestShim(770.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(79.20m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(79.21m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(79.24m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(79.25m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(136.87m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));

            // Z
            niCode = 'Z';
            Assert.AreEqual(0.00m, TestShim(155.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(0.01m, TestShim(155.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(12.30m, TestShim(770.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(12.31m, TestShim(770.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(13.20m, TestShim(815.04m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(13.21m, TestShim(815.05m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(13.24m, TestShim(815.29m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(13.25m, TestShim(815.30m, niCode, PayPeriods.Weekly, 2015));
            Assert.AreEqual(70.87m, TestShim(1180m, niCode, PayPeriods.Weekly, 2015));
        }
    }
}
