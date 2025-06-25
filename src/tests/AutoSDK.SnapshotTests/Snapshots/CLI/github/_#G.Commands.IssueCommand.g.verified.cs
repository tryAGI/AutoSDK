//HintName: G.Commands.IssueCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IssueCommand : global::System.CommandLine.Command
    {
        public IssueCommand(
            IssuesListCommand command0,
            IssuesListForOrgCommand command1,
            IssuesListAssigneesCommand command2,
            IssuesCheckUserCanBeAssignedCommand command3,
            IssuesListForRepoCommand command4,
            IssuesCreateCommand command5,
            IssuesListCommentsForRepoCommand command6,
            IssuesGetCommentCommand command7,
            IssuesUpdateCommentCommand command8,
            IssuesDeleteCommentCommand command9,
            IssuesListEventsForRepoCommand command10,
            IssuesGetEventCommand command11,
            IssuesGetCommand command12,
            IssuesUpdateCommand command13,
            IssuesAddAssigneesCommand command14,
            IssuesRemoveAssigneesCommand command15,
            IssuesCheckUserCanBeAssignedToIssueCommand command16,
            IssuesListCommentsCommand command17,
            IssuesCreateCommentCommand command18,
            IssuesListEventsCommand command19,
            IssuesListLabelsOnIssueCommand command20,
            IssuesAddLabelsCommand command21,
            IssuesSetLabelsCommand command22,
            IssuesRemoveAllLabelsCommand command23,
            IssuesRemoveLabelCommand command24,
            IssuesLockCommand command25,
            IssuesUnlockCommand command26,
            IssuesListEventsForTimelineCommand command27,
            IssuesListLabelsForRepoCommand command28,
            IssuesCreateLabelCommand command29,
            IssuesGetLabelCommand command30,
            IssuesUpdateLabelCommand command31,
            IssuesDeleteLabelCommand command32,
            IssuesListMilestonesCommand command33,
            IssuesCreateMilestoneCommand command34,
            IssuesGetMilestoneCommand command35,
            IssuesUpdateMilestoneCommand command36,
            IssuesDeleteMilestoneCommand command37,
            IssuesListLabelsForMilestoneCommand command38,
            IssuesListForAuthenticatedUserCommand command39)
            : base(
                name: "issue")
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
            Subcommands.Add(command27);
            Subcommands.Add(command28);
            Subcommands.Add(command29);
            Subcommands.Add(command30);
            Subcommands.Add(command31);
            Subcommands.Add(command32);
            Subcommands.Add(command33);
            Subcommands.Add(command34);
            Subcommands.Add(command35);
            Subcommands.Add(command36);
            Subcommands.Add(command37);
            Subcommands.Add(command38);
            Subcommands.Add(command39);
        }
    }
}