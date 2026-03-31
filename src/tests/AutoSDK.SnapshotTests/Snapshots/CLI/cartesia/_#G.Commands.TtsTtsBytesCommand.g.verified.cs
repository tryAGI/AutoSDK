//HintName: G.Commands.TtsTtsBytesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TtsTtsBytesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TtsBytesCartesiaVersion cartesiaVersion,
            string modelId,
            string transcript,
            global::G.TTSRequestVoiceSpecifier voice,
            global::G.SupportedLanguage? language,
            global::G.GenerationConfig? generationConfig,
            global::G.OutputFormat outputFormat,
            bool? save,
            string? pronunciationDictId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.TtsBytesCartesiaVersion> CartesiaVersion { get; } = new(
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

        private global::System.CommandLine.Argument<global::G.OutputFormat> OutputFormat { get; } = new(
            name: "outputFormat")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.SupportedLanguage?> Language { get; } = new(
            name: "language")
        {
            Description = @"The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).",
        };

        private global::System.CommandLine.Option<global::G.GenerationConfig?> GenerationConfig { get; } = new(
            name: "generationConfig")
        {
            Description = @"Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.

See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.",
        };

        private global::System.CommandLine.Option<bool?> Save { get; } = new(
            name: "save")
        {
            Description = @"Whether to save the generated audio file. When true, the response will include a `Cartesia-File-ID` header.",
        };

        private global::System.CommandLine.Option<string?> PronunciationDictId { get; } = new(
            name: "pronunciationDictId")
        {
            Description = @"The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.",
        };


        public TtsTtsBytesCommand(
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
            Options.Add(Language);
            Options.Add(GenerationConfig);
            Options.Add(Save);
            Options.Add(PronunciationDictId);

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
            var language = parseResult.GetRequiredValue(Language);
            var generationConfig = parseResult.GetRequiredValue(GenerationConfig);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var save = parseResult.GetRequiredValue(Save);
            var pronunciationDictId = parseResult.GetRequiredValue(PronunciationDictId);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                modelId: modelId,
                transcript: transcript,
                voice: voice,
                language: language,
                generationConfig: generationConfig,
                outputFormat: outputFormat,
                save: save,
                pronunciationDictId: pronunciationDictId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Tts.TtsBytesAsync(
                cartesiaVersion: cartesiaVersion,
                modelId: modelId,
                transcript: transcript,
                voice: voice,
                language: language,
                generationConfig: generationConfig,
                outputFormat: outputFormat,
                save: save,
                pronunciationDictId: pronunciationDictId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}