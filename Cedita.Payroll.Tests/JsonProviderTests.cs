// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cedita.Payroll.Engines;
using System.Linq;

namespace Cedita.Payroll.Tests
{
    [TestClass]
    public class JsonProviderTests
    {
        private IProvideTaxYearSpecifics _provider = new JsonTaxYearSpecificProvider();

        [TestCategory("JSON Provider Tests"), TestMethod]
        public void JsonBracketProvision()
        {
            var provider = new JsonTaxYearSpecificProvider();
            provider.SetTaxYear(2015);

            var brackets = provider.GetTaxBrackets();

            Assert.AreEqual(31785, brackets.First().To);
        }
    }
}
