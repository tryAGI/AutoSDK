//HintName: G.Commands.TeamsAddOrUpdateMembershipForUserInOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsAddOrUpdateMembershipForUserInOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string teamSlug,
            string username,
            global::G.TeamsAddOrUpdateMembershipForUserInOrgRequestRole? role,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TeamMembership response,
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

        private global::System.CommandLine.Argument<string> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.TeamsAddOrUpdateMembershipForUserInOrgRequestRole?> Role { get; } = new(
            name: "role")
        {
            Description = "",
        };
        public TeamsAddOrUpdateMembershipForUserInOrgCommand(G.IApi client) : base(
            name: "teams",
            description: @"Adds an organization member to a team. An authenticated organization owner or team maintainer can add organization members to a team.

Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

> [!NOTE]
> When you have team synchronization set up for a team with your organization's identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team's membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see ""[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/).""

An organization owner can add someone who is not part of the team's organization to a team. When an organization owner adds someone to a team who is not an organization member, this endpoint will send an invitation to the person via email. This newly-created membership will be in the ""pending"" state until the person accepts the invitation, at which point the membership will transition to the ""active"" state and the user will be added as a member of the team.

If the user is already a member of the team, this endpoint will update the role of the team member's role. To update the membership of a team member, the authenticated user must be an organization owner or a team maintainer.

> [!NOTE]
> You can also specify a team by `org_id` and `team_id` using the route `PUT /organizations/{org_id}/team/{team_id}/memberships/{username}`.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(TeamSlug);
            Arguments.Add(Username);
            Options.Add(Role);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var teamSlug = parseResult.GetRequiredValue(TeamSlug);
            var username = parseResult.GetRequiredValue(Username);
            var role = parseResult.GetRequiredValue(Role);

            Validate(
                parseResult: parseResult,
                org: org,
                teamSlug: teamSlug,
                username: username,
                role: role,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Teams.TeamsAddOrUpdateMembershipForUserInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                username: username,
                role: role,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}