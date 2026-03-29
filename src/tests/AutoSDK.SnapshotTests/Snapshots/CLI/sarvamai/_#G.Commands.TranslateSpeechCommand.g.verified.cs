//HintName: G.Commands.TranslateSpeechCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranslateSpeechCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[] file,
            string filename,
            global::G.TranslateSpeechRequestModel? model,
            global::G.TranslateSpeechRequestLanguageCode? languageCode,
            global::G.TranslateSpeechRequestInputAudioCodec? inputAudioCodec,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.SpeechToTextTranslateResponse response,
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

        private global::System.CommandLine.Option<global::G.TranslateSpeechRequestModel?> Model { get; } = new(
            name: "model")
        {
            Description = @"Speech-to-text model",
        };

        private global::System.CommandLine.Option<global::G.TranslateSpeechRequestLanguageCode?> LanguageCode { get; } = new(
            name: "languageCode")
        {
            Description = @"Language of the audio (BCP-47)",
        };

        private global::System.CommandLine.Option<global::G.TranslateSpeechRequestInputAudioCodec?> InputAudioCodec { get; } = new(
            name: "inputAudioCodec")
        {
            Description = @"Required for PCM format files",
        };


        public TranslateSpeechCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "translate",
            description: @"Combines speech recognition and translation in a single step.
Converts spoken Indian language directly into English text.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(File);
            Arguments.Add(Filename);
            Options.Add(Model);
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
            var languageCode = parseResult.GetRequiredValue(LanguageCode);
            var inputAudioCodec = parseResult.GetRequiredValue(InputAudioCodec);

            Validate(
                parseResult: parseResult,
                file: file,
                filename: filename,
                model: model,
                languageCode: languageCode,
                inputAudioCodec: inputAudioCodec,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TranslateSpeechAsync(
                file: file,
                filename: filename,
                model: model,
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