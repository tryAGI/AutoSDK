//HintName: G.Commands.GetVoicesPvcByVoiceIdSamplesBySampleIdAudioCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetVoicesPvcByVoiceIdSamplesBySampleIdAudioCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            string sampleId,
            string? xiApiKey,
            bool? removeBackgroundNoise,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VoiceSamplePreviewResponseModel response,
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

        private global::System.CommandLine.Option<bool?> RemoveBackgroundNoise { get; } = new(
            name: "removeBackgroundNoise")
        {
            Description = "",
        };
        public GetVoicesPvcByVoiceIdSamplesBySampleIdAudioCommand(G.IApi client) : base(
            name: "get",
            description: @"Retrieve the first 30 seconds of voice sample audio with or without noise removal.")
        {
            _client = client;

            Arguments.Add(VoiceId);
            Arguments.Add(SampleId);
            Options.Add(XiApiKey);
            Options.Add(RemoveBackgroundNoise);

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
            var removeBackgroundNoise = parseResult.GetRequiredValue(RemoveBackgroundNoise);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                sampleId: sampleId,
                xiApiKey: xiApiKey,
                removeBackgroundNoise: removeBackgroundNoise,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PvcVoices.GetVoicesPvcByVoiceIdSamplesBySampleIdAudioAsync(
                voiceId: voiceId,
                sampleId: sampleId,
                xiApiKey: xiApiKey,
                removeBackgroundNoise: removeBackgroundNoise,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}