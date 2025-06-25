//HintName: G.Commands.ClassifyV1ClassifyPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClassifyV1ClassifyPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? model,
            string? classifierId,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ApiSchemasClassificationTextDoc, global::G.ApiSchemasClassificationImageDoc, string>>, global::G.ApiSchemasClassificationTextDoc, global::G.ApiSchemasClassificationImageDoc, string> input,
            global::System.Collections.Generic.IList<string>? labels,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ClassificationOutput response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ApiSchemasClassificationTextDoc, global::G.ApiSchemasClassificationImageDoc, string>>, global::G.ApiSchemasClassificationTextDoc, global::G.ApiSchemasClassificationImageDoc, string>> Input { get; } = new(
            name: "input")
        {
            Description = @"List of text and images or a single text and image for classification",
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
- `jina-embeddings-v3`,	570M,	1024

For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).",
        };

        private global::System.CommandLine.Option<string?> ClassifierId { get; } = new(
            name: "classifierId")
        {
            Description = @"The identifier of the classifier. If not provided, a new classifier will be created.
You can provide only either `model` or `classifier_id`",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Labels { get; } = new(
            name: "labels")
        {
            Description = @"List of labels used for classification",
        };
        public ClassifyV1ClassifyPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "classify",
            description: @"Classify.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Input);
            Options.Add(Model);
            Options.Add(ClassifierId);
            Options.Add(Labels);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var classifierId = parseResult.GetRequiredValue(ClassifierId);
            var input = parseResult.GetRequiredValue(Input);
            var labels = parseResult.GetRequiredValue(Labels);

            Validate(
                parseResult: parseResult,
                model: model,
                classifierId: classifierId,
                input: input,
                labels: labels,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Classification.ClassifyV1ClassifyPostAsync(
                model: model,
                classifierId: classifierId,
                input: input,
                labels: labels,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}