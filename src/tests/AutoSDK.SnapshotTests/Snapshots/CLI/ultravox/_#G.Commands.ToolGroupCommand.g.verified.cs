//HintName: G.Commands.ToolGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ToolGroupCommand : global::System.CommandLine.Command
    {
        public ToolGroupCommand(
            ToolsToolsCreateCommand command0,
            ToolsToolsDestroyCommand command1,
            ToolsToolsHistoryListCommand command2,
            ToolsToolsListCommand command3,
            ToolsToolsRetrieveCommand command4,
            ToolsToolsTestCreateCommand command5,
            ToolsToolsUpdateCommand command6)
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