//HintName: G.Commands.EmbedCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EmbedCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            global::System.Collections.Generic.IList<string> texts,
            global::System.Collections.Generic.IList<string>? images,
            string model,
            global::G.EmbedInputType? inputType,
            global::System.Collections.Generic.IList<global::G.EmbeddingType> embeddingTypes,
            global::G.EmbedRequestTruncate truncate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EmbedResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Texts { get; } = new(
            name: "texts")
        {
            Description = @"An array of strings for the model to embed. Maximum number of texts per call is `96`.",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"ID of one of the available [Embedding models](https://docs.cohere.com/docs/cohere-embed).",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.EmbeddingType>> EmbeddingTypes { get; } = new(
            name: "embeddingTypes")
        {
            Description = @"Specifies the types of embeddings you want to get back. Not required and default is None, which returns the Embed Floats response type. Can be one or more of the following types.

* `""float""`: Use this when you want to get back the default float embeddings. Supported with all Embed models.
* `""int8""`: Use this when you want to get back signed int8 embeddings. Supported with Embed v3.0 and newer Embed models.
* `""uint8""`: Use this when you want to get back unsigned int8 embeddings. Supported with Embed v3.0 and newer Embed models.
* `""binary""`: Use this when you want to get back signed binary embeddings. Supported with Embed v3.0 and newer Embed models.
* `""ubinary""`: Use this when you want to get back unsigned binary embeddings. Supported with Embed v3.0 and newer Embed models.",
        };

        private global::System.CommandLine.Argument<global::G.EmbedRequestTruncate> Truncate { get; } = new(
            name: "truncate")
        {
            Description = @"One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.

Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.

If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Images { get; } = new(
            name: "images")
        {
            Description = @"An array of image data URIs for the model to embed. Maximum number of images per call is `1`.

The image must be a valid [data URI](https://developer.mozilla.org/en-US/docs/Web/URI/Schemes/data). The image must be in either `image/jpeg` or `image/png` format and has a maximum size of 5MB.

Images are only supported with Embed v3.0 and newer models.",
        };

        private global::System.CommandLine.Option<global::G.EmbedInputType?> InputType { get; } = new(
            name: "inputType")
        {
            Description = @"Specifies the type of input passed to the model. Required for embedding models v3 and higher.

- `""search_document""`: Used for embeddings stored in a vector database for search use-cases.
- `""search_query""`: Used for embeddings of search queries run against a vector DB to find relevant documents.
- `""classification""`: Used for embeddings passed through a text classifier.
- `""clustering""`: Used for the embeddings run through a clustering algorithm.
- `""image""`: Used for embeddings with image input.",
        };
        public EmbedCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "embed",
            description: @"This endpoint returns text and image embeddings. An embedding is a list of floating point numbers that captures semantic information about the content that it represents.

Embeddings can be used to create classifiers as well as empower semantic search. To learn more about embeddings, see the embedding page.

If you want to learn more how to use the embedding model, have a look at the [Semantic Search Guide](https://docs.cohere.com/docs/semantic-search).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Texts);
            Arguments.Add(Model);
            Arguments.Add(EmbeddingTypes);
            Arguments.Add(Truncate);
            Options.Add(XClientName);
            Options.Add(Images);
            Options.Add(InputType);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var texts = parseResult.GetRequiredValue(Texts);
            var images = parseResult.GetRequiredValue(Images);
            var model = parseResult.GetRequiredValue(Model);
            var inputType = parseResult.GetRequiredValue(InputType);
            var embeddingTypes = parseResult.GetRequiredValue(EmbeddingTypes);
            var truncate = parseResult.GetRequiredValue(Truncate);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                texts: texts,
                images: images,
                model: model,
                inputType: inputType,
                embeddingTypes: embeddingTypes,
                truncate: truncate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.EmbedAsync(
                xClientName: xClientName,
                texts: texts,
                images: images,
                model: model,
                inputType: inputType,
                embeddingTypes: embeddingTypes,
                truncate: truncate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}