//HintName: G.Commands.SpansUpdateSpanCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpansUpdateSpanCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string? projectName,
            global::System.Guid? projectId,
            global::System.Guid traceId,
            global::System.Guid? parentSpanId,
            string? name,
            global::G.SpanUpdateType? type,
            global::System.DateTime? endTime,
            global::G.JsonListString? input,
            global::G.JsonListString? output,
            global::G.JsonListString? metadata,
            string? model,
            string? provider,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? tagsToAdd,
            global::System.Collections.Generic.IList<string>? tagsToRemove,
            global::System.Collections.Generic.Dictionary<string, int>? usage,
            double? totalEstimatedCost,
            global::G.ErrorInfo? errorInfo,
            double? ttft,
            global::G.SpanUpdateSource? source,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> TraceId { get; } = new(
            name: "traceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"If null and project_id not specified, Default Project is assumed",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"If null and project_name not specified, Default Project is assumed",
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

        private global::System.CommandLine.Option<global::G.SpanUpdateType?> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> EndTime { get; } = new(
            name: "endTime")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.JsonListString?> Input { get; } = new(
            name: "input")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.JsonListString?> Output { get; } = new(
            name: "output")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.JsonListString?> Metadata { get; } = new(
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
            Description = @"Tags",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> TagsToAdd { get; } = new(
            name: "tagsToAdd")
        {
            Description = @"Tags to add",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> TagsToRemove { get; } = new(
            name: "tagsToRemove")
        {
            Description = @"Tags to remove",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, int>?> Usage { get; } = new(
            name: "usage")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> TotalEstimatedCost { get; } = new(
            name: "totalEstimatedCost")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ErrorInfo?> ErrorInfo { get; } = new(
            name: "errorInfo")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> Ttft { get; } = new(
            name: "ttft")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.SpanUpdateSource?> Source { get; } = new(
            name: "source")
        {
            Description = @"",
        };


        public SpansUpdateSpanCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update span by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Arguments.Add(TraceId);
            Options.Add(ProjectName);
            Options.Add(ProjectId);
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
            Options.Add(TagsToAdd);
            Options.Add(TagsToRemove);
            Options.Add(Usage);
            Options.Add(TotalEstimatedCost);
            Options.Add(ErrorInfo);
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
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var traceId = parseResult.GetRequiredValue(TraceId);
            var parentSpanId = parseResult.GetRequiredValue(ParentSpanId);
            var name = parseResult.GetRequiredValue(Name);
            var type = parseResult.GetRequiredValue(Type);
            var endTime = parseResult.GetRequiredValue(EndTime);
            var input = parseResult.GetRequiredValue(Input);
            var output = parseResult.GetRequiredValue(Output);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var model = parseResult.GetRequiredValue(Model);
            var provider = parseResult.GetRequiredValue(Provider);
            var tags = parseResult.GetRequiredValue(Tags);
            var tagsToAdd = parseResult.GetRequiredValue(TagsToAdd);
            var tagsToRemove = parseResult.GetRequiredValue(TagsToRemove);
            var usage = parseResult.GetRequiredValue(Usage);
            var totalEstimatedCost = parseResult.GetRequiredValue(TotalEstimatedCost);
            var errorInfo = parseResult.GetRequiredValue(ErrorInfo);
            var ttft = parseResult.GetRequiredValue(Ttft);
            var source = parseResult.GetRequiredValue(Source);

            Validate(
                parseResult: parseResult,
                id: id,
                projectName: projectName,
                projectId: projectId,
                traceId: traceId,
                parentSpanId: parentSpanId,
                name: name,
                type: type,
                endTime: endTime,
                input: input,
                output: output,
                metadata: metadata,
                model: model,
                provider: provider,
                tags: tags,
                tagsToAdd: tagsToAdd,
                tagsToRemove: tagsToRemove,
                usage: usage,
                totalEstimatedCost: totalEstimatedCost,
                errorInfo: errorInfo,
                ttft: ttft,
                source: source,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Spans.UpdateSpanAsync(
                id: id,
                projectName: projectName,
                projectId: projectId,
                traceId: traceId,
                parentSpanId: parentSpanId,
                name: name,
                type: type,
                endTime: endTime,
                input: input,
                output: output,
                metadata: metadata,
                model: model,
                provider: provider,
                tags: tags,
                tagsToAdd: tagsToAdd,
                tagsToRemove: tagsToRemove,
                usage: usage,
                totalEstimatedCost: totalEstimatedCost,
                errorInfo: errorInfo,
                ttft: ttft,
                source: source,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}