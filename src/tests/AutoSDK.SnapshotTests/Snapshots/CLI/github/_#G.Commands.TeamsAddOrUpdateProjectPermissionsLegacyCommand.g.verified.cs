//HintName: G.Commands.TeamsAddOrUpdateProjectPermissionsLegacyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsAddOrUpdateProjectPermissionsLegacyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int teamId,
            int projectId,
            global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission? permission,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> TeamId { get; } = new(
            name: "teamId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission?> Permission { get; } = new(
            name: "permission")
        {
            Description = "",
        };
        public TeamsAddOrUpdateProjectPermissionsLegacyCommand(G.IApi client) : base(
            name: "teams",
            description: @"> [!WARNING]
> **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Add or update team project permissions](https://docs.github.com/rest/teams/teams#add-or-update-team-project-permissions) endpoint.

Adds an organization project to a team. To add a project to a team or update the team's permission on a project, the authenticated user must have `admin` permissions for the project. The project and team must be part of the same organization.")
        {
            _client = client;

            Arguments.Add(TeamId);
            Arguments.Add(ProjectId);
            Options.Add(Permission);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var teamId = parseResult.GetRequiredValue(TeamId);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var permission = parseResult.GetRequiredValue(Permission);

            Validate(
                parseResult: parseResult,
                teamId: teamId,
                projectId: projectId,
                permission: permission,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Teams.TeamsAddOrUpdateProjectPermissionsLegacyAsync(
                teamId: teamId,
                projectId: projectId,
                permission: permission,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}