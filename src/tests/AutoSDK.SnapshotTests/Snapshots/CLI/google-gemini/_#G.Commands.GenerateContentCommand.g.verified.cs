//HintName: G.Commands.GenerateContentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerateContentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelId,
            global::G.GenerationConfig? generationConfig,
            global::System.Collections.Generic.IList<global::G.Content>? contents,
            global::System.Collections.Generic.IList<global::G.SafetySetting>? safetySettings,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GenerateContentResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.GenerationConfig?> GenerationConfig { get; } = new(
            name: "generationConfig")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Content>?> Contents { get; } = new(
            name: "contents")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.SafetySetting>?> SafetySettings { get; } = new(
            name: "safetySettings")
        {
            Description = @"",
        };
        public GenerateContentCommand(G.IApi client) : base(
            name: "generate",
            description: @"Generates a response from the model given an input `GenerateContentRequest`.")
        {
            _client = client;

            Arguments.Add(ModelId);
            Options.Add(GenerationConfig);
            Options.Add(Contents);
            Options.Add(SafetySettings);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var modelId = parseResult.GetRequiredValue(ModelId);
            var generationConfig = parseResult.GetRequiredValue(GenerationConfig);
            var contents = parseResult.GetRequiredValue(Contents);
            var safetySettings = parseResult.GetRequiredValue(SafetySettings);

            Validate(
                parseResult: parseResult,
                modelId: modelId,
                generationConfig: generationConfig,
                contents: contents,
                safetySettings: safetySettings,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.GenerateContentAsync(
                modelId: modelId,
                generationConfig: generationConfig,
                contents: contents,
                safetySettings: safetySettings,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}