//HintName: G.Commands.TracesSearchTraceThreadsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesSearchTraceThreadsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? projectName,
            global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::G.TraceThreadFilter>? filters,
            global::System.Guid? lastRetrievedThreadModelId,
            int? limit,
            bool? truncate,
            bool? stripAttachments,
            global::System.DateTime? fromTime,
            global::System.DateTime? toTime,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.TraceThreadFilter>?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> LastRetrievedThreadModelId { get; } = new(
            name: "lastRetrievedThreadModelId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Max number of trace thread to be streamed",
        };

        private global::System.CommandLine.Option<bool?> Truncate { get; } = new(
            name: "truncate")
        {
            Description = @"Truncate input, output and metadata to slim payloads",
        };

        private global::System.CommandLine.Option<bool?> StripAttachments { get; } = new(
            name: "stripAttachments")
        {
            Description = @"If true, returns attachment references like [file.png]; if false, downloads and reinjects stripped attachments",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> FromTime { get; } = new(
            name: "fromTime")
        {
            Description = @"Filter trace threads created from this time (ISO-8601 format).",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> ToTime { get; } = new(
            name: "toTime")
        {
            Description = @"Filter trace threads created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.",
        };


        public TracesSearchTraceThreadsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "search",
            description: @"Search trace threads")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(ProjectName);
            Options.Add(ProjectId);
            Options.Add(Filters);
            Options.Add(LastRetrievedThreadModelId);
            Options.Add(Limit);
            Options.Add(Truncate);
            Options.Add(StripAttachments);
            Options.Add(FromTime);
            Options.Add(ToTime);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var filters = parseResult.GetRequiredValue(Filters);
            var lastRetrievedThreadModelId = parseResult.GetRequiredValue(LastRetrievedThreadModelId);
            var limit = parseResult.GetRequiredValue(Limit);
            var truncate = parseResult.GetRequiredValue(Truncate);
            var stripAttachments = parseResult.GetRequiredValue(StripAttachments);
            var fromTime = parseResult.GetRequiredValue(FromTime);
            var toTime = parseResult.GetRequiredValue(ToTime);

            Validate(
                parseResult: parseResult,
                projectName: projectName,
                projectId: projectId,
                filters: filters,
                lastRetrievedThreadModelId: lastRetrievedThreadModelId,
                limit: limit,
                truncate: truncate,
                stripAttachments: stripAttachments,
                fromTime: fromTime,
                toTime: toTime,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Traces.SearchTraceThreadsAsync(
                projectName: projectName,
                projectId: projectId,
                filters: filters,
                lastRetrievedThreadModelId: lastRetrievedThreadModelId,
                limit: limit,
                truncate: truncate,
                stripAttachments: stripAttachments,
                fromTime: fromTime,
                toTime: toTime,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}