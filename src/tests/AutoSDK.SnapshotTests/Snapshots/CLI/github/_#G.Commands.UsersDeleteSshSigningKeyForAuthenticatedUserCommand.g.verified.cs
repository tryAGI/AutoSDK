//HintName: G.Commands.UsersDeleteSshSigningKeyForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersDeleteSshSigningKeyForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int sshSigningKeyId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> SshSigningKeyId { get; } = new(
            name: "sshSigningKeyId")
        {
            Description = "",
        };

        public UsersDeleteSshSigningKeyForAuthenticatedUserCommand(G.IApi client) : base(
            name: "users",
            description: @"Deletes an SSH signing key from the authenticated user's GitHub account.

OAuth app tokens and personal access tokens (classic) need the `admin:ssh_signing_key` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(SshSigningKeyId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var sshSigningKeyId = parseResult.GetRequiredValue(SshSigningKeyId);

            Validate(
                parseResult: parseResult,
                sshSigningKeyId: sshSigningKeyId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Users.UsersDeleteSshSigningKeyForAuthenticatedUserAsync(
                sshSigningKeyId: sshSigningKeyId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}