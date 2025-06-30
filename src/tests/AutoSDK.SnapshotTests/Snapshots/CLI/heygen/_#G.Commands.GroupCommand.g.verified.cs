//HintName: G.Commands.GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroupCommand : global::System.CommandLine.Command
    {
        public GroupCommand(
            V1VideoStatusGetCommand command0)
            : base(
                name: "")
        {
            Subcommands.Add(command0);
        }
    }
}