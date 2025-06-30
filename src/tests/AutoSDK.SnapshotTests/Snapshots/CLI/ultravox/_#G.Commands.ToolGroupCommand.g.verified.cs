//HintName: G.Commands.ToolGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ToolGroupCommand : global::System.CommandLine.Command
    {
        public ToolGroupCommand(
            ToolsListCommand command0,
            ToolsCreateCommand command1,
            ToolsRetrieveCommand command2,
            ToolsUpdateCommand command3,
            ToolsDestroyCommand command4,
            ToolsHistoryListCommand command5,
            ToolsTestCreateCommand command6)
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