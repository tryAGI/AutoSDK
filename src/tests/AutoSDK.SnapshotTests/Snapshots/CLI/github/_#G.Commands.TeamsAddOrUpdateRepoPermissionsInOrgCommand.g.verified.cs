//HintName: G.Commands.TeamsAddOrUpdateRepoPermissionsInOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsAddOrUpdateRepoPermissionsInOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string teamSlug,
            string owner,
            string repo,
            string? permission,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> TeamSlug { get; } = new(
            name: "teamSlug")
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

        private global::System.CommandLine.Option<string?> Permission { get; } = new(
            name: "permission")
        {
            Description = "",
        };
        public TeamsAddOrUpdateRepoPermissionsInOrgCommand(G.IApi client) : base(
            name: "teams",
            description: @"To add a repository to a team or update the team's permission on a repository, the authenticated user must have admin access to the repository, and must be able to see the team. The repository must be owned by the organization, or a direct fork of a repository owned by the organization. You will get a `422 Unprocessable Entity` status if you attempt to add a repository to a team that is not owned by the organization. Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see ""[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method).""

> [!NOTE]
> You can also specify a team by `org_id` and `team_id` using the route `PUT /organizations/{org_id}/team/{team_id}/repos/{owner}/{repo}`.

For more information about the permission levels, see ""[Repository permission levels for an organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/repository-permission-levels-for-an-organization#permission-levels-for-repositories-owned-by-an-organization)"".")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(TeamSlug);
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
            var org = parseResult.GetRequiredValue(Org);
            var teamSlug = parseResult.GetRequiredValue(TeamSlug);
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var permission = parseResult.GetRequiredValue(Permission);

            Validate(
                parseResult: parseResult,
                org: org,
                teamSlug: teamSlug,
                owner: owner,
                repo: repo,
                permission: permission,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Teams.TeamsAddOrUpdateRepoPermissionsInOrgAsync(
                org: org,
                teamSlug: teamSlug,
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