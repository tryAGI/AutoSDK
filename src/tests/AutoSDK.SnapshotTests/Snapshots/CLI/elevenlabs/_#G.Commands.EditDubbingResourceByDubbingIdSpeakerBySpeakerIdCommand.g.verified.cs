//HintName: G.Commands.EditDubbingResourceByDubbingIdSpeakerBySpeakerIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EditDubbingResourceByDubbingIdSpeakerBySpeakerIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string dubbingId,
            string speakerId,
            string? xiApiKey,
            string? voiceId,
            global::System.Collections.Generic.IList<string>? languages,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SpeakerUpdatedResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DubbingId { get; } = new(
            name: "dubbingId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> SpeakerId { get; } = new(
            name: "speakerId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Languages { get; } = new(
            name: "languages")
        {
            Description = "",
        };
        public EditDubbingResourceByDubbingIdSpeakerBySpeakerIdCommand(G.IApi client) : base(
            name: "edit",
            description: @"Amend the metadata associated with a speaker, such as their voice. Both voice cloning and using voices from the ElevenLabs library are supported.")
        {
            _client = client;

            Arguments.Add(DubbingId);
            Arguments.Add(SpeakerId);
            Options.Add(XiApiKey);
            Options.Add(VoiceId);
            Options.Add(Languages);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var dubbingId = parseResult.GetRequiredValue(DubbingId);
            var speakerId = parseResult.GetRequiredValue(SpeakerId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var languages = parseResult.GetRequiredValue(Languages);

            Validate(
                parseResult: parseResult,
                dubbingId: dubbingId,
                speakerId: speakerId,
                xiApiKey: xiApiKey,
                voiceId: voiceId,
                languages: languages,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dubbing.EditDubbingResourceByDubbingIdSpeakerBySpeakerIdAsync(
                dubbingId: dubbingId,
                speakerId: speakerId,
                xiApiKey: xiApiKey,
                voiceId: voiceId,
                languages: languages,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}