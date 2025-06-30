//HintName: G.Commands.BulkEmbeddingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BulkEmbeddingGroupCommand : global::System.CommandLine.Command
    {
        public BulkEmbeddingGroupCommand(
            StartBulkEmbeddingV1BulkEmbeddingsPostCommand command0,
            RetrieveJobV1BulkEmbeddingsJobIdGetCommand command1,
            DownloadResultV1BulkEmbeddingsJobIdDownloadResultPostCommand command2)
            : base(
                name: "bulkembedding")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}