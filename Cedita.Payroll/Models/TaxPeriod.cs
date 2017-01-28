// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using System;

namespace Cedita.Payroll.Models
{
    /// <summary>
    /// <see cref="TaxPeriod"/> represents a tax period for a specific date
    /// </summary>
    public class TaxPeriod
    {
        public DateTime Date { get; }
        public int Year { get; }
        public int Week { get; }
        public int Fortnight { get; }
        public int FourWeek { get; }
        public int Month { get; }

        public TaxPeriod(DateTime date, int year, int week, int fortnight, int fourweek, int month)
        {
            Date = date;
            Year = year;
            Week = week;
            Fortnight = fortnight;
            FourWeek = fourweek;
            Month = month;
        }

        public TaxPeriod(DateTime date)
        {
            Date = date;
            Year = date.Year;
            if (date.Month < 4 || (date.Month == 4 && date.Day < 6))
                Year--;

            var taxYearStart = new DateTime(Year, 4, 6);
            var span = date - taxYearStart;

            Week = (int)Math.Floor(span.Days / 7d) + 1;
            Fortnight = Week / 2;
            FourWeek = Week / 4;

            if (date.Day < 6)
                date = date.AddMonths(-1);

            var monthDiff = date.Month - 3;
            var yearDiff = date.Year - Year;
            Month = (yearDiff * 12) + monthDiff;
        }
    }
}
