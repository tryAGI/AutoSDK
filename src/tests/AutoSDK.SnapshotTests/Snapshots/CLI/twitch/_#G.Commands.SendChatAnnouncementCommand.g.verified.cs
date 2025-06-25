//HintName: G.Commands.SendChatAnnouncementCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SendChatAnnouncementCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Message { get; } = new(
            name: "message")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SendChatAnnouncementBodyColor?> Color { get; } = new(
            name: "color")
        {
            Description = "",
        };
        public SendChatAnnouncementCommand(G.IApi client) : base(
            name: "send",
            description: @"Sends an announcement to the broadcaster’s chat room.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:announcements** scope.")
        {
            _client = client;

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