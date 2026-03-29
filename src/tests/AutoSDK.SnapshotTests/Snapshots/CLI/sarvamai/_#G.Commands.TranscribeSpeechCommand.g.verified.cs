//HintName: G.Commands.TranscribeSpeechCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranscribeSpeechCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[] file,
            string filename,
            global::G.TranscribeSpeechRequestModel? model,
            global::G.TranscribeSpeechRequestMode? mode,
            global::G.TranscribeSpeechRequestLanguageCode? languageCode,
            global::G.TranscribeSpeechRequestInputAudioCodec? inputAudioCodec,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.SpeechToTextResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<byte[]> File { get; } = new(
            name: "file")
        {
            Description = @"Audio file (WAV, MP3, AAC, AIFF, OGG, OPUS, FLAC, MP4/M4A, AMR, WMA, WebM, PCM)",
        };

        private global::System.CommandLine.Argument<string> Filename { get; } = new(
            name: "filename")
        {
            Description = @"Audio file (WAV, MP3, AAC, AIFF, OGG, OPUS, FLAC, MP4/M4A, AMR, WMA, WebM, PCM)",
        };

        private global::System.CommandLine.Option<global::G.TranscribeSpeechRequestModel?> Model { get; } = new(
            name: "model")
        {
            Description = @"Speech-to-text model",
        };

        private global::System.CommandLine.Option<global::G.TranscribeSpeechRequestMode?> Mode { get; } = new(
            name: "mode")
        {
            Description = @"Operation mode (saaras:v3 only)",
        };

        private global::System.CommandLine.Option<global::G.TranscribeSpeechRequestLanguageCode?> LanguageCode { get; } = new(
            name: "languageCode")
        {
            Description = @"Language of the audio (BCP-47). Optional for saarika:v2.5.",
        };

        private global::System.CommandLine.Option<global::G.TranscribeSpeechRequestInputAudioCodec?> InputAudioCodec { get; } = new(
            name: "inputAudioCodec")
        {
            Description = @"Required for PCM format files",
        };


        public TranscribeSpeechCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "transcribe",
            description: @"Converts spoken language into written text. Supports multiple modes
including transcribe, translate, verbatim, translit, and codemix.
Audio files up to 30 seconds for synchronous processing.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(File);
            Arguments.Add(Filename);
            Options.Add(Model);
            Options.Add(Mode);
            Options.Add(LanguageCode);
            Options.Add(InputAudioCodec);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var model = parseResult.GetRequiredValue(Model);
            var mode = parseResult.GetRequiredValue(Mode);
            var languageCode = parseResult.GetRequiredValue(LanguageCode);
            var inputAudioCodec = parseResult.GetRequiredValue(InputAudioCodec);

            Validate(
                parseResult: parseResult,
                file: file,
                filename: filename,
                model: model,
                mode: mode,
                languageCode: languageCode,
                inputAudioCodec: inputAudioCodec,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TranscribeSpeechAsync(
                file: file,
                filename: filename,
                model: model,
                mode: mode,
                languageCode: languageCode,
                inputAudioCodec: inputAudioCodec,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}