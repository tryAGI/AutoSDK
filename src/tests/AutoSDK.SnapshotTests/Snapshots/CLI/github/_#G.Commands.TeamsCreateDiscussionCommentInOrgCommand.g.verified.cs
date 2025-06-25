//HintName: G.Commands.TeamsCreateDiscussionCommentInOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsCreateDiscussionCommentInOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string teamSlug,
            int discussionNumber,
            string body,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TeamDiscussionComment response,
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

        private global::System.CommandLine.Argument<int> DiscussionNumber { get; } = new(
            name: "discussionNumber")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Body { get; } = new(
            name: "body")
        {
            Description = "",
        };

        public TeamsCreateDiscussionCommentInOrgCommand(G.IApi client) : base(
            name: "teams",
            description: @"Creates a new comment on a team discussion.

This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see ""[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)"" and ""[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api).""

> [!NOTE]
> You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments`.

OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(TeamSlug);
            Arguments.Add(DiscussionNumber);
            Arguments.Add(Body);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var teamSlug = parseResult.GetRequiredValue(TeamSlug);
            var discussionNumber = parseResult.GetRequiredValue(DiscussionNumber);
            var body = parseResult.GetRequiredValue(Body);

            Validate(
                parseResult: parseResult,
                org: org,
                teamSlug: teamSlug,
                discussionNumber: discussionNumber,
                body: body,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Teams.TeamsCreateDiscussionCommentInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                discussionNumber: discussionNumber,
                body: body,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}