# Cedita.Payroll
Cedita.Payroll is a .NET Standard version of HMRC-compliant PAYE, National Insurance, and related calculators. Core components for building payroll services.

## Calculate Tax Due for Pay Period (PAYE only)
To calculate the tax due for any specific period would take 4 lines of code, 3 for resolution / configuration of the engine (subject to simplification).

```cs
using Cedita.Payroll.Engines;
using Cedita.Payroll.Engines.Paye;

// ..

var payeEngine = DefaultEngineResolver.GetEngine<IPayeCalculationEngine>(year);
// Use the default PayrollConfig.json provider
payeEngine.SetTaxYearSpecificsProvider(new JsonTaxYearSpecificProvider());
payeEngine.SetTaxYear(year);

var taxDueInPeriod = payeEngine.CalculateTaxDueForPeriod("1150L", 5000, PayPeriods.Monthly, 1);
```
