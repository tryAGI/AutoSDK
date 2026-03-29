//HintName: G.Commands.SpansGetSpanStatsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpansGetSpanStatsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? projectId,
            string? projectName,
            global::System.Guid? traceId,
            global::G.GetSpanStatsType? type,
            string? filters,
            string? search,
            global::System.DateTime? fromTime,
            global::System.DateTime? toTime,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ProjectStatsPublic response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> TraceId { get; } = new(
            name: "traceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.GetSpanStatsType?> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Search { get; } = new(
            name: "search")
        {
            Description = @"Full-text search across span fields",
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


        public SpansGetSpanStatsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get span stats")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(ProjectId);
            Options.Add(ProjectName);
            Options.Add(TraceId);
            Options.Add(Type);
            Options.Add(Filters);
            Options.Add(Search);
            Options.Add(FromTime);
            Options.Add(ToTime);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var traceId = parseResult.GetRequiredValue(TraceId);
            var type = parseResult.GetRequiredValue(Type);
            var filters = parseResult.GetRequiredValue(Filters);
            var search = parseResult.GetRequiredValue(Search);
            var fromTime = parseResult.GetRequiredValue(FromTime);
            var toTime = parseResult.GetRequiredValue(ToTime);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                projectName: projectName,
                traceId: traceId,
                type: type,
                filters: filters,
                search: search,
                fromTime: fromTime,
                toTime: toTime,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Spans.GetSpanStatsAsync(
                projectId: projectId,
                projectName: projectName,
                traceId: traceId,
                type: type,
                filters: filters,
                search: search,
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