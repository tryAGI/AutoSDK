//HintName: G.Commands.TeamsUpdateDiscussionCommentInOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsUpdateDiscussionCommentInOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string teamSlug,
            int discussionNumber,
            int commentNumber,
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

        private global::System.CommandLine.Argument<int> CommentNumber { get; } = new(
            name: "commentNumber")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Body { get; } = new(
            name: "body")
        {
            Description = "",
        };

        public TeamsUpdateDiscussionCommentInOrgCommand(G.IApi client) : base(
            name: "teams",
            description: @"Edits the body text of a discussion comment.

> [!NOTE]
> You can also specify a team by `org_id` and `team_id` using the route `PATCH /organizations/{org_id}/team/{team_id}/discussions/{discussion_number}/comments/{comment_number}`.

OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(TeamSlug);
            Arguments.Add(DiscussionNumber);
            Arguments.Add(CommentNumber);
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
            var commentNumber = parseResult.GetRequiredValue(CommentNumber);
            var body = parseResult.GetRequiredValue(Body);

            Validate(
                parseResult: parseResult,
                org: org,
                teamSlug: teamSlug,
                discussionNumber: discussionNumber,
                commentNumber: commentNumber,
                body: body,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Teams.TeamsUpdateDiscussionCommentInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                discussionNumber: discussionNumber,
                commentNumber: commentNumber,
                body: body,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}