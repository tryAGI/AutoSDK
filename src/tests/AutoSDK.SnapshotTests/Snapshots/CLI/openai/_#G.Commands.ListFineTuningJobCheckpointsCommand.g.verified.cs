//HintName: G.Commands.ListFineTuningJobCheckpointsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListFineTuningJobCheckpointsCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string fineTuningJobId,
            string? after,
            int? limit,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListFineTuningJobCheckpointsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FineTuningJobId { get; } = new(
            name: "fineTuningJobId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };
        public ListFineTuningJobCheckpointsCommand(G.IOpenAiClient client) : base(
            name: "list",
            description: @"")
        {
            _client = client;

            Arguments.Add(FineTuningJobId);
            Options.Add(After);
            Options.Add(Limit);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fineTuningJobId = parseResult.GetRequiredValue(FineTuningJobId);
            var after = parseResult.GetRequiredValue(After);
            var limit = parseResult.GetRequiredValue(Limit);

            Validate(
                parseResult: parseResult,
                fineTuningJobId: fineTuningJobId,
                after: after,
                limit: limit,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FineTuning.ListFineTuningJobCheckpointsAsync(
                fineTuningJobId: fineTuningJobId,
                after: after,
                limit: limit,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}