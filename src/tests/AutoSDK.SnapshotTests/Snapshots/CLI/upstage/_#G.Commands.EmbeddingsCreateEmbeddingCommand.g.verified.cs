//HintName: G.Commands.EmbeddingsCreateEmbeddingCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EmbeddingsCreateEmbeddingCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.EmbeddingResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The model to use for generating embeddings.
Available models: solar-embedding-1-large, solar-embedding-1-large-passage,
solar-embedding-1-large-query",
        };

        private global::System.CommandLine.Argument<global::G.OneOf<string, global::System.Collections.Generic.IList<string>>> Input { get; } = new(
            name: "input")
        {
            Description = @"Input text to embed. Can be a string or array of strings.",
        };



        public EmbeddingsCreateEmbeddingCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates an embedding vector representing the input text.
Supports Solar Embedding models for passage and query embeddings.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Input);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var input = parseResult.GetRequiredValue(Input);

            Validate(
                parseResult: parseResult,
                model: model,
                input: input,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Embeddings.CreateEmbeddingAsync(
                model: model,
                input: input,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}