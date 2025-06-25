//HintName: G.Commands.ActionsAddSelectedRepoToOrgSecretCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsAddSelectedRepoToOrgSecretCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string secretName,
            int repositoryId,
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

        private global::System.CommandLine.Argument<int> RepositoryId { get; } = new(
            name: "repositoryId")
        {
            Description = "",
        };

        public ActionsAddSelectedRepoToOrgSecretCommand(G.IApi client) : base(
            name: "actions",
            description: @"Adds a repository to an organization secret when the `visibility` for
repository access is set to `selected`. For more information about setting the visibility, see [Create or
update an organization secret](https://docs.github.com/rest/actions/secrets#create-or-update-an-organization-secret).

Authenticated users must have collaborator access to a repository to create, update, or read secrets.

OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(SecretName);
            Arguments.Add(RepositoryId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var secretName = parseResult.GetRequiredValue(SecretName);
            var repositoryId = parseResult.GetRequiredValue(RepositoryId);

            Validate(
                parseResult: parseResult,
                org: org,
                secretName: secretName,
                repositoryId: repositoryId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsAddSelectedRepoToOrgSecretAsync(
                org: org,
                secretName: secretName,
                repositoryId: repositoryId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}