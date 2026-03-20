//HintName: G.Commands.MultiVectorGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MultiVectorGroupCommand : global::System.CommandLine.Command
    {
        public MultiVectorGroupCommand(
            MultiVectorCreateMultiVectorV1MultiEmbeddingsPostCommand command0,
            MultiVectorCreateMultiVectorV1MultiVectorPostCommand command1)
            : base(
                name: "multivector")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}