//HintName: G.Commands.EditDubbingResourceByDubbingIdSegmentBySegmentIdByLanguageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EditDubbingResourceByDubbingIdSegmentBySegmentIdByLanguageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string dubbingId,
            string segmentId,
            string language,
            string? xiApiKey,
            double? startTime,
            double? endTime,
            string? text,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SegmentUpdateResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DubbingId { get; } = new(
            name: "dubbingId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> SegmentId { get; } = new(
            name: "segmentId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Language { get; } = new(
            name: "language")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> StartTime { get; } = new(
            name: "startTime")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> EndTime { get; } = new(
            name: "endTime")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Text { get; } = new(
            name: "text")
        {
            Description = "",
        };
        public EditDubbingResourceByDubbingIdSegmentBySegmentIdByLanguageCommand(G.IApi client) : base(
            name: "edit",
            description: @"Modifies a single segment with new text and/or start/end times. Will update the values for only a specific language of a segment. Does not automatically regenerate the dub.")
        {
            _client = client;

            Arguments.Add(DubbingId);
            Arguments.Add(SegmentId);
            Arguments.Add(Language);
            Options.Add(XiApiKey);
            Options.Add(StartTime);
            Options.Add(EndTime);
            Options.Add(Text);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var dubbingId = parseResult.GetRequiredValue(DubbingId);
            var segmentId = parseResult.GetRequiredValue(SegmentId);
            var language = parseResult.GetRequiredValue(Language);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var startTime = parseResult.GetRequiredValue(StartTime);
            var endTime = parseResult.GetRequiredValue(EndTime);
            var text = parseResult.GetRequiredValue(Text);

            Validate(
                parseResult: parseResult,
                dubbingId: dubbingId,
                segmentId: segmentId,
                language: language,
                xiApiKey: xiApiKey,
                startTime: startTime,
                endTime: endTime,
                text: text,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dubbing.EditDubbingResourceByDubbingIdSegmentBySegmentIdByLanguageAsync(
                dubbingId: dubbingId,
                segmentId: segmentId,
                language: language,
                xiApiKey: xiApiKey,
                startTime: startTime,
                endTime: endTime,
                text: text,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}