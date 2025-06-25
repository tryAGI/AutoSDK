//HintName: G.Commands.ListModelTriggerChartRecordsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListModelTriggerChartRecordsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string requesterId,
            string? aggregationWindow,
            global::System.DateTime? start,
            global::System.DateTime? stop,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListModelTriggerChartRecordsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> RequesterId { get; } = new(
            name: "requesterId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> AggregationWindow { get; } = new(
            name: "aggregationWindow")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Start { get; } = new(
            name: "start")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Stop { get; } = new(
            name: "stop")
        {
            Description = @"",
        };
        public ListModelTriggerChartRecordsCommand(G.IApi client) : base(
            name: "list",
            description: @"Returns a timeline of model trigger counts for a given requester. The
response will contain one set of records (datapoints), representing the
amount of triggers in a time bucket.")
        {
            _client = client;

            Arguments.Add(RequesterId);
            Options.Add(AggregationWindow);
            Options.Add(Start);
            Options.Add(Stop);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var requesterId = parseResult.GetRequiredValue(RequesterId);
            var aggregationWindow = parseResult.GetRequiredValue(AggregationWindow);
            var start = parseResult.GetRequiredValue(Start);
            var stop = parseResult.GetRequiredValue(Stop);

            Validate(
                parseResult: parseResult,
                requesterId: requesterId,
                aggregationWindow: aggregationWindow,
                start: start,
                stop: stop,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Metrics.ListModelTriggerChartRecordsAsync(
                requesterId: requesterId,
                aggregationWindow: aggregationWindow,
                start: start,
                stop: stop,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}