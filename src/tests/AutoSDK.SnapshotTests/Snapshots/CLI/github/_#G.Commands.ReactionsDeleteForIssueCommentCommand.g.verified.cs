﻿//HintName: G.Commands.ReactionsDeleteForIssueCommentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReactionsDeleteForIssueCommentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            long commentId,
            int reactionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<long> CommentId { get; } = new(
            name: "commentId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> ReactionId { get; } = new(
            name: "reactionId")
        {
            Description = "",
        };

        public ReactionsDeleteForIssueCommentCommand(G.IApi client) : base(
            name: "reactions",
            description: @"> [!NOTE]
> You can also specify a repository by `repository_id` using the route `DELETE delete /repositories/:repository_id/issues/comments/:comment_id/reactions/:reaction_id`.

Delete a reaction to an [issue comment](https://docs.github.com/rest/issues/comments#get-an-issue-comment).")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(CommentId);
            Arguments.Add(ReactionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var commentId = parseResult.GetRequiredValue(CommentId);
            var reactionId = parseResult.GetRequiredValue(ReactionId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                commentId: commentId,
                reactionId: reactionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Reactions.ReactionsDeleteForIssueCommentAsync(
                owner: owner,
                repo: repo,
                commentId: commentId,
                reactionId: reactionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}