//HintName: G.Commands.CreateSpeechToSpeechByVoiceIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateSpeechToSpeechByVoiceIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            bool? enableLogging,
            int? optimizeStreamingLatency,
            global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat? outputFormat,
            string? xiApiKey,
            byte[] audio,
            string audioname,
            string? modelId,
            string? voiceSettings,
            int? seed,
            bool? removeBackgroundNoise,
            global::G.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat? fileFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<byte[]> Audio { get; } = new(
            name: "audio")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Audioname { get; } = new(
            name: "audioname")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> EnableLogging { get; } = new(
            name: "enableLogging")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> OptimizeStreamingLatency { get; } = new(
            name: "optimizeStreamingLatency")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat?> OutputFormat { get; } = new(
            name: "outputFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ModelId { get; } = new(
            name: "modelId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> VoiceSettings { get; } = new(
            name: "voiceSettings")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> RemoveBackgroundNoise { get; } = new(
            name: "removeBackgroundNoise")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat?> FileFormat { get; } = new(
            name: "fileFormat")
        {
            Description = "",
        };
        public CreateSpeechToSpeechByVoiceIdCommand(G.IApi client) : base(
            name: "create",
            description: @"Transform audio from one voice to another. Maintain full control over emotion, timing and delivery.")
        {
            _client = client;

            Arguments.Add(VoiceId);
            Arguments.Add(Audio);
            Arguments.Add(Audioname);
            Options.Add(EnableLogging);
            Options.Add(OptimizeStreamingLatency);
            Options.Add(OutputFormat);
            Options.Add(XiApiKey);
            Options.Add(ModelId);
            Options.Add(VoiceSettings);
            Options.Add(Seed);
            Options.Add(RemoveBackgroundNoise);
            Options.Add(FileFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var enableLogging = parseResult.GetRequiredValue(EnableLogging);
            var optimizeStreamingLatency = parseResult.GetRequiredValue(OptimizeStreamingLatency);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var audio = parseResult.GetRequiredValue(Audio);
            var audioname = parseResult.GetRequiredValue(Audioname);
            var modelId = parseResult.GetRequiredValue(ModelId);
            var voiceSettings = parseResult.GetRequiredValue(VoiceSettings);
            var seed = parseResult.GetRequiredValue(Seed);
            var removeBackgroundNoise = parseResult.GetRequiredValue(RemoveBackgroundNoise);
            var fileFormat = parseResult.GetRequiredValue(FileFormat);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                enableLogging: enableLogging,
                optimizeStreamingLatency: optimizeStreamingLatency,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                audio: audio,
                audioname: audioname,
                modelId: modelId,
                voiceSettings: voiceSettings,
                seed: seed,
                removeBackgroundNoise: removeBackgroundNoise,
                fileFormat: fileFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SpeechToSpeech.CreateSpeechToSpeechByVoiceIdAsync(
                voiceId: voiceId,
                enableLogging: enableLogging,
                optimizeStreamingLatency: optimizeStreamingLatency,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                audio: audio,
                audioname: audioname,
                modelId: modelId,
                voiceSettings: voiceSettings,
                seed: seed,
                removeBackgroundNoise: removeBackgroundNoise,
                fileFormat: fileFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}