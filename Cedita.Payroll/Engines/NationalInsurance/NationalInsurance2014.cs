﻿// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Models.TaxYearSpecifics;
using System;

namespace Cedita.Payroll.Engines.NationalInsurance
{
    [EngineApplicableTaxYear(TaxYearStartYear = 2014)]
    public class NationalInsurance2014 : NationalInsuranceCalculationEngine
    {
        public override NationalInsuranceCalculation CalculateNationalInsurance(decimal gross, char niCategory, PayPeriods periods)
        {
            int periodCnt = 52;
            int weeksInPeriod = 1;
            if (periods == PayPeriods.Monthly)
                periodCnt = 12;
            else
                weeksInPeriod = (int)Math.Round((decimal)periodCnt / (int)periods);

            var totalPT = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.PrimaryThreshold);
            var totalST = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.SecondaryThreshold);
            var totalUAP = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.UpperAccrualPoint);
            var totalUEL = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.UpperEarningsLimit);
            var totalLEL = TaxYearSpecificProvider.GetSpecificValue<decimal>(TaxYearSpecificValues.LowerEarningsLimit);
            var niRates = TaxYearSpecificProvider.GetCodeSpecifics(niCategory);

            decimal periodPT = TaxMath.PeriodRound(TaxMath.Factor(totalPT, weeksInPeriod, periodCnt), weeksInPeriod),
                periodST = TaxMath.PeriodRound(TaxMath.Factor(totalST, weeksInPeriod, periodCnt), weeksInPeriod),
                periodUAP = TaxMath.PeriodRound(TaxMath.Factor(totalUAP, weeksInPeriod, periodCnt), weeksInPeriod),
                periodUEL = TaxMath.PeriodRound(TaxMath.Factor(totalUEL, weeksInPeriod, periodCnt), weeksInPeriod),
                periodLEL = TaxMath.PeriodRound(TaxMath.Factor(totalLEL, weeksInPeriod, periodCnt), weeksInPeriod);

            var niCalc = new NationalInsuranceCalculation();

            // Employee NI Gross
            niCalc.EmployeeNiGross = TaxMath.HmrcRound(SubtractRound(gross, periodUAP, periodPT) * (niRates.EeD / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(SubtractRound(gross, periodUEL, periodUAP) * (niRates.EeE / 100));
            niCalc.EmployeeNiGross += TaxMath.HmrcRound(SubtractRound(gross, gross, periodUEL) * (niRates.EeF / 100));

            niCalc.EmployeeNiRebate = TaxMath.HmrcRound(SubtractRound(gross, periodST, periodLEL) * (niRates.EeB / 100));
            niCalc.EmployeeNiRebate += TaxMath.HmrcRound(SubtractRound(gross, periodPT, periodST) * (niRates.EeC / 100));

            // Employer NI Gross
            niCalc.EmployerNiGross = TaxMath.HmrcRound(SubtractRound(gross, periodPT, periodST) * (niRates.ErC / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(SubtractRound(gross, periodUAP, periodPT) * (niRates.ErD / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(SubtractRound(gross, periodUEL, periodUAP) * (niRates.ErE / 100));
            niCalc.EmployerNiGross += TaxMath.HmrcRound(SubtractRound(gross, gross, periodUEL) * (niRates.ErF / 100));

            niCalc.EmployerNiRebate = TaxMath.HmrcRound(SubtractRound(gross, periodST, periodLEL) * (niRates.ErB / 100));

            return niCalc;
        }
    }
}
