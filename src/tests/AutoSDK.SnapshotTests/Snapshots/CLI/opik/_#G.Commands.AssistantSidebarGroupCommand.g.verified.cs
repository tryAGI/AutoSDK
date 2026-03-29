//HintName: G.Commands.AssistantSidebarGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AssistantSidebarGroupCommand : global::System.CommandLine.Command
    {
        public AssistantSidebarGroupCommand(
            AssistantSidebarsGetAssistantSidebarConfigCommand command0)
            : base(
                name: "assistantsidebar")
        {
            Subcommands.Add(command0);
        }
    }
}