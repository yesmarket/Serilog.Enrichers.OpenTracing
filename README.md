# Serilog.Enrichers.OpenTracing

Use this to enrich logs with OpenTracing context i.e. TraceId and SpanId.

Configure serilog is as follows;
```json
"serilog": {
   "minimumLevel": { /* ... */ }
   },
   "writeTo": [
      { /* ... */ }
   ],
   "enrich": [ /* ... , */ "WithOpenTracingContext" ]
}
```

To install from nuget;
```bash
Install-Package Serilog.Enrichers.OpenTracing
```
