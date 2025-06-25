//HintName: G.Commands.UsersCheckFollowingForUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersCheckFollowingForUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string username,
            string targetUser,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> TargetUser { get; } = new(
            name: "targetUser")
        {
            Description = "",
        };

        public UsersCheckFollowingForUserCommand(G.IApi client) : base(
            name: "users",
            description: @"")
        {
            _client = client;

            Arguments.Add(Username);
            Arguments.Add(TargetUser);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var username = parseResult.GetRequiredValue(Username);
            var targetUser = parseResult.GetRequiredValue(TargetUser);

            Validate(
                parseResult: parseResult,
                username: username,
                targetUser: targetUser,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Users.UsersCheckFollowingForUserAsync(
                username: username,
                targetUser: targetUser,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}