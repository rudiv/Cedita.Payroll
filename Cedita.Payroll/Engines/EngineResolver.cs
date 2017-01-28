// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Cedita.Payroll.Engines
{
    /// <summary>
    /// Default Engine Resolver looks for <see cref="IResolvableEngine"/> implementors by tax year
    /// </summary>
    public static class DefaultEngineResolver
    {
        private static Dictionary<Tuple<int, Type>, IResolvableEngine> CreatedEngines { get; set; }

        /// <summary>
        /// Get instance of an <see cref="IResolvableEngine"/> by tax year
        /// </summary>
        /// <typeparam name="T">Implementor of <see cref="IResolvableEngine"/></typeparam>
        /// <param name="taxYear">Year start of tax year</param>
        /// <returns><see cref="IResolvableEngine"/> instance</returns>
        public static T GetEngine<T>(int taxYear)
            where T : IResolvableEngine
        {
            var exportedTypes = typeof(IResolvableEngine).GetTypeInfo().Assembly.ExportedTypes;
            var assignableTypes = exportedTypes.Where(m => m.GetTypeInfo().ImplementedInterfaces.Contains(typeof(T)));
            var filteredTypes = assignableTypes
                .SelectMany(m => m.GetTypeInfo().GetCustomAttributes<EngineApplicableTaxYear>().Select(attr => new
                {
                    TaxYearStart = attr.TaxYearStartYear,
                    Type = m
                }))
                .ToList();

            if (filteredTypes.Count() > 0)
            {
                // Now that we have the types try and find one that is for this tax year
                var taxYearType = filteredTypes.FirstOrDefault(m => m.TaxYearStart == taxYear);

                if (taxYearType == null)
                    // Default to the latest available engine
                    taxYearType = filteredTypes.OrderByDescending(m => m.TaxYearStart).FirstOrDefault();

                if (taxYearType != null)
                    return (T)Activator.CreateInstance(taxYearType.Type);
            }
            
            throw new InvalidOperationException($"Could not find engine of type {typeof(T)} for tax year {taxYear} nor a suitable default.");
        }
    }

    /// <summary>
    /// Represents an engine type that is resolvable by the default resolver
    /// </summary>
    public interface IResolvableEngine { }
}
