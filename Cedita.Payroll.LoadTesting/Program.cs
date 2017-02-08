using Cedita.Payroll.Engines.Paye;
using Cedita.Payroll.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Cedita.Payroll.LoadTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Models.PayrollDataImport> importedRows;
            //using (var textReader = new StreamReader(File.OpenRead("PayrollTest-156731Src1.csv")))
            using (var textReader = new StreamReader(File.OpenRead("PayrollTest-42627Src2.csv")))
            using (var csvHelper = new CsvReader(textReader))
            {
                importedRows = csvHelper.GetRecords<Models.PayrollDataImport>().ToList();
            }

            var paye16 = Engines.DefaultEngineResolver.GetEngine<IPayeCalculationEngine>(2016);
            paye16.SetTaxYearSpecificsProvider(new JsonTaxYearSpecificProvider());
            paye16.SetTaxYear(2016);

            Console.WriteLine("Cnt: " + importedRows.Count);
            var items = importedRows;//.Take(10);
            int success = 0, failures = 0;
            var failedVariations = new List<decimal>();
            var failedPds = new List<int>();
            var failedWeeks = new Dictionary<int, int>();
            Stopwatch sw = new Stopwatch();
            Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ssss")} - Starting calcs");
            sw.Start();
            foreach (var item in items)
            {
                var tax = paye16.CalculateTaxDueForPeriod(TaxCode.Parse(item.TaxCode), item.TaxableGross, PayPeriods.Weekly,
                    item.TaxWeek, item.Wk1Mo1, item.TotalTaxableGtd - item.TaxableGross + item.P45GrossToDate, item.TotalTtd + item.P45TaxToDate);
                decimal difference = tax - item.TaxPaid;
                if (tax >= item.TaxPaid - 1m && tax <= item.TaxPaid + 1m)
                {
                    success++;
                }
                else
                {
                    failures++;
                    if (failedWeeks.ContainsKey(item.TaxWeek)) failedWeeks[item.TaxWeek]++;
                    else failedWeeks.Add(item.TaxWeek, 1);
                    failedVariations.Add(tax - item.TaxPaid);
                    failedPds.Add(item.PayrollDataId);
                }
            }
            sw.Stop();

            Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ssss")} - Calcs done");
            Console.WriteLine($"Completed in {sw.Elapsed}");
            Console.WriteLine($"{success} successes");
            Console.WriteLine($"{failures} failures");
            Console.WriteLine((failedVariations.Count > 0 ? failedVariations.Average() : 0) + " average variation in failures");
            Console.WriteLine("Failures occured in tax weeks weeks:\r\n\t" + string.Join("\r\n\t", failedWeeks.Select(m => m.Key + ": " + m.Value)));
            Console.ReadLine();
        }
    }
}