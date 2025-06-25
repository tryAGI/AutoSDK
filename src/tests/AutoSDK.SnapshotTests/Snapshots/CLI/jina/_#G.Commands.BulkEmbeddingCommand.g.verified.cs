//HintName: G.Commands.BulkEmbeddingCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BulkEmbeddingCommand : global::System.CommandLine.Command
    {
        public BulkEmbeddingCommand(
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