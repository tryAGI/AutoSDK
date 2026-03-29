//HintName: G.Commands.ToolsApiGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ToolsApiGroupCommand : global::System.CommandLine.Command
    {
        public ToolsApiGroupCommand(
            ToolsApiCreateToolsAiDetectCommand command0,
            ToolsApiCreateToolsComprehendMedicalCommand command1,
            ToolsApiCreateToolsContextAwareSplittingCommand command2,
            ToolsApiCreateToolsPdfParserByFileIdCommand command3,
            ToolsApiCreateToolsTextToGraphCommand command4,
            ToolsApiCreateToolsWebSearchCommand command5)
            : base(
                name: "toolsapi")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}