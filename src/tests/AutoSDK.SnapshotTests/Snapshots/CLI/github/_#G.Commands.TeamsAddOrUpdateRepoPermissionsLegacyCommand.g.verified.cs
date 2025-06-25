//HintName: G.Commands.TeamsAddOrUpdateRepoPermissionsLegacyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsAddOrUpdateRepoPermissionsLegacyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int teamId,
            string owner,
            string repo,
            global::G.TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission? permission,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> TeamId { get; } = new(
            name: "teamId")
        {
            Description = "",
        };

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

        private global::System.CommandLine.Option<global::G.TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission?> Permission { get; } = new(
            name: "permission")
        {
            Description = "",
        };
        public TeamsAddOrUpdateRepoPermissionsLegacyCommand(G.IApi client) : base(
            name: "teams",
            description: @"> [!WARNING]
> **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new ""[Add or update team repository permissions](https://docs.github.com/rest/teams/teams#add-or-update-team-repository-permissions)"" endpoint.

To add a repository to a team or update the team's permission on a repository, the authenticated user must have admin access to the repository, and must be able to see the team. The repository must be owned by the organization, or a direct fork of a repository owned by the organization. You will get a `422 Unprocessable Entity` status if you attempt to add a repository to a team that is not owned by the organization.

Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see ""[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method).""")
        {
            _client = client;

            Arguments.Add(TeamId);
            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(Permission);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var teamId = parseResult.GetRequiredValue(TeamId);
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var permission = parseResult.GetRequiredValue(Permission);

            Validate(
                parseResult: parseResult,
                teamId: teamId,
                owner: owner,
                repo: repo,
                permission: permission,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Teams.TeamsAddOrUpdateRepoPermissionsLegacyAsync(
                teamId: teamId,
                owner: owner,
                repo: repo,
                permission: permission,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}