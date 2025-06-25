//HintName: G.Commands.CreateEmbedJobCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateEmbedJobCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            string datasetId,
            global::System.Collections.Generic.IList<global::G.EmbeddingType>? embeddingTypes,
            global::G.EmbedInputType inputType,
            string model,
            string? name,
            global::G.CreateEmbedJobRequestTruncate? truncate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateEmbedJobResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DatasetId { get; } = new(
            name: "datasetId")
        {
            Description = @"ID of a [Dataset](https://docs.cohere.com/docs/datasets). The Dataset must be of type `embed-input` and must have a validation status `Validated`",
        };

        private global::System.CommandLine.Argument<global::G.EmbedInputType> InputType { get; } = new(
            name: "inputType")
        {
            Description = @"Specifies the type of input passed to the model. Required for embedding models v3 and higher.

- `""search_document""`: Used for embeddings stored in a vector database for search use-cases.
- `""search_query""`: Used for embeddings of search queries run against a vector DB to find relevant documents.
- `""classification""`: Used for embeddings passed through a text classifier.
- `""clustering""`: Used for the embeddings run through a clustering algorithm.
- `""image""`: Used for embeddings with image input.",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"ID of the embedding model.

Available models and corresponding embedding dimensions:

- `embed-english-v3.0` : 1024
- `embed-multilingual-v3.0` : 1024
- `embed-english-light-v3.0` : 384
- `embed-multilingual-light-v3.0` : 384",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.EmbeddingType>?> EmbeddingTypes { get; } = new(
            name: "embeddingTypes")
        {
            Description = @"Specifies the types of embeddings you want to get back. Not required and default is None, which returns the Embed Floats response type. Can be one or more of the following types.

* `""float""`: Use this when you want to get back the default float embeddings. Valid for all models.
* `""int8""`: Use this when you want to get back signed int8 embeddings. Valid for v3 and newer model versions.
* `""uint8""`: Use this when you want to get back unsigned int8 embeddings. Valid for v3 and newer model versions.
* `""binary""`: Use this when you want to get back signed binary embeddings. Valid for v3 and newer model versions.
* `""ubinary""`: Use this when you want to get back unsigned binary embeddings. Valid for v3 and newer model versions.",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"The name of the embed job.",
        };

        private global::System.CommandLine.Option<global::G.CreateEmbedJobRequestTruncate?> Truncate { get; } = new(
            name: "truncate")
        {
            Description = @"One of `START|END` to specify how the API will handle inputs longer than the maximum token length.

Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.",
        };
        public CreateEmbedJobCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This API launches an async Embed job for a [Dataset](https://docs.cohere.com/docs/datasets) of type `embed-input`. The result of a completed embed job is new Dataset of type `embed-output`, which contains the original text entries and the corresponding embeddings.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DatasetId);
            Arguments.Add(InputType);
            Arguments.Add(Model);
            Options.Add(XClientName);
            Options.Add(EmbeddingTypes);
            Options.Add(Name);
            Options.Add(Truncate);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var datasetId = parseResult.GetRequiredValue(DatasetId);
            var embeddingTypes = parseResult.GetRequiredValue(EmbeddingTypes);
            var inputType = parseResult.GetRequiredValue(InputType);
            var model = parseResult.GetRequiredValue(Model);
            var name = parseResult.GetRequiredValue(Name);
            var truncate = parseResult.GetRequiredValue(Truncate);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                datasetId: datasetId,
                embeddingTypes: embeddingTypes,
                inputType: inputType,
                model: model,
                name: name,
                truncate: truncate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.EmbedJobs.CreateEmbedJobAsync(
                xClientName: xClientName,
                datasetId: datasetId,
                embeddingTypes: embeddingTypes,
                inputType: inputType,
                model: model,
                name: name,
                truncate: truncate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}