//HintName: G.Commands.SendChatMessageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SendChatMessageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string senderId,
            string message,
            string? replyParentMessageId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SendChatMessageResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> SenderId { get; } = new(
            name: "senderId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Message { get; } = new(
            name: "message")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ReplyParentMessageId { get; } = new(
            name: "replyParentMessageId")
        {
            Description = @"",
        };
        public SendChatMessageCommand(G.IApi client) : base(
            name: "send",
            description: @"NEW Sends a message to the broadcaster’s chat room.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the `user:write:chat` scope. If app access token used, then additionally requires `user:bot` scope from chatting user, and either `channel:bot` scope from broadcaster or moderator status.")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(SenderId);
            Arguments.Add(Message);
            Options.Add(ReplyParentMessageId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var senderId = parseResult.GetRequiredValue(SenderId);
            var message = parseResult.GetRequiredValue(Message);
            var replyParentMessageId = parseResult.GetRequiredValue(ReplyParentMessageId);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                senderId: senderId,
                message: message,
                replyParentMessageId: replyParentMessageId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Chat.SendChatMessageAsync(
                broadcasterId: broadcasterId,
                senderId: senderId,
                message: message,
                replyParentMessageId: replyParentMessageId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}