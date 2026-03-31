//HintName: G.Commands.AudioCreateTranscriptionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AudioCreateTranscriptionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[]? file,
            string? filename,
            string? url,
            global::G.AnyOf<string, global::G.CreateTranscriptionRequestModel?> model,
            global::G.AnyOf<string, global::G.CreateTranscriptionRequestLanguage?>? language,
            string? prompt,
            global::G.CreateTranscriptionRequestResponseFormat? responseFormat,
            double? temperature,
            global::System.Collections.Generic.IList<global::G.CreateTranscriptionRequestTimestampGranularitie>? timestampGranularities,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateTranscriptionResponseJson response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::G.CreateTranscriptionRequestModel?>> Model { get; } = new(
            name: "model")
        {
            Description = @"ID of the model to use. `whisper-large-v3` and `whisper-large-v3-turbo` are currently available.",
        };

        private global::System.CommandLine.Option<byte[]?> File { get; } = new(
            name: "file")
        {
            Description = @"The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
Either a file or a URL must be provided. Note that the file field is not supported in Batch API requests.",
        };

        private global::System.CommandLine.Option<string?> Filename { get; } = new(
            name: "filename")
        {
            Description = @"The audio file object (not file name) to transcribe, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
Either a file or a URL must be provided. Note that the file field is not supported in Batch API requests.",
        };

        private global::System.CommandLine.Option<string?> Url { get; } = new(
            name: "url")
        {
            Description = @"The audio URL to translate/transcribe (supports Base64URL).
Either a file or a URL must be provided. For Batch API requests, the URL field is required since the file field is not supported.",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<string, global::G.CreateTranscriptionRequestLanguage?>?> Language { get; } = new(
            name: "language")
        {
            Description = @"The language of the input audio. Supplying the input language in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format will improve accuracy and latency.",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"An optional text to guide the model's style or continue a previous audio segment. The [prompt](/docs/speech-text) should match the audio language.",
        };

        private global::System.CommandLine.Option<global::G.CreateTranscriptionRequestResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"The format of the transcript output, in one of these options: `json`, `text`, or `verbose_json`.",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.CreateTranscriptionRequestTimestampGranularitie>?> TimestampGranularities { get; } = new(
            name: "timestampGranularities")
        {
            Description = @"The timestamp granularities to populate for this transcription. `response_format` must be set `verbose_json` to use timestamp granularities. Either or both of these options are supported: `word`, or `segment`. Note: There is no additional latency for segment timestamps, but generating word timestamps incurs additional latency.",
        };


        public AudioCreateTranscriptionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Options.Add(File);
            Options.Add(Filename);
            Options.Add(Url);
            Options.Add(Language);
            Options.Add(Prompt);
            Options.Add(ResponseFormat);
            Options.Add(Temperature);
            Options.Add(TimestampGranularities);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var url = parseResult.GetRequiredValue(Url);
            var model = parseResult.GetRequiredValue(Model);
            var language = parseResult.GetRequiredValue(Language);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var timestampGranularities = parseResult.GetRequiredValue(TimestampGranularities);

            Validate(
                parseResult: parseResult,
                file: file,
                filename: filename,
                url: url,
                model: model,
                language: language,
                prompt: prompt,
                responseFormat: responseFormat,
                temperature: temperature,
                timestampGranularities: timestampGranularities,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Audio.CreateTranscriptionAsync(
                file: file,
                filename: filename,
                url: url,
                model: model,
                language: language,
                prompt: prompt,
                responseFormat: responseFormat,
                temperature: temperature,
                timestampGranularities: timestampGranularities,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}