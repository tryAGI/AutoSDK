//HintName: G.Commands.EmbeddingCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EmbeddingCommand : global::System.CommandLine.Command
    {
        public EmbeddingCommand(
            CreateEmbeddingCommand command0)
            : base(
                name: "embedding")
        {
            Subcommands.Add(command0);
        }
    }
}