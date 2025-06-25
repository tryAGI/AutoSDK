//HintName: G.Commands.DependabotCreateOrUpdateOrgSecretCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DependabotCreateOrUpdateOrgSecretCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string secretName,
            string? encryptedValue,
            string? keyId,
            global::G.DependabotCreateOrUpdateOrgSecretRequestVisibility visibility,
            global::System.Collections.Generic.IList<string>? selectedRepositoryIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EmptyObject response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> SecretName { get; } = new(
            name: "secretName")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.DependabotCreateOrUpdateOrgSecretRequestVisibility> Visibility { get; } = new(
            name: "visibility")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> EncryptedValue { get; } = new(
            name: "encryptedValue")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> KeyId { get; } = new(
            name: "keyId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> SelectedRepositoryIds { get; } = new(
            name: "selectedRepositoryIds")
        {
            Description = "",
        };
        public DependabotCreateOrUpdateOrgSecretCommand(G.IApi client) : base(
            name: "dependabot",
            description: @"Creates or updates an organization secret with an encrypted value. Encrypt your secret using
[LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see ""[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api).""

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(SecretName);
            Arguments.Add(Visibility);
            Options.Add(EncryptedValue);
            Options.Add(KeyId);
            Options.Add(SelectedRepositoryIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var secretName = parseResult.GetRequiredValue(SecretName);
            var encryptedValue = parseResult.GetRequiredValue(EncryptedValue);
            var keyId = parseResult.GetRequiredValue(KeyId);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var selectedRepositoryIds = parseResult.GetRequiredValue(SelectedRepositoryIds);

            Validate(
                parseResult: parseResult,
                org: org,
                secretName: secretName,
                encryptedValue: encryptedValue,
                keyId: keyId,
                visibility: visibility,
                selectedRepositoryIds: selectedRepositoryIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dependabot.DependabotCreateOrUpdateOrgSecretAsync(
                org: org,
                secretName: secretName,
                encryptedValue: encryptedValue,
                keyId: keyId,
                visibility: visibility,
                selectedRepositoryIds: selectedRepositoryIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}