//HintName: G.Commands.GetVoicesPvcByVoiceIdSamplesBySampleIdSpeakersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetVoicesPvcByVoiceIdSamplesBySampleIdSpeakersCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            string sampleId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SpeakerSeparationResponseModel response,
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

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetVoicesPvcByVoiceIdSamplesBySampleIdSpeakersCommand(G.IApi client) : base(
            name: "get",
            description: @"Retrieve the status of the speaker separation process and the list of detected speakers if complete.")
        {
            _client = client;

            Arguments.Add(VoiceId);
            Arguments.Add(SampleId);
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
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                sampleId: sampleId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PvcVoices.GetVoicesPvcByVoiceIdSamplesBySampleIdSpeakersAsync(
                voiceId: voiceId,
                sampleId: sampleId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}