//HintName: G.Commands.GetCustomRewardRedemptionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetCustomRewardRedemptionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string rewardId,
            global::G.GetCustomRewardRedemptionStatus? status,
            global::System.Collections.Generic.IList<string>? id,
            global::G.GetCustomRewardRedemptionSort? sort,
            string? after,
            int? first,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetCustomRewardRedemptionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that owns the custom reward. This ID must match the user ID found in the user OAuth token.",
        };

        private global::System.CommandLine.Argument<string> RewardId { get; } = new(
            name: "rewardId")
        {
            Description = @"The ID that identifies the custom reward whose redemptions you want to get.",
        };

        private global::System.CommandLine.Option<global::G.GetCustomRewardRedemptionStatus?> Status { get; } = new(
            name: "status")
        {
            Description = @"The status of the redemptions to return. The possible case-sensitive values are:  
* CANCELED
* FULFILLED
* UNFULFILLED
**NOTE**: This field is required only if you don’t specify the _id_ query parameter.  
**NOTE**: Canceled and fulfilled redemptions are returned for only a few days after they’re canceled or fulfilled.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Id { get; } = new(
            name: "id")
        {
            Description = @"A list of IDs to filter the redemptions by. To specify more than one ID, include this parameter for each redemption you want to get. For example, `id=1234&id=5678`. You may specify a maximum of 50 IDs.  
Duplicate IDs are ignored. The response contains only the IDs that were found. If none of the IDs were found, the response is 404 Not Found.",
        };

        private global::System.CommandLine.Option<global::G.GetCustomRewardRedemptionSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = @"The order to sort redemptions by. The possible case-sensitive values are:  
* OLDEST
* NEWEST
The default is OLDEST.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The **Pagination** object in the response contains the cursor’s value. [Read more](https://dev.twitch.tv/docs/api/guide#pagination)",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of redemptions to return per page in the response. The minimum page size is 1 redemption per page and the maximum is 50\. The default is 20.",
        };
        public GetCustomRewardRedemptionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets a list of redemptions for the specified custom reward. The app used to create the reward is the only app that may get the redemptions.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:redemptions** or **channel:manage:redemptions** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(RewardId);
            Options.Add(Status);
            Options.Add(Id);
            Options.Add(Sort);
            Options.Add(After);
            Options.Add(First);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var rewardId = parseResult.GetRequiredValue(RewardId);
            var status = parseResult.GetRequiredValue(Status);
            var id = parseResult.GetRequiredValue(Id);
            var sort = parseResult.GetRequiredValue(Sort);
            var after = parseResult.GetRequiredValue(After);
            var first = parseResult.GetRequiredValue(First);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                rewardId: rewardId,
                status: status,
                id: id,
                sort: sort,
                after: after,
                first: first,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ChannelPoints.GetCustomRewardRedemptionAsync(
                broadcasterId: broadcasterId,
                rewardId: rewardId,
                status: status,
                id: id,
                sort: sort,
                after: after,
                first: first,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}