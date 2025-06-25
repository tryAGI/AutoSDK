//HintName: G.Commands.TrainV1TrainPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TrainV1TrainPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? model,
            string? classifierId,
            global::G.TrainingAPIInputVisibility? visibility,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextExampleDoc, global::G.ImageExampleDoc>>, global::G.TextExampleDoc, global::G.ImageExampleDoc> input,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TrainingOutput response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextExampleDoc, global::G.ImageExampleDoc>>, global::G.TextExampleDoc, global::G.ImageExampleDoc>> Input { get; } = new(
            name: "input")
        {
            Description = @"List of text and images and labels or a single text and image and label to train the classifier",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = @"The identifier of the model.

Available models and corresponding param size and dimension:
- `jina-clip-v1`,	223M,	768
- `jina-embeddings-v2-base-en`,	137M,	768
- `jina-embeddings-v2-base-es`,	161M,	768
- `jina-embeddings-v2-base-de`,	161M,	768
- `jina-embeddings-v2-base-zh`,	161M,	768
- `jina-embeddings-v2-base-code`,	137M,	768

For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).

You can provide only either `model` or `classifier_id`",
        };

        private global::System.CommandLine.Option<string?> ClassifierId { get; } = new(
            name: "classifierId")
        {
            Description = @"The identifier of the classifier. If not provided, a new classifier will be created.
You can provide only either `model` or `classifier_id`",
        };

        private global::System.CommandLine.Option<global::G.TrainingAPIInputVisibility?> Visibility { get; } = new(
            name: "visibility")
        {
            Description = @"The visibility of the classifier when created. Will be ignored if `classifier_id` is provided",
        };
        public TrainV1TrainPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "train",
            description: @"Rank pairs.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Input);
            Options.Add(Model);
            Options.Add(ClassifierId);
            Options.Add(Visibility);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var classifierId = parseResult.GetRequiredValue(ClassifierId);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var input = parseResult.GetRequiredValue(Input);

            Validate(
                parseResult: parseResult,
                model: model,
                classifierId: classifierId,
                visibility: visibility,
                input: input,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Classification.TrainV1TrainPostAsync(
                model: model,
                classifierId: classifierId,
                visibility: visibility,
                input: input,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}