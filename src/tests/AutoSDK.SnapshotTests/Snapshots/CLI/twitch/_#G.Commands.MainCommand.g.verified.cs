//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            AdGroupCommand command0,
            AnalyticGroupCommand command1,
            BitGroupCommand command2,
            ChannelGroupCommand command3,
            ChannelPointGroupCommand command4,
            CharityGroupCommand command5,
            ChatGroupCommand command6,
            ClipGroupCommand command7,
            ConduitGroupCommand command8,
            CCLGroupCommand command9,
            EntitlementGroupCommand command10,
            ExtensionGroupCommand command11,
            EventSubGroupCommand command12,
            GameGroupCommand command13,
            GoalGroupCommand command14,
            GuestStarGroupCommand command15,
            HypeTrainGroupCommand command16,
            ModerationGroupCommand command17,
            PollGroupCommand command18,
            PredictionGroupCommand command19,
            RaidGroupCommand command20,
            ScheduleGroupCommand command21,
            SearchGroupCommand command22,
            StreamGroupCommand command23,
            SubscriptionGroupCommand command24,
            TagGroupCommand command25,
            TeamGroupCommand command26,
            UserGroupCommand command27,
            VideoGroupCommand command28,
            WhisperGroupCommand command29)
            : base(
                description: "CLI tool")
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
        }
    }
}