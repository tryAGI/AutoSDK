using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    private static string GetObservabilityLifecycleHelperClassName(
        CSharpSettings settings)
    {
        var configuredClassName = settings.ObservabilityLifecycleHelperClassName;
        if (string.IsNullOrWhiteSpace(configuredClassName))
        {
            configuredClassName = "ObservabilityIngestionLifecycle";
        }

        return configuredClassName
            .ToPropertyName()
            .UseWordSeparator('.', '-', '_', '/');
    }

    public static string GenerateObservabilityLifecycleHelpers(
        CSharpSettings settings,
        string className,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return $@"#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// Env-backed options for generated observability ingestion lifecycle helpers.
    /// </summary>
    public sealed class ObservabilityIngestionOptions
    {{
        public bool Enabled {{ get; set; }} = true;

        public string? ApiKey {{ get; set; }}

        public string? Endpoint {{ get; set; }}

        public string? Project {{ get; set; }}

        public string? Workspace {{ get; set; }}

        public string? Environment {{ get; set; }}

        public int BatchSize {{ get; set; }} = 50;

        public int QueueSize {{ get; set; }} = 1000;

        public int WorkerCount {{ get; set; }} = 1;

        public double SamplingRate {{ get; set; }} = 1.0;

        public global::System.TimeSpan FlushInterval {{ get; set; }} = global::System.TimeSpan.FromSeconds(5);

        public void Validate()
        {{
            if (BatchSize <= 0)
            {{
                throw new global::System.ArgumentOutOfRangeException(nameof(BatchSize), ""Batch size must be positive."");
            }}
            if (QueueSize <= 0)
            {{
                throw new global::System.ArgumentOutOfRangeException(nameof(QueueSize), ""Queue size must be positive."");
            }}
            if (WorkerCount <= 0)
            {{
                throw new global::System.ArgumentOutOfRangeException(nameof(WorkerCount), ""Worker count must be positive."");
            }}
            if (SamplingRate < 0.0 || SamplingRate > 1.0)
            {{
                throw new global::System.ArgumentOutOfRangeException(nameof(SamplingRate), ""Sampling rate must be between 0 and 1."");
            }}
            if (FlushInterval < global::System.TimeSpan.Zero)
            {{
                throw new global::System.ArgumentOutOfRangeException(nameof(FlushInterval), ""Flush interval must not be negative."");
            }}
        }}

        public static ObservabilityIngestionOptions FromEnvironment()
        {{
            var options = new ObservabilityIngestionOptions
            {{
                Enabled = GetBool(""AUTOSDK_OBSERVABILITY_ENABLED"") ??
                    GetBool(""LANGSMITH_TRACING"") ??
                    true,
                ApiKey = GetString(""AUTOSDK_OBSERVABILITY_API_KEY"") ??
                    GetString(""LANGSMITH_API_KEY"") ??
                    GetString(""LANGFUSE_PUBLIC_KEY"") ??
                    GetString(""BRAINTRUST_API_KEY""),
                Endpoint = GetString(""AUTOSDK_OBSERVABILITY_ENDPOINT"") ??
                    GetString(""LANGSMITH_ENDPOINT"") ??
                    GetString(""LANGFUSE_HOST""),
                Project = GetString(""AUTOSDK_OBSERVABILITY_PROJECT"") ??
                    GetString(""LANGSMITH_PROJECT"") ??
                    GetString(""BRAINTRUST_PROJECT""),
                Workspace = GetString(""AUTOSDK_OBSERVABILITY_WORKSPACE"") ??
                    GetString(""LANGSMITH_WORKSPACE_ID""),
                Environment = GetString(""AUTOSDK_OBSERVABILITY_ENVIRONMENT"") ??
                    GetString(""ASPNETCORE_ENVIRONMENT""),
                BatchSize = GetInt(""AUTOSDK_OBSERVABILITY_BATCH_SIZE"") ?? 50,
                QueueSize = GetInt(""AUTOSDK_OBSERVABILITY_QUEUE_SIZE"") ?? 1000,
                WorkerCount = GetInt(""AUTOSDK_OBSERVABILITY_WORKER_COUNT"") ?? 1,
                SamplingRate = GetDouble(""AUTOSDK_OBSERVABILITY_SAMPLING_RATE"") ?? 1.0,
                FlushInterval = global::System.TimeSpan.FromSeconds(
                    GetDouble(""AUTOSDK_OBSERVABILITY_FLUSH_INTERVAL_SECONDS"") ?? 5.0),
            }};
            options.Validate();
            return options;
        }}

        private static string? GetString(
            string name)
        {{
            var value = global::System.Environment.GetEnvironmentVariable(name);
            return string.IsNullOrWhiteSpace(value) ? null : value;
        }}

        private static bool? GetBool(
            string name)
        {{
            var value = GetString(name);
            if (value is null)
            {{
                return null;
            }}

            return value.Equals(""1"", global::System.StringComparison.OrdinalIgnoreCase) ||
                value.Equals(""true"", global::System.StringComparison.OrdinalIgnoreCase) ||
                value.Equals(""yes"", global::System.StringComparison.OrdinalIgnoreCase) ||
                value.Equals(""on"", global::System.StringComparison.OrdinalIgnoreCase);
        }}

        private static int? GetInt(
            string name)
        {{
            return int.TryParse(
                GetString(name),
                global::System.Globalization.NumberStyles.Integer,
                global::System.Globalization.CultureInfo.InvariantCulture,
                out var value)
                ? value
                : null;
        }}

        private static double? GetDouble(
            string name)
        {{
            return double.TryParse(
                GetString(name),
                global::System.Globalization.NumberStyles.Float,
                global::System.Globalization.CultureInfo.InvariantCulture,
                out var value)
                ? value
                : null;
        }}
    }}

    /// <summary>
    /// A provider-neutral trace, span, log, score, or feedback event queued for batch ingestion.
    /// </summary>
    public sealed class ObservabilityIngestionEvent
    {{
        public ObservabilityIngestionEvent(
            string name,
            string eventType = ""event"",
            string? traceId = null,
            string? spanId = null,
            string? parentSpanId = null,
            string? body = null,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? attributes = null,
            global::System.DateTimeOffset? timestamp = null)
        {{
            if (string.IsNullOrWhiteSpace(name))
            {{
                throw new global::System.ArgumentException(""Event name must be non-empty."", nameof(name));
            }}
            if (string.IsNullOrWhiteSpace(eventType))
            {{
                throw new global::System.ArgumentException(""Event type must be non-empty."", nameof(eventType));
            }}

            Name = name;
            EventType = eventType;
            TraceId = traceId;
            SpanId = spanId;
            ParentSpanId = parentSpanId;
            Body = body;
            Timestamp = timestamp ?? global::System.DateTimeOffset.UtcNow;
            Attributes = attributes is null
                ? new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.Ordinal)
                : new global::System.Collections.Generic.Dictionary<string, string>(attributes, global::System.StringComparer.Ordinal);
        }}

        public string Name {{ get; }}

        public string EventType {{ get; }}

        public string? TraceId {{ get; }}

        public string? SpanId {{ get; }}

        public string? ParentSpanId {{ get; }}

        public string? Body {{ get; }}

        public global::System.DateTimeOffset Timestamp {{ get; }}

        public global::System.Collections.Generic.IReadOnlyDictionary<string, string> Attributes {{ get; }}

        public static ObservabilityIngestionEvent Log(
            string name,
            string? body = null,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? attributes = null)
        {{
            return new ObservabilityIngestionEvent(
                name,
                eventType: ""log"",
                body: body,
                attributes: attributes);
        }}

        public static ObservabilityIngestionEvent Span(
            string name,
            string traceId,
            string spanId,
            string? parentSpanId = null,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? attributes = null)
        {{
            return new ObservabilityIngestionEvent(
                name,
                eventType: ""span"",
                traceId: traceId,
                spanId: spanId,
                parentSpanId: parentSpanId,
                attributes: attributes);
        }}
    }}

    /// <summary>
    /// Batches observability events and drains them through a generated raw ingestion endpoint delegate.
    /// </summary>
    public sealed class {className} : global::System.IAsyncDisposable, global::System.IDisposable
    {{
        private readonly global::System.Func<global::System.Collections.Generic.IReadOnlyList<ObservabilityIngestionEvent>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> _ingestBatchAsync;
        private readonly object _gate = new object();
        private readonly global::System.Collections.Generic.List<ObservabilityIngestionEvent> _queue =
            new global::System.Collections.Generic.List<ObservabilityIngestionEvent>();
        private readonly global::System.Threading.SemaphoreSlim _flushGate = new global::System.Threading.SemaphoreSlim(1, 1);
        private readonly global::System.Threading.Timer? _timer;
        private long _sampleCounter;
        private bool _shutdown;
        private bool _disposed;

        public {className}(
            global::System.Func<global::System.Collections.Generic.IReadOnlyList<ObservabilityIngestionEvent>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> ingestBatchAsync,
            ObservabilityIngestionOptions? options = null)
        {{
            _ingestBatchAsync = ingestBatchAsync ?? throw new global::System.ArgumentNullException(nameof(ingestBatchAsync));
            Options = options ?? ObservabilityIngestionOptions.FromEnvironment();
            Options.Validate();

            if (Options.Enabled && Options.FlushInterval > global::System.TimeSpan.Zero)
            {{
                _timer = new global::System.Threading.Timer(
                    static state => _ = (({className})state!).FlushInBackgroundAsync(),
                    this,
                    Options.FlushInterval,
                    Options.FlushInterval);
            }}
        }}

        public ObservabilityIngestionOptions Options {{ get; }}

        public int QueuedCount
        {{
            get
            {{
                lock (_gate)
                {{
                    return _queue.Count;
                }}
            }}
        }}

        public global::System.Action<ObservabilityIngestionEvent>? EventDropped {{ get; set; }}

        public global::System.Action<global::System.Exception>? FlushFailed {{ get; set; }}

        public bool Enqueue(
            ObservabilityIngestionEvent ingestionEvent)
        {{
            if (ingestionEvent is null)
            {{
                throw new global::System.ArgumentNullException(nameof(ingestionEvent));
            }}
            ThrowIfDisposed();

            if (!Options.Enabled || !ShouldSample())
            {{
                EventDropped?.Invoke(ingestionEvent);
                return false;
            }}

            var shouldFlush = false;
            lock (_gate)
            {{
                if (_shutdown)
                {{
                    throw new global::System.InvalidOperationException(""Observability ingestion lifecycle has been shut down."");
                }}
                if (_queue.Count >= Options.QueueSize)
                {{
                    EventDropped?.Invoke(ingestionEvent);
                    return false;
                }}

                _queue.Add(ingestionEvent);
                shouldFlush = _queue.Count >= Options.BatchSize;
            }}

            if (shouldFlush)
            {{
                _ = FlushInBackgroundAsync();
            }}

            return true;
        }}

        public bool EnqueueLog(
            string name,
            string? body = null,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? attributes = null)
        {{
            return Enqueue(ObservabilityIngestionEvent.Log(name, body, attributes));
        }}

        public bool EnqueueException(
            string name,
            global::System.Exception exception,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? attributes = null)
        {{
            if (exception is null)
            {{
                throw new global::System.ArgumentNullException(nameof(exception));
            }}

            var values = attributes is null
                ? new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.Ordinal)
                : new global::System.Collections.Generic.Dictionary<string, string>(attributes, global::System.StringComparer.Ordinal);
            values[""exception.type""] = exception.GetType().FullName ?? exception.GetType().Name;
            values[""exception.message""] = exception.Message;

            return Enqueue(new ObservabilityIngestionEvent(
                name,
                eventType: ""exception"",
                body: exception.ToString(),
                attributes: values));
        }}

        public async global::System.Threading.Tasks.Task FlushAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            ThrowIfDisposed();
            if (!Options.Enabled)
            {{
                return;
            }}

            await _flushGate.WaitAsync(cancellationToken).ConfigureAwait(false);
            try
            {{
                while (true)
                {{
                    var batch = TakeBatch();
                    if (batch.Count == 0)
                    {{
                        return;
                    }}

                    try
                    {{
                        await _ingestBatchAsync(batch, cancellationToken).ConfigureAwait(false);
                    }}
                    catch
                    {{
                        RequeueFront(batch);
                        throw;
                    }}
                }}
            }}
            catch (global::System.Exception ex)
            {{
                FlushFailed?.Invoke(ex);
                throw;
            }}
            finally
            {{
                _flushGate.Release();
            }}
        }}

        public async global::System.Threading.Tasks.Task ShutdownAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            ThrowIfDisposed();
            lock (_gate)
            {{
                _shutdown = true;
            }}

            _timer?.Dispose();
            await FlushAsync(cancellationToken).ConfigureAwait(false);
        }}

        public async global::System.Threading.Tasks.ValueTask DisposeAsync()
        {{
            if (_disposed)
            {{
                return;
            }}

            await ShutdownAsync().ConfigureAwait(false);
            _timer?.Dispose();
            _flushGate.Dispose();
            _disposed = true;
        }}

        public void Dispose()
        {{
            if (_disposed)
            {{
                return;
            }}

            ShutdownAsync().GetAwaiter().GetResult();
            _timer?.Dispose();
            _flushGate.Dispose();
            _disposed = true;
        }}

        private bool ShouldSample()
        {{
            if (Options.SamplingRate >= 1.0)
            {{
                return true;
            }}
            if (Options.SamplingRate <= 0.0)
            {{
                return false;
            }}

            var interval = (long)global::System.Math.Ceiling(1.0 / Options.SamplingRate);
            if (interval <= 1)
            {{
                return true;
            }}

            return global::System.Threading.Interlocked.Increment(ref _sampleCounter) % interval == 0;
        }}

        private global::System.Collections.Generic.List<ObservabilityIngestionEvent> TakeBatch()
        {{
            lock (_gate)
            {{
                if (_queue.Count == 0)
                {{
                    return new global::System.Collections.Generic.List<ObservabilityIngestionEvent>();
                }}

                var count = _queue.Count < Options.BatchSize ? _queue.Count : Options.BatchSize;
                var batch = _queue.GetRange(0, count);
                _queue.RemoveRange(0, count);
                return batch;
            }}
        }}

        private void RequeueFront(
            global::System.Collections.Generic.List<ObservabilityIngestionEvent> batch)
        {{
            lock (_gate)
            {{
                _queue.InsertRange(0, batch);
            }}
        }}

        private async global::System.Threading.Tasks.Task FlushInBackgroundAsync()
        {{
            try
            {{
                await FlushAsync().ConfigureAwait(false);
            }}
            catch (global::System.ObjectDisposedException)
            {{
            }}
            catch (global::System.InvalidOperationException)
            {{
            }}
            catch (global::System.Exception ex)
            {{
                FlushFailed?.Invoke(ex);
            }}
        }}

        private void ThrowIfDisposed()
        {{
            if (_disposed)
            {{
                throw new global::System.ObjectDisposedException(nameof({className}));
            }}
        }}
    }}
}}
";
    }
}
