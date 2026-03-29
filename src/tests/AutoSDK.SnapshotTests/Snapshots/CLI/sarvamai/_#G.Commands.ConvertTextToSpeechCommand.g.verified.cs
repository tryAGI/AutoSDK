//HintName: G.Commands.ConvertTextToSpeechCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ConvertTextToSpeechCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string text,
            global::G.TextToSpeechRequestTargetLanguageCode targetLanguageCode,
            global::G.TextToSpeechRequestModel? model,
            global::G.TextToSpeechRequestSpeaker? speaker,
            double? pitch,
            double? pace,
            double? loudness,
            double? temperature,
            global::G.TextToSpeechRequestSpeechSampleRate? speechSampleRate,
            global::G.TextToSpeechRequestOutputAudioCodec? outputAudioCodec,
            bool? enablePreprocessing,
            string? dictId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.TextToSpeechResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = @"Text to convert to speech (max 2500 chars for v3, 1500 for v2). Supports code-mixed text.",
        };

        private global::System.CommandLine.Argument<global::G.TextToSpeechRequestTargetLanguageCode> TargetLanguageCode { get; } = new(
            name: "targetLanguageCode")
        {
            Description = @"Language code (BCP-47) for text normalization",
        };

        private global::System.CommandLine.Option<global::G.TextToSpeechRequestModel?> Model { get; } = new(
            name: "model")
        {
            Description = @"TTS model to use",
        };

        private global::System.CommandLine.Option<global::G.TextToSpeechRequestSpeaker?> Speaker { get; } = new(
            name: "speaker")
        {
            Description = @"Speaker voice (default: shubh for v3, anushka for v2)",
        };

        private global::System.CommandLine.Option<double?> Pitch { get; } = new(
            name: "pitch")
        {
            Description = @"Pitch adjustment (-0.75 to 0.75). v2 only.",
        };

        private global::System.CommandLine.Option<double?> Pace { get; } = new(
            name: "pace")
        {
            Description = @"Speech speed (v3: 0.5-2.0, v2: 0.3-3.0)",
        };

        private global::System.CommandLine.Option<double?> Loudness { get; } = new(
            name: "loudness")
        {
            Description = @"Loudness (0.3-3.0). v2 only.",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"Randomness/expressiveness (0.01-2.0). v3 only.",
        };

        private global::System.CommandLine.Option<global::G.TextToSpeechRequestSpeechSampleRate?> SpeechSampleRate { get; } = new(
            name: "speechSampleRate")
        {
            Description = @"Audio sample rate in Hz",
        };

        private global::System.CommandLine.Option<global::G.TextToSpeechRequestOutputAudioCodec?> OutputAudioCodec { get; } = new(
            name: "outputAudioCodec")
        {
            Description = @"Output audio format",
        };

        private global::System.CommandLine.Option<bool?> EnablePreprocessing { get; } = new(
            name: "enablePreprocessing")
        {
            Description = @"Enable preprocessing. v2 only.",
        };

        private global::System.CommandLine.Option<string?> DictId { get; } = new(
            name: "dictId")
        {
            Description = @"Custom pronunciation dictionary ID. v3 only.",
        };


        public ConvertTextToSpeechCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "convert",
            description: @"Converts text to natural speech using the Bulbul model.
Supports 10 Indian languages plus English with 30+ speaker voices.
Max 2500 characters per request (v3).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Text);
            Arguments.Add(TargetLanguageCode);
            Options.Add(Model);
            Options.Add(Speaker);
            Options.Add(Pitch);
            Options.Add(Pace);
            Options.Add(Loudness);
            Options.Add(Temperature);
            Options.Add(SpeechSampleRate);
            Options.Add(OutputAudioCodec);
            Options.Add(EnablePreprocessing);
            Options.Add(DictId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var text = parseResult.GetRequiredValue(Text);
            var targetLanguageCode = parseResult.GetRequiredValue(TargetLanguageCode);
            var model = parseResult.GetRequiredValue(Model);
            var speaker = parseResult.GetRequiredValue(Speaker);
            var pitch = parseResult.GetRequiredValue(Pitch);
            var pace = parseResult.GetRequiredValue(Pace);
            var loudness = parseResult.GetRequiredValue(Loudness);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var speechSampleRate = parseResult.GetRequiredValue(SpeechSampleRate);
            var outputAudioCodec = parseResult.GetRequiredValue(OutputAudioCodec);
            var enablePreprocessing = parseResult.GetRequiredValue(EnablePreprocessing);
            var dictId = parseResult.GetRequiredValue(DictId);

            Validate(
                parseResult: parseResult,
                text: text,
                targetLanguageCode: targetLanguageCode,
                model: model,
                speaker: speaker,
                pitch: pitch,
                pace: pace,
                loudness: loudness,
                temperature: temperature,
                speechSampleRate: speechSampleRate,
                outputAudioCodec: outputAudioCodec,
                enablePreprocessing: enablePreprocessing,
                dictId: dictId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConvertTextToSpeechAsync(
                text: text,
                targetLanguageCode: targetLanguageCode,
                model: model,
                speaker: speaker,
                pitch: pitch,
                pace: pace,
                loudness: loudness,
                temperature: temperature,
                speechSampleRate: speechSampleRate,
                outputAudioCodec: outputAudioCodec,
                enablePreprocessing: enablePreprocessing,
                dictId: dictId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}