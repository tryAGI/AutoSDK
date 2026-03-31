//HintName: G.Commands.SttSttTranscribeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SttSttTranscribeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SttTranscribeCartesiaVersion cartesiaVersion,
            global::G.STTEncoding? encoding,
            int? sampleRate,
            byte[]? file,
            string? filename,
            string? model,
            global::G.SttTranscribeRequestLanguage? language,
            global::System.Collections.Generic.IList<global::G.TimestampGranularity>? timestampGranularities,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.TranscriptionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.SttTranscribeCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Option<global::G.STTEncoding?> Encoding { get; } = new(
            name: "encoding")
        {
            Description = @"The encoding format to process the audio as. If not specified, the audio file will be decoded automatically.

**Supported formats:**
- `pcm_s16le` - 16-bit signed integer PCM, little-endian (recommended for best performance)
- `pcm_s32le` - 32-bit signed integer PCM, little-endian
- `pcm_f16le` - 16-bit floating point PCM, little-endian
- `pcm_f32le` - 32-bit floating point PCM, little-endian
- `pcm_mulaw` - 8-bit μ-law encoded PCM
- `pcm_alaw` - 8-bit A-law encoded PCM",
        };

        private global::System.CommandLine.Option<int?> SampleRate { get; } = new(
            name: "sampleRate")
        {
            Description = @"The sample rate of the audio in Hz.",
        };

        private global::System.CommandLine.Option<byte[]?> File { get; } = new(
            name: "file")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Filename { get; } = new(
            name: "filename")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = @"ID of the model to use for transcription. Use `ink-whisper` for the latest Cartesia Whisper model.",
        };

        private global::System.CommandLine.Option<global::G.SttTranscribeRequestLanguage?> Language { get; } = new(
            name: "language")
        {
            Description = @"The language of the input audio in ISO-639-1 format. Defaults to `en`.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.TimestampGranularity>?> TimestampGranularities { get; } = new(
            name: "timestampGranularities")
        {
            Description = @"The timestamp granularities to populate for this transcription. Currently only `word` level timestamps are supported.",
        };


        public SttSttTranscribeCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "stt",
            description: @"Transcribes audio files into text using Cartesia's Speech-to-Text API.

Upload an audio file and receive a complete transcription response. Supports arbitrarily long audio files with automatic intelligent chunking for longer audio.

**Supported audio formats:** flac, m4a, mp3, mp4, mpeg, mpga, oga, ogg, wav, webm

**Response format:** Returns JSON with transcribed text, duration, and language. Include `timestamp_granularities: [""word""]` to get word-level timestamps.
**Pricing:** Batch transcription is priced at **1 credit per 2 seconds** of audio processed.

<Note>
For migrating from the OpenAI SDK, see our [OpenAI Whisper to Cartesia Ink Migration Guide](/api-reference/stt/migrate-from-open-ai).
</Note>")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Options.Add(Encoding);
            Options.Add(SampleRate);
            Options.Add(File);
            Options.Add(Filename);
            Options.Add(Model);
            Options.Add(Language);
            Options.Add(TimestampGranularities);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var encoding = parseResult.GetRequiredValue(Encoding);
            var sampleRate = parseResult.GetRequiredValue(SampleRate);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var model = parseResult.GetRequiredValue(Model);
            var language = parseResult.GetRequiredValue(Language);
            var timestampGranularities = parseResult.GetRequiredValue(TimestampGranularities);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                encoding: encoding,
                sampleRate: sampleRate,
                file: file,
                filename: filename,
                model: model,
                language: language,
                timestampGranularities: timestampGranularities,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stt.SttTranscribeAsync(
                cartesiaVersion: cartesiaVersion,
                encoding: encoding,
                sampleRate: sampleRate,
                file: file,
                filename: filename,
                model: model,
                language: language,
                timestampGranularities: timestampGranularities,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}