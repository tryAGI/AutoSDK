//HintName: G.Commands.UsersAddEmailForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersAddEmailForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Email> response,
            global::System.Threading.CancellationToken cancellationToken);


        public UsersAddEmailForAuthenticatedUserCommand(G.IApi client) : base(
            name: "users",
            description: @"OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.")
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
            var response = await _client.Users.UsersAddEmailForAuthenticatedUserAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}