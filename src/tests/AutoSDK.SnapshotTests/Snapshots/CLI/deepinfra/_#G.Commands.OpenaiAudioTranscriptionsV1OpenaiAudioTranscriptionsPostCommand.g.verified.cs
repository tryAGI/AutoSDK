//HintName: G.Commands.OpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xDeepinfraSource,
            string? xiApiKey,
            byte[] file,
            string filename,
            string model,
            string? language,
            string? prompt,
            global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat? responseFormat,
            double? temperature,
            global::System.Collections.Generic.IList<global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitie>? timestampGranularities,
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

        private global::System.CommandLine.Option<string?> Language { get; } = new(
            name: "language")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitie>?> TimestampGranularities { get; } = new(
            name: "timestampGranularities")
        {
            Description = @"",
        };
        public OpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostCommand(G.IApi client) : base(
            name: "openai",
            description: @"")
        {
            _client = client;

            Arguments.Add(File);
            Arguments.Add(Filename);
            Arguments.Add(Model);
            Options.Add(XDeepinfraSource);
            Options.Add(XiApiKey);
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
            var xDeepinfraSource = parseResult.GetRequiredValue(XDeepinfraSource);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var model = parseResult.GetRequiredValue(Model);
            var language = parseResult.GetRequiredValue(Language);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var timestampGranularities = parseResult.GetRequiredValue(TimestampGranularities);

            Validate(
                parseResult: parseResult,
                xDeepinfraSource: xDeepinfraSource,
                xiApiKey: xiApiKey,
                file: file,
                filename: filename,
                model: model,
                language: language,
                prompt: prompt,
                responseFormat: responseFormat,
                temperature: temperature,
                timestampGranularities: timestampGranularities,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.OpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostAsync(
                xDeepinfraSource: xDeepinfraSource,
                xiApiKey: xiApiKey,
                file: file,
                filename: filename,
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