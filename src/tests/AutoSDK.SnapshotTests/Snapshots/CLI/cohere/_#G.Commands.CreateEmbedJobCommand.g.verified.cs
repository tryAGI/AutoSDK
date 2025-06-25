//HintName: G.Commands.CreateEmbedJobCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateEmbedJobCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.EmbedInputType> InputType { get; } = new(
            name: "inputType")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.EmbeddingType>?> EmbeddingTypes { get; } = new(
            name: "embeddingTypes")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateEmbedJobRequestTruncate?> Truncate { get; } = new(
            name: "truncate")
        {
            Description = "",
        };
        public CreateEmbedJobCommand(G.IApi client) : base(
            name: "create",
            description: @"This API launches an async Embed job for a [Dataset](https://docs.cohere.com/docs/datasets) of type `embed-input`. The result of a completed embed job is new Dataset of type `embed-output`, which contains the original text entries and the corresponding embeddings.")
        {
            _client = client;

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