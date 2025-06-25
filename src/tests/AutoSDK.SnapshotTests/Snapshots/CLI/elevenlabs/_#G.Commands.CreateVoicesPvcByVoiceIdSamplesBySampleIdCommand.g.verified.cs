//HintName: G.Commands.CreateVoicesPvcByVoiceIdSamplesBySampleIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVoicesPvcByVoiceIdSamplesBySampleIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            string sampleId,
            string? xiApiKey,
            bool? removeBackgroundNoise,
            global::System.Collections.Generic.IList<string>? selectedSpeakerIds,
            int? trimStartTime,
            int? trimEndTime,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddVoiceResponseModel response,
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

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> SelectedSpeakerIds { get; } = new(
            name: "selectedSpeakerIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> TrimStartTime { get; } = new(
            name: "trimStartTime")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> TrimEndTime { get; } = new(
            name: "trimEndTime")
        {
            Description = "",
        };
        public CreateVoicesPvcByVoiceIdSamplesBySampleIdCommand(G.IApi client) : base(
            name: "create",
            description: @"Update a PVC voice sample - apply noise removal, or select speaker.")
        {
            _client = client;

            Arguments.Add(VoiceId);
            Arguments.Add(SampleId);
            Options.Add(XiApiKey);
            Options.Add(RemoveBackgroundNoise);
            Options.Add(SelectedSpeakerIds);
            Options.Add(TrimStartTime);
            Options.Add(TrimEndTime);

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
            var selectedSpeakerIds = parseResult.GetRequiredValue(SelectedSpeakerIds);
            var trimStartTime = parseResult.GetRequiredValue(TrimStartTime);
            var trimEndTime = parseResult.GetRequiredValue(TrimEndTime);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                sampleId: sampleId,
                xiApiKey: xiApiKey,
                removeBackgroundNoise: removeBackgroundNoise,
                selectedSpeakerIds: selectedSpeakerIds,
                trimStartTime: trimStartTime,
                trimEndTime: trimEndTime,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PvcVoices.CreateVoicesPvcByVoiceIdSamplesBySampleIdAsync(
                voiceId: voiceId,
                sampleId: sampleId,
                xiApiKey: xiApiKey,
                removeBackgroundNoise: removeBackgroundNoise,
                selectedSpeakerIds: selectedSpeakerIds,
                trimStartTime: trimStartTime,
                trimEndTime: trimEndTime,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}