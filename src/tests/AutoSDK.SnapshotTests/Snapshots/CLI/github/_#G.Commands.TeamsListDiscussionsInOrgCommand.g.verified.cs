//HintName: G.Commands.TeamsListDiscussionsInOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsListDiscussionsInOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string teamSlug,
            global::G.TeamsListDiscussionsInOrgDirection? direction,
            int? perPage,
            int? page,
            string? pinned,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.TeamDiscussion> response,
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

        private global::System.CommandLine.Option<global::G.TeamsListDiscussionsInOrgDirection?> Direction { get; } = new(
            name: "direction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Pinned { get; } = new(
            name: "pinned")
        {
            Description = "",
        };
        public TeamsListDiscussionsInOrgCommand(G.IApi client) : base(
            name: "teams",
            description: @"List all discussions on a team's page.

> [!NOTE]
> You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/discussions`.

OAuth app tokens and personal access tokens (classic) need the `read:discussion` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(TeamSlug);
            Options.Add(Direction);
            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(Pinned);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var teamSlug = parseResult.GetRequiredValue(TeamSlug);
            var direction = parseResult.GetRequiredValue(Direction);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);
            var pinned = parseResult.GetRequiredValue(Pinned);

            Validate(
                parseResult: parseResult,
                org: org,
                teamSlug: teamSlug,
                direction: direction,
                perPage: perPage,
                page: page,
                pinned: pinned,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Teams.TeamsListDiscussionsInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                direction: direction,
                perPage: perPage,
                page: page,
                pinned: pinned,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}