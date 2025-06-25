//HintName: G.Commands.CreateTextToDialogueCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateTextToDialogueCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TextToDialogueMultiVoiceV1TextToDialoguePostOutputFormat? outputFormat,
            string? xiApiKey,
            global::System.Collections.Generic.IList<global::G.DialogueInput> inputs,
            string? modelId,
            global::G.ModelSettingsResponseModel? settings,
            global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorRequestModel>? pronunciationDictionaryLocators,
            int? seed,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.DialogueInput>> Inputs { get; } = new(
            name: "inputs")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.TextToDialogueMultiVoiceV1TextToDialoguePostOutputFormat?> OutputFormat { get; } = new(
            name: "outputFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ModelId { get; } = new(
            name: "modelId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ModelSettingsResponseModel?> Settings { get; } = new(
            name: "settings")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorRequestModel>?> PronunciationDictionaryLocators { get; } = new(
            name: "pronunciationDictionaryLocators")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = "",
        };
        public CreateTextToDialogueCommand(G.IApi client) : base(
            name: "create",
            description: @"Converts a list of text and voice ID pairs into speech (dialogue) and returns audio.")
        {
            _client = client;

            Arguments.Add(Inputs);
            Options.Add(OutputFormat);
            Options.Add(XiApiKey);
            Options.Add(ModelId);
            Options.Add(Settings);
            Options.Add(PronunciationDictionaryLocators);
            Options.Add(Seed);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var inputs = parseResult.GetRequiredValue(Inputs);
            var modelId = parseResult.GetRequiredValue(ModelId);
            var settings = parseResult.GetRequiredValue(Settings);
            var pronunciationDictionaryLocators = parseResult.GetRequiredValue(PronunciationDictionaryLocators);
            var seed = parseResult.GetRequiredValue(Seed);

            Validate(
                parseResult: parseResult,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                inputs: inputs,
                modelId: modelId,
                settings: settings,
                pronunciationDictionaryLocators: pronunciationDictionaryLocators,
                seed: seed,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TextToDialogue.CreateTextToDialogueAsync(
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                inputs: inputs,
                modelId: modelId,
                settings: settings,
                pronunciationDictionaryLocators: pronunciationDictionaryLocators,
                seed: seed,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}