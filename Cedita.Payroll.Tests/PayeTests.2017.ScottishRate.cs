// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cedita.Payroll.Tests
{
    public partial class PayeTests
    {
        [TestCategory("PAYE Tests"), TestMethod]
        public void ScottishRatePayeCalculations2017()
        {
            // General Tax Rate
            Assert.AreEqual(0m, LegacyShim(39.24m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(0.20m, LegacyShim(39.25m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(532m, LegacyShim(2699.24m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(532.20m, LegacyShim(2699.25m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(532.23m, LegacyShim(2699.26m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(4467.43m, LegacyShim(12538.24m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(4467.83m, LegacyShim(12538.25m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(4467.83m, LegacyShim(12538.26m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(4468.28m, LegacyShim(12539.25m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));

            Assert.AreEqual(122.80m, LegacyShim(623.82m, "S45L", PayPeriods.Weekly, 1, 0, 0, false, 2017));
            Assert.AreEqual(123m, LegacyShim(623.83m, "S45L", PayPeriods.Weekly, 1, 0, 0, false, 2017));
            Assert.AreEqual(123.19m, LegacyShim(623.84m, "S45L", PayPeriods.Weekly, 1, 0, 0, false, 2017));
            Assert.AreEqual(1030.79m, LegacyShim(2893.82m, "S45L", PayPeriods.Weekly, 1, 0, 0, false, 2017));
            Assert.AreEqual(1031.19m, LegacyShim(2893.83m, "S45L", PayPeriods.Weekly, 1, 0, 0, false, 2017));
            Assert.AreEqual(1031.21m, LegacyShim(2893.84m, "S45L", PayPeriods.Weekly, 1, 0, 0, false, 2017));

            // Scottish to rUK
            Assert.AreEqual(584.23m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(584.63m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 2, 2830 * 1, 584.23m, false, 2017));
            Assert.AreEqual(584.64m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 3, 2830 * 2, 1168.86m, false, 2017));
            Assert.AreEqual(584.63m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 4, 2830 * 3, 1753.50m, false, 2017));
            Assert.AreEqual(584.23m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 5, 2830 * 4, 2338.13m, false, 2017));
            Assert.AreEqual(584.64m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 6, 2830 * 5, 2922.36m, false, 2017));
            Assert.AreEqual(401.46m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 7, 2830 * 6, 3507m, false, 2017));
            Assert.AreEqual(558.34m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 8, 2830 * 7, 3908.46m, false, 2017));
            Assert.AreEqual(558.20m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 9, 2830 * 8, 4466.80m, false, 2017));
            Assert.AreEqual(558.46m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 10, 2830 * 9, 5025m, false, 2017));
            Assert.AreEqual(558.47m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 11, 2830 * 10, 5583.46m, false, 2017));
            Assert.AreEqual(558.47m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 12, 2830 * 11, 6141.93m, false, 2017));

            // rUK to Scottish
            Assert.AreEqual(558.20m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 1, 0, 0, false, 2017));
            Assert.AreEqual(558.40m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 2, 2830 * 1, 558.20m, false, 2017));
            Assert.AreEqual(558.40m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 3, 2830 * 2, 1116.60m, false, 2017));
            Assert.AreEqual(558.40m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 4, 2830 * 3, 1675m, false, 2017));
            Assert.AreEqual(558.20m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 5, 2830 * 4, 2233.40m, false, 2017));
            Assert.AreEqual(558.40m, LegacyShim(2830m, "45L", PayPeriods.Monthly, 6, 2830 * 5, 2791.60m, false, 2017));
            Assert.AreEqual(741.63m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 7, 2830 * 6, 3350m, false, 2017));
            Assert.AreEqual(584.63m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 8, 2830 * 7, 4091.63m, false, 2017));
            Assert.AreEqual(584.24m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 9, 2830 * 8, 4676.26m, false, 2017));
            Assert.AreEqual(584.63m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 10, 2830 * 9, 5260.50m, false, 2017));
            Assert.AreEqual(584.63m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 11, 2830 * 10, 5845.13m, false, 2017));
            Assert.AreEqual(584.64m, LegacyShim(2830m, "S45L", PayPeriods.Monthly, 12, 2830 * 11, 6429.76m, false, 2017));
        }
    }
}
