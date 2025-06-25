//HintName: G.Commands.UpdateUserChatColorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateUserChatColorCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string userId,
            global::G.UpdateUserChatColorColor color,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.UpdateUserChatColorColor> Color { get; } = new(
            name: "color")
        {
            Description = @"",
        };

        public UpdateUserChatColorCommand(G.IApi client) : base(
            name: "update",
            description: @"Updates the color used for the user’s name in chat.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:manage:chat\_color** scope.")
        {
            _client = client;

            Arguments.Add(UserId);
            Arguments.Add(Color);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var userId = parseResult.GetRequiredValue(UserId);
            var color = parseResult.GetRequiredValue(Color);

            Validate(
                parseResult: parseResult,
                userId: userId,
                color: color,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Chat.UpdateUserChatColorAsync(
                userId: userId,
                color: color,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}