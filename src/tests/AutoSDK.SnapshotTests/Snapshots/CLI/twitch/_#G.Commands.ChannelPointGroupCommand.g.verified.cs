//HintName: G.Commands.ChannelPointGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChannelPointGroupCommand : global::System.CommandLine.Command
    {
        public ChannelPointGroupCommand(
            ChannelPointsCreateCustomRewardsCommand command0,
            ChannelPointsDeleteCustomRewardCommand command1,
            ChannelPointsGetCustomRewardCommand command2,
            ChannelPointsUpdateCustomRewardCommand command3,
            ChannelPointsGetCustomRewardRedemptionCommand command4,
            ChannelPointsUpdateRedemptionStatusCommand command5)
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