//HintName: G.Commands.DownloadResultV1BulkEmbeddingsJobIdDownloadResultPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DownloadResultV1BulkEmbeddingsJobIdDownloadResultPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string jobId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DownloadResultResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> JobId { get; } = new(
            name: "jobId")
        {
            Description = @"",
        };

        public DownloadResultV1BulkEmbeddingsJobIdDownloadResultPostCommand(G.IApi client) : base(
            name: "download",
            description: @"")
        {
            _client = client;

            Arguments.Add(JobId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var jobId = parseResult.GetRequiredValue(JobId);

            Validate(
                parseResult: parseResult,
                jobId: jobId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.BulkEmbeddings.DownloadResultV1BulkEmbeddingsJobIdDownloadResultPostAsync(
                jobId: jobId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}