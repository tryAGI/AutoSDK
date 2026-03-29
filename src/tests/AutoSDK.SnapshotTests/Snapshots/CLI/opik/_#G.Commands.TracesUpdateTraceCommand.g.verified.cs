//HintName: G.Commands.TracesUpdateTraceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesUpdateTraceCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string? projectName,
            global::System.Guid? projectId,
            string? name,
            global::System.DateTime? endTime,
            global::G.JsonListString? input,
            global::G.JsonListString? output,
            global::G.JsonListString? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? tagsToAdd,
            global::System.Collections.Generic.IList<string>? tagsToRemove,
            global::G.ErrorInfo? errorInfo,
            string? threadId,
            double? ttft,
            global::G.TraceUpdateSource? source,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
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

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
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

        private global::System.CommandLine.Option<global::G.ErrorInfo?> ErrorInfo { get; } = new(
            name: "errorInfo")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ThreadId { get; } = new(
            name: "threadId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> Ttft { get; } = new(
            name: "ttft")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.TraceUpdateSource?> Source { get; } = new(
            name: "source")
        {
            Description = @"",
        };


        public TracesUpdateTraceCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update trace by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(ProjectName);
            Options.Add(ProjectId);
            Options.Add(Name);
            Options.Add(EndTime);
            Options.Add(Input);
            Options.Add(Output);
            Options.Add(Metadata);
            Options.Add(Tags);
            Options.Add(TagsToAdd);
            Options.Add(TagsToRemove);
            Options.Add(ErrorInfo);
            Options.Add(ThreadId);
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
            var name = parseResult.GetRequiredValue(Name);
            var endTime = parseResult.GetRequiredValue(EndTime);
            var input = parseResult.GetRequiredValue(Input);
            var output = parseResult.GetRequiredValue(Output);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var tags = parseResult.GetRequiredValue(Tags);
            var tagsToAdd = parseResult.GetRequiredValue(TagsToAdd);
            var tagsToRemove = parseResult.GetRequiredValue(TagsToRemove);
            var errorInfo = parseResult.GetRequiredValue(ErrorInfo);
            var threadId = parseResult.GetRequiredValue(ThreadId);
            var ttft = parseResult.GetRequiredValue(Ttft);
            var source = parseResult.GetRequiredValue(Source);

            Validate(
                parseResult: parseResult,
                id: id,
                projectName: projectName,
                projectId: projectId,
                name: name,
                endTime: endTime,
                input: input,
                output: output,
                metadata: metadata,
                tags: tags,
                tagsToAdd: tagsToAdd,
                tagsToRemove: tagsToRemove,
                errorInfo: errorInfo,
                threadId: threadId,
                ttft: ttft,
                source: source,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Traces.UpdateTraceAsync(
                id: id,
                projectName: projectName,
                projectId: projectId,
                name: name,
                endTime: endTime,
                input: input,
                output: output,
                metadata: metadata,
                tags: tags,
                tagsToAdd: tagsToAdd,
                tagsToRemove: tagsToRemove,
                errorInfo: errorInfo,
                threadId: threadId,
                ttft: ttft,
                source: source,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}