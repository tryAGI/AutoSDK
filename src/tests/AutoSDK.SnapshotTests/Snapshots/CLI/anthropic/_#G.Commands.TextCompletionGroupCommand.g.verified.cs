//HintName: G.Commands.TextCompletionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TextCompletionGroupCommand : global::System.CommandLine.Command
    {
        public TextCompletionGroupCommand(
            CompletePostCommand command0)
            : base(
                name: "textcompletion")
        {
            Subcommands.Add(command0);
        }
    }
}