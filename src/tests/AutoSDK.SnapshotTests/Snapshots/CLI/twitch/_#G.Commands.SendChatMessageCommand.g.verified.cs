﻿//HintName: G.Commands.SendChatMessageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SendChatMessageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The ID of the broadcaster whose chat room the message will be sent to.",
        };

        private global::System.CommandLine.Argument<string> SenderId { get; } = new(
            name: "senderId")
        {
            Description = @"The ID of the user sending the message. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Argument<string> Message { get; } = new(
            name: "message")
        {
            Description = @"The message to send. The message is limited to a maximum of 500 characters. Chat messages can also include emoticons. To include emoticons, use the name of the emote. The names are case sensitive. Don’t include colons around the name (e.g., :bleedPurple:). If Twitch recognizes the name, Twitch converts the name to the emote before writing the chat message to the chat room",
        };

        private global::System.CommandLine.Option<string?> ReplyParentMessageId { get; } = new(
            name: "replyParentMessageId")
        {
            Description = @"The ID of the chat message being replied to.",
        };
        public SendChatMessageCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "send",
            description: @"NEW Sends a message to the broadcaster’s chat room.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the `user:write:chat` scope. If app access token used, then additionally requires `user:bot` scope from chatting user, and either `channel:bot` scope from broadcaster or moderator status.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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