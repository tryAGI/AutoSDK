//HintName: G.Commands.TeamsDeleteInOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsDeleteInOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string teamSlug,
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

        public TeamsDeleteInOrgCommand(G.IApi client) : base(
            name: "teams",
            description: @"To delete a team, the authenticated user must be an organization owner or team maintainer.

If you are an organization owner, deleting a parent team will delete all of its child teams as well.

> [!NOTE]
> You can also specify a team by `org_id` and `team_id` using the route `DELETE /organizations/{org_id}/team/{team_id}`.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(TeamSlug);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var teamSlug = parseResult.GetRequiredValue(TeamSlug);

            Validate(
                parseResult: parseResult,
                org: org,
                teamSlug: teamSlug,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Teams.TeamsDeleteInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}