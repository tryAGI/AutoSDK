//HintName: G.Commands.DatasetsExpandDatasetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsExpandDatasetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string model,
            int? sampleCount,
            global::System.Collections.Generic.IList<string>? preserveFields,
            string? variationInstructions,
            string? customPrompt,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DatasetExpansionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The model to use for synthetic data generation",
        };

        private global::System.CommandLine.Option<int?> SampleCount { get; } = new(
            name: "sampleCount")
        {
            Description = @"Number of synthetic samples to generate",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> PreserveFields { get; } = new(
            name: "preserveFields")
        {
            Description = @"Fields to preserve patterns from original data",
        };

        private global::System.CommandLine.Option<string?> VariationInstructions { get; } = new(
            name: "variationInstructions")
        {
            Description = @"Additional instructions for data variation",
        };

        private global::System.CommandLine.Option<string?> CustomPrompt { get; } = new(
            name: "customPrompt")
        {
            Description = @"Custom prompt to use for generation instead of auto-generated one",
        };


        public DatasetsExpandDatasetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "expand",
            description: @"Generate synthetic dataset samples using LLM based on existing data patterns")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Arguments.Add(Model);
            Options.Add(SampleCount);
            Options.Add(PreserveFields);
            Options.Add(VariationInstructions);
            Options.Add(CustomPrompt);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var model = parseResult.GetRequiredValue(Model);
            var sampleCount = parseResult.GetRequiredValue(SampleCount);
            var preserveFields = parseResult.GetRequiredValue(PreserveFields);
            var variationInstructions = parseResult.GetRequiredValue(VariationInstructions);
            var customPrompt = parseResult.GetRequiredValue(CustomPrompt);

            Validate(
                parseResult: parseResult,
                id: id,
                model: model,
                sampleCount: sampleCount,
                preserveFields: preserveFields,
                variationInstructions: variationInstructions,
                customPrompt: customPrompt,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.ExpandDatasetAsync(
                id: id,
                model: model,
                sampleCount: sampleCount,
                preserveFields: preserveFields,
                variationInstructions: variationInstructions,
                customPrompt: customPrompt,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}