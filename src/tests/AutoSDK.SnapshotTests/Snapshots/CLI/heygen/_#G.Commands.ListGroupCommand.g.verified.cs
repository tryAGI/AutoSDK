//HintName: G.Commands.ListGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListGroupCommand : global::System.CommandLine.Command
    {
        public ListGroupCommand(
            ListsV1VoiceListCommand command0,
            ListsV1AvatarListCommand command1,
            ListsV2VoicesCommand command2,
            ListsV2AvatarsCommand command3,
            ListsV1VideoListCommand command4)
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