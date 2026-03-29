//HintName: G.Commands.CheckGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CheckGroupCommand : global::System.CommandLine.Command
    {
        public CheckGroupCommand(
            CheckCheckAccessCommand command0,
            CheckGetWorkspaceNameCommand command1)
            : base(
                name: "check")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}