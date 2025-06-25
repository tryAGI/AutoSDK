//HintName: G.Commands.CreateMultiVectorV1MultiVectorPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateMultiVectorV1MultiVectorPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::G.ApiSchemasEmbeddingTextDoc>, global::G.ApiSchemasEmbeddingTextDoc> input,
            global::G.TextEmbeddingAPIInputInputType? inputType,
            global::G.AnyOf<global::G.TextEmbeddingAPIInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.TextEmbeddingAPIInputEmbeddingTypeItem>>? embeddingType,
            int? dimensions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ColbertModelEmbeddingsOutput response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The identifier of the model.

Available models and corresponding param size and dimension:
- `jina-colbert-v1-en`,	137",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::G.ApiSchemasEmbeddingTextDoc>, global::G.ApiSchemasEmbeddingTextDoc>> Input { get; } = new(
            name: "input")
        {
            Description = @"List of texts to embed",
        };

        private global::System.CommandLine.Option<global::G.TextEmbeddingAPIInputInputType?> InputType { get; } = new(
            name: "inputType")
        {
            Description = @"Type of the embedding to compute, query or document",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<global::G.TextEmbeddingAPIInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.TextEmbeddingAPIInputEmbeddingTypeItem>>?> EmbeddingType { get; } = new(
            name: "embeddingType")
        {
            Description = @"The format in which you want the embeddings to be returned.Possible value are `float`, `base64`, `binary`, `ubinary` or a list containing any of them. Defaults to `float`",
        };

        private global::System.CommandLine.Option<int?> Dimensions { get; } = new(
            name: "dimensions")
        {
            Description = @"Dimensions of the vectors to be returned. Only valid for v2 colbert models. Defaults to 128",
        };
        public CreateMultiVectorV1MultiVectorPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create multiple vector representations of the given input texts. One vector representation for each token in the input text.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Input);
            Options.Add(InputType);
            Options.Add(EmbeddingType);
            Options.Add(Dimensions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var input = parseResult.GetRequiredValue(Input);
            var inputType = parseResult.GetRequiredValue(InputType);
            var embeddingType = parseResult.GetRequiredValue(EmbeddingType);
            var dimensions = parseResult.GetRequiredValue(Dimensions);

            Validate(
                parseResult: parseResult,
                model: model,
                input: input,
                inputType: inputType,
                embeddingType: embeddingType,
                dimensions: dimensions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.MultiVector.CreateMultiVectorV1MultiVectorPostAsync(
                model: model,
                input: input,
                inputType: inputType,
                embeddingType: embeddingType,
                dimensions: dimensions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}