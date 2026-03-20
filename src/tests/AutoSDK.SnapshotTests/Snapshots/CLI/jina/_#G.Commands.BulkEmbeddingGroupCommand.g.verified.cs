//HintName: G.Commands.BulkEmbeddingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BulkEmbeddingGroupCommand : global::System.CommandLine.Command
    {
        public BulkEmbeddingGroupCommand(
            BulkEmbeddingsDownloadResultV1BulkEmbeddingsJobIdDownloadResultPostCommand command0,
            BulkEmbeddingsRetrieveJobV1BulkEmbeddingsJobIdGetCommand command1,
            BulkEmbeddingsStartBulkEmbeddingV1BulkEmbeddingsPostCommand command2)
            : base(
                name: "bulkembedding")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}