//HintName: G.Commands.ListPipelineTriggerChartRecordsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListPipelineTriggerChartRecordsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? aggregationWindow,
            string? filter,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListPipelineTriggerChartRecordsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> AggregationWindow { get; } = new(
            name: "aggregationWindow")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"",
        };
        public ListPipelineTriggerChartRecordsCommand(G.IApi client) : base(
            name: "list",
            description: @"Returns a timeline of pipline trigger counts for the pipelines of a given
owner.
NOTE: This method will soon return the trigger counts of a given requester.")
        {
            _client = client;

            Options.Add(AggregationWindow);
            Options.Add(Filter);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var aggregationWindow = parseResult.GetRequiredValue(AggregationWindow);
            var filter = parseResult.GetRequiredValue(Filter);

            Validate(
                parseResult: parseResult,
                aggregationWindow: aggregationWindow,
                filter: filter,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Metrics.ListPipelineTriggerChartRecordsAsync(
                aggregationWindow: aggregationWindow,
                filter: filter,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}