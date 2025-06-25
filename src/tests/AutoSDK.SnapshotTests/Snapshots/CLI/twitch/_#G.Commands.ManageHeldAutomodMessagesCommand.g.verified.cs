//HintName: G.Commands.ManageHeldAutomodMessagesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManageHeldAutomodMessagesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string userId,
            string msgId,
            global::G.ManageHeldAutoModMessagesBodyAction action,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> MsgId { get; } = new(
            name: "msgId")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Argument<global::G.ManageHeldAutoModMessagesBodyAction> Action { get; } = new(
            name: "action")
        {
            Description = @"",
        };

        public ManageHeldAutomodMessagesCommand(G.IApi client) : base(
            name: "manage",
            description: @"Allow or deny the message that AutoMod flagged for review. For information about AutoMod, see [How to Use AutoMod](https://help.twitch.tv/s/article/how-to-use-automod).

To get messages that AutoMod is holding for review, subscribe to the **automod-queue.<moderator\_id>.<channel\_id>** [topic](https://dev.twitch.tv/docs/pubsub#topics) using [PubSub](https://dev.twitch.tv/docs/pubsub). PubSub sends a notification to your app when AutoMod holds a message for review.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:automod** scope.")
        {
            _client = client;

            Arguments.Add(UserId);
            Arguments.Add(MsgId);
            Arguments.Add(Action);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var userId = parseResult.GetRequiredValue(UserId);
            var msgId = parseResult.GetRequiredValue(MsgId);
            var action = parseResult.GetRequiredValue(Action);

            Validate(
                parseResult: parseResult,
                userId: userId,
                msgId: msgId,
                action: action,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Moderation.ManageHeldAutomodMessagesAsync(
                userId: userId,
                msgId: msgId,
                action: action,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}