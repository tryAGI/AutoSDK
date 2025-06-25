//HintName: G.Commands.CreateTextToVoiceCreateVoiceFromPreviewCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateTextToVoiceCreateVoiceFromPreviewCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string voiceName,
            string voiceDescription,
            string generatedVoiceId,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            global::System.Collections.Generic.IList<string>? playedNotSelectedVoiceIds,
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

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Labels { get; } = new(
            name: "labels")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> PlayedNotSelectedVoiceIds { get; } = new(
            name: "playedNotSelectedVoiceIds")
        {
            Description = "",
        };
        public CreateTextToVoiceCreateVoiceFromPreviewCommand(G.IApi client) : base(
            name: "create",
            description: @"Create a voice from previously generated voice preview. This endpoint should be called after you fetched a generated_voice_id using POST /v1/text-to-voice/create-previews.")
        {
            _client = client;

            Arguments.Add(VoiceName);
            Arguments.Add(VoiceDescription);
            Arguments.Add(GeneratedVoiceId);
            Options.Add(XiApiKey);
            Options.Add(Labels);
            Options.Add(PlayedNotSelectedVoiceIds);

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
            var labels = parseResult.GetRequiredValue(Labels);
            var playedNotSelectedVoiceIds = parseResult.GetRequiredValue(PlayedNotSelectedVoiceIds);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                voiceName: voiceName,
                voiceDescription: voiceDescription,
                generatedVoiceId: generatedVoiceId,
                labels: labels,
                playedNotSelectedVoiceIds: playedNotSelectedVoiceIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TextToVoice.CreateTextToVoiceCreateVoiceFromPreviewAsync(
                xiApiKey: xiApiKey,
                voiceName: voiceName,
                voiceDescription: voiceDescription,
                generatedVoiceId: generatedVoiceId,
                labels: labels,
                playedNotSelectedVoiceIds: playedNotSelectedVoiceIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}