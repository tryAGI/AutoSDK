//HintName: G.Commands.TeamsGetMembershipForUserLegacyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsGetMembershipForUserLegacyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int teamId,
            string username,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TeamMembership response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> TeamId { get; } = new(
            name: "teamId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        public TeamsGetMembershipForUserLegacyCommand(G.IApi client) : base(
            name: "teams",
            description: @"> [!WARNING]
> **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Get team membership for a user](https://docs.github.com/rest/teams/members#get-team-membership-for-a-user) endpoint.

Team members will include the members of child teams.

To get a user's membership with a team, the team must be visible to the authenticated user.

**Note:**
The response contains the `state` of the membership and the member's `role`.

The `role` for organization owners is set to `maintainer`. For more information about `maintainer` roles, see [Create a team](https://docs.github.com/rest/teams/teams#create-a-team).")
        {
            _client = client;

            Arguments.Add(TeamId);
            Arguments.Add(Username);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var teamId = parseResult.GetRequiredValue(TeamId);
            var username = parseResult.GetRequiredValue(Username);

            Validate(
                parseResult: parseResult,
                teamId: teamId,
                username: username,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Teams.TeamsGetMembershipForUserLegacyAsync(
                teamId: teamId,
                username: username,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}