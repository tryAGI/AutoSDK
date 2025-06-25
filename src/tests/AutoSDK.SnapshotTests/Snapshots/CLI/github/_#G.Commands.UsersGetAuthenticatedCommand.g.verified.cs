//HintName: G.Commands.UsersGetAuthenticatedCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersGetAuthenticatedCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OneOf<global::G.PrivateUser, global::G.PublicUser> response,
            global::System.Threading.CancellationToken cancellationToken);


        public UsersGetAuthenticatedCommand(G.IApi client) : base(
            name: "users",
            description: @"OAuth app tokens and personal access tokens (classic) need the `user` scope in order for the response to include private profile information.")
        {
            _client = client;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Users.UsersGetAuthenticatedAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}