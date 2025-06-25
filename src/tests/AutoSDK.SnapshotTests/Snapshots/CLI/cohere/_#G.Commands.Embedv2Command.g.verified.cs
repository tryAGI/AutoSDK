//HintName: G.Commands.Embedv2Command.g.cs

#nullable enable

namespace G
{
    internal sealed partial class Embedv2Command : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            global::System.Collections.Generic.IList<global::G.EmbeddingType> embeddingTypes,
            global::System.Collections.Generic.IList<string>? images,
            global::G.EmbedInputType inputType,
            global::System.Collections.Generic.IList<global::G.EmbedInput>? inputs,
            int? maxTokens,
            string model,
            int? outputDimension,
            global::System.Collections.Generic.IList<string> texts,
            global::G.Embedv2RequestTruncate truncate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EmbedByTypeResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.EmbeddingType>> EmbeddingTypes { get; } = new(
            name: "embeddingTypes")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.EmbedInputType> InputType { get; } = new(
            name: "inputType")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Texts { get; } = new(
            name: "texts")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.Embedv2RequestTruncate> Truncate { get; } = new(
            name: "truncate")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Images { get; } = new(
            name: "images")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.EmbedInput>?> Inputs { get; } = new(
            name: "inputs")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> OutputDimension { get; } = new(
            name: "outputDimension")
        {
            Description = @"",
        };
        public Embedv2Command(G.IApi client) : base(
            name: "embedv2",
            description: @"This endpoint returns text embeddings. An embedding is a list of floating point numbers that captures semantic information about the text that it represents.

Embeddings can be used to create text classifiers as well as empower semantic search. To learn more about embeddings, see the embedding page.

If you want to learn more how to use the embedding model, have a look at the [Semantic Search Guide](https://docs.cohere.com/docs/semantic-search).")
        {
            _client = client;

            Arguments.Add(EmbeddingTypes);
            Arguments.Add(InputType);
            Arguments.Add(Model);
            Arguments.Add(Texts);
            Arguments.Add(Truncate);
            Options.Add(XClientName);
            Options.Add(Images);
            Options.Add(Inputs);
            Options.Add(MaxTokens);
            Options.Add(OutputDimension);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var embeddingTypes = parseResult.GetRequiredValue(EmbeddingTypes);
            var images = parseResult.GetRequiredValue(Images);
            var inputType = parseResult.GetRequiredValue(InputType);
            var inputs = parseResult.GetRequiredValue(Inputs);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var model = parseResult.GetRequiredValue(Model);
            var outputDimension = parseResult.GetRequiredValue(OutputDimension);
            var texts = parseResult.GetRequiredValue(Texts);
            var truncate = parseResult.GetRequiredValue(Truncate);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                embeddingTypes: embeddingTypes,
                images: images,
                inputType: inputType,
                inputs: inputs,
                maxTokens: maxTokens,
                model: model,
                outputDimension: outputDimension,
                texts: texts,
                truncate: truncate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Embedv2Async(
                xClientName: xClientName,
                embeddingTypes: embeddingTypes,
                images: images,
                inputType: inputType,
                inputs: inputs,
                maxTokens: maxTokens,
                model: model,
                outputDimension: outputDimension,
                texts: texts,
                truncate: truncate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}