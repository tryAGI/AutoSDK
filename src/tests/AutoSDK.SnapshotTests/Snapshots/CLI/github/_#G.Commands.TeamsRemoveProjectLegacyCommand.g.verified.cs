//HintName: G.Commands.TeamsRemoveProjectLegacyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsRemoveProjectLegacyCommand : global::System.CommandLine.Command
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

        public TeamsRemoveProjectLegacyCommand(G.IApi client) : base(
            name: "teams",
            description: @"> [!WARNING]
> **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Remove a project from a team](https://docs.github.com/rest/teams/teams#remove-a-project-from-a-team) endpoint.

Removes an organization project from a team. An organization owner or a team maintainer can remove any project from the team. To remove a project from a team as an organization member, the authenticated user must have `read` access to both the team and project, or `admin` access to the team or project. **Note:** This endpoint removes the project from the team, but does not delete it.")
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
            await _client.Teams.TeamsRemoveProjectLegacyAsync(
                teamId: teamId,
                projectId: projectId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}