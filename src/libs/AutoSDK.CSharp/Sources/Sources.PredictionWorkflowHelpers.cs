using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    private static string GetPredictionWorkflowHelperClassName(
        CSharpSettings settings)
    {
        var configuredClassName = settings.PredictionWorkflowHelperClassName;
        if (string.IsNullOrWhiteSpace(configuredClassName))
        {
            configuredClassName = "PredictionWorkflowRunner";
        }

        return configuredClassName
            .ToPropertyName()
            .UseWordSeparator('.', '-', '_', '/');
    }

    public static string GeneratePredictionWorkflowHelpers(
        CSharpSettings settings,
        string className,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return $@"#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// Metadata used to connect a raw create operation, status reload operation, optional cancellation action, and result projection.
    /// </summary>
    public sealed class PredictionWorkflowMetadata
    {{
        public string? StartOperationId {{ get; set; }}

        public string? ReloadOperationId {{ get; set; }}

        public string? CancelOperationId {{ get; set; }}

        public string StatusPropertyName {{ get; set; }} = ""status"";

        public string ResultPropertyName {{ get; set; }} = ""output"";

        public string WaitHeaderName {{ get; set; }} = ""Prefer"";

        public string WaitHeaderValue {{ get; set; }} = ""wait"";

        public string? WaitQueryParameterName {{ get; set; }}

        public string ReloadLinkName {{ get; set; }} = ""get"";

        public string CancelLinkName {{ get; set; }} = ""cancel"";

        public string StreamLinkName {{ get; set; }} = ""stream"";

        public bool PreferSynchronousWait {{ get; set; }} = true;

        public global::System.Collections.Generic.ISet<string> SuccessStatuses {{ get; }} =
            PredictionWorkflowOptions.CreateDefaultSuccessStatuses();

        public global::System.Collections.Generic.ISet<string> FailureStatuses {{ get; }} =
            PredictionWorkflowOptions.CreateDefaultFailureStatuses();

        public global::System.Collections.Generic.ISet<string> CanceledStatuses {{ get; }} =
            PredictionWorkflowOptions.CreateDefaultCanceledStatuses();

        public PredictionWorkflowOptions CreateOptions()
        {{
            var options = new PredictionWorkflowOptions
            {{
                PreferSynchronousWait = PreferSynchronousWait,
                PreferWaitHeaderValue = WaitHeaderValue,
            }};

            ReplaceSet(options.SuccessStatuses, SuccessStatuses);
            ReplaceSet(options.FailureStatuses, FailureStatuses);
            ReplaceSet(options.CanceledStatuses, CanceledStatuses);
            options.Validate();
            return options;
        }}

        private static void ReplaceSet(
            global::System.Collections.Generic.ISet<string> target,
            global::System.Collections.Generic.IEnumerable<string> values)
        {{
            target.Clear();
            foreach (var value in values)
            {{
                if (!string.IsNullOrWhiteSpace(value))
                {{
                    target.Add(value.Trim());
                }}
            }}
        }}
    }}

    /// <summary>
    /// Runtime behavior for generated prediction/job workflow helpers.
    /// </summary>
    public sealed class PredictionWorkflowOptions
    {{
        public PredictionWorkflowOptions()
        {{
            SuccessStatuses = CreateDefaultSuccessStatuses();
            FailureStatuses = CreateDefaultFailureStatuses();
            CanceledStatuses = CreateDefaultCanceledStatuses();
        }}

        public global::System.TimeSpan PollInterval {{ get; set; }} = global::System.TimeSpan.FromSeconds(1);

        public global::System.TimeSpan Timeout {{ get; set; }} = global::System.TimeSpan.FromMinutes(10);

        public bool PreferSynchronousWait {{ get; set; }} = true;

        public string PreferWaitHeaderValue {{ get; set; }} = ""wait"";

        public bool TreatMissingStatusAsSuccess {{ get; set; }} = true;

        public global::System.Collections.Generic.ISet<string> SuccessStatuses {{ get; }}

        public global::System.Collections.Generic.ISet<string> FailureStatuses {{ get; }}

        public global::System.Collections.Generic.ISet<string> CanceledStatuses {{ get; }}

        public void Validate()
        {{
            if (PollInterval < global::System.TimeSpan.Zero)
            {{
                throw new global::System.ArgumentOutOfRangeException(nameof(PollInterval), ""Poll interval must not be negative."");
            }}

            if (Timeout <= global::System.TimeSpan.Zero)
            {{
                throw new global::System.ArgumentOutOfRangeException(nameof(Timeout), ""Timeout must be positive."");
            }}

            if (string.IsNullOrWhiteSpace(PreferWaitHeaderValue))
            {{
                throw new global::System.ArgumentException(""Prefer wait header value must be non-empty."", nameof(PreferWaitHeaderValue));
            }}
        }}

        public static global::System.Collections.Generic.HashSet<string> CreateDefaultSuccessStatuses()
        {{
            return new global::System.Collections.Generic.HashSet<string>(
                global::System.StringComparer.OrdinalIgnoreCase)
            {{
                ""success"",
                ""succeeded"",
                ""complete"",
                ""completed"",
                ""done"",
                ""finished"",
            }};
        }}

        public static global::System.Collections.Generic.HashSet<string> CreateDefaultFailureStatuses()
        {{
            return new global::System.Collections.Generic.HashSet<string>(
                global::System.StringComparer.OrdinalIgnoreCase)
            {{
                ""error"",
                ""errored"",
                ""failed"",
                ""failure"",
            }};
        }}

        public static global::System.Collections.Generic.HashSet<string> CreateDefaultCanceledStatuses()
        {{
            return new global::System.Collections.Generic.HashSet<string>(
                global::System.StringComparer.OrdinalIgnoreCase)
            {{
                ""aborted"",
                ""cancelled"",
                ""canceled"",
            }};
        }}
    }}

    public sealed class PredictionWorkflowException : global::System.Exception
    {{
        public PredictionWorkflowException(
            string message,
            string status,
            object? envelope,
            global::System.Exception? innerException = null)
            : base(message, innerException)
        {{
            Status = status;
            Envelope = envelope;
        }}

        public string Status {{ get; }}

        public object? Envelope {{ get; }}
    }}

    public sealed class PredictionWorkflowTimeoutException : global::System.TimeoutException
    {{
        public PredictionWorkflowTimeoutException(
            string message,
            string? lastStatus,
            object? lastEnvelope)
            : base(message)
        {{
            LastStatus = lastStatus;
            LastEnvelope = lastEnvelope;
        }}

        public string? LastStatus {{ get; }}

        public object? LastEnvelope {{ get; }}
    }}

    public sealed class PredictionWorkflowResult<TEnvelope, TResult>
    {{
        public PredictionWorkflowResult(
            TEnvelope envelope,
            TResult result,
            string? status,
            bool completedSynchronously,
            int pollCount)
        {{
            Envelope = envelope;
            Result = result;
            Status = status;
            CompletedSynchronously = completedSynchronously;
            PollCount = pollCount;
        }}

        public TEnvelope Envelope {{ get; }}

        public TResult Result {{ get; }}

        public string? Status {{ get; }}

        public bool CompletedSynchronously {{ get; }}

        public int PollCount {{ get; }}
    }}

    public sealed class PredictionResourceActions<TEnvelope>
    {{
        private readonly global::System.Func<TEnvelope, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TEnvelope>>? _reloadAsync;
        private readonly global::System.Func<TEnvelope, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task>? _cancelAsync;

        public PredictionResourceActions(
            global::System.Func<TEnvelope, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TEnvelope>>? reloadAsync = null,
            global::System.Func<TEnvelope, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task>? cancelAsync = null)
        {{
            _reloadAsync = reloadAsync;
            _cancelAsync = cancelAsync;
        }}

        public bool CanReload => _reloadAsync is not null;

        public bool CanCancel => _cancelAsync is not null;

        public async global::System.Threading.Tasks.Task<TEnvelope> ReloadAsync(
            TEnvelope envelope,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            if (_reloadAsync is null)
            {{
                throw new global::System.InvalidOperationException(""No reload delegate was configured for this prediction resource."");
            }}

            return await _reloadAsync(envelope, cancellationToken).ConfigureAwait(false);
        }}

        public async global::System.Threading.Tasks.Task CancelAsync(
            TEnvelope envelope,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            if (_cancelAsync is null)
            {{
                throw new global::System.InvalidOperationException(""No cancellation delegate was configured for this prediction resource."");
            }}

            await _cancelAsync(envelope, cancellationToken).ConfigureAwait(false);
        }}
    }}

    /// <summary>
    /// Composes raw create, reload, cancel, and projection delegates into a provider-style prediction/job workflow.
    /// </summary>
    public sealed class {className}<TCreateRequest, TEnvelope, TResult>
    {{
        private readonly global::System.Func<TCreateRequest, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TEnvelope>> _createAsync;
        private readonly global::System.Func<TEnvelope, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TEnvelope>> _reloadAsync;
        private readonly global::System.Func<TEnvelope, TResult> _resultSelector;
        private readonly global::System.Func<TEnvelope, string?> _statusSelector;
        private readonly global::System.Func<TEnvelope, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task>? _cancelAsync;
        private readonly PredictionWorkflowOptions _options;

        public {className}(
            global::System.Func<TCreateRequest, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TEnvelope>> createAsync,
            global::System.Func<TEnvelope, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TEnvelope>> reloadAsync,
            global::System.Func<TEnvelope, TResult> resultSelector,
            global::System.Func<TEnvelope, string?> statusSelector,
            global::System.Func<TEnvelope, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task>? cancelAsync = null,
            PredictionWorkflowOptions? options = null)
        {{
            _createAsync = createAsync ?? throw new global::System.ArgumentNullException(nameof(createAsync));
            _reloadAsync = reloadAsync ?? throw new global::System.ArgumentNullException(nameof(reloadAsync));
            _resultSelector = resultSelector ?? throw new global::System.ArgumentNullException(nameof(resultSelector));
            _statusSelector = statusSelector ?? throw new global::System.ArgumentNullException(nameof(statusSelector));
            _cancelAsync = cancelAsync;
            _options = options ?? new PredictionWorkflowOptions();
            _options.Validate();
        }}

        public PredictionWorkflowOptions Options => _options;

        public bool IsSuccessStatus(
            string? status)
        {{
            return _options.SuccessStatuses.Contains(NormalizeStatus(status));
        }}

        public bool IsFailureStatus(
            string? status)
        {{
            return _options.FailureStatuses.Contains(NormalizeStatus(status));
        }}

        public bool IsCanceledStatus(
            string? status)
        {{
            return _options.CanceledStatuses.Contains(NormalizeStatus(status));
        }}

        public bool IsTerminalStatus(
            string? status)
        {{
            return IsSuccessStatus(status) ||
                IsFailureStatus(status) ||
                IsCanceledStatus(status);
        }}

        public async global::System.Threading.Tasks.Task<PredictionWorkflowResult<TEnvelope, TResult>> RunAsync(
            TCreateRequest request,
            bool cancelOnCancellation = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            var startedAt = global::System.DateTimeOffset.UtcNow;
            var completedSynchronously = true;
            var pollCount = 0;
            var hasEnvelope = false;
            TEnvelope? lastEnvelope = default;

            try
            {{
                var envelope = await _createAsync(request, cancellationToken).ConfigureAwait(false);
                lastEnvelope = envelope;
                hasEnvelope = true;

                while (true)
                {{
                    cancellationToken.ThrowIfCancellationRequested();

                    var status = NormalizeStatus(_statusSelector(envelope));
                    if (string.IsNullOrWhiteSpace(status) && _options.TreatMissingStatusAsSuccess)
                    {{
                        return new PredictionWorkflowResult<TEnvelope, TResult>(
                            envelope,
                            _resultSelector(envelope),
                            status,
                            completedSynchronously,
                            pollCount);
                    }}

                    if (IsSuccessStatus(status))
                    {{
                        return new PredictionWorkflowResult<TEnvelope, TResult>(
                            envelope,
                            _resultSelector(envelope),
                            status,
                            completedSynchronously,
                            pollCount);
                    }}

                    ThrowIfTerminalFailure(status, envelope);

                    if (global::System.DateTimeOffset.UtcNow - startedAt >= _options.Timeout)
                    {{
                        throw new PredictionWorkflowTimeoutException(
                            ""Prediction workflow did not reach a terminal status before the configured timeout."",
                            status,
                            envelope);
                    }}

                    completedSynchronously = false;

                    if (_options.PollInterval > global::System.TimeSpan.Zero)
                    {{
                        await global::System.Threading.Tasks.Task.Delay(_options.PollInterval, cancellationToken).ConfigureAwait(false);
                    }}

                    envelope = await _reloadAsync(envelope, cancellationToken).ConfigureAwait(false);
                    lastEnvelope = envelope;
                    hasEnvelope = true;
                    pollCount++;
                }}
            }}
            catch (global::System.OperationCanceledException) when (cancelOnCancellation && hasEnvelope)
            {{
                await TryCancelAfterCancellationAsync(lastEnvelope!, global::System.Threading.CancellationToken.None).ConfigureAwait(false);
                throw;
            }}
        }}

        public async global::System.Threading.Tasks.Task<TEnvelope> CreateAndWaitForEnvelopeAsync(
            TCreateRequest request,
            bool cancelOnCancellation = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            var result = await RunAsync(request, cancelOnCancellation, cancellationToken).ConfigureAwait(false);
            return result.Envelope;
        }}

        public async global::System.Threading.Tasks.Task<TResult> RunForResultAsync(
            TCreateRequest request,
            bool cancelOnCancellation = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            var result = await RunAsync(request, cancelOnCancellation, cancellationToken).ConfigureAwait(false);
            return result.Result;
        }}

        public async global::System.Threading.Tasks.Task CancelAsync(
            TEnvelope envelope,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            if (_cancelAsync is null)
            {{
                throw new global::System.InvalidOperationException(""No cancellation delegate was configured for this prediction workflow."");
            }}

            await _cancelAsync(envelope, cancellationToken).ConfigureAwait(false);
        }}

        private void ThrowIfTerminalFailure(
            string status,
            TEnvelope envelope)
        {{
            if (IsCanceledStatus(status))
            {{
                throw new PredictionWorkflowException(
                    ""Prediction workflow reached a canceled terminal status."",
                    status,
                    envelope);
            }}

            if (IsFailureStatus(status))
            {{
                throw new PredictionWorkflowException(
                    ""Prediction workflow reached a failed terminal status."",
                    status,
                    envelope);
            }}
        }}

        private async global::System.Threading.Tasks.Task TryCancelAfterCancellationAsync(
            TEnvelope envelope,
            global::System.Threading.CancellationToken cancellationToken)
        {{
            if (_cancelAsync is null)
            {{
                return;
            }}

            try
            {{
                await _cancelAsync(envelope, cancellationToken).ConfigureAwait(false);
            }}
            catch
            {{
            }}
        }}

        private static string NormalizeStatus(
            string? status)
        {{
            return string.IsNullOrWhiteSpace(status) ? string.Empty : status.Trim();
        }}
    }}
}}
";
    }
}
