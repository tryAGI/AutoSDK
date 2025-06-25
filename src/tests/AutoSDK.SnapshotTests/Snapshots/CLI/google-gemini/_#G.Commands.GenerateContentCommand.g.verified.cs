//HintName: G.Commands.GenerateContentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerateContentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The id of the model to use.",
        };

        private global::System.CommandLine.Option<global::G.GenerationConfig?> GenerationConfig { get; } = new(
            name: "generationConfig")
        {
            Description = @"Configuration options for model generation and outputs. Not all parameters may be configurable for every model.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Content>?> Contents { get; } = new(
            name: "contents")
        {
            Description = @"Required. The content of the current conversation with the model. For single-turn queries, this is a single instance. For multi-turn queries, this is a repeated field that contains conversation history + latest request.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.SafetySetting>?> SafetySettings { get; } = new(
            name: "safetySettings")
        {
            Description = @"Optional. A list of unique `SafetySetting` instances for blocking unsafe content. This will be enforced on the `GenerateContentRequest.contents` and `GenerateContentResponse.candidates`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT are supported.",
        };
        public GenerateContentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "generate",
            description: @"Generates a response from the model given an input `GenerateContentRequest`.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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