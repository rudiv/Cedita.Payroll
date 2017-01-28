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
    }
}
