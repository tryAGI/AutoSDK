//HintName: G.Commands.CreateTextToSpeechByVoiceIdWithTimestampsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateTextToSpeechByVoiceIdWithTimestampsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            bool? enableLogging,
            int? optimizeStreamingLatency,
            global::G.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOutputFormat? outputFormat,
            string? xiApiKey,
            string text,
            string? modelId,
            string? languageCode,
            global::G.VoiceSettingsResponseModel? voiceSettings,
            global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorRequestModel>? pronunciationDictionaryLocators,
            int? seed,
            string? previousText,
            string? nextText,
            global::System.Collections.Generic.IList<string>? previousRequestIds,
            global::System.Collections.Generic.IList<string>? nextRequestIds,
            bool? usePvcAsIvc,
            global::G.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalization? applyTextNormalization,
            bool? applyLanguageTextNormalization,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AudioWithTimestampsResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> EnableLogging { get; } = new(
            name: "enableLogging")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> OptimizeStreamingLatency { get; } = new(
            name: "optimizeStreamingLatency")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOutputFormat?> OutputFormat { get; } = new(
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

        private global::System.CommandLine.Option<string?> LanguageCode { get; } = new(
            name: "languageCode")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.VoiceSettingsResponseModel?> VoiceSettings { get; } = new(
            name: "voiceSettings")
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

        private global::System.CommandLine.Option<string?> PreviousText { get; } = new(
            name: "previousText")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> NextText { get; } = new(
            name: "nextText")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> PreviousRequestIds { get; } = new(
            name: "previousRequestIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> NextRequestIds { get; } = new(
            name: "nextRequestIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> UsePvcAsIvc { get; } = new(
            name: "usePvcAsIvc")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalization?> ApplyTextNormalization { get; } = new(
            name: "applyTextNormalization")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ApplyLanguageTextNormalization { get; } = new(
            name: "applyLanguageTextNormalization")
        {
            Description = "",
        };
        public CreateTextToSpeechByVoiceIdWithTimestampsCommand(G.IApi client) : base(
            name: "create",
            description: @"Generate speech from text with precise character-level timing information for audio-text synchronization.")
        {
            _client = client;

            Arguments.Add(VoiceId);
            Arguments.Add(Text);
            Options.Add(EnableLogging);
            Options.Add(OptimizeStreamingLatency);
            Options.Add(OutputFormat);
            Options.Add(XiApiKey);
            Options.Add(ModelId);
            Options.Add(LanguageCode);
            Options.Add(VoiceSettings);
            Options.Add(PronunciationDictionaryLocators);
            Options.Add(Seed);
            Options.Add(PreviousText);
            Options.Add(NextText);
            Options.Add(PreviousRequestIds);
            Options.Add(NextRequestIds);
            Options.Add(UsePvcAsIvc);
            Options.Add(ApplyTextNormalization);
            Options.Add(ApplyLanguageTextNormalization);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var enableLogging = parseResult.GetRequiredValue(EnableLogging);
            var optimizeStreamingLatency = parseResult.GetRequiredValue(OptimizeStreamingLatency);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var text = parseResult.GetRequiredValue(Text);
            var modelId = parseResult.GetRequiredValue(ModelId);
            var languageCode = parseResult.GetRequiredValue(LanguageCode);
            var voiceSettings = parseResult.GetRequiredValue(VoiceSettings);
            var pronunciationDictionaryLocators = parseResult.GetRequiredValue(PronunciationDictionaryLocators);
            var seed = parseResult.GetRequiredValue(Seed);
            var previousText = parseResult.GetRequiredValue(PreviousText);
            var nextText = parseResult.GetRequiredValue(NextText);
            var previousRequestIds = parseResult.GetRequiredValue(PreviousRequestIds);
            var nextRequestIds = parseResult.GetRequiredValue(NextRequestIds);
            var usePvcAsIvc = parseResult.GetRequiredValue(UsePvcAsIvc);
            var applyTextNormalization = parseResult.GetRequiredValue(ApplyTextNormalization);
            var applyLanguageTextNormalization = parseResult.GetRequiredValue(ApplyLanguageTextNormalization);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                enableLogging: enableLogging,
                optimizeStreamingLatency: optimizeStreamingLatency,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                text: text,
                modelId: modelId,
                languageCode: languageCode,
                voiceSettings: voiceSettings,
                pronunciationDictionaryLocators: pronunciationDictionaryLocators,
                seed: seed,
                previousText: previousText,
                nextText: nextText,
                previousRequestIds: previousRequestIds,
                nextRequestIds: nextRequestIds,
                usePvcAsIvc: usePvcAsIvc,
                applyTextNormalization: applyTextNormalization,
                applyLanguageTextNormalization: applyLanguageTextNormalization,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TextToSpeech.CreateTextToSpeechByVoiceIdWithTimestampsAsync(
                voiceId: voiceId,
                enableLogging: enableLogging,
                optimizeStreamingLatency: optimizeStreamingLatency,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                text: text,
                modelId: modelId,
                languageCode: languageCode,
                voiceSettings: voiceSettings,
                pronunciationDictionaryLocators: pronunciationDictionaryLocators,
                seed: seed,
                previousText: previousText,
                nextText: nextText,
                previousRequestIds: previousRequestIds,
                nextRequestIds: nextRequestIds,
                usePvcAsIvc: usePvcAsIvc,
                applyTextNormalization: applyTextNormalization,
                applyLanguageTextNormalization: applyLanguageTextNormalization,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}