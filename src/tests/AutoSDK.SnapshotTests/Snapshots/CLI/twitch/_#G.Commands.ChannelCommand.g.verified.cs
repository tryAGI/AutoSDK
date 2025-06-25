//HintName: G.Commands.ChannelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChannelCommand : global::System.CommandLine.Command
    {
        public ChannelCommand(
            GetChannelInformationCommand command0,
            ModifyChannelInformationCommand command1,
            GetChannelEditorsCommand command2,
            GetFollowedChannelsCommand command3,
            GetChannelFollowersCommand command4)
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