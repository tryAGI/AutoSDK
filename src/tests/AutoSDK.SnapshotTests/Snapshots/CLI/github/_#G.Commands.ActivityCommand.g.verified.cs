//HintName: G.Commands.ActivityCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActivityCommand : global::System.CommandLine.Command
    {
        public ActivityCommand(
            ActivityListPublicEventsCommand command0,
            ActivityGetFeedsCommand command1,
            ActivityListPublicEventsForRepoNetworkCommand command2,
            ActivityListNotificationsForAuthenticatedUserCommand command3,
            ActivityMarkNotificationsAsReadCommand command4,
            ActivityGetThreadCommand command5,
            ActivityMarkThreadAsReadCommand command6,
            ActivityMarkThreadAsDoneCommand command7,
            ActivityGetThreadSubscriptionForAuthenticatedUserCommand command8,
            ActivitySetThreadSubscriptionCommand command9,
            ActivityDeleteThreadSubscriptionCommand command10,
            ActivityListPublicOrgEventsCommand command11,
            ActivityListRepoEventsCommand command12,
            ActivityListRepoNotificationsForAuthenticatedUserCommand command13,
            ActivityMarkRepoNotificationsAsReadCommand command14,
            ActivityListStargazersForRepoCommand command15,
            ActivityListWatchersForRepoCommand command16,
            ActivityGetRepoSubscriptionCommand command17,
            ActivitySetRepoSubscriptionCommand command18,
            ActivityDeleteRepoSubscriptionCommand command19,
            ActivityListReposStarredByAuthenticatedUserCommand command20,
            ActivityCheckRepoIsStarredByAuthenticatedUserCommand command21,
            ActivityStarRepoForAuthenticatedUserCommand command22,
            ActivityUnstarRepoForAuthenticatedUserCommand command23,
            ActivityListWatchedReposForAuthenticatedUserCommand command24,
            ActivityListEventsForAuthenticatedUserCommand command25,
            ActivityListOrgEventsForAuthenticatedUserCommand command26,
            ActivityListPublicEventsForUserCommand command27,
            ActivityListReceivedEventsForUserCommand command28,
            ActivityListReceivedPublicEventsForUserCommand command29,
            ActivityListReposStarredByUserCommand command30,
            ActivityListReposWatchedByUserCommand command31)
            : base(
                name: "activity")
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
        }
    }
}