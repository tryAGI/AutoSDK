//HintName: G.Commands.ListCreditConsumptionChartRecordsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListCreditConsumptionChartRecordsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Option<string?> AggregationWindow { get; } = new(
            name: "aggregationWindow")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Start { get; } = new(
            name: "start")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Stop { get; } = new(
            name: "stop")
        {
            Description = "",
        };
        public ListCreditConsumptionChartRecordsCommand(G.IApi client) : base(
            name: "list",
            description: @"Returns a timeline of Instill Credit consumption for a given owner. The
response will contain one set of records (datapoints) per consumption
source (e.g. ""pipeline"", ""model""). Each datapoint represents the amount
consumed in a time bucket.")
        {
            _client = client;

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