//HintName: G.Commands.GetUsageCharacterStatsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetUsageCharacterStatsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.DateTimeOffset startUnix,
            global::System.DateTimeOffset endUnix,
            bool? includeWorkspaceMetrics,
            global::G.BreakdownTypes? breakdownType,
            global::G.UsageAggregationInterval? aggregationInterval,
            global::G.MetricType? metric,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UsageCharactersResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.DateTimeOffset> StartUnix { get; } = new(
            name: "startUnix")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.DateTimeOffset> EndUnix { get; } = new(
            name: "endUnix")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IncludeWorkspaceMetrics { get; } = new(
            name: "includeWorkspaceMetrics")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BreakdownTypes?> BreakdownType { get; } = new(
            name: "breakdownType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.UsageAggregationInterval?> AggregationInterval { get; } = new(
            name: "aggregationInterval")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.MetricType?> Metric { get; } = new(
            name: "metric")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetUsageCharacterStatsCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns the usage metrics for the current user or the entire workspace they are part of. The response provides a time axis based on the specified aggregation interval (default: day), with usage values for each interval along that axis. Usage is broken down by the selected breakdown type. For example, breakdown type ""voice"" will return the usage of each voice for each interval along the time axis.")
        {
            _client = client;

            Arguments.Add(StartUnix);
            Arguments.Add(EndUnix);
            Options.Add(IncludeWorkspaceMetrics);
            Options.Add(BreakdownType);
            Options.Add(AggregationInterval);
            Options.Add(Metric);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var startUnix = parseResult.GetRequiredValue(StartUnix);
            var endUnix = parseResult.GetRequiredValue(EndUnix);
            var includeWorkspaceMetrics = parseResult.GetRequiredValue(IncludeWorkspaceMetrics);
            var breakdownType = parseResult.GetRequiredValue(BreakdownType);
            var aggregationInterval = parseResult.GetRequiredValue(AggregationInterval);
            var metric = parseResult.GetRequiredValue(Metric);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                startUnix: startUnix,
                endUnix: endUnix,
                includeWorkspaceMetrics: includeWorkspaceMetrics,
                breakdownType: breakdownType,
                aggregationInterval: aggregationInterval,
                metric: metric,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Usage.GetUsageCharacterStatsAsync(
                startUnix: startUnix,
                endUnix: endUnix,
                includeWorkspaceMetrics: includeWorkspaceMetrics,
                breakdownType: breakdownType,
                aggregationInterval: aggregationInterval,
                metric: metric,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}