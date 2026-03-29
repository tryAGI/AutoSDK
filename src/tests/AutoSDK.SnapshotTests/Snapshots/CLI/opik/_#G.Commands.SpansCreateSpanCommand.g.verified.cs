//HintName: G.Commands.SpansCreateSpanCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpansCreateSpanCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? id,
            string? projectName,
            global::System.Guid? traceId,
            global::System.Guid? parentSpanId,
            string? name,
            global::G.SpanWriteType? type,
            global::System.DateTime startTime,
            global::System.DateTime? endTime,
            global::G.JsonListStringWrite? input,
            global::G.JsonListStringWrite? output,
            global::G.JsonListStringWrite? metadata,
            string? model,
            string? provider,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.Dictionary<string, int>? usage,
            global::G.ErrorInfoWrite? errorInfo,
            global::System.DateTime? lastUpdatedAt,
            double? totalEstimatedCost,
            string? totalEstimatedCostVersion,
            double? ttft,
            global::G.SpanWriteSource? source,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.DateTime> StartTime { get; } = new(
            name: "startTime")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"If null, the default project is used",
        };

        private global::System.CommandLine.Option<global::System.Guid?> TraceId { get; } = new(
            name: "traceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ParentSpanId { get; } = new(
            name: "parentSpanId")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.SpanWriteType?> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> EndTime { get; } = new(
            name: "endTime")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.JsonListStringWrite?> Input { get; } = new(
            name: "input")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.JsonListStringWrite?> Output { get; } = new(
            name: "output")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.JsonListStringWrite?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Provider { get; } = new(
            name: "provider")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, int>?> Usage { get; } = new(
            name: "usage")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ErrorInfoWrite?> ErrorInfo { get; } = new(
            name: "errorInfo")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> LastUpdatedAt { get; } = new(
            name: "lastUpdatedAt")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> TotalEstimatedCost { get; } = new(
            name: "totalEstimatedCost")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> TotalEstimatedCostVersion { get; } = new(
            name: "totalEstimatedCostVersion")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> Ttft { get; } = new(
            name: "ttft")
        {
            Description = @"Time to first token in milliseconds",
        };

        private global::System.CommandLine.Option<global::G.SpanWriteSource?> Source { get; } = new(
            name: "source")
        {
            Description = @"",
        };


        public SpansCreateSpanCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create span")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StartTime);
            Options.Add(Id);
            Options.Add(ProjectName);
            Options.Add(TraceId);
            Options.Add(ParentSpanId);
            Options.Add(Name);
            Options.Add(Type);
            Options.Add(EndTime);
            Options.Add(Input);
            Options.Add(Output);
            Options.Add(Metadata);
            Options.Add(Model);
            Options.Add(Provider);
            Options.Add(Tags);
            Options.Add(Usage);
            Options.Add(ErrorInfo);
            Options.Add(LastUpdatedAt);
            Options.Add(TotalEstimatedCost);
            Options.Add(TotalEstimatedCostVersion);
            Options.Add(Ttft);
            Options.Add(Source);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var traceId = parseResult.GetRequiredValue(TraceId);
            var parentSpanId = parseResult.GetRequiredValue(ParentSpanId);
            var name = parseResult.GetRequiredValue(Name);
            var type = parseResult.GetRequiredValue(Type);
            var startTime = parseResult.GetRequiredValue(StartTime);
            var endTime = parseResult.GetRequiredValue(EndTime);
            var input = parseResult.GetRequiredValue(Input);
            var output = parseResult.GetRequiredValue(Output);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var model = parseResult.GetRequiredValue(Model);
            var provider = parseResult.GetRequiredValue(Provider);
            var tags = parseResult.GetRequiredValue(Tags);
            var usage = parseResult.GetRequiredValue(Usage);
            var errorInfo = parseResult.GetRequiredValue(ErrorInfo);
            var lastUpdatedAt = parseResult.GetRequiredValue(LastUpdatedAt);
            var totalEstimatedCost = parseResult.GetRequiredValue(TotalEstimatedCost);
            var totalEstimatedCostVersion = parseResult.GetRequiredValue(TotalEstimatedCostVersion);
            var ttft = parseResult.GetRequiredValue(Ttft);
            var source = parseResult.GetRequiredValue(Source);

            Validate(
                parseResult: parseResult,
                id: id,
                projectName: projectName,
                traceId: traceId,
                parentSpanId: parentSpanId,
                name: name,
                type: type,
                startTime: startTime,
                endTime: endTime,
                input: input,
                output: output,
                metadata: metadata,
                model: model,
                provider: provider,
                tags: tags,
                usage: usage,
                errorInfo: errorInfo,
                lastUpdatedAt: lastUpdatedAt,
                totalEstimatedCost: totalEstimatedCost,
                totalEstimatedCostVersion: totalEstimatedCostVersion,
                ttft: ttft,
                source: source,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Spans.CreateSpanAsync(
                id: id,
                projectName: projectName,
                traceId: traceId,
                parentSpanId: parentSpanId,
                name: name,
                type: type,
                startTime: startTime,
                endTime: endTime,
                input: input,
                output: output,
                metadata: metadata,
                model: model,
                provider: provider,
                tags: tags,
                usage: usage,
                errorInfo: errorInfo,
                lastUpdatedAt: lastUpdatedAt,
                totalEstimatedCost: totalEstimatedCost,
                totalEstimatedCostVersion: totalEstimatedCostVersion,
                ttft: ttft,
                source: source,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}