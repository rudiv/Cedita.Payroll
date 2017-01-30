// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class NiTests
    {
        [TestCategory("NI Tests"), TestMethod]
        public void NationalInsurance2016()
        {
            // A
            var niCode = 'A';
            Assert.AreEqual(0.00m, TestShim(155.04m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(0.01m, TestShim(155.05m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(0.12m, TestShim(156.04m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(0.14m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(173.24m, TestShim(827.04m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(173.25m, TestShim(827.05m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(173.28m, TestShim(827.29m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(173.29m, TestShim(827.30m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(229.01m, TestShim(1180.00m, niCode, PayPeriods.Weekly, 2016));

            Assert.AreEqual(0.00m, TestShim(310.04m, niCode, PayPeriods.Fortnightly, 2016));
            Assert.AreEqual(0.01m, TestShim(310.05m, niCode, PayPeriods.Fortnightly, 2016));
            Assert.AreEqual(0.24m, TestShim(312.04m, niCode, PayPeriods.Fortnightly, 2016));
            Assert.AreEqual(0.26m, TestShim(312.05m, niCode, PayPeriods.Fortnightly, 2016));
            Assert.AreEqual(346.48m, TestShim(1654.04m, niCode, PayPeriods.Fortnightly, 2016));
            Assert.AreEqual(346.49m, TestShim(1654.05m, niCode, PayPeriods.Fortnightly, 2016));
            Assert.AreEqual(346.52m, TestShim(1654.29m, niCode, PayPeriods.Fortnightly, 2016));
            Assert.AreEqual(346.53m, TestShim(1654.30m, niCode, PayPeriods.Fortnightly, 2016));
            Assert.AreEqual(487.26m, TestShim(2545m, niCode, PayPeriods.Fortnightly, 2016));

            Assert.AreEqual(0.00m, TestShim(620.04m, niCode, PayPeriods.FourWeekly, 2016));
            Assert.AreEqual(0.01m, TestShim(620.05m, niCode, PayPeriods.FourWeekly, 2016));
            Assert.AreEqual(0.48m, TestShim(624.04m, niCode, PayPeriods.FourWeekly, 2016));
            Assert.AreEqual(0.50m, TestShim(624.05m, niCode, PayPeriods.FourWeekly, 2016));
            Assert.AreEqual(692.95m, TestShim(3308.04m, niCode, PayPeriods.FourWeekly, 2016));
            Assert.AreEqual(692.96m, TestShim(3308.05m, niCode, PayPeriods.FourWeekly, 2016));
            Assert.AreEqual(692.99m, TestShim(3308.29m, niCode, PayPeriods.FourWeekly, 2016));
            Assert.AreEqual(693m, TestShim(3308.30m, niCode, PayPeriods.FourWeekly, 2016));
            Assert.AreEqual(936.59m, TestShim(4850m, niCode, PayPeriods.FourWeekly, 2016));
            
            Assert.AreEqual(0.00m, TestShim(672.04m, niCode, PayPeriods.Monthly, 2016));
            Assert.AreEqual(0.01m, TestShim(672.05m, niCode, PayPeriods.Monthly, 2016));
            Assert.AreEqual(0.48m, TestShim(676.04m, niCode, PayPeriods.Monthly, 2016));
            Assert.AreEqual(0.50m, TestShim(676.05m, niCode, PayPeriods.Monthly, 2016));
            Assert.AreEqual(750.49m, TestShim(3583.04m, niCode, PayPeriods.Monthly, 2016));
            Assert.AreEqual(750.50m, TestShim(3583.05m, niCode, PayPeriods.Monthly, 2016));
            Assert.AreEqual(750.53m, TestShim(3583.29m, niCode, PayPeriods.Monthly, 2016));
            Assert.AreEqual(750.54m, TestShim(3583.30m, niCode, PayPeriods.Monthly, 2016));
            Assert.AreEqual(1053.38m, TestShim(5500m, niCode, PayPeriods.Monthly, 2016));

            // B
            niCode = 'B';
            Assert.AreEqual(0.00m, TestShim(155.10m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(0.01m, TestShim(155.11m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(0.06m, TestShim(156.04m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(0.07m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(131.91m, TestShim(827.04m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(131.92m, TestShim(827.05m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(131.95m, TestShim(827.29m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(131.96m, TestShim(827.30m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(187.68m, TestShim(1180m, niCode, PayPeriods.Weekly, 2016));

            // C
            niCode = 'C';
            Assert.AreEqual(0.00m, TestShim(156.04m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(0.01m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(92.60m, TestShim(827.04m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(92.61m, TestShim(827.05m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(141.31m, TestShim(1180m, niCode, PayPeriods.Weekly, 2016));

            // H
            niCode = 'H';
            Assert.AreEqual(0.00m, TestShim(155.04m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(0.01m, TestShim(155.05m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(80.64m, TestShim(827.04m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(80.65m, TestShim(827.05m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(80.68m, TestShim(827.29m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(80.69m, TestShim(827.30m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(136.41m, TestShim(1180m, niCode, PayPeriods.Weekly, 2016));

            // J
            niCode = 'J';
            Assert.AreEqual(0.00m, TestShim(155.29m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(0.01m, TestShim(155.30m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(0.02m, TestShim(156.04m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(0.03m, TestShim(156.05m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(106.04m, TestShim(827.04m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(106.05m, TestShim(827.05m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(106.08m, TestShim(827.29m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(106.09m, TestShim(827.30m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(161.81m, TestShim(1180m, niCode, PayPeriods.Weekly, 2016));

            // M
            niCode = 'M';
            Assert.AreEqual(0.00m, TestShim(155.04m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(0.01m, TestShim(155.05m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(80.64m, TestShim(827.04m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(80.65m, TestShim(827.05m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(80.68m, TestShim(827.29m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(80.69m, TestShim(827.30m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(136.41m, TestShim(1180m, niCode, PayPeriods.Weekly, 2016));

            // Z
            niCode = 'Z';
            Assert.AreEqual(0.00m, TestShim(155.29m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(0.01m, TestShim(155.30m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(13.44m, TestShim(827.04m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(13.45m, TestShim(827.05m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(13.48m, TestShim(827.29m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(13.49m, TestShim(827.30m, niCode, PayPeriods.Weekly, 2016));
            Assert.AreEqual(69.21m, TestShim(1180m, niCode, PayPeriods.Weekly, 2016));
        }
    }
}
