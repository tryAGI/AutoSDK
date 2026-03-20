//HintName: G.Commands.BulkEmbeddingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BulkEmbeddingGroupCommand : global::System.CommandLine.Command
    {
        public BulkEmbeddingGroupCommand(
            BulkEmbeddingsStartBulkEmbeddingV1BulkEmbeddingsPostCommand command0,
            BulkEmbeddingsRetrieveJobV1BulkEmbeddingsJobIdGetCommand command1,
            BulkEmbeddingsDownloadResultV1BulkEmbeddingsJobIdDownloadResultPostCommand command2)
            : base(
                name: "bulkembedding")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}