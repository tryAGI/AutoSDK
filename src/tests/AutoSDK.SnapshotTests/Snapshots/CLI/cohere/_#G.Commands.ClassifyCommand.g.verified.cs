//HintName: G.Commands.ClassifyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClassifyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Inputs { get; } = new(
            name: "inputs")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Preset { get; } = new(
            name: "preset")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.ClassifyRequestTruncate> Truncate { get; } = new(
            name: "truncate")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = "",
        };
        public ClassifyCommand(G.IApi client) : base(
            name: "classify",
            description: @"This endpoint makes a prediction about which label fits the specified text inputs best. To make a prediction, Classify uses the provided `examples` of text + label pairs as a reference.
Note: [Fine-tuned models](https://docs.cohere.com/docs/classify-fine-tuning) trained on classification examples don't require the `examples` parameter to be passed in explicitly.")
        {
            _client = client;

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