//HintName: G.Commands.EndPredictionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EndPredictionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string id,
            global::G.EndPredictionBodyStatus status,
            string? winningOutcomeId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EndPredictionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.EndPredictionBodyStatus> Status { get; } = new(
            name: "status")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> WinningOutcomeId { get; } = new(
            name: "winningOutcomeId")
        {
            Description = "",
        };
        public EndPredictionCommand(G.IApi client) : base(
            name: "end",
            description: @"Locks, resolves, or cancels a Channel Points Prediction.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:predictions** scope.")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(Id);
            Arguments.Add(Status);
            Options.Add(WinningOutcomeId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var id = parseResult.GetRequiredValue(Id);
            var status = parseResult.GetRequiredValue(Status);
            var winningOutcomeId = parseResult.GetRequiredValue(WinningOutcomeId);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                id: id,
                status: status,
                winningOutcomeId: winningOutcomeId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Predictions.EndPredictionAsync(
                broadcasterId: broadcasterId,
                id: id,
                status: status,
                winningOutcomeId: winningOutcomeId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}