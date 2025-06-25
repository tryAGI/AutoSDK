//HintName: G.Commands.TextToSpeechStreamV1TextToSpeechVoiceIdStreamPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TextToSpeechStreamV1TextToSpeechVoiceIdStreamPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            string? outputFormat,
            string? xDeepinfraSource,
            string? xiApiKey,
            string text,
            string? modelId,
            global::G.TtsResponseFormat? requestOutputFormat,
            string? languageCode,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> OutputFormat { get; } = new(
            name: "outputFormat")
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

        private global::System.CommandLine.Option<string?> ModelId { get; } = new(
            name: "modelId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.TtsResponseFormat?> RequestOutputFormat { get; } = new(
            name: "requestOutputFormat")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> LanguageCode { get; } = new(
            name: "languageCode")
        {
            Description = @"",
        };
        public TextToSpeechStreamV1TextToSpeechVoiceIdStreamPostCommand(G.IApi client) : base(
            name: "text",
            description: @"")
        {
            _client = client;

            Arguments.Add(VoiceId);
            Arguments.Add(Text);
            Options.Add(OutputFormat);
            Options.Add(XDeepinfraSource);
            Options.Add(XiApiKey);
            Options.Add(ModelId);
            Options.Add(RequestOutputFormat);
            Options.Add(LanguageCode);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var xDeepinfraSource = parseResult.GetRequiredValue(XDeepinfraSource);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var text = parseResult.GetRequiredValue(Text);
            var modelId = parseResult.GetRequiredValue(ModelId);
            var requestOutputFormat = parseResult.GetRequiredValue(RequestOutputFormat);
            var languageCode = parseResult.GetRequiredValue(LanguageCode);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                outputFormat: outputFormat,
                xDeepinfraSource: xDeepinfraSource,
                xiApiKey: xiApiKey,
                text: text,
                modelId: modelId,
                requestOutputFormat: requestOutputFormat,
                languageCode: languageCode,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TextToSpeechStreamV1TextToSpeechVoiceIdStreamPostAsync(
                voiceId: voiceId,
                outputFormat: outputFormat,
                xDeepinfraSource: xDeepinfraSource,
                xiApiKey: xiApiKey,
                text: text,
                modelId: modelId,
                requestOutputFormat: requestOutputFormat,
                languageCode: languageCode,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}