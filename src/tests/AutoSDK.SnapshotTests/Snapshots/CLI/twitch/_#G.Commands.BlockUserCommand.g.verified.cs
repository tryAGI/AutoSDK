//HintName: G.Commands.BlockUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BlockUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string targetUserId,
            global::G.BlockUserSourceContext? sourceContext,
            global::G.BlockUserReason? reason,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TargetUserId { get; } = new(
            name: "targetUserId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BlockUserSourceContext?> SourceContext { get; } = new(
            name: "sourceContext")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BlockUserReason?> Reason { get; } = new(
            name: "reason")
        {
            Description = "",
        };
        public BlockUserCommand(G.IApi client) : base(
            name: "block",
            description: @"Blocks the specified user from interacting with or having contact with the broadcaster. The user ID in the OAuth token identifies the broadcaster who is blocking the user.

To learn more about blocking users, see [Block Other Users on Twitch](https://help.twitch.tv/s/article/how-to-manage-harassment-in-chat?language=en%5FUS#BlockWhispersandMessagesfromStrangers).

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:manage:blocked\_users** scope.")
        {
            _client = client;

            Arguments.Add(TargetUserId);
            Options.Add(SourceContext);
            Options.Add(Reason);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var targetUserId = parseResult.GetRequiredValue(TargetUserId);
            var sourceContext = parseResult.GetRequiredValue(SourceContext);
            var reason = parseResult.GetRequiredValue(Reason);

            Validate(
                parseResult: parseResult,
                targetUserId: targetUserId,
                sourceContext: sourceContext,
                reason: reason,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Users.BlockUserAsync(
                targetUserId: targetUserId,
                sourceContext: sourceContext,
                reason: reason,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}