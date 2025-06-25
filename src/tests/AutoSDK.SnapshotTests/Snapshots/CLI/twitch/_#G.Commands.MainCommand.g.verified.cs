//HintName: G.Commands.MainCommand.g.cs

#nullable enable

namespace G
{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {
        public MainCommand(
            AdCommand command0,
            AnalyticCommand command1,
            BitCommand command2,
            ChannelCommand command3,
            ChannelPointCommand command4,
            CharityCommand command5,
            ChatCommand command6,
            ClipCommand command7,
            ConduitCommand command8,
            CCLCommand command9,
            EntitlementCommand command10,
            ExtensionCommand command11,
            EventSubCommand command12,
            GameCommand command13,
            GoalCommand command14,
            GuestStarCommand command15,
            HypeTrainCommand command16,
            ModerationCommand command17,
            PollCommand command18,
            PredictionCommand command19,
            RaidCommand command20,
            ScheduleCommand command21,
            SearchCommand command22,
            StreamCommand command23,
            SubscriptionCommand command24,
            TagCommand command25,
            TeamCommand command26,
            UserCommand command27,
            VideoCommand command28,
            WhisperCommand command29)
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