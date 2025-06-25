//HintName: G.Commands.CreateBatchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateBatchCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string inputFileId,
            global::G.CreateBatchRequestEndpoint endpoint,
            global::G.CreateBatchRequestCompletionWindow completionWindow,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Batch response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> InputFileId { get; } = new(
            name: "inputFileId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.CreateBatchRequestEndpoint> Endpoint { get; } = new(
            name: "endpoint")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateBatchRequestCompletionWindow> CompletionWindow { get; } = new(
            name: "completionWindow")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };
        public CreateBatchCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(InputFileId);
            Arguments.Add(Endpoint);
            Options.Add(CompletionWindow);
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