//HintName: G.Commands.GetVoicesByVoiceIdSamplesBySampleIdAudioCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetVoicesByVoiceIdSamplesBySampleIdAudioCommand : global::System.CommandLine.Command
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
        public GetVoicesByVoiceIdSamplesBySampleIdAudioCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns the audio corresponding to a sample attached to a voice.")
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
            await _client.Samples.GetVoicesByVoiceIdSamplesBySampleIdAudioAsync(
                voiceId: voiceId,
                sampleId: sampleId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}