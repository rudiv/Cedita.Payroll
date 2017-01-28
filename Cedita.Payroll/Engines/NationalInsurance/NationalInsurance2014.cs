// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

namespace Cedita.Payroll.Engines.NationalInsurance
{
    [EngineApplicableTaxYear(TaxYearStartYear = 2014)]
    [EngineApplicableTaxYear(TaxYearStartYear = 2015)]
    public class NationalInsurance2014 : INiCalculationEngine
    {
    }
}
