//HintName: G.Commands.ListModelTriggerChartRecordsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListModelTriggerChartRecordsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The ID of the namespace that requested the model triggers.",
        };

        private global::System.CommandLine.Option<string?> AggregationWindow { get; } = new(
            name: "aggregationWindow")
        {
            Description = @"Aggregation window. The value is a positive duration string, i.e. a
sequence of decimal numbers, each with optional fraction and a unit
suffix, such as ""300ms"", ""1.5h"" or ""2h45m"".
The minimum (and default) window is 1h.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Start { get; } = new(
            name: "start")
        {
            Description = @"Beginning of the time range from which the records will be fetched.
The default value is the beginning of the current day, in UTC.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Stop { get; } = new(
            name: "stop")
        {
            Description = @"End of the time range from which the records will be fetched.
The default value is the current timestamp.",
        };
        public ListModelTriggerChartRecordsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Returns a timeline of model trigger counts for a given requester. The
response will contain one set of records (datapoints), representing the
amount of triggers in a time bucket.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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