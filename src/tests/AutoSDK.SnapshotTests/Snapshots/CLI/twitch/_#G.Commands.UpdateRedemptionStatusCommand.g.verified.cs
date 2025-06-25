//HintName: G.Commands.UpdateRedemptionStatusCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateRedemptionStatusCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"A list of IDs that identify the redemptions to update. To specify more than one ID, include this parameter for each redemption you want to update. For example, `id=1234&id=5678`. You may specify a maximum of 50 IDs.",
        };

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that’s updating the redemption. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Argument<string> RewardId { get; } = new(
            name: "rewardId")
        {
            Description = @"The ID that identifies the reward that’s been redeemed.",
        };

        private global::System.CommandLine.Argument<global::G.UpdateRedemptionStatusBodyStatus> Status { get; } = new(
            name: "status")
        {
            Description = @"The status to set the redemption to. Possible values are:  
* CANCELED
* FULFILLED
Setting the status to CANCELED refunds the user’s channel points.",
        };

        public UpdateRedemptionStatusCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Updates a redemption’s status. You may update a redemption only if its status is UNFULFILLED. The app used to create the reward is the only app that may update the redemption.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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