//HintName: G.Commands.PullCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PullCommand : global::System.CommandLine.Command
    {
        public PullCommand(
            PullsListCommand command0,
            PullsCreateCommand command1,
            PullsListReviewCommentsForRepoCommand command2,
            PullsGetReviewCommentCommand command3,
            PullsUpdateReviewCommentCommand command4,
            PullsDeleteReviewCommentCommand command5,
            PullsGetCommand command6,
            PullsUpdateCommand command7,
            PullsListReviewCommentsCommand command8,
            PullsCreateReviewCommentCommand command9,
            PullsCreateReplyForReviewCommentCommand command10,
            PullsListCommitsCommand command11,
            PullsListFilesCommand command12,
            PullsCheckIfMergedCommand command13,
            PullsMergeCommand command14,
            PullsListRequestedReviewersCommand command15,
            PullsRequestReviewersCommand command16,
            PullsRemoveRequestedReviewersCommand command17,
            PullsListReviewsCommand command18,
            PullsCreateReviewCommand command19,
            PullsGetReviewCommand command20,
            PullsUpdateReviewCommand command21,
            PullsDeletePendingReviewCommand command22,
            PullsListCommentsForReviewCommand command23,
            PullsDismissReviewCommand command24,
            PullsSubmitReviewCommand command25,
            PullsUpdateBranchCommand command26)
            : base(
                name: "pull")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
            Subcommands.Add(command9);
            Subcommands.Add(command10);
            Subcommands.Add(command11);
            Subcommands.Add(command12);
            Subcommands.Add(command13);
            Subcommands.Add(command14);
            Subcommands.Add(command15);
            Subcommands.Add(command16);
            Subcommands.Add(command17);
            Subcommands.Add(command18);
            Subcommands.Add(command19);
            Subcommands.Add(command20);
            Subcommands.Add(command21);
            Subcommands.Add(command22);
            Subcommands.Add(command23);
            Subcommands.Add(command24);
            Subcommands.Add(command25);
            Subcommands.Add(command26);
        }
    }
}