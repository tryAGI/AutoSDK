//HintName: G.Commands.CodespacesSetSelectedReposForOrgSecretCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespacesSetSelectedReposForOrgSecretCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string secretName,
            global::System.Collections.Generic.IList<int> selectedRepositoryIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
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

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<int>> SelectedRepositoryIds { get; } = new(
            name: "selectedRepositoryIds")
        {
            Description = "",
        };

        public CodespacesSetSelectedReposForOrgSecretCommand(G.IApi client) : base(
            name: "codespaces",
            description: @"Replaces all repositories for an organization development environment secret when the `visibility`
for repository access is set to `selected`. The visibility is set when you [Create
or update an organization secret](https://docs.github.com/rest/codespaces/organization-secrets#create-or-update-an-organization-secret).

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(SecretName);
            Arguments.Add(SelectedRepositoryIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var secretName = parseResult.GetRequiredValue(SecretName);
            var selectedRepositoryIds = parseResult.GetRequiredValue(SelectedRepositoryIds);

            Validate(
                parseResult: parseResult,
                org: org,
                secretName: secretName,
                selectedRepositoryIds: selectedRepositoryIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Codespaces.CodespacesSetSelectedReposForOrgSecretAsync(
                org: org,
                secretName: secretName,
                selectedRepositoryIds: selectedRepositoryIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}