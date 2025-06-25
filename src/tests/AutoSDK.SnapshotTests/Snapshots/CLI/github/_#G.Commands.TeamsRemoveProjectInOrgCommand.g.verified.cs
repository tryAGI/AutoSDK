//HintName: G.Commands.TeamsRemoveProjectInOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsRemoveProjectInOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string teamSlug,
            int projectId,
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

        private global::System.CommandLine.Argument<int> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        public TeamsRemoveProjectInOrgCommand(G.IApi client) : base(
            name: "teams",
            description: @"Removes an organization project from a team. An organization owner or a team maintainer can remove any project from the team. To remove a project from a team as an organization member, the authenticated user must have `read` access to both the team and project, or `admin` access to the team or project. This endpoint removes the project from the team, but does not delete the project.

> [!NOTE]
> You can also specify a team by `org_id` and `team_id` using the route `DELETE /organizations/{org_id}/team/{team_id}/projects/{project_id}`.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(TeamSlug);
            Arguments.Add(ProjectId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var teamSlug = parseResult.GetRequiredValue(TeamSlug);
            var projectId = parseResult.GetRequiredValue(ProjectId);

            Validate(
                parseResult: parseResult,
                org: org,
                teamSlug: teamSlug,
                projectId: projectId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Teams.TeamsRemoveProjectInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                projectId: projectId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}