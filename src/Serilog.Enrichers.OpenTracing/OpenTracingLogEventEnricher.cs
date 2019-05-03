using OpenTracing.Util;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers.OpenTracing
{
    public class OpenTracingLogEventEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            var tracer = GlobalTracer.Instance;
            if (tracer?.ActiveSpan == null)
                return;

            logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty("TraceId", tracer.ActiveSpan.Context.TraceId));
            logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty("SpanId", tracer.ActiveSpan.Context.SpanId));
        }
    }
}