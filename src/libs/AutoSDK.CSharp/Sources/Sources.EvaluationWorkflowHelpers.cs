using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    private static string GetEvaluationWorkflowHelperClassName(
        CSharpSettings settings)
    {
        var configuredClassName = settings.EvaluationWorkflowHelperClassName;
        if (string.IsNullOrWhiteSpace(configuredClassName))
        {
            configuredClassName = "DatasetEvaluationRunner";
        }

        return configuredClassName
            .ToPropertyName()
            .UseWordSeparator('.', '-', '_', '/');
    }

    public static string GenerateEvaluationWorkflowHelpers(
        CSharpSettings settings,
        string className,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return $@"#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// Metadata that describes a provider dataset, experiment, score, and feedback operation cluster.
    /// </summary>
    public sealed class EvaluationWorkflowMetadata
    {{
        public string? ListDatasetItemsOperationId {{ get; set; }}

        public string? CreateExperimentOperationId {{ get; set; }}

        public string? CreateExperimentItemsOperationId {{ get; set; }}

        public string? BatchCreateScoresOperationId {{ get; set; }}

        public string? BatchCreateFeedbackOperationId {{ get; set; }}

        public string DatasetItemSchemaName {{ get; set; }} = ""DatasetItem"";

        public string ExperimentSchemaName {{ get; set; }} = ""Experiment"";

        public string ScoreSchemaName {{ get; set; }} = ""Score"";

        public string FeedbackSchemaName {{ get; set; }} = ""Feedback"";

        public string DatasetItemsLinkName {{ get; set; }} = ""items"";

        public string ExperimentLinkName {{ get; set; }} = ""experiment"";

        public string ScoresLinkName {{ get; set; }} = ""scores"";

        public string FeedbackLinkName {{ get; set; }} = ""feedback"";

        public string TraceIdPropertyName {{ get; set; }} = ""traceId"";

        public string SpanIdPropertyName {{ get; set; }} = ""spanId"";

        public string RunIdPropertyName {{ get; set; }} = ""runId"";

        public global::System.Collections.Generic.IList<string> ScorerNames {{ get; }} =
            new global::System.Collections.Generic.List<string>();
    }}

    public sealed class EvaluationWorkflowOptions
    {{
        public int MaxConcurrency {{ get; set; }} = 4;

        public int PublishBatchSize {{ get; set; }} = 50;

        public bool ContinueOnItemFailure {{ get; set; }} = true;

        public bool ThrowOnPublishFailure {{ get; set; }}

        public void Validate()
        {{
            if (MaxConcurrency <= 0)
            {{
                throw new global::System.ArgumentOutOfRangeException(nameof(MaxConcurrency), ""Max concurrency must be positive."");
            }}

            if (PublishBatchSize <= 0)
            {{
                throw new global::System.ArgumentOutOfRangeException(nameof(PublishBatchSize), ""Publish batch size must be positive."");
            }}
        }}
    }}

    public sealed class EvaluationTaskContext<TItem>
    {{
        public EvaluationTaskContext(
            TItem item,
            int index,
            string? experimentId)
        {{
            Item = item;
            Index = index;
            ExperimentId = experimentId;
        }}

        public TItem Item {{ get; }}

        public int Index {{ get; }}

        public string? ExperimentId {{ get; }}
    }}

    public sealed class EvaluationTaskResult<TOutput>
    {{
        public EvaluationTaskResult(
            TOutput output,
            string? traceId = null,
            string? spanId = null,
            string? runId = null,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? metadata = null)
        {{
            Output = output;
            TraceId = traceId;
            SpanId = spanId;
            RunId = runId;
            Metadata = metadata ?? EmptyMetadata;
        }}

        public TOutput Output {{ get; }}

        public string? TraceId {{ get; }}

        public string? SpanId {{ get; }}

        public string? RunId {{ get; }}

        public global::System.Collections.Generic.IReadOnlyDictionary<string, string> Metadata {{ get; }}

        public static EvaluationTaskResult<TOutput> FromOutput(
            TOutput output)
        {{
            return new EvaluationTaskResult<TOutput>(output);
        }}

        private static readonly global::System.Collections.Generic.IReadOnlyDictionary<string, string> EmptyMetadata =
            new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.Ordinal);
    }}

    public sealed class EvaluationScore
    {{
        public EvaluationScore(
            string name,
            double? value = null,
            string? label = null,
            string? comment = null,
            global::System.Collections.Generic.IReadOnlyDictionary<string, string>? metadata = null)
        {{
            if (string.IsNullOrWhiteSpace(name))
            {{
                throw new global::System.ArgumentException(""Score name must be non-empty."", nameof(name));
            }}

            Name = name;
            Value = value;
            Label = label;
            Comment = comment;
            Metadata = metadata ?? EmptyMetadata;
        }}

        public string Name {{ get; }}

        public double? Value {{ get; }}

        public string? Label {{ get; }}

        public string? Comment {{ get; }}

        public global::System.Collections.Generic.IReadOnlyDictionary<string, string> Metadata {{ get; }}

        private static readonly global::System.Collections.Generic.IReadOnlyDictionary<string, string> EmptyMetadata =
            new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.Ordinal);
    }}

    public sealed class EvaluationItemContext<TItem, TOutput>
    {{
        public EvaluationItemContext(
            TItem item,
            int index,
            string? experimentId,
            EvaluationTaskResult<TOutput> taskResult)
        {{
            Item = item;
            Index = index;
            ExperimentId = experimentId;
            TaskResult = taskResult ?? throw new global::System.ArgumentNullException(nameof(taskResult));
        }}

        public TItem Item {{ get; }}

        public int Index {{ get; }}

        public string? ExperimentId {{ get; }}

        public EvaluationTaskResult<TOutput> TaskResult {{ get; }}

        public TOutput Output => TaskResult.Output;

        public string? TraceId => TaskResult.TraceId;

        public string? SpanId => TaskResult.SpanId;

        public string? RunId => TaskResult.RunId;
    }}

    public sealed class EvaluationScorer<TItem, TOutput>
    {{
        private readonly global::System.Func<EvaluationItemContext<TItem, TOutput>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<EvaluationScore>> _scoreAsync;

        public EvaluationScorer(
            string name,
            global::System.Func<EvaluationItemContext<TItem, TOutput>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<EvaluationScore>> scoreAsync)
        {{
            if (string.IsNullOrWhiteSpace(name))
            {{
                throw new global::System.ArgumentException(""Scorer name must be non-empty."", nameof(name));
            }}

            Name = name;
            _scoreAsync = scoreAsync ?? throw new global::System.ArgumentNullException(nameof(scoreAsync));
        }}

        public string Name {{ get; }}

        public async global::System.Threading.Tasks.Task<EvaluationScore> ScoreAsync(
            EvaluationItemContext<TItem, TOutput> context,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            return await _scoreAsync(context, cancellationToken).ConfigureAwait(false);
        }}

        public static EvaluationScorer<TItem, TOutput> FromValue(
            string name,
            global::System.Func<EvaluationItemContext<TItem, TOutput>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<double?>> scoreAsync)
        {{
            if (scoreAsync is null)
            {{
                throw new global::System.ArgumentNullException(nameof(scoreAsync));
            }}

            return new EvaluationScorer<TItem, TOutput>(
                name,
                async (context, cancellationToken) => new EvaluationScore(
                    name,
                    await scoreAsync(context, cancellationToken).ConfigureAwait(false)));
        }}
    }}

    public sealed class EvaluationItemResult<TItem, TOutput>
    {{
        private EvaluationItemResult(
            TItem item,
            int index,
            string? experimentId,
            TOutput? output,
            string? traceId,
            string? spanId,
            string? runId,
            global::System.Collections.Generic.IReadOnlyList<EvaluationScore> scores,
            global::System.Collections.Generic.IReadOnlyList<global::System.Exception> exceptions)
        {{
            Item = item;
            Index = index;
            ExperimentId = experimentId;
            Output = output;
            TraceId = traceId;
            SpanId = spanId;
            RunId = runId;
            Scores = scores;
            Exceptions = exceptions;
        }}

        public TItem Item {{ get; }}

        public int Index {{ get; }}

        public string? ExperimentId {{ get; }}

        public TOutput? Output {{ get; }}

        public string? TraceId {{ get; }}

        public string? SpanId {{ get; }}

        public string? RunId {{ get; }}

        public global::System.Collections.Generic.IReadOnlyList<EvaluationScore> Scores {{ get; }}

        public global::System.Collections.Generic.IReadOnlyList<global::System.Exception> Exceptions {{ get; }}

        public bool Succeeded => Exceptions.Count == 0;

        public global::System.Exception? Exception => Exceptions.Count == 0 ? null : Exceptions[0];

        public static EvaluationItemResult<TItem, TOutput> Success(
            TItem item,
            int index,
            string? experimentId,
            EvaluationTaskResult<TOutput> taskResult,
            global::System.Collections.Generic.IReadOnlyList<EvaluationScore> scores)
        {{
            if (taskResult is null)
            {{
                throw new global::System.ArgumentNullException(nameof(taskResult));
            }}

            return new EvaluationItemResult<TItem, TOutput>(
                item,
                index,
                experimentId,
                taskResult.Output,
                taskResult.TraceId,
                taskResult.SpanId,
                taskResult.RunId,
                scores,
                EmptyExceptions);
        }}

        public static EvaluationItemResult<TItem, TOutput> Failure(
            TItem item,
            int index,
            string? experimentId,
            TOutput? output,
            string? traceId,
            string? spanId,
            string? runId,
            global::System.Collections.Generic.IReadOnlyList<EvaluationScore> scores,
            global::System.Collections.Generic.IReadOnlyList<global::System.Exception> exceptions)
        {{
            return new EvaluationItemResult<TItem, TOutput>(
                item,
                index,
                experimentId,
                output,
                traceId,
                spanId,
                runId,
                scores,
                exceptions);
        }}

        private static readonly global::System.Collections.Generic.IReadOnlyList<global::System.Exception> EmptyExceptions =
            new global::System.Collections.Generic.List<global::System.Exception>();
    }}

    public sealed class EvaluationWorkflowResult<TItem, TOutput>
    {{
        public EvaluationWorkflowResult(
            string? experimentId,
            global::System.Collections.Generic.IReadOnlyList<EvaluationItemResult<TItem, TOutput>> items,
            global::System.Exception? publishException = null,
            int publishedBatchCount = 0)
        {{
            ExperimentId = experimentId;
            Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            PublishException = publishException;
            PublishedBatchCount = publishedBatchCount;

            var scores = new global::System.Collections.Generic.List<EvaluationScore>();
            var exceptions = new global::System.Collections.Generic.List<global::System.Exception>();
            for (var i = 0; i < Items.Count; i++)
            {{
                var item = Items[i];
                TotalCount++;
                if (item.Succeeded)
                {{
                    SucceededCount++;
                }}
                else
                {{
                    FailedCount++;
                }}

                for (var scoreIndex = 0; scoreIndex < item.Scores.Count; scoreIndex++)
                {{
                    scores.Add(item.Scores[scoreIndex]);
                }}

                for (var exceptionIndex = 0; exceptionIndex < item.Exceptions.Count; exceptionIndex++)
                {{
                    exceptions.Add(item.Exceptions[exceptionIndex]);
                }}
            }}

            if (publishException is not null)
            {{
                exceptions.Add(publishException);
            }}

            Scores = scores;
            Exceptions = exceptions;
        }}

        public string? ExperimentId {{ get; }}

        public global::System.Collections.Generic.IReadOnlyList<EvaluationItemResult<TItem, TOutput>> Items {{ get; }}

        public int TotalCount {{ get; }}

        public int SucceededCount {{ get; }}

        public int FailedCount {{ get; }}

        public int PublishedBatchCount {{ get; }}

        public global::System.Exception? PublishException {{ get; }}

        public global::System.Collections.Generic.IReadOnlyList<EvaluationScore> Scores {{ get; }}

        public global::System.Collections.Generic.IReadOnlyList<global::System.Exception> Exceptions {{ get; }}

        public bool IsSuccessful => FailedCount == 0 && PublishException is null;
    }}

    /// <summary>
    /// Composes dataset items, task execution, scorers, and score/feedback publishing into one evaluation run.
    /// </summary>
    public sealed class {className}<TItem, TOutput>
    {{
        private readonly global::System.Func<EvaluationTaskContext<TItem>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<EvaluationTaskResult<TOutput>>> _taskAsync;
        private readonly global::System.Collections.Generic.List<EvaluationScorer<TItem, TOutput>> _scorers;
        private readonly global::System.Func<global::System.Collections.Generic.IReadOnlyList<EvaluationItemResult<TItem, TOutput>>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task>? _publishBatchAsync;
        private readonly global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string?>>? _createExperimentAsync;
        private readonly EvaluationWorkflowOptions _options;

        public {className}(
            global::System.Func<EvaluationTaskContext<TItem>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<EvaluationTaskResult<TOutput>>> taskAsync,
            global::System.Collections.Generic.IEnumerable<EvaluationScorer<TItem, TOutput>>? scorers = null,
            global::System.Func<global::System.Collections.Generic.IReadOnlyList<EvaluationItemResult<TItem, TOutput>>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task>? publishBatchAsync = null,
            global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<string?>>? createExperimentAsync = null,
            EvaluationWorkflowOptions? options = null)
        {{
            _taskAsync = taskAsync ?? throw new global::System.ArgumentNullException(nameof(taskAsync));
            _scorers = scorers is null
                ? new global::System.Collections.Generic.List<EvaluationScorer<TItem, TOutput>>()
                : new global::System.Collections.Generic.List<EvaluationScorer<TItem, TOutput>>(scorers);
            _publishBatchAsync = publishBatchAsync;
            _createExperimentAsync = createExperimentAsync;
            _options = options ?? new EvaluationWorkflowOptions();
            _options.Validate();
        }}

        public EvaluationWorkflowOptions Options => _options;

        public async global::System.Threading.Tasks.Task<EvaluationWorkflowResult<TItem, TOutput>> RunAsync(
            global::System.Collections.Generic.IEnumerable<TItem> items,
            string? experimentId = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            if (items is null)
            {{
                throw new global::System.ArgumentNullException(nameof(items));
            }}

            _options.Validate();

            var resolvedExperimentId = experimentId;
            if (resolvedExperimentId is null && _createExperimentAsync is not null)
            {{
                resolvedExperimentId = await _createExperimentAsync(cancellationToken).ConfigureAwait(false);
            }}

            var sourceItems = new global::System.Collections.Generic.List<EvaluationInputItem>();
            var itemIndex = 0;
            foreach (var item in items)
            {{
                sourceItems.Add(new EvaluationInputItem(itemIndex, item));
                itemIndex++;
            }}

            var results = new EvaluationItemResult<TItem, TOutput>?[sourceItems.Count];
            using var throttler = new global::System.Threading.SemaphoreSlim(_options.MaxConcurrency);
            var tasks = new global::System.Collections.Generic.List<global::System.Threading.Tasks.Task>(sourceItems.Count);

            for (var i = 0; i < sourceItems.Count; i++)
            {{
                tasks.Add(RunItemWithThrottleAsync(
                    sourceItems[i],
                    resolvedExperimentId,
                    results,
                    throttler,
                    cancellationToken));
            }}

            await global::System.Threading.Tasks.Task.WhenAll(tasks).ConfigureAwait(false);

            var completed = new global::System.Collections.Generic.List<EvaluationItemResult<TItem, TOutput>>(results.Length);
            for (var i = 0; i < results.Length; i++)
            {{
                var result = results[i];
                if (result is null)
                {{
                    throw new global::System.InvalidOperationException(""Evaluation item did not produce a result."");
                }}

                completed.Add(result);
            }}

            var publishedBatchCount = 0;
            global::System.Exception? publishException = null;
            if (_publishBatchAsync is not null && completed.Count > 0)
            {{
                for (var start = 0; start < completed.Count; start += _options.PublishBatchSize)
                {{
                    var count = global::System.Math.Min(_options.PublishBatchSize, completed.Count - start);
                    var batch = completed.GetRange(start, count);
                    try
                    {{
                        await _publishBatchAsync(batch, cancellationToken).ConfigureAwait(false);
                        publishedBatchCount++;
                    }}
                    catch (global::System.Exception ex) when (!IsCancellation(ex, cancellationToken))
                    {{
                        publishException = ex;
                        if (_options.ThrowOnPublishFailure)
                        {{
                            throw;
                        }}

                        break;
                    }}
                }}
            }}

            return new EvaluationWorkflowResult<TItem, TOutput>(
                resolvedExperimentId,
                completed,
                publishException,
                publishedBatchCount);
        }}

        private async global::System.Threading.Tasks.Task RunItemWithThrottleAsync(
            EvaluationInputItem sourceItem,
            string? experimentId,
            EvaluationItemResult<TItem, TOutput>?[] results,
            global::System.Threading.SemaphoreSlim throttler,
            global::System.Threading.CancellationToken cancellationToken)
        {{
            await throttler.WaitAsync(cancellationToken).ConfigureAwait(false);
            try
            {{
                results[sourceItem.Index] = await RunItemAsync(sourceItem, experimentId, cancellationToken).ConfigureAwait(false);
            }}
            finally
            {{
                throttler.Release();
            }}
        }}

        private async global::System.Threading.Tasks.Task<EvaluationItemResult<TItem, TOutput>> RunItemAsync(
            EvaluationInputItem sourceItem,
            string? experimentId,
            global::System.Threading.CancellationToken cancellationToken)
        {{
            EvaluationTaskResult<TOutput>? taskResult = null;
            var scores = new global::System.Collections.Generic.List<EvaluationScore>();
            var exceptions = new global::System.Collections.Generic.List<global::System.Exception>();

            try
            {{
                taskResult = await _taskAsync(
                    new EvaluationTaskContext<TItem>(sourceItem.Item, sourceItem.Index, experimentId),
                    cancellationToken).ConfigureAwait(false);

                for (var i = 0; i < _scorers.Count; i++)
                {{
                    try
                    {{
                        var score = await _scorers[i].ScoreAsync(
                            new EvaluationItemContext<TItem, TOutput>(
                                sourceItem.Item,
                                sourceItem.Index,
                                experimentId,
                                taskResult),
                            cancellationToken).ConfigureAwait(false);
                        scores.Add(score);
                    }}
                    catch (global::System.Exception ex) when (_options.ContinueOnItemFailure && !IsCancellation(ex, cancellationToken))
                    {{
                        exceptions.Add(ex);
                    }}
                }}
            }}
            catch (global::System.Exception ex) when (_options.ContinueOnItemFailure && !IsCancellation(ex, cancellationToken))
            {{
                exceptions.Add(ex);
            }}

            if (exceptions.Count == 0 && taskResult is not null)
            {{
                return EvaluationItemResult<TItem, TOutput>.Success(
                    sourceItem.Item,
                    sourceItem.Index,
                    experimentId,
                    taskResult,
                    scores);
            }}

            return EvaluationItemResult<TItem, TOutput>.Failure(
                sourceItem.Item,
                sourceItem.Index,
                experimentId,
                taskResult is null ? default : taskResult.Output,
                taskResult?.TraceId,
                taskResult?.SpanId,
                taskResult?.RunId,
                scores,
                exceptions);
        }}

        private static bool IsCancellation(
            global::System.Exception exception,
            global::System.Threading.CancellationToken cancellationToken)
        {{
            return exception is global::System.OperationCanceledException && cancellationToken.IsCancellationRequested;
        }}

        private sealed class EvaluationInputItem
        {{
            public EvaluationInputItem(
                int index,
                TItem item)
            {{
                Index = index;
                Item = item;
            }}

            public int Index {{ get; }}

            public TItem Item {{ get; }}
        }}
    }}
}}
";
    }
}
