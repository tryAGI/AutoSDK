//HintName: G.Commands.ChannelPointGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChannelPointGroupCommand : global::System.CommandLine.Command
    {
        public ChannelPointGroupCommand(
            CreateCustomRewardsCommand command0,
            DeleteCustomRewardCommand command1,
            GetCustomRewardCommand command2,
            UpdateCustomRewardCommand command3,
            GetCustomRewardRedemptionCommand command4,
            UpdateRedemptionStatusCommand command5)
            : base(
                name: "channelpoint")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}