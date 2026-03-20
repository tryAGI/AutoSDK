//HintName: G.Commands.ChannelGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChannelGroupCommand : global::System.CommandLine.Command
    {
        public ChannelGroupCommand(
            ChannelsGetChannelInformationCommand command0,
            ChannelsModifyChannelInformationCommand command1,
            ChannelsGetChannelEditorsCommand command2,
            ChannelsGetFollowedChannelsCommand command3,
            ChannelsGetChannelFollowersCommand command4)
            : base(
                name: "channel")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}