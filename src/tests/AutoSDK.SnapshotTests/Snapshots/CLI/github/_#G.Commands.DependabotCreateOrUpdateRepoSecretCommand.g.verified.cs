//HintName: G.Commands.DependabotCreateOrUpdateRepoSecretCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DependabotCreateOrUpdateRepoSecretCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string secretName,
            string? encryptedValue,
            string? keyId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EmptyObject response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> SecretName { get; } = new(
            name: "secretName")
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
        public DependabotCreateOrUpdateRepoSecretCommand(G.IApi client) : base(
            name: "dependabot",
            description: @"Creates or updates a repository secret with an encrypted value. Encrypt your secret using
[LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see ""[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api).""

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(SecretName);
            Options.Add(EncryptedValue);
            Options.Add(KeyId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var secretName = parseResult.GetRequiredValue(SecretName);
            var encryptedValue = parseResult.GetRequiredValue(EncryptedValue);
            var keyId = parseResult.GetRequiredValue(KeyId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                secretName: secretName,
                encryptedValue: encryptedValue,
                keyId: keyId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dependabot.DependabotCreateOrUpdateRepoSecretAsync(
                owner: owner,
                repo: repo,
                secretName: secretName,
                encryptedValue: encryptedValue,
                keyId: keyId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}