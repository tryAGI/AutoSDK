//HintName: G.Commands.ListCreditConsumptionChartRecordsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListCreditConsumptionChartRecordsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string? aggregationWindow,
            global::System.DateTime? start,
            global::System.DateTime? stop,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListCreditConsumptionChartRecordsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"The ID of the namespace that owns the credit.",
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
        public ListCreditConsumptionChartRecordsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Returns a timeline of Instill Credit consumption for a given owner. The
response will contain one set of records (datapoints) per consumption
source (e.g. ""pipeline"", ""model""). Each datapoint represents the amount
consumed in a time bucket.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
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
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var aggregationWindow = parseResult.GetRequiredValue(AggregationWindow);
            var start = parseResult.GetRequiredValue(Start);
            var stop = parseResult.GetRequiredValue(Stop);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                aggregationWindow: aggregationWindow,
                start: start,
                stop: stop,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Metrics.ListCreditConsumptionChartRecordsAsync(
                namespaceId: namespaceId,
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