//HintName: G.Commands.DatasetsPatchDatasetItemCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsPatchDatasetItemCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid itemId,
            global::System.Guid? id,
            global::System.Guid? traceId,
            global::System.Guid? spanId,
            global::G.DatasetItemWriteSource source,
            global::G.JsonNode data,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<global::G.EvaluatorItemWrite>? evaluators,
            global::G.ExecutionPolicyWrite? executionPolicy,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ItemId { get; } = new(
            name: "itemId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.DatasetItemWriteSource> Source { get; } = new(
            name: "source")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.JsonNode> Data { get; } = new(
            name: "data")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> Id { get; } = new(
            name: "id")
        {
            Description = @"Stable item identifier.
On write, used as the upsert key.
If omitted, a new ID is generated.
Remains the same across dataset versions",
        };

        private global::System.CommandLine.Option<global::System.Guid?> TraceId { get; } = new(
            name: "traceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> SpanId { get; } = new(
            name: "spanId")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.EvaluatorItemWrite>?> Evaluators { get; } = new(
            name: "evaluators")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ExecutionPolicyWrite?> ExecutionPolicy { get; } = new(
            name: "executionPolicy")
        {
            Description = @"",
        };


        public DatasetsPatchDatasetItemCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "patch",
            description: @"Partially update dataset item by id. Only provided fields will be updated.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ItemId);
            Arguments.Add(Source);
            Arguments.Add(Data);
            Options.Add(Id);
            Options.Add(TraceId);
            Options.Add(SpanId);
            Options.Add(Description);
            Options.Add(Tags);
            Options.Add(Evaluators);
            Options.Add(ExecutionPolicy);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var itemId = parseResult.GetRequiredValue(ItemId);
            var id = parseResult.GetRequiredValue(Id);
            var traceId = parseResult.GetRequiredValue(TraceId);
            var spanId = parseResult.GetRequiredValue(SpanId);
            var source = parseResult.GetRequiredValue(Source);
            var data = parseResult.GetRequiredValue(Data);
            var description = parseResult.GetRequiredValue(Description);
            var tags = parseResult.GetRequiredValue(Tags);
            var evaluators = parseResult.GetRequiredValue(Evaluators);
            var executionPolicy = parseResult.GetRequiredValue(ExecutionPolicy);

            Validate(
                parseResult: parseResult,
                itemId: itemId,
                id: id,
                traceId: traceId,
                spanId: spanId,
                source: source,
                data: data,
                description: description,
                tags: tags,
                evaluators: evaluators,
                executionPolicy: executionPolicy,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Datasets.PatchDatasetItemAsync(
                itemId: itemId,
                id: id,
                traceId: traceId,
                spanId: spanId,
                source: source,
                data: data,
                description: description,
                tags: tags,
                evaluators: evaluators,
                executionPolicy: executionPolicy,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}