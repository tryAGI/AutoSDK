//HintName: G.Commands.CodespacesCreateOrUpdateSecretForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespacesCreateOrUpdateSecretForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string secretName,
            string? encryptedValue,
            string keyId,
            global::System.Collections.Generic.IList<global::G.AnyOf<int?, string>>? selectedRepositoryIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EmptyObject response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> SecretName { get; } = new(
            name: "secretName")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> KeyId { get; } = new(
            name: "keyId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> EncryptedValue { get; } = new(
            name: "encryptedValue")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.AnyOf<int?, string>>?> SelectedRepositoryIds { get; } = new(
            name: "selectedRepositoryIds")
        {
            Description = "",
        };
        public CodespacesCreateOrUpdateSecretForAuthenticatedUserCommand(G.IApi client) : base(
            name: "codespaces",
            description: @"Creates or updates a development environment secret for a user's codespace with an encrypted value. Encrypt your secret using
[LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see ""[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api).""

The authenticated user must have Codespaces access to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `codespace` or `codespace:secrets` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(SecretName);
            Arguments.Add(KeyId);
            Options.Add(EncryptedValue);
            Options.Add(SelectedRepositoryIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var secretName = parseResult.GetRequiredValue(SecretName);
            var encryptedValue = parseResult.GetRequiredValue(EncryptedValue);
            var keyId = parseResult.GetRequiredValue(KeyId);
            var selectedRepositoryIds = parseResult.GetRequiredValue(SelectedRepositoryIds);

            Validate(
                parseResult: parseResult,
                secretName: secretName,
                encryptedValue: encryptedValue,
                keyId: keyId,
                selectedRepositoryIds: selectedRepositoryIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Codespaces.CodespacesCreateOrUpdateSecretForAuthenticatedUserAsync(
                secretName: secretName,
                encryptedValue: encryptedValue,
                keyId: keyId,
                selectedRepositoryIds: selectedRepositoryIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}