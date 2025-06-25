//HintName: G.Commands.DeleteChatMessagesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteChatMessagesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The ID of the broadcaster that owns the chat room to remove messages from.",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = @"The ID of the broadcaster or a user that has permission to moderate the broadcaster’s chat room. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Option<string?> MessageId { get; } = new(
            name: "messageId")
        {
            Description = @"The ID of the message to remove. The `id` tag in the [PRIVMSG](https://dev.twitch.tv/docs/irc/tags#privmsg-tags) tag contains the message’s ID. Restrictions:  
* The message must have been created within the last 6 hours.
* The message must not belong to the broadcaster.
* The message must not belong to another moderator.
If not specified, the request removes all messages in the broadcaster’s chat room.",
        };
        public DeleteChatMessagesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Removes a single chat message or all chat messages from the broadcaster’s chat room.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:chat\_messages** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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