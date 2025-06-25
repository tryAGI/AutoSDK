//HintName: G.Commands.OpenaiAudioTranslationsV1OpenaiAudioTranslationsPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OpenaiAudioTranslationsV1OpenaiAudioTranslationsPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xDeepinfraSource,
            string? xiApiKey,
            byte[] file,
            string filename,
            string model,
            string? prompt,
            global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat? responseFormat,
            double? temperature,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<byte[]> File { get; } = new(
            name: "file")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Filename { get; } = new(
            name: "filename")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XDeepinfraSource { get; } = new(
            name: "xDeepinfraSource")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"",
        };
        public OpenaiAudioTranslationsV1OpenaiAudioTranslationsPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "openai",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(File);
            Arguments.Add(Filename);
            Arguments.Add(Model);
            Options.Add(XDeepinfraSource);
            Options.Add(XiApiKey);
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
            var xDeepinfraSource = parseResult.GetRequiredValue(XDeepinfraSource);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var model = parseResult.GetRequiredValue(Model);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var temperature = parseResult.GetRequiredValue(Temperature);

            Validate(
                parseResult: parseResult,
                xDeepinfraSource: xDeepinfraSource,
                xiApiKey: xiApiKey,
                file: file,
                filename: filename,
                model: model,
                prompt: prompt,
                responseFormat: responseFormat,
                temperature: temperature,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.OpenaiAudioTranslationsV1OpenaiAudioTranslationsPostAsync(
                xDeepinfraSource: xDeepinfraSource,
                xiApiKey: xiApiKey,
                file: file,
                filename: filename,
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