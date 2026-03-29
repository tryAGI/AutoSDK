//HintName: G.Commands.SpeechTranscribeOrTranslateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpeechTranscribeOrTranslateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string audioUrl,
            int samplingRate,
            global::G.TranscribeOrTranslateRequestTargetLanguage? targetLanguage,
            bool? isTranslate,
            bool? returnTranslationAudio,
            double? temperature,
            int? maxTokens,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.TranscribeOrTranslateResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> AudioUrl { get; } = new(
            name: "audioUrl")
        {
            Description = @"URL to a WAV audio file (http/https) or a base64-encoded data URI (data:audio/wav;base64,...).",
        };

        private global::System.CommandLine.Argument<int> SamplingRate { get; } = new(
            name: "samplingRate")
        {
            Description = @"Audio sampling rate in Hz. Recommended value is 16000.",
        };

        private global::System.CommandLine.Option<global::G.TranscribeOrTranslateRequestTargetLanguage?> TargetLanguage { get; } = new(
            name: "targetLanguage")
        {
            Description = @"Target language for translation. When omitted, only transcription is performed.",
        };

        private global::System.CommandLine.Option<bool?> IsTranslate { get; } = new(
            name: "isTranslate")
        {
            Description = @"Set to true to indicate this is a translation request. Must be true when target_language is specified.",
        };

        private global::System.CommandLine.Option<bool?> ReturnTranslationAudio { get; } = new(
            name: "returnTranslationAudio")
        {
            Description = @"Set to true to receive base64-encoded WAV audio of the translated speech. Requires is_translate and target_language.",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"Controls randomness in generation. Use 0.0 for deterministic output.",
        };

        private global::System.CommandLine.Option<int?> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"Maximum number of tokens to generate.",
        };


        public SpeechTranscribeOrTranslateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "transcribe",
            description: @"Transcribes audio to text and optionally translates it to a target language.
Supports three modes: transcription only, translation (text output), and
speech-to-speech translation (with audio output).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(AudioUrl);
            Arguments.Add(SamplingRate);
            Options.Add(TargetLanguage);
            Options.Add(IsTranslate);
            Options.Add(ReturnTranslationAudio);
            Options.Add(Temperature);
            Options.Add(MaxTokens);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var audioUrl = parseResult.GetRequiredValue(AudioUrl);
            var samplingRate = parseResult.GetRequiredValue(SamplingRate);
            var targetLanguage = parseResult.GetRequiredValue(TargetLanguage);
            var isTranslate = parseResult.GetRequiredValue(IsTranslate);
            var returnTranslationAudio = parseResult.GetRequiredValue(ReturnTranslationAudio);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);

            Validate(
                parseResult: parseResult,
                audioUrl: audioUrl,
                samplingRate: samplingRate,
                targetLanguage: targetLanguage,
                isTranslate: isTranslate,
                returnTranslationAudio: returnTranslationAudio,
                temperature: temperature,
                maxTokens: maxTokens,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Speech.TranscribeOrTranslateAsync(
                audioUrl: audioUrl,
                samplingRate: samplingRate,
                targetLanguage: targetLanguage,
                isTranslate: isTranslate,
                returnTranslationAudio: returnTranslationAudio,
                temperature: temperature,
                maxTokens: maxTokens,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}