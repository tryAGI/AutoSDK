﻿//HintName: G.Commands.ReactionsCreateForTeamDiscussionCommentInOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReactionsCreateForTeamDiscussionCommentInOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string teamSlug,
            int discussionNumber,
            int commentNumber,
            global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent content,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Reaction response,
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

        private global::System.CommandLine.Argument<global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent> Content { get; } = new(
            name: "content")
        {
            Description = "",
        };

        public ReactionsCreateForTeamDiscussionCommentInOrgCommand(G.IApi client) : base(
            name: "reactions",
            description: @"Create a reaction to a [team discussion comment](https://docs.github.com/rest/teams/discussion-comments#get-a-discussion-comment).

A response with an HTTP `200` status means that you already added the reaction type to this team discussion comment.

> [!NOTE]
> You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions`.

OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(TeamSlug);
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
            var org = parseResult.GetRequiredValue(Org);
            var teamSlug = parseResult.GetRequiredValue(TeamSlug);
            var discussionNumber = parseResult.GetRequiredValue(DiscussionNumber);
            var commentNumber = parseResult.GetRequiredValue(CommentNumber);
            var content = parseResult.GetRequiredValue(Content);

            Validate(
                parseResult: parseResult,
                org: org,
                teamSlug: teamSlug,
                discussionNumber: discussionNumber,
                commentNumber: commentNumber,
                content: content,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Reactions.ReactionsCreateForTeamDiscussionCommentInOrgAsync(
                org: org,
                teamSlug: teamSlug,
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