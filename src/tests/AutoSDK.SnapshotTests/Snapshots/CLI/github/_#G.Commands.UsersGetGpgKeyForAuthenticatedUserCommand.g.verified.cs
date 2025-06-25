//HintName: G.Commands.UsersGetGpgKeyForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsersGetGpgKeyForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int gpgKeyId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GpgKey response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> GpgKeyId { get; } = new(
            name: "gpgKeyId")
        {
            Description = "",
        };

        public UsersGetGpgKeyForAuthenticatedUserCommand(G.IApi client) : base(
            name: "users",
            description: @"View extended details for a single GPG key.

OAuth app tokens and personal access tokens (classic) need the `read:gpg_key` scope to use this endpoint.")
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
            var response = await _client.Users.UsersGetGpgKeyForAuthenticatedUserAsync(
                gpgKeyId: gpgKeyId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}