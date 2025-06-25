//HintName: G.Commands.UsersUnfollowCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersUnfollowCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string username,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        public UsersUnfollowCommand(G.IApi client) : base(
            name: "users",
            description: @"OAuth app tokens and personal access tokens (classic) need the `user:follow` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Username);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var username = parseResult.GetRequiredValue(Username);

            Validate(
                parseResult: parseResult,
                username: username,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Users.UsersUnfollowAsync(
                username: username,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}