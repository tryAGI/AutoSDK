//HintName: G.Commands.StartARaidCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StartARaidCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? fromBroadcasterId,
            string? toBroadcasterId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.StartRaidResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> FromBroadcasterId { get; } = new(
            name: "fromBroadcasterId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ToBroadcasterId { get; } = new(
            name: "toBroadcasterId")
        {
            Description = @"",
        };
        public StartARaidCommand(G.IApi client) : base(
            name: "start",
            description: @"Raid another channel by sending the broadcaster’s viewers to the targeted channel.

When you call the API from a chat bot or extension, the Twitch UX pops up a window at the top of the chat room that identifies the number of viewers in the raid. The raid occurs when the broadcaster clicks **Raid Now** or after the 90-second countdown expires.

To determine whether the raid successfully occurred, you must subscribe to the [Channel Raid](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelraid) event. For more information, see [Get notified when a raid begins](https://dev.twitch.tv/docs/api/raids#get-notified-when-a-raid-begins).

To cancel a pending raid, use the [Cancel a raid](https://dev.twitch.tv/docs/api/reference#cancel-a-raid) endpoint.

**Rate Limit**: The limit is 10 requests within a 10-minute window.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:raids** scope.")
        {
            _client = client;

            Options.Add(FromBroadcasterId);
            Options.Add(ToBroadcasterId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fromBroadcasterId = parseResult.GetRequiredValue(FromBroadcasterId);
            var toBroadcasterId = parseResult.GetRequiredValue(ToBroadcasterId);

            Validate(
                parseResult: parseResult,
                fromBroadcasterId: fromBroadcasterId,
                toBroadcasterId: toBroadcasterId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Raids.StartARaidAsync(
                fromBroadcasterId: fromBroadcasterId,
                toBroadcasterId: toBroadcasterId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}