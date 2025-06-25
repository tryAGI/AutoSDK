//HintName: G.Commands.CreateMultiVectorV1MultiEmbeddingsPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateMultiVectorV1MultiEmbeddingsPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::G.ApiSchemasEmbeddingTextDoc>, global::G.ApiSchemasEmbeddingTextDoc>> Input { get; } = new(
            name: "input")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.TextEmbeddingAPIInputInputType?> InputType { get; } = new(
            name: "inputType")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<global::G.TextEmbeddingAPIInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.TextEmbeddingAPIInputEmbeddingTypeItem>>?> EmbeddingType { get; } = new(
            name: "embeddingType")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Dimensions { get; } = new(
            name: "dimensions")
        {
            Description = @"",
        };
        public CreateMultiVectorV1MultiEmbeddingsPostCommand(G.IApi client) : base(
            name: "create",
            description: @"Create multiple vector representations of the given input texts. One vector representation for each token in the input text.")
        {
            _client = client;

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
            var response = await _client.MultiVector.CreateMultiVectorV1MultiEmbeddingsPostAsync(
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