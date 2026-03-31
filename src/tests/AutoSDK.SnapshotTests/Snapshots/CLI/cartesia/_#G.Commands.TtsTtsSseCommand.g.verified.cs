//HintName: G.Commands.TtsTtsSseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TtsTtsSseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TtsSseCartesiaVersion cartesiaVersion,
            string modelId,
            string transcript,
            global::G.TTSRequestVoiceSpecifier voice,
            global::G.SSEOutputFormat outputFormat,
            global::G.GenerationConfig? generationConfig,
            global::G.SupportedLanguage? language,
            bool? addTimestamps,
            bool? addPhonemeTimestamps,
            bool? useNormalizedTimestamps,
            string? pronunciationDictId,
            string? contextId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.TtsSseCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = @"The ID of the model to use for the generation. See [Models](/build-with-cartesia/tts-models) for available models.",
        };

        private global::System.CommandLine.Argument<string> Transcript { get; } = new(
            name: "transcript")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.TTSRequestVoiceSpecifier> Voice { get; } = new(
            name: "voice")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.SSEOutputFormat> OutputFormat { get; } = new(
            name: "outputFormat")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.GenerationConfig?> GenerationConfig { get; } = new(
            name: "generationConfig")
        {
            Description = @"Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.

See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.",
        };

        private global::System.CommandLine.Option<global::G.SupportedLanguage?> Language { get; } = new(
            name: "language")
        {
            Description = @"The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).",
        };

        private global::System.CommandLine.Option<bool?> AddTimestamps { get; } = new(
            name: "addTimestamps")
        {
            Description = @"Whether to return word-level timestamps. If `false` (default), no word timestamps will be produced at all. If `true`, the server will return timestamp events containing word-level timing information.",
        };

        private global::System.CommandLine.Option<bool?> AddPhonemeTimestamps { get; } = new(
            name: "addPhonemeTimestamps")
        {
            Description = @"Whether to return phoneme-level timestamps. If `false` (default), no phoneme timestamps will be produced. If `true`, the server will return timestamp events containing phoneme-level timing information.",
        };

        private global::System.CommandLine.Option<bool?> UseNormalizedTimestamps { get; } = new(
            name: "useNormalizedTimestamps")
        {
            Description = @"Whether to use normalized timestamps (True) or original timestamps (False).",
        };

        private global::System.CommandLine.Option<string?> PronunciationDictId { get; } = new(
            name: "pronunciationDictId")
        {
            Description = @"The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.",
        };

        private global::System.CommandLine.Option<string?> ContextId { get; } = new(
            name: "contextId")
        {
            Description = @"A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.

Some customers use unique identifiers from their own systems (such as conversation IDs) as context IDs.",
        };


        public TtsTtsSseCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "tts",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(ModelId);
            Arguments.Add(Transcript);
            Arguments.Add(Voice);
            Arguments.Add(OutputFormat);
            Options.Add(GenerationConfig);
            Options.Add(Language);
            Options.Add(AddTimestamps);
            Options.Add(AddPhonemeTimestamps);
            Options.Add(UseNormalizedTimestamps);
            Options.Add(PronunciationDictId);
            Options.Add(ContextId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var modelId = parseResult.GetRequiredValue(ModelId);
            var transcript = parseResult.GetRequiredValue(Transcript);
            var voice = parseResult.GetRequiredValue(Voice);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var generationConfig = parseResult.GetRequiredValue(GenerationConfig);
            var language = parseResult.GetRequiredValue(Language);
            var addTimestamps = parseResult.GetRequiredValue(AddTimestamps);
            var addPhonemeTimestamps = parseResult.GetRequiredValue(AddPhonemeTimestamps);
            var useNormalizedTimestamps = parseResult.GetRequiredValue(UseNormalizedTimestamps);
            var pronunciationDictId = parseResult.GetRequiredValue(PronunciationDictId);
            var contextId = parseResult.GetRequiredValue(ContextId);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                modelId: modelId,
                transcript: transcript,
                voice: voice,
                outputFormat: outputFormat,
                generationConfig: generationConfig,
                language: language,
                addTimestamps: addTimestamps,
                addPhonemeTimestamps: addPhonemeTimestamps,
                useNormalizedTimestamps: useNormalizedTimestamps,
                pronunciationDictId: pronunciationDictId,
                contextId: contextId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Tts.TtsSseAsync(
                cartesiaVersion: cartesiaVersion,
                modelId: modelId,
                transcript: transcript,
                voice: voice,
                outputFormat: outputFormat,
                generationConfig: generationConfig,
                language: language,
                addTimestamps: addTimestamps,
                addPhonemeTimestamps: addPhonemeTimestamps,
                useNormalizedTimestamps: useNormalizedTimestamps,
                pronunciationDictId: pronunciationDictId,
                contextId: contextId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}