// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using Cedita.Payroll.Models;
using System;

namespace Cedita.Payroll
{
    public static class TaxDate
    {
        /// <summary>
        /// Get the <see cref="TaxPeriod"/> for this <see cref="DateTime"/>
        /// </summary>
        /// <param name="date"><see cref="DateTime"/></param>
        /// <returns><see cref="TaxPeriod"/> for <paramref name="date"/></returns>
        public static TaxPeriod TaxPeriod(this DateTime date)
        {
            return GetTaxPeriod(date);
        }

        public static TaxPeriod GetTaxPeriod(DateTime date)
        {
            var origDate = date;
            var year = date.Year;
            if (date.Month < 4 || (date.Month == 4 && date.Day < 6))
                year--;

            var taxYearStart = new DateTime(year, 4, 6);
            var span = date - taxYearStart;

            var week = (int)Math.Floor(span.Days / 7d) + 1;
            var fortnight = week / 2;
            var fourweek = week / 4;

            if (date.Day < 6)
                date = date.AddMonths(-1);

            var monthDiff = date.Month - 3;
            var yearDiff = date.Year - year;
            var month = (yearDiff * 12) + monthDiff;

            return new TaxPeriod(origDate, year, week, fortnight, fourweek, month);
        }
    }
}
