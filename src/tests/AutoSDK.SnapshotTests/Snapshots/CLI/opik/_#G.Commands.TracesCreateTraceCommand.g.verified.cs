//HintName: G.Commands.TracesCreateTraceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesCreateTraceCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? id,
            string? projectName,
            string? name,
            global::System.DateTime startTime,
            global::System.DateTime? endTime,
            global::G.JsonListStringWrite? input,
            global::G.JsonListStringWrite? output,
            global::G.JsonListStringWrite? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.ErrorInfoWrite? errorInfo,
            global::System.DateTime? lastUpdatedAt,
            double? ttft,
            string? threadId,
            global::G.TraceWriteSource? source,
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

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
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

        private global::System.CommandLine.Option<double?> Ttft { get; } = new(
            name: "ttft")
        {
            Description = @"Time to first token in milliseconds",
        };

        private global::System.CommandLine.Option<string?> ThreadId { get; } = new(
            name: "threadId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.TraceWriteSource?> Source { get; } = new(
            name: "source")
        {
            Description = @"",
        };


        public TracesCreateTraceCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Get trace")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StartTime);
            Options.Add(Id);
            Options.Add(ProjectName);
            Options.Add(Name);
            Options.Add(EndTime);
            Options.Add(Input);
            Options.Add(Output);
            Options.Add(Metadata);
            Options.Add(Tags);
            Options.Add(ErrorInfo);
            Options.Add(LastUpdatedAt);
            Options.Add(Ttft);
            Options.Add(ThreadId);
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
            var name = parseResult.GetRequiredValue(Name);
            var startTime = parseResult.GetRequiredValue(StartTime);
            var endTime = parseResult.GetRequiredValue(EndTime);
            var input = parseResult.GetRequiredValue(Input);
            var output = parseResult.GetRequiredValue(Output);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var tags = parseResult.GetRequiredValue(Tags);
            var errorInfo = parseResult.GetRequiredValue(ErrorInfo);
            var lastUpdatedAt = parseResult.GetRequiredValue(LastUpdatedAt);
            var ttft = parseResult.GetRequiredValue(Ttft);
            var threadId = parseResult.GetRequiredValue(ThreadId);
            var source = parseResult.GetRequiredValue(Source);

            Validate(
                parseResult: parseResult,
                id: id,
                projectName: projectName,
                name: name,
                startTime: startTime,
                endTime: endTime,
                input: input,
                output: output,
                metadata: metadata,
                tags: tags,
                errorInfo: errorInfo,
                lastUpdatedAt: lastUpdatedAt,
                ttft: ttft,
                threadId: threadId,
                source: source,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Traces.CreateTraceAsync(
                id: id,
                projectName: projectName,
                name: name,
                startTime: startTime,
                endTime: endTime,
                input: input,
                output: output,
                metadata: metadata,
                tags: tags,
                errorInfo: errorInfo,
                lastUpdatedAt: lastUpdatedAt,
                ttft: ttft,
                threadId: threadId,
                source: source,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}