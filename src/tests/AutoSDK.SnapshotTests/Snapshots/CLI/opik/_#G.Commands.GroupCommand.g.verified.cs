//HintName: G.Commands.GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroupCommand : global::System.CommandLine.Command
    {
        public GroupCommand(
            IsAliveCommand command0,
            VersionCommand command1)
            : base(
                name: "")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}