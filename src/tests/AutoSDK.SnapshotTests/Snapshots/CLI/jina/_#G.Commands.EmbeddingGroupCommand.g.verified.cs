//HintName: G.Commands.EmbeddingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EmbeddingGroupCommand : global::System.CommandLine.Command
    {
        public EmbeddingGroupCommand(
            CreateEmbeddingV1EmbeddingsPostCommand command0)
            : base(
                name: "embedding")
        {
            Subcommands.Add(command0);
        }
    }
}