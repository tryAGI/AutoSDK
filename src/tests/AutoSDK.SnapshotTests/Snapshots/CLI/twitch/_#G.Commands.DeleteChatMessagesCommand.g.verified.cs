//HintName: G.Commands.DeleteChatMessagesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteChatMessagesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string moderatorId,
            string? messageId,
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

        private global::System.CommandLine.Option<string?> MessageId { get; } = new(
            name: "messageId")
        {
            Description = "",
        };
        public DeleteChatMessagesCommand(G.IApi client) : base(
            name: "delete",
            description: @"Removes a single chat message or all chat messages from the broadcaster’s chat room.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:chat\_messages** scope.")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(ModeratorId);
            Options.Add(MessageId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var moderatorId = parseResult.GetRequiredValue(ModeratorId);
            var messageId = parseResult.GetRequiredValue(MessageId);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                messageId: messageId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Moderation.DeleteChatMessagesAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                messageId: messageId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}