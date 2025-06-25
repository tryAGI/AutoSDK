//HintName: G.Commands.TeamsAddOrUpdateProjectPermissionsInOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsAddOrUpdateProjectPermissionsInOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string teamSlug,
            int projectId,
            global::G.TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission? permission,
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

        private global::System.CommandLine.Option<global::G.TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission?> Permission { get; } = new(
            name: "permission")
        {
            Description = "",
        };
        public TeamsAddOrUpdateProjectPermissionsInOrgCommand(G.IApi client) : base(
            name: "teams",
            description: @"Adds an organization project to a team. To add a project to a team or update the team's permission on a project, the authenticated user must have `admin` permissions for the project. The project and team must be part of the same organization.

> [!NOTE]
> You can also specify a team by `org_id` and `team_id` using the route `PUT /organizations/{org_id}/team/{team_id}/projects/{project_id}`.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(TeamSlug);
            Arguments.Add(ProjectId);
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
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var permission = parseResult.GetRequiredValue(Permission);

            Validate(
                parseResult: parseResult,
                org: org,
                teamSlug: teamSlug,
                projectId: projectId,
                permission: permission,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Teams.TeamsAddOrUpdateProjectPermissionsInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                projectId: projectId,
                permission: permission,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}