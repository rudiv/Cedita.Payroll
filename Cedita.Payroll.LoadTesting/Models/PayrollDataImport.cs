using System;
using System.Collections.Generic;
using System.Text;

namespace Cedita.Payroll.LoadTesting.Models
{
    public class PayrollDataImport
    {
        public int PayrollDataId { get; set; }
        public int TaxWeek { get; set; }
        public string TaxCode { get; set; }
        public bool Wk1Mo1 { get; set; }
        public decimal TaxableGross { get; set; }
        public decimal EeNi { get; set; }
        public decimal ErNi { get; set; }
        public decimal NetPay { get; set; }
        public decimal TaxPaid { get; set; }
        public decimal TotalTaxableGtd { get; set; }
        public decimal TotalTtd { get; set; }
        public decimal P45GrossToDate { get; set; }
        public decimal P45TaxToDate { get; set; }
    }
}
