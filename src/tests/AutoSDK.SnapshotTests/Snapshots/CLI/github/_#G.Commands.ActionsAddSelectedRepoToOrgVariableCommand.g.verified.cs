//HintName: G.Commands.ActionsAddSelectedRepoToOrgVariableCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsAddSelectedRepoToOrgVariableCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string name,
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

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> RepositoryId { get; } = new(
            name: "repositoryId")
        {
            Description = "",
        };

        public ActionsAddSelectedRepoToOrgVariableCommand(G.IApi client) : base(
            name: "actions",
            description: @"Adds a repository to an organization variable that is available to selected repositories.
Organization variables that are available to selected repositories have their `visibility` field set to `selected`.

Authenticated users must have collaborator access to a repository to create, update, or read secrets.

OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Name);
            Arguments.Add(RepositoryId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var name = parseResult.GetRequiredValue(Name);
            var repositoryId = parseResult.GetRequiredValue(RepositoryId);

            Validate(
                parseResult: parseResult,
                org: org,
                name: name,
                repositoryId: repositoryId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsAddSelectedRepoToOrgVariableAsync(
                org: org,
                name: name,
                repositoryId: repositoryId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}