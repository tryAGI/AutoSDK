//HintName: G.Commands.MultiVectorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MultiVectorCommand : global::System.CommandLine.Command
    {
        public MultiVectorCommand(
            CreateMultiVectorV1MultiVectorPostCommand command0,
            CreateMultiVectorV1MultiEmbeddingsPostCommand command1)
            : base(
                name: "multivector")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}