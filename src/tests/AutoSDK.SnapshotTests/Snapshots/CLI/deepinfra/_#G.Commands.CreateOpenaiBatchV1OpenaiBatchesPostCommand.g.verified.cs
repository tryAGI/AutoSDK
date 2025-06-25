//HintName: G.Commands.CreateOpenaiBatchV1OpenaiBatchesPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateOpenaiBatchV1OpenaiBatchesPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string inputFileId,
            global::G.OpenAIBatchesInEndpoint endpoint,
            global::G.OpenAIBatchesInCompletionWindow completionWindow,
            object? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OpenAIBatch response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> InputFileId { get; } = new(
            name: "inputFileId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.OpenAIBatchesInEndpoint> Endpoint { get; } = new(
            name: "endpoint")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<object?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.OpenAIBatchesInCompletionWindow> CompletionWindow { get; } = new(
            name: "completionWindow")
        {
            Description = @"",
        };
        public CreateOpenaiBatchV1OpenaiBatchesPostCommand(G.IApi client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(InputFileId);
            Arguments.Add(Endpoint);
            Arguments.Add(Metadata);
            Options.Add(XiApiKey);
            Options.Add(CompletionWindow);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var inputFileId = parseResult.GetRequiredValue(InputFileId);
            var endpoint = parseResult.GetRequiredValue(Endpoint);
            var completionWindow = parseResult.GetRequiredValue(CompletionWindow);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                inputFileId: inputFileId,
                endpoint: endpoint,
                completionWindow: completionWindow,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateOpenaiBatchV1OpenaiBatchesPostAsync(
                xiApiKey: xiApiKey,
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