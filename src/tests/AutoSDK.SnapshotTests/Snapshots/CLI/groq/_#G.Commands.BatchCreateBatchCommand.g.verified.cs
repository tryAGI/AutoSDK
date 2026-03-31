//HintName: G.Commands.BatchCreateBatchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BatchCreateBatchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string inputFileId,
            global::G.CreateBatchRequestEndpoint endpoint,
            string completionWindow,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Batch response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> InputFileId { get; } = new(
            name: "inputFileId")
        {
            Description = @"The ID of an uploaded file that contains requests for the new batch.

See [upload file](/docs/api-reference#files-upload) for how to upload a file.

Your input file must be formatted as a [JSONL file](/docs/batch), and must be uploaded with the purpose `batch`. The file can be up to 100 MB in size.",
        };

        private global::System.CommandLine.Argument<string> CompletionWindow { get; } = new(
            name: "completionWindow")
        {
            Description = @"The time frame within which the batch should be processed. Durations from `24h` to `7d` are supported.",
        };

        private global::System.CommandLine.Option<global::G.CreateBatchRequestEndpoint> Endpoint { get; } = new(
            name: "endpoint")
        {
            Description = @"The endpoint to be used for all requests in the batch. Currently `/v1/chat/completions` is supported.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"Optional custom metadata for the batch.",
        };


        public BatchCreateBatchCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(InputFileId);
            Arguments.Add(CompletionWindow);
            Options.Add(Endpoint);
            Options.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var inputFileId = parseResult.GetRequiredValue(InputFileId);
            var endpoint = parseResult.GetRequiredValue(Endpoint);
            var completionWindow = parseResult.GetRequiredValue(CompletionWindow);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                inputFileId: inputFileId,
                endpoint: endpoint,
                completionWindow: completionWindow,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Batch.CreateBatchAsync(
                inputFileId: inputFileId,
                endpoint: endpoint,
                completionWindow: completionWindow,
                metadata: metadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}