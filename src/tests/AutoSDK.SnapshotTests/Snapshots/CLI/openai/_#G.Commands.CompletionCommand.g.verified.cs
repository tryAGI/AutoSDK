//HintName: G.Commands.CompletionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CompletionCommand : global::System.CommandLine.Command
    {
        public CompletionCommand(
            CreateCompletionCommand command0)
            : base(
                name: "completion")
        {
            Subcommands.Add(command0);
        }
    }
}