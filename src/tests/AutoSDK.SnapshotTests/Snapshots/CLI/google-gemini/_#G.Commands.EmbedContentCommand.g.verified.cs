//HintName: G.Commands.EmbedContentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EmbedContentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelId,
            string? title,
            global::G.Content? content,
            global::G.EmbedContentRequestTaskType? taskType,
            string? model,
            int? outputDimensionality,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EmbedContentResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = @"The id of the model to use.",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = @"Optional. An optional title for the text. Only applicable when TaskType is `RETRIEVAL_DOCUMENT`. Note: Specifying a `title` for `RETRIEVAL_DOCUMENT` provides better quality embeddings for retrieval.",
        };

        private global::System.CommandLine.Option<global::G.Content?> Content { get; } = new(
            name: "content")
        {
            Description = @"The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.",
        };

        private global::System.CommandLine.Option<global::G.EmbedContentRequestTaskType?> TaskType { get; } = new(
            name: "taskType")
        {
            Description = @"Optional. Optional task type for which the embeddings will be used. Can only be set for `models/embedding-001` or newer models.",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = @"Required. The model's resource name. This serves as an ID for the Model to use. This name should match a model name returned by the `ListModels` method. Format: `models/{model}`",
        };

        private global::System.CommandLine.Option<int?> OutputDimensionality { get; } = new(
            name: "outputDimensionality")
        {
            Description = @"Optional. Optional reduced dimension for the output embedding. If set, excessive values in the output embedding are truncated from the end. Supported by newer models since 2024, and the earlier model (`models/embedding-001`) cannot specify this value.",
        };
        public EmbedContentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "embed",
            description: @"Generates an embedding from the model given an input `Content`.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ModelId);
            Options.Add(Title);
            Options.Add(Content);
            Options.Add(TaskType);
            Options.Add(Model);
            Options.Add(OutputDimensionality);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var modelId = parseResult.GetRequiredValue(ModelId);
            var title = parseResult.GetRequiredValue(Title);
            var content = parseResult.GetRequiredValue(Content);
            var taskType = parseResult.GetRequiredValue(TaskType);
            var model = parseResult.GetRequiredValue(Model);
            var outputDimensionality = parseResult.GetRequiredValue(OutputDimensionality);

            Validate(
                parseResult: parseResult,
                modelId: modelId,
                title: title,
                content: content,
                taskType: taskType,
                model: model,
                outputDimensionality: outputDimensionality,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.EmbedContentAsync(
                modelId: modelId,
                title: title,
                content: content,
                taskType: taskType,
                model: model,
                outputDimensionality: outputDimensionality,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}