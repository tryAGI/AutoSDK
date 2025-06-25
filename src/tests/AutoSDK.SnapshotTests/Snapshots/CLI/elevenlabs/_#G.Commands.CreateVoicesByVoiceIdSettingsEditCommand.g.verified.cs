//HintName: G.Commands.CreateVoicesByVoiceIdSettingsEditCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVoicesByVoiceIdSettingsEditCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            string? xiApiKey,
            double? stability,
            bool? useSpeakerBoost,
            double? similarityBoost,
            double? style,
            double? speed,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EditVoiceSettingsResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> Stability { get; } = new(
            name: "stability")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> UseSpeakerBoost { get; } = new(
            name: "useSpeakerBoost")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> SimilarityBoost { get; } = new(
            name: "similarityBoost")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> Style { get; } = new(
            name: "style")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> Speed { get; } = new(
            name: "speed")
        {
            Description = "",
        };
        public CreateVoicesByVoiceIdSettingsEditCommand(G.IApi client) : base(
            name: "create",
            description: @"Edit your settings for a specific voice. ""similarity_boost"" corresponds to ""Clarity + Similarity Enhancement"" in the web app and ""stability"" corresponds to ""Stability"" slider in the web app.")
        {
            _client = client;

            Arguments.Add(VoiceId);
            Options.Add(XiApiKey);
            Options.Add(Stability);
            Options.Add(UseSpeakerBoost);
            Options.Add(SimilarityBoost);
            Options.Add(Style);
            Options.Add(Speed);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var stability = parseResult.GetRequiredValue(Stability);
            var useSpeakerBoost = parseResult.GetRequiredValue(UseSpeakerBoost);
            var similarityBoost = parseResult.GetRequiredValue(SimilarityBoost);
            var style = parseResult.GetRequiredValue(Style);
            var speed = parseResult.GetRequiredValue(Speed);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                stability: stability,
                useSpeakerBoost: useSpeakerBoost,
                similarityBoost: similarityBoost,
                style: style,
                speed: speed,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Voices.CreateVoicesByVoiceIdSettingsEditAsync(
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                stability: stability,
                useSpeakerBoost: useSpeakerBoost,
                similarityBoost: similarityBoost,
                style: style,
                speed: speed,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}