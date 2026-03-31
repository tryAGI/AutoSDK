//HintName: G.Commands.CompletionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CompletionGroupCommand : global::System.CommandLine.Command
    {
        public CompletionGroupCommand(
            CompletionsCreateChatCompletionCommand command0)
            : base(
                name: "completion")
        {
            Subcommands.Add(command0);
        }
    }
}