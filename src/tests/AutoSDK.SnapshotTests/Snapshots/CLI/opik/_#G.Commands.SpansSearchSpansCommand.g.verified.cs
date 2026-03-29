//HintName: G.Commands.SpansSearchSpansCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpansSearchSpansCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? traceId,
            string? projectName,
            global::System.Guid? projectId,
            global::G.SpanSearchStreamRequestPublicType? type,
            global::System.Collections.Generic.IList<global::G.SpanFilterPublic>? filters,
            int? limit,
            global::System.Guid? lastRetrievedId,
            bool? truncate,
            global::System.DateTime? fromTime,
            global::System.DateTime? toTime,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Guid?> TraceId { get; } = new(
            name: "traceId")
        {
            Description = @"",
        };

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

        private global::System.CommandLine.Option<global::G.SpanSearchStreamRequestPublicType?> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.SpanFilterPublic>?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Max number of spans to be streamed",
        };

        private global::System.CommandLine.Option<global::System.Guid?> LastRetrievedId { get; } = new(
            name: "lastRetrievedId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Truncate { get; } = new(
            name: "truncate")
        {
            Description = @"Truncate image included in either input, output or metadata",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> FromTime { get; } = new(
            name: "fromTime")
        {
            Description = @"Filter spans created from this time (ISO-8601 format).",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> ToTime { get; } = new(
            name: "toTime")
        {
            Description = @"Filter spans created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.",
        };


        public SpansSearchSpansCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "search",
            description: @"Search spans")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(TraceId);
            Options.Add(ProjectName);
            Options.Add(ProjectId);
            Options.Add(Type);
            Options.Add(Filters);
            Options.Add(Limit);
            Options.Add(LastRetrievedId);
            Options.Add(Truncate);
            Options.Add(FromTime);
            Options.Add(ToTime);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var traceId = parseResult.GetRequiredValue(TraceId);
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var type = parseResult.GetRequiredValue(Type);
            var filters = parseResult.GetRequiredValue(Filters);
            var limit = parseResult.GetRequiredValue(Limit);
            var lastRetrievedId = parseResult.GetRequiredValue(LastRetrievedId);
            var truncate = parseResult.GetRequiredValue(Truncate);
            var fromTime = parseResult.GetRequiredValue(FromTime);
            var toTime = parseResult.GetRequiredValue(ToTime);

            Validate(
                parseResult: parseResult,
                traceId: traceId,
                projectName: projectName,
                projectId: projectId,
                type: type,
                filters: filters,
                limit: limit,
                lastRetrievedId: lastRetrievedId,
                truncate: truncate,
                fromTime: fromTime,
                toTime: toTime,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Spans.SearchSpansAsync(
                traceId: traceId,
                projectName: projectName,
                projectId: projectId,
                type: type,
                filters: filters,
                limit: limit,
                lastRetrievedId: lastRetrievedId,
                truncate: truncate,
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