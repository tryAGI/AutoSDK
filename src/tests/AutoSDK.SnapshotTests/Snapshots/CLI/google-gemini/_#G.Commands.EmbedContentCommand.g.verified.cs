//HintName: G.Commands.EmbedContentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EmbedContentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.Content?> Content { get; } = new(
            name: "content")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.EmbedContentRequestTaskType?> TaskType { get; } = new(
            name: "taskType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> OutputDimensionality { get; } = new(
            name: "outputDimensionality")
        {
            Description = "",
        };
        public EmbedContentCommand(G.IApi client) : base(
            name: "embed",
            description: @"Generates an embedding from the model given an input `Content`.")
        {
            _client = client;

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