//HintName: G.Commands.UsersBlockCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersBlockCommand : global::System.CommandLine.Command
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

        public UsersBlockCommand(G.IApi client) : base(
            name: "users",
            description: @"Blocks the given user and returns a 204. If the authenticated user cannot block the given user a 422 is returned.")
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
            await _client.Users.UsersBlockAsync(
                username: username,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}