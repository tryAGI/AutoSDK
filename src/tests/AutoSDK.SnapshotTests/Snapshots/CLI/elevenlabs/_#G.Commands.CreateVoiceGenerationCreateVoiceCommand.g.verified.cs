//HintName: G.Commands.CreateVoiceGenerationCreateVoiceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVoiceGenerationCreateVoiceCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string voiceName,
            string voiceDescription,
            string generatedVoiceId,
            global::System.Collections.Generic.IList<string>? playedNotSelectedVoiceIds,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VoiceResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VoiceName { get; } = new(
            name: "voiceName")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> VoiceDescription { get; } = new(
            name: "voiceDescription")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> GeneratedVoiceId { get; } = new(
            name: "generatedVoiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> PlayedNotSelectedVoiceIds { get; } = new(
            name: "playedNotSelectedVoiceIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Labels { get; } = new(
            name: "labels")
        {
            Description = "",
        };
        public CreateVoiceGenerationCreateVoiceCommand(G.IApi client) : base(
            name: "create",
            description: @"Create a previously generated voice. This endpoint should be called after you fetched a generated_voice_id using /v1/voice-generation/generate-voice.")
        {
            _client = client;

            Arguments.Add(VoiceName);
            Arguments.Add(VoiceDescription);
            Arguments.Add(GeneratedVoiceId);
            Options.Add(XiApiKey);
            Options.Add(PlayedNotSelectedVoiceIds);
            Options.Add(Labels);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var voiceName = parseResult.GetRequiredValue(VoiceName);
            var voiceDescription = parseResult.GetRequiredValue(VoiceDescription);
            var generatedVoiceId = parseResult.GetRequiredValue(GeneratedVoiceId);
            var playedNotSelectedVoiceIds = parseResult.GetRequiredValue(PlayedNotSelectedVoiceIds);
            var labels = parseResult.GetRequiredValue(Labels);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                voiceName: voiceName,
                voiceDescription: voiceDescription,
                generatedVoiceId: generatedVoiceId,
                playedNotSelectedVoiceIds: playedNotSelectedVoiceIds,
                labels: labels,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VoiceGeneration.CreateVoiceGenerationCreateVoiceAsync(
                xiApiKey: xiApiKey,
                voiceName: voiceName,
                voiceDescription: voiceDescription,
                generatedVoiceId: generatedVoiceId,
                playedNotSelectedVoiceIds: playedNotSelectedVoiceIds,
                labels: labels,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}