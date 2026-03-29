//HintName: G.Commands.TracesGetTraceStatsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesGetTraceStatsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? projectId,
            string? projectName,
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

        private global::System.CommandLine.Option<string?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Search { get; } = new(
            name: "search")
        {
            Description = @"Full-text search across trace fields",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> FromTime { get; } = new(
            name: "fromTime")
        {
            Description = @"Filter traces created from this time (ISO-8601 format).",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> ToTime { get; } = new(
            name: "toTime")
        {
            Description = @"Filter traces created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.",
        };


        public TracesGetTraceStatsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get trace stats")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(ProjectId);
            Options.Add(ProjectName);
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
            var filters = parseResult.GetRequiredValue(Filters);
            var search = parseResult.GetRequiredValue(Search);
            var fromTime = parseResult.GetRequiredValue(FromTime);
            var toTime = parseResult.GetRequiredValue(ToTime);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                projectName: projectName,
                filters: filters,
                search: search,
                fromTime: fromTime,
                toTime: toTime,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Traces.GetTraceStatsAsync(
                projectId: projectId,
                projectName: projectName,
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