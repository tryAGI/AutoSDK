//HintName: G.Commands.ToolGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ToolGroupCommand : global::System.CommandLine.Command
    {
        public ToolGroupCommand(
            ToolsToolsListCommand command0,
            ToolsToolsCreateCommand command1,
            ToolsToolsRetrieveCommand command2,
            ToolsToolsUpdateCommand command3,
            ToolsToolsDestroyCommand command4,
            ToolsToolsHistoryListCommand command5,
            ToolsToolsTestCreateCommand command6)
            : base(
                name: "tool")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
        }
    }
}