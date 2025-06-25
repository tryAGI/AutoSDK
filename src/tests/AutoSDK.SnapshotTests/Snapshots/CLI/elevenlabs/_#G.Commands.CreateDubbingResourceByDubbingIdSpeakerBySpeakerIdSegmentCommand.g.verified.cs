//HintName: G.Commands.CreateDubbingResourceByDubbingIdSpeakerBySpeakerIdSegmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateDubbingResourceByDubbingIdSpeakerBySpeakerIdSegmentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string dubbingId,
            string speakerId,
            string? xiApiKey,
            double startTime,
            double endTime,
            string? text,
            global::System.Collections.Generic.Dictionary<string, string>? translations,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SegmentCreateResponse response,
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

        private global::System.CommandLine.Argument<double> StartTime { get; } = new(
            name: "startTime")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<double> EndTime { get; } = new(
            name: "endTime")
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

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Translations { get; } = new(
            name: "translations")
        {
            Description = "",
        };
        public CreateDubbingResourceByDubbingIdSpeakerBySpeakerIdSegmentCommand(G.IApi client) : base(
            name: "create",
            description: @"Creates a new segment in dubbing resource with a start and end time for the speaker in every available language. Does not automatically generate transcripts/translations/audio.")
        {
            _client = client;

            Arguments.Add(DubbingId);
            Arguments.Add(SpeakerId);
            Arguments.Add(StartTime);
            Arguments.Add(EndTime);
            Options.Add(XiApiKey);
            Options.Add(Text);
            Options.Add(Translations);

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
            var startTime = parseResult.GetRequiredValue(StartTime);
            var endTime = parseResult.GetRequiredValue(EndTime);
            var text = parseResult.GetRequiredValue(Text);
            var translations = parseResult.GetRequiredValue(Translations);

            Validate(
                parseResult: parseResult,
                dubbingId: dubbingId,
                speakerId: speakerId,
                xiApiKey: xiApiKey,
                startTime: startTime,
                endTime: endTime,
                text: text,
                translations: translations,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dubbing.CreateDubbingResourceByDubbingIdSpeakerBySpeakerIdSegmentAsync(
                dubbingId: dubbingId,
                speakerId: speakerId,
                xiApiKey: xiApiKey,
                startTime: startTime,
                endTime: endTime,
                text: text,
                translations: translations,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}