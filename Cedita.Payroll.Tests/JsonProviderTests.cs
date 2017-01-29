// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cedita.Payroll.Engines;
using System.Linq;
using Cedita.Payroll.Models.TaxYearSpecifics;

namespace Cedita.Payroll.Tests
{
    [TestClass]
    public class JsonProviderTests
    {
        private IProvideTaxYearSpecifics _provider = new JsonTaxYearSpecificProvider();

        [TestCategory("JSON Provider Tests"), TestMethod]
        public void DefaultJsonProviderTest()
        {
            var provider = new JsonTaxYearSpecificProvider();
            provider.SetTaxYear(2015);

            var brackets = provider.GetTaxBrackets();
            Assert.AreEqual(31785, brackets.First().To);
            Assert.AreEqual(150000, brackets.Last().From);

            var niCodeA = provider.GetCodeSpecifics('A');
            Assert.AreEqual(12, niCodeA.EeD);
            Assert.AreEqual(13.8m, niCodeA.ErF);

            var fixedCode = provider.GetFixedCode("NT");
            Assert.AreEqual(0, fixedCode.Rate);

            Assert.AreEqual("1060L", provider.GetSpecificValue<string>(TaxYearSpecificValues.DefaultTaxCode));
            Assert.AreEqual(40040, provider.GetSpecificValue<decimal>(TaxYearSpecificValues.UpperAccrualPoint));
            Assert.AreEqual(0.6m, provider.GetSpecificValue<decimal>(TaxYearSpecificValues.DeaProtectedEarnings));

            // Check that we can change tax years
            provider.SetTaxYear(2017);
            brackets = provider.GetTaxBrackets();
            Assert.AreNotEqual(31785, brackets.First().To);

            niCodeA = provider.GetCodeSpecifics('A');
            Assert.AreEqual(2, niCodeA.EeD);
            Assert.AreEqual(0, niCodeA.ErF);

            fixedCode = provider.GetFixedCode("BR");
            Assert.AreEqual(0.2m, fixedCode.Rate);

            Assert.AreEqual("1150L", provider.GetSpecificValue<string>(TaxYearSpecificValues.DefaultTaxCode));
            Assert.AreEqual(8164, provider.GetSpecificValue<decimal>(TaxYearSpecificValues.PrimaryThreshold));
        }
    }
}
