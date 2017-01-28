// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using System;
using System.Collections.Generic;

namespace Cedita.Payroll.Engines.Paye
{
    [EngineApplicableTaxYear(TaxYearStartYear = 2014)]
    public class PayeVersion12 : IPayeCalculationEngine
    {
        protected Dictionary<Tuple<int, int, int>, PayeInternalBracket> BracketStore { get; set; }
        public PayeInternalBracket GetBracket(int year, int period, int periods)
        {
            return new PayeInternalBracket();
        }

        public void SetTaxYearSpecificsProvider(IProvideTaxYearSpecifics provider)
        {
            throw new NotImplementedException();
        }
    }
}
