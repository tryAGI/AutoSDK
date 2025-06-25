//HintName: G.Commands.MarkdownCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MarkdownCommand : global::System.CommandLine.Command
    {
        public MarkdownCommand(
            MarkdownRenderCommand command0,
            MarkdownRenderRawCommand command1)
            : base(
                name: "markdown")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}