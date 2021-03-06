﻿// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Engines;
using Cedita.Payroll.Engines.NationalInsurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Cedita.Payroll.Tests
{
    [TestClass]
    public partial class NiTests
    {
        protected Dictionary<int, INiCalculationEngine> CalcEngines = new Dictionary<int, INiCalculationEngine>();

        protected decimal TestShim(decimal gross, char niCode, PayPeriods periods, int year)
        {
            if (!CalcEngines.ContainsKey(year))
            {
                CalcEngines.Add(year, DefaultEngineResolver.GetEngine<INiCalculationEngine>(year));
                CalcEngines[year].SetTaxYearSpecificsProvider(new JsonTaxYearSpecificProvider());
                CalcEngines[year].SetTaxYear(year);
            }

            var result = CalcEngines[year].CalculateNationalInsurance(gross, niCode, periods);
            return result.EmployeeNi + result.EmployerNi;
        }
    }
}
