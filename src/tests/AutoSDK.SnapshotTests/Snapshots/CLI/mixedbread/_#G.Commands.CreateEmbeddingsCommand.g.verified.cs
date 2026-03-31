//HintName: G.Commands.CreateEmbeddingsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateEmbeddingsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> input,
            int? dimensions,
            string? prompt,
            bool? normalized,
            global::G.AnyOf<global::G.EncodingFormat3?, global::System.Collections.Generic.IList<global::G.EncodingFormat3>>? encodingFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.EmbeddingCreateResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The model to use for creating embeddings.",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>> Input { get; } = new(
            name: "input")
        {
            Description = @"The input to create embeddings for.",
        };

        private global::System.CommandLine.Option<int?> Dimensions { get; } = new(
            name: "dimensions")
        {
            Description = @"The number of dimensions to use for the embeddings.",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"The prompt to use for the embedding creation.",
        };

        private global::System.CommandLine.Option<bool?> Normalized { get; } = new(
            name: "normalized")
        {
            Description = @"Whether to normalize the embeddings.",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<global::G.EncodingFormat3?, global::System.Collections.Generic.IList<global::G.EncodingFormat3>>?> EncodingFormat { get; } = new(
            name: "encodingFormat")
        {
            Description = @"The encoding format(s) of the embeddings. Can be a single format or a list of formats.",
        };


        public CreateEmbeddingsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create embeddings for text or images using the specified model, encoding format, and normalization.

Args:
    params: The parameters for creating embeddings.

Returns:
    EmbeddingCreateResponse: The response containing the embeddings.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Input);
            Options.Add(Dimensions);
            Options.Add(Prompt);
            Options.Add(Normalized);
            Options.Add(EncodingFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var input = parseResult.GetRequiredValue(Input);
            var dimensions = parseResult.GetRequiredValue(Dimensions);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var normalized = parseResult.GetRequiredValue(Normalized);
            var encodingFormat = parseResult.GetRequiredValue(EncodingFormat);

            Validate(
                parseResult: parseResult,
                model: model,
                input: input,
                dimensions: dimensions,
                prompt: prompt,
                normalized: normalized,
                encodingFormat: encodingFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateEmbeddingsAsync(
                model: model,
                input: input,
                dimensions: dimensions,
                prompt: prompt,
                normalized: normalized,
                encodingFormat: encodingFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}