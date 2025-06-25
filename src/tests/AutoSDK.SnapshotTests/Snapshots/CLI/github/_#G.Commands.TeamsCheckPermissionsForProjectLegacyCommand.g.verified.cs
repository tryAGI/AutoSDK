//HintName: G.Commands.TeamsCheckPermissionsForProjectLegacyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsCheckPermissionsForProjectLegacyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int teamId,
            int projectId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TeamProject response,
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

        public TeamsCheckPermissionsForProjectLegacyCommand(G.IApi client) : base(
            name: "teams",
            description: @"> [!WARNING]
> **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Check team permissions for a project](https://docs.github.com/rest/teams/teams#check-team-permissions-for-a-project) endpoint.

Checks whether a team has `read`, `write`, or `admin` permissions for an organization project. The response includes projects inherited from a parent team.")
        {
            _client = client;

            Arguments.Add(TeamId);
            Arguments.Add(ProjectId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var teamId = parseResult.GetRequiredValue(TeamId);
            var projectId = parseResult.GetRequiredValue(ProjectId);

            Validate(
                parseResult: parseResult,
                teamId: teamId,
                projectId: projectId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Teams.TeamsCheckPermissionsForProjectLegacyAsync(
                teamId: teamId,
                projectId: projectId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}