//HintName: G.Commands.EndPredictionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EndPredictionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The ID of the broadcaster that’s running the prediction. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"The ID of the prediction to update.",
        };

        private global::System.CommandLine.Argument<global::G.EndPredictionBodyStatus> Status { get; } = new(
            name: "status")
        {
            Description = @"The status to set the prediction to. Possible case-sensitive values are:  
* RESOLVED — The winning outcome is determined and the Channel Points are distributed to the viewers who predicted the correct outcome.
* CANCELED — The broadcaster is canceling the prediction and sending refunds to the participants.
* LOCKED — The broadcaster is locking the prediction, which means viewers may no longer make predictions.
The broadcaster can update an active prediction to LOCKED, RESOLVED, or CANCELED; and update a locked prediction to RESOLVED or CANCELED.  
The broadcaster has up to 24 hours after the prediction window closes to resolve the prediction. If not, Twitch sets the status to CANCELED and returns the points.",
        };

        private global::System.CommandLine.Option<string?> WinningOutcomeId { get; } = new(
            name: "winningOutcomeId")
        {
            Description = @"The ID of the winning outcome. You must set this parameter if you set `status` to RESOLVED.",
        };
        public EndPredictionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "end",
            description: @"Locks, resolves, or cancels a Channel Points Prediction.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:predictions** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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