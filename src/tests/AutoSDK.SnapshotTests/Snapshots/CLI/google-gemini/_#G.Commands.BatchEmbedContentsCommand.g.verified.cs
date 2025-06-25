//HintName: G.Commands.BatchEmbedContentsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BatchEmbedContentsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelId,
            global::System.Collections.Generic.IList<global::G.EmbedContentRequest>? requests,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BatchEmbedContentsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = @"The id of the model to use.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.EmbedContentRequest>?> Requests { get; } = new(
            name: "requests")
        {
            Description = @"Required. Embed requests for the batch. The model in each of these requests must match the model specified `BatchEmbedContentsRequest.model`.",
        };
        public BatchEmbedContentsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "batch",
            description: @"Generates multiple embeddings from the model given input text in a synchronous call.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ModelId);
            Options.Add(Requests);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var modelId = parseResult.GetRequiredValue(ModelId);
            var requests = parseResult.GetRequiredValue(Requests);

            Validate(
                parseResult: parseResult,
                modelId: modelId,
                requests: requests,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.BatchEmbedContentsAsync(
                modelId: modelId,
                requests: requests,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}