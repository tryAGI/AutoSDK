//HintName: G.Commands.CreateTextToVoiceCreatePreviewsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateTextToVoiceCreatePreviewsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat? outputFormat,
            string? xiApiKey,
            string voiceDescription,
            string? text,
            bool? autoGenerateText,
            double? loudness,
            double? quality,
            int? seed,
            double? guidanceScale,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VoicePreviewsResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VoiceDescription { get; } = new(
            name: "voiceDescription")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat?> OutputFormat { get; } = new(
            name: "outputFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Text { get; } = new(
            name: "text")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AutoGenerateText { get; } = new(
            name: "autoGenerateText")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> Loudness { get; } = new(
            name: "loudness")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> Quality { get; } = new(
            name: "quality")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> GuidanceScale { get; } = new(
            name: "guidanceScale")
        {
            Description = "",
        };
        public CreateTextToVoiceCreatePreviewsCommand(G.IApi client) : base(
            name: "create",
            description: @"Generate a custom voice based on voice description. This method returns a list of voice previews. Each preview has a generated_voice_id and a sample of the voice as base64 encoded mp3 audio. If you like the a voice previewand want to create the voice call /v1/text-to-voice/create-voice-from-preview with the generated_voice_id to create the voice.")
        {
            _client = client;

            Arguments.Add(VoiceDescription);
            Options.Add(OutputFormat);
            Options.Add(XiApiKey);
            Options.Add(Text);
            Options.Add(AutoGenerateText);
            Options.Add(Loudness);
            Options.Add(Quality);
            Options.Add(Seed);
            Options.Add(GuidanceScale);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var voiceDescription = parseResult.GetRequiredValue(VoiceDescription);
            var text = parseResult.GetRequiredValue(Text);
            var autoGenerateText = parseResult.GetRequiredValue(AutoGenerateText);
            var loudness = parseResult.GetRequiredValue(Loudness);
            var quality = parseResult.GetRequiredValue(Quality);
            var seed = parseResult.GetRequiredValue(Seed);
            var guidanceScale = parseResult.GetRequiredValue(GuidanceScale);

            Validate(
                parseResult: parseResult,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                voiceDescription: voiceDescription,
                text: text,
                autoGenerateText: autoGenerateText,
                loudness: loudness,
                quality: quality,
                seed: seed,
                guidanceScale: guidanceScale,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TextToVoice.CreateTextToVoiceCreatePreviewsAsync(
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                voiceDescription: voiceDescription,
                text: text,
                autoGenerateText: autoGenerateText,
                loudness: loudness,
                quality: quality,
                seed: seed,
                guidanceScale: guidanceScale,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}