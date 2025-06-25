//HintName: G.Commands.UpdateDropsEntitlementsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateDropsEntitlementsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string>? entitlementIds,
            global::G.UpdateDropsEntitlementsBodyFulfillmentStatus? fulfillmentStatus,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateDropsEntitlementsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> EntitlementIds { get; } = new(
            name: "entitlementIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.UpdateDropsEntitlementsBodyFulfillmentStatus?> FulfillmentStatus { get; } = new(
            name: "fulfillmentStatus")
        {
            Description = "",
        };
        public UpdateDropsEntitlementsCommand(G.IApi client) : base(
            name: "update",
            description: @"Updates the Drop entitlement’s fulfillment status.

The following table identifies which entitlements are updated based on the type of access token used.

| Access token type | Data that’s updated |
| - | - |
| App | Updates all entitlements with benefits owned by the organization in the access token. |
| User | Updates all entitlements owned by the user in the access token and where the benefits are owned by the organization in the access token. |


__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens). The client ID in the access token must own the game.")
        {
            _client = client;

            Options.Add(EntitlementIds);
            Options.Add(FulfillmentStatus);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var entitlementIds = parseResult.GetRequiredValue(EntitlementIds);
            var fulfillmentStatus = parseResult.GetRequiredValue(FulfillmentStatus);

            Validate(
                parseResult: parseResult,
                entitlementIds: entitlementIds,
                fulfillmentStatus: fulfillmentStatus,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Entitlements.UpdateDropsEntitlementsAsync(
                entitlementIds: entitlementIds,
                fulfillmentStatus: fulfillmentStatus,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}