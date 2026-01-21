//HintName: G.Commands.OpenaiAudioSpeechV1OpenaiAudioSpeechPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OpenaiAudioSpeechV1OpenaiAudioSpeechPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xDeepinfraSource,
            string? xiApiKey,
            string model,
            string input,
            string? voice,
            global::G.TtsResponseFormat? responseFormat,
            double? speed,
            object? extraBody,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"model name",
        };

        private global::System.CommandLine.Argument<string> Input { get; } = new(
            name: "input")
        {
            Description = @"Text to convert to speech",
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

        private global::System.CommandLine.Option<string?> Voice { get; } = new(
            name: "voice")
        {
            Description = @"Preset voices to use for the speech.",
        };

        private global::System.CommandLine.Option<global::G.TtsResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"response format for the speech",
        };

        private global::System.CommandLine.Option<double?> Speed { get; } = new(
            name: "speed")
        {
            Description = @"speed of the speech",
        };

        private global::System.CommandLine.Option<object?> ExtraBody { get; } = new(
            name: "extraBody")
        {
            Description = @"Extra body parameters for the model.",
        };
        public OpenaiAudioSpeechV1OpenaiAudioSpeechPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "openai",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Input);
            Options.Add(XDeepinfraSource);
            Options.Add(XiApiKey);
            Options.Add(Voice);
            Options.Add(ResponseFormat);
            Options.Add(Speed);
            Options.Add(ExtraBody);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xDeepinfraSource = parseResult.GetRequiredValue(XDeepinfraSource);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var model = parseResult.GetRequiredValue(Model);
            var input = parseResult.GetRequiredValue(Input);
            var voice = parseResult.GetRequiredValue(Voice);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var speed = parseResult.GetRequiredValue(Speed);
            var extraBody = parseResult.GetRequiredValue(ExtraBody);

            Validate(
                parseResult: parseResult,
                xDeepinfraSource: xDeepinfraSource,
                xiApiKey: xiApiKey,
                model: model,
                input: input,
                voice: voice,
                responseFormat: responseFormat,
                speed: speed,
                extraBody: extraBody,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.OpenaiAudioSpeechV1OpenaiAudioSpeechPostAsync(
                xDeepinfraSource: xDeepinfraSource,
                xiApiKey: xiApiKey,
                model: model,
                input: input,
                voice: voice,
                responseFormat: responseFormat,
                speed: speed,
                extraBody: extraBody,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}