//HintName: G.Commands.GetDropsEntitlementsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetDropsEntitlementsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string>? id,
            string? userId,
            string? gameId,
            global::G.GetDropsEntitlementsFulfillmentStatus? fulfillmentStatus,
            string? after,
            int? first,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetDropsEntitlementsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> UserId { get; } = new(
            name: "userId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> GameId { get; } = new(
            name: "gameId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GetDropsEntitlementsFulfillmentStatus?> FulfillmentStatus { get; } = new(
            name: "fulfillmentStatus")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = "",
        };
        public GetDropsEntitlementsCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets an organization’s list of entitlements that have been granted to a game, a user, or both.

**NOTE:** Entitlements returned in the response body data are not guaranteed to be sorted by any field returned by the API. To retrieve **CLAIMED** or **FULFILLED** entitlements, use the `fulfillment_status` query parameter to filter results. To retrieve entitlements for a specific game, use the `game_id` query parameter to filter results.

The following table identifies the request parameters that you may specify based on the type of access token used.

| Access token type | Parameter | Description |
| - | - | - |
| App | None | If you don’t specify request parameters, the request returns all entitlements that your organization owns. |
| App | user_id | The request returns all entitlements for any game that the organization granted to the specified user. |
| App | user_id, game_id | The request returns all entitlements that the specified game granted to the specified user. |
| App | game_id | The request returns all entitlements that the specified game granted to all entitled users. |
| User | None | If you don’t specify request parameters, the request returns all entitlements for any game that the organization granted to the user identified in the access token. |
| User | user_id | Invalid. |
| User | user_id, game_id | Invalid. |
| User | game_id | The request returns all entitlements that the specified game granted to the user identified in the access token. |


__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens). The client ID in the access token must own the game.")
        {
            _client = client;

            Options.Add(Id);
            Options.Add(UserId);
            Options.Add(GameId);
            Options.Add(FulfillmentStatus);
            Options.Add(After);
            Options.Add(First);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var userId = parseResult.GetRequiredValue(UserId);
            var gameId = parseResult.GetRequiredValue(GameId);
            var fulfillmentStatus = parseResult.GetRequiredValue(FulfillmentStatus);
            var after = parseResult.GetRequiredValue(After);
            var first = parseResult.GetRequiredValue(First);

            Validate(
                parseResult: parseResult,
                id: id,
                userId: userId,
                gameId: gameId,
                fulfillmentStatus: fulfillmentStatus,
                after: after,
                first: first,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Entitlements.GetDropsEntitlementsAsync(
                id: id,
                userId: userId,
                gameId: gameId,
                fulfillmentStatus: fulfillmentStatus,
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