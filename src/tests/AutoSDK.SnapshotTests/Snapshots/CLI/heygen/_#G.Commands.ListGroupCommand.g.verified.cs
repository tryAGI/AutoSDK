//HintName: G.Commands.ListGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListGroupCommand : global::System.CommandLine.Command
    {
        public ListGroupCommand(
            V1VoiceListCommand command0,
            V1AvatarListCommand command1,
            V2VoicesCommand command2,
            V2AvatarsCommand command3,
            V1VideoListCommand command4)
            : base(
                name: "list")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}