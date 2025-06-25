//HintName: G.Commands.ReactionsCreateForTeamDiscussionCommentLegacyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReactionsCreateForTeamDiscussionCommentLegacyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int teamId,
            int discussionNumber,
            int commentNumber,
            global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent content,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Reaction response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> TeamId { get; } = new(
            name: "teamId")
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

        private global::System.CommandLine.Argument<global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent> Content { get; } = new(
            name: "content")
        {
            Description = "",
        };

        public ReactionsCreateForTeamDiscussionCommentLegacyCommand(G.IApi client) : base(
            name: "reactions",
            description: @"> [!WARNING]
> **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new ""[Create reaction for a team discussion comment](https://docs.github.com/rest/reactions/reactions#create-reaction-for-a-team-discussion-comment)"" endpoint.

Create a reaction to a [team discussion comment](https://docs.github.com/rest/teams/discussion-comments#get-a-discussion-comment).

A response with an HTTP `200` status means that you already added the reaction type to this team discussion comment.

OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(TeamId);
            Arguments.Add(DiscussionNumber);
            Arguments.Add(CommentNumber);
            Arguments.Add(Content);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var teamId = parseResult.GetRequiredValue(TeamId);
            var discussionNumber = parseResult.GetRequiredValue(DiscussionNumber);
            var commentNumber = parseResult.GetRequiredValue(CommentNumber);
            var content = parseResult.GetRequiredValue(Content);

            Validate(
                parseResult: parseResult,
                teamId: teamId,
                discussionNumber: discussionNumber,
                commentNumber: commentNumber,
                content: content,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Reactions.ReactionsCreateForTeamDiscussionCommentLegacyAsync(
                teamId: teamId,
                discussionNumber: discussionNumber,
                commentNumber: commentNumber,
                content: content,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}