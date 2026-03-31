//HintName: G.Commands.AudioCreateTranslationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AudioCreateTranslationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[]? file,
            string? filename,
            string? url,
            global::G.AnyOf<string, global::G.CreateTranslationRequestModel?> model,
            string? prompt,
            global::G.CreateTranslationRequestResponseFormat? responseFormat,
            double? temperature,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateTranslationResponseJson response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::G.CreateTranslationRequestModel?>> Model { get; } = new(
            name: "model")
        {
            Description = @"ID of the model to use. `whisper-large-v3` and `whisper-large-v3-turbo` are currently available.",
        };

        private global::System.CommandLine.Option<byte[]?> File { get; } = new(
            name: "file")
        {
            Description = @"The audio file object (not file name) translate, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.",
        };

        private global::System.CommandLine.Option<string?> Filename { get; } = new(
            name: "filename")
        {
            Description = @"The audio file object (not file name) translate, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.",
        };

        private global::System.CommandLine.Option<string?> Url { get; } = new(
            name: "url")
        {
            Description = @"The audio URL to translate/transcribe (supports Base64URL). Either file or url must be provided.
When using the Batch API only url is supported.",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"An optional text to guide the model's style or continue a previous audio segment. The [prompt](/docs/guides/speech-to-text/prompting) should be in English.",
        };

        private global::System.CommandLine.Option<global::G.CreateTranslationRequestResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"The format of the transcript output, in one of these options: `json`, `text`, or `verbose_json`.",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.",
        };


        public AudioCreateTranslationCommand(
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
            Options.Add(Prompt);
            Options.Add(ResponseFormat);
            Options.Add(Temperature);

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
            var prompt = parseResult.GetRequiredValue(Prompt);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var temperature = parseResult.GetRequiredValue(Temperature);

            Validate(
                parseResult: parseResult,
                file: file,
                filename: filename,
                url: url,
                model: model,
                prompt: prompt,
                responseFormat: responseFormat,
                temperature: temperature,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Audio.CreateTranslationAsync(
                file: file,
                filename: filename,
                url: url,
                model: model,
                prompt: prompt,
                responseFormat: responseFormat,
                temperature: temperature,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}