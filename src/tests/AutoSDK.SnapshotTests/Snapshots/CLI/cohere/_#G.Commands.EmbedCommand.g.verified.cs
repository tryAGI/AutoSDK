//HintName: G.Commands.EmbedCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EmbedCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            global::System.Collections.Generic.IList<global::G.EmbeddingType> embeddingTypes,
            global::System.Collections.Generic.IList<string>? images,
            global::G.EmbedInputType? inputType,
            string model,
            global::System.Collections.Generic.IList<string> texts,
            global::G.EmbedRequestTruncate truncate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EmbedResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.EmbeddingType>> EmbeddingTypes { get; } = new(
            name: "embeddingTypes")
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

        private global::System.CommandLine.Argument<global::G.EmbedRequestTruncate> Truncate { get; } = new(
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

        private global::System.CommandLine.Option<global::G.EmbedInputType?> InputType { get; } = new(
            name: "inputType")
        {
            Description = @"",
        };
        public EmbedCommand(G.IApi client) : base(
            name: "embed",
            description: @"This endpoint returns text and image embeddings. An embedding is a list of floating point numbers that captures semantic information about the content that it represents.

Embeddings can be used to create classifiers as well as empower semantic search. To learn more about embeddings, see the embedding page.

If you want to learn more how to use the embedding model, have a look at the [Semantic Search Guide](https://docs.cohere.com/docs/semantic-search).")
        {
            _client = client;

            Arguments.Add(EmbeddingTypes);
            Arguments.Add(Model);
            Arguments.Add(Texts);
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
            var embeddingTypes = parseResult.GetRequiredValue(EmbeddingTypes);
            var images = parseResult.GetRequiredValue(Images);
            var inputType = parseResult.GetRequiredValue(InputType);
            var model = parseResult.GetRequiredValue(Model);
            var texts = parseResult.GetRequiredValue(Texts);
            var truncate = parseResult.GetRequiredValue(Truncate);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                embeddingTypes: embeddingTypes,
                images: images,
                inputType: inputType,
                model: model,
                texts: texts,
                truncate: truncate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.EmbedAsync(
                xClientName: xClientName,
                embeddingTypes: embeddingTypes,
                images: images,
                inputType: inputType,
                model: model,
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