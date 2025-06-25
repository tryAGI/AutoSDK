//HintName: G.Commands.GetShieldModeStatusCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetShieldModeStatusCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string moderatorId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetShieldModeStatusResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = "",
        };

        public GetShieldModeStatusCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets the broadcaster’s Shield Mode activation status.

To receive notification when the broadcaster activates and deactivates Shield Mode, subscribe to the [channel.shield\_mode.begin](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelshield%5Fmodebegin) and [channel.shield\_mode.end](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelshield%5Fmodeend) subscription types.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:read:shield\_mode** or **moderator:manage:shield\_mode** scope.")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(ModeratorId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var moderatorId = parseResult.GetRequiredValue(ModeratorId);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Moderation.GetShieldModeStatusAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}