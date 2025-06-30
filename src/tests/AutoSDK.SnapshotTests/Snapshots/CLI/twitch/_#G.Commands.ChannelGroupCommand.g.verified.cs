//HintName: G.Commands.ChannelGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChannelGroupCommand : global::System.CommandLine.Command
    {
        public ChannelGroupCommand(
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