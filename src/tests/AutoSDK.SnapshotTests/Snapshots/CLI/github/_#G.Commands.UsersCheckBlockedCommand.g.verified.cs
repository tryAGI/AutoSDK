//HintName: G.Commands.UsersCheckBlockedCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersCheckBlockedCommand : global::System.CommandLine.Command
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

        public UsersCheckBlockedCommand(G.IApi client) : base(
            name: "users",
            description: @"Returns a 204 if the given user is blocked by the authenticated user. Returns a 404 if the given user is not blocked by the authenticated user, or if the given user account has been identified as spam by GitHub.")
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
            await _client.Users.UsersCheckBlockedAsync(
                username: username,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}