//HintName: G.Commands.SendChatAnnouncementCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SendChatAnnouncementCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string moderatorId,
            string message,
            global::G.SendChatAnnouncementBodyColor? color,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that owns the chat room to send the announcement to.",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = @"The ID of a user who has permission to moderate the broadcaster’s chat room, or the broadcaster’s ID if they’re sending the announcement. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Argument<string> Message { get; } = new(
            name: "message")
        {
            Description = @"The announcement to make in the broadcaster’s chat room. Announcements are limited to a maximum of 500 characters; announcements longer than 500 characters are truncated.",
        };

        private global::System.CommandLine.Option<global::G.SendChatAnnouncementBodyColor?> Color { get; } = new(
            name: "color")
        {
            Description = @"The color used to highlight the announcement. Possible case-sensitive values are:  
* blue
* green
* orange
* purple
* primary (default)
If `color` is set to _primary_ or is not set, the channel’s accent color is used to highlight the announcement (see **Profile Accent Color** under [profile settings](https://www.twitch.tv/settings/profile), **Channel and Videos**, and **Brand**).",
        };
        public SendChatAnnouncementCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "send",
            description: @"Sends an announcement to the broadcaster’s chat room.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:announcements** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(ModeratorId);
            Arguments.Add(Message);
            Options.Add(Color);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var moderatorId = parseResult.GetRequiredValue(ModeratorId);
            var message = parseResult.GetRequiredValue(Message);
            var color = parseResult.GetRequiredValue(Color);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                message: message,
                color: color,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Chat.SendChatAnnouncementAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                message: message,
                color: color,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}