//HintName: G.Commands.ClassifyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClassifyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            global::System.Collections.Generic.IList<global::G.ClassifyExample> examples,
            global::System.Collections.Generic.IList<string> inputs,
            string model,
            string preset,
            global::G.ClassifyRequestTruncate truncate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ClassifyResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.ClassifyExample>> Examples { get; } = new(
            name: "examples")
        {
            Description = @"An array of examples to provide context to the model. Each example is a text string and its associated label/class. Each unique label requires at least 2 examples associated with it; the maximum number of examples is 2500, and each example has a maximum length of 512 tokens. The values should be structured as `{text: ""..."",label: ""...""}`.
Note: [Fine-tuned Models](https://docs.cohere.com/docs/classify-fine-tuning) trained on classification examples don't require the `examples` parameter to be passed in explicitly.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Inputs { get; } = new(
            name: "inputs")
        {
            Description = @"A list of up to 96 texts to be classified. Each one must be a non-empty string.
There is, however, no consistent, universal limit to the length a particular input can be. We perform classification on the first `x` tokens of each input, and `x` varies depending on which underlying model is powering classification. The maximum token length for each model is listed in the ""max tokens"" column [here](https://docs.cohere.com/docs/models).
Note: by default the `truncate` parameter is set to `END`, so tokens exceeding the limit will be automatically dropped. This behavior can be disabled by setting `truncate` to `NONE`, which will result in validation errors for longer texts.",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"ID of a [Fine-tuned](https://docs.cohere.com/v2/docs/classify-starting-the-training) Classify model",
        };

        private global::System.CommandLine.Argument<string> Preset { get; } = new(
            name: "preset")
        {
            Description = @"The ID of a custom playground preset. You can create presets in the [playground](https://dashboard.cohere.com/playground/classify?model=large). If you use a preset, all other parameters become optional, and any included parameters will override the preset's parameters.",
        };

        private global::System.CommandLine.Argument<global::G.ClassifyRequestTruncate> Truncate { get; } = new(
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
        public ClassifyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "classify",
            description: @"This endpoint makes a prediction about which label fits the specified text inputs best. To make a prediction, Classify uses the provided `examples` of text + label pairs as a reference.
Note: [Fine-tuned models](https://docs.cohere.com/docs/classify-fine-tuning) trained on classification examples don't require the `examples` parameter to be passed in explicitly.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Examples);
            Arguments.Add(Inputs);
            Arguments.Add(Model);
            Arguments.Add(Preset);
            Arguments.Add(Truncate);
            Options.Add(XClientName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var examples = parseResult.GetRequiredValue(Examples);
            var inputs = parseResult.GetRequiredValue(Inputs);
            var model = parseResult.GetRequiredValue(Model);
            var preset = parseResult.GetRequiredValue(Preset);
            var truncate = parseResult.GetRequiredValue(Truncate);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                examples: examples,
                inputs: inputs,
                model: model,
                preset: preset,
                truncate: truncate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ClassifyAsync(
                xClientName: xClientName,
                examples: examples,
                inputs: inputs,
                model: model,
                preset: preset,
                truncate: truncate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}