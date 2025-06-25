//HintName: G.Commands.CheckAutomodStatusCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CheckAutomodStatusCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            global::System.Collections.Generic.IList<global::G.CheckAutoModStatusBodyDataItem> data,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CheckAutoModStatusResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.CheckAutoModStatusBodyDataItem>> Data { get; } = new(
            name: "data")
        {
            Description = "",
        };

        public CheckAutomodStatusCommand(G.IApi client) : base(
            name: "check",
            description: @"Checks whether AutoMod would flag the specified message for review.

AutoMod is a moderation tool that holds inappropriate or harassing chat messages for moderators to review. Moderators approve or deny the messages that AutoMod flags; only approved messages are released to chat. AutoMod detects misspellings and evasive language automatically. For information about AutoMod, see [How to Use AutoMod](https://help.twitch.tv/s/article/how-to-use-automod).

**Rate Limits**: Rates are limited per channel based on the account type rather than per access token.

| Account type | Limit per minute | Limit per hour |
| - | - | - |
| Normal | 5 | 50 |
| Affiliate | 10 | 100 |
| Partner | 30 | 300 |


The above limits are in addition to the standard [Twitch API rate limits](https://dev.twitch.tv/docs/api/guide#twitch-rate-limits). The rate limit headers in the response represent the Twitch rate limits and not the above limits.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderation:read** scope.")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(Data);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var data = parseResult.GetRequiredValue(Data);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                data: data,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Moderation.CheckAutomodStatusAsync(
                broadcasterId: broadcasterId,
                data: data,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}