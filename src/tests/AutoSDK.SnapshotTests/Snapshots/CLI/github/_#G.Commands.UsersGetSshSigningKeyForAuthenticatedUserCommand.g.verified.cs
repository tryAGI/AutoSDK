//HintName: G.Commands.UsersGetSshSigningKeyForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersGetSshSigningKeyForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int sshSigningKeyId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SshSigningKey response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> SshSigningKeyId { get; } = new(
            name: "sshSigningKeyId")
        {
            Description = "",
        };

        public UsersGetSshSigningKeyForAuthenticatedUserCommand(G.IApi client) : base(
            name: "users",
            description: @"Gets extended details for an SSH signing key.

OAuth app tokens and personal access tokens (classic) need the `read:ssh_signing_key` scope to use this endpoint.")
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
            var response = await _client.Users.UsersGetSshSigningKeyForAuthenticatedUserAsync(
                sshSigningKeyId: sshSigningKeyId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}