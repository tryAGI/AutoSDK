//HintName: G.Commands.UsersCreateGpgKeyForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersCreateGpgKeyForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? name,
            string armoredPublicKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GpgKey response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ArmoredPublicKey { get; } = new(
            name: "armoredPublicKey")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };
        public UsersCreateGpgKeyForAuthenticatedUserCommand(G.IApi client) : base(
            name: "users",
            description: @"Adds a GPG key to the authenticated user's GitHub account.

OAuth app tokens and personal access tokens (classic) need the `write:gpg_key` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(ArmoredPublicKey);
            Options.Add(Name);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var armoredPublicKey = parseResult.GetRequiredValue(ArmoredPublicKey);

            Validate(
                parseResult: parseResult,
                name: name,
                armoredPublicKey: armoredPublicKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Users.UsersCreateGpgKeyForAuthenticatedUserAsync(
                name: name,
                armoredPublicKey: armoredPublicKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}