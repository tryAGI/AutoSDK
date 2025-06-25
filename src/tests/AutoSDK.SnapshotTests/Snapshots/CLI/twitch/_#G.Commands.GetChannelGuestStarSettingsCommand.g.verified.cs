//HintName: G.Commands.GetChannelGuestStarSettingsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetChannelGuestStarSettingsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string moderatorId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetChannelGuestStarSettingsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster you want to get guest star settings for.",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = @"The ID of the broadcaster or a user that has permission to moderate the broadcaster’s chat room. This ID must match the user ID in the user access token.",
        };

        public GetChannelGuestStarSettingsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"BETA Gets the channel settings for configuration of the Guest Star feature for a particular host.

__Authorization:__

* Query parameter `moderator_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)
* Requires OAuth Scope: `channel:read:guest_star`, `channel:manage:guest_star`, `moderator:read:guest_star` or `moderator:manage:guest_star`")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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
            var response = await _client.GuestStar.GetChannelGuestStarSettingsAsync(
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