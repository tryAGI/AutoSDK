//HintName: G.Commands.TextCompletionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TextCompletionCommand : global::System.CommandLine.Command
    {
        public TextCompletionCommand(
            CompletePostCommand command0)
            : base(
                name: "textcompletion")
        {
            Subcommands.Add(command0);
        }
    }
}