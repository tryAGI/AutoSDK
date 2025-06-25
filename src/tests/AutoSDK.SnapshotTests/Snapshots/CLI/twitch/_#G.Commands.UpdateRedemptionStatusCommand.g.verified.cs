//HintName: G.Commands.UpdateRedemptionStatusCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateRedemptionStatusCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string> id,
            string broadcasterId,
            string rewardId,
            global::G.UpdateRedemptionStatusBodyStatus status,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateRedemptionStatusResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> RewardId { get; } = new(
            name: "rewardId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.UpdateRedemptionStatusBodyStatus> Status { get; } = new(
            name: "status")
        {
            Description = @"",
        };

        public UpdateRedemptionStatusCommand(G.IApi client) : base(
            name: "update",
            description: @"Updates a redemption’s status. You may update a redemption only if its status is UNFULFILLED. The app used to create the reward is the only app that may update the redemption.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.")
        {
            _client = client;

            Arguments.Add(Id);
            Arguments.Add(BroadcasterId);
            Arguments.Add(RewardId);
            Arguments.Add(Status);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var rewardId = parseResult.GetRequiredValue(RewardId);
            var status = parseResult.GetRequiredValue(Status);

            Validate(
                parseResult: parseResult,
                id: id,
                broadcasterId: broadcasterId,
                rewardId: rewardId,
                status: status,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ChannelPoints.UpdateRedemptionStatusAsync(
                id: id,
                broadcasterId: broadcasterId,
                rewardId: rewardId,
                status: status,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}