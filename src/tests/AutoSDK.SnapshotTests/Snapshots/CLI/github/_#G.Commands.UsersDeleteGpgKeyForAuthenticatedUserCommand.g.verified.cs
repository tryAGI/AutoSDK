//HintName: G.Commands.UsersDeleteGpgKeyForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersDeleteGpgKeyForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int gpgKeyId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> GpgKeyId { get; } = new(
            name: "gpgKeyId")
        {
            Description = "",
        };

        public UsersDeleteGpgKeyForAuthenticatedUserCommand(G.IApi client) : base(
            name: "users",
            description: @"Removes a GPG key from the authenticated user's GitHub account.

OAuth app tokens and personal access tokens (classic) need the `admin:gpg_key` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(GpgKeyId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var gpgKeyId = parseResult.GetRequiredValue(GpgKeyId);

            Validate(
                parseResult: parseResult,
                gpgKeyId: gpgKeyId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Users.UsersDeleteGpgKeyForAuthenticatedUserAsync(
                gpgKeyId: gpgKeyId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}