//HintName: G.Commands.GetVoicesPvcByVoiceIdSamplesBySampleIdSpeakersBySpeakerIdAudioCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetVoicesPvcByVoiceIdSamplesBySampleIdSpeakersBySpeakerIdAudioCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            string sampleId,
            string speakerId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SpeakerAudioResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> SampleId { get; } = new(
            name: "sampleId")
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
        public GetVoicesPvcByVoiceIdSamplesBySampleIdSpeakersBySpeakerIdAudioCommand(G.IApi client) : base(
            name: "get",
            description: @"Retrieve the separated audio for a specific speaker.")
        {
            _client = client;

            Arguments.Add(VoiceId);
            Arguments.Add(SampleId);
            Arguments.Add(SpeakerId);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var sampleId = parseResult.GetRequiredValue(SampleId);
            var speakerId = parseResult.GetRequiredValue(SpeakerId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                sampleId: sampleId,
                speakerId: speakerId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PvcVoices.GetVoicesPvcByVoiceIdSamplesBySampleIdSpeakersBySpeakerIdAudioAsync(
                voiceId: voiceId,
                sampleId: sampleId,
                speakerId: speakerId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}