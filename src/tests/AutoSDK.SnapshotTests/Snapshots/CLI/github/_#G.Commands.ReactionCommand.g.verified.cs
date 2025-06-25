//HintName: G.Commands.ReactionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReactionCommand : global::System.CommandLine.Command
    {
        public ReactionCommand(
            ReactionsListForTeamDiscussionCommentInOrgCommand command0,
            ReactionsCreateForTeamDiscussionCommentInOrgCommand command1,
            ReactionsDeleteForTeamDiscussionCommentCommand command2,
            ReactionsListForTeamDiscussionInOrgCommand command3,
            ReactionsCreateForTeamDiscussionInOrgCommand command4,
            ReactionsDeleteForTeamDiscussionCommand command5,
            ReactionsListForCommitCommentCommand command6,
            ReactionsCreateForCommitCommentCommand command7,
            ReactionsDeleteForCommitCommentCommand command8,
            ReactionsListForIssueCommentCommand command9,
            ReactionsCreateForIssueCommentCommand command10,
            ReactionsDeleteForIssueCommentCommand command11,
            ReactionsListForIssueCommand command12,
            ReactionsCreateForIssueCommand command13,
            ReactionsDeleteForIssueCommand command14,
            ReactionsListForPullRequestReviewCommentCommand command15,
            ReactionsCreateForPullRequestReviewCommentCommand command16,
            ReactionsDeleteForPullRequestCommentCommand command17,
            ReactionsListForReleaseCommand command18,
            ReactionsCreateForReleaseCommand command19,
            ReactionsDeleteForReleaseCommand command20,
            ReactionsListForTeamDiscussionCommentLegacyCommand command21,
            ReactionsCreateForTeamDiscussionCommentLegacyCommand command22,
            ReactionsListForTeamDiscussionLegacyCommand command23,
            ReactionsCreateForTeamDiscussionLegacyCommand command24)
            : base(
                name: "reaction")
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
        }
    }
}