using System;
using Serilog.Configuration;

namespace Serilog.Enrichers.OpenTracing
{
    public static class LoggingExtensions
    {
        public static LoggerConfiguration WithOpenTracing(this LoggerEnrichmentConfiguration enrich)
        {
            if (enrich == null)
                throw new ArgumentNullException(nameof(enrich));

            return enrich.With<OpenTracingLogEventEnricher>();
        }
    }
}