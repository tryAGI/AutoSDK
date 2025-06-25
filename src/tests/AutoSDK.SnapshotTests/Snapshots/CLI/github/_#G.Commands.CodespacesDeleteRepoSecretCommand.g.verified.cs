//HintName: G.Commands.CodespacesDeleteRepoSecretCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespacesDeleteRepoSecretCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string secretName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
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

        public CodespacesDeleteRepoSecretCommand(G.IApi client) : base(
            name: "codespaces",
            description: @"Deletes a development environment secret in a repository using the secret name.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(SecretName);

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

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                secretName: secretName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Codespaces.CodespacesDeleteRepoSecretAsync(
                owner: owner,
                repo: repo,
                secretName: secretName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}