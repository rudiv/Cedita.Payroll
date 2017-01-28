// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

namespace Cedita.Payroll.Engines.Paye
{
    public interface IPayeCalculationEngine : IResolvableEngine
    {
        PayeInternalBracket GetBracket(int year, int period, int periods);
    }
}
