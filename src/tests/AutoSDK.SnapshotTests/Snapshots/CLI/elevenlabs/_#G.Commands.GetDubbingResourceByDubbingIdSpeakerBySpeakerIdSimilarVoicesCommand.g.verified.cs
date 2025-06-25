//HintName: G.Commands.GetDubbingResourceByDubbingIdSpeakerBySpeakerIdSimilarVoicesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetDubbingResourceByDubbingIdSpeakerBySpeakerIdSimilarVoicesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string dubbingId,
            string speakerId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SimilarVoicesForSpeakerResponse response,
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
        public GetDubbingResourceByDubbingIdSpeakerBySpeakerIdSimilarVoicesCommand(G.IApi client) : base(
            name: "get",
            description: @"Fetch the top 10 similar voices to a speaker, including the voice IDs, names, descriptions, and, where possible, a sample audio recording.")
        {
            _client = client;

            Arguments.Add(DubbingId);
            Arguments.Add(SpeakerId);
            Options.Add(XiApiKey);

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

            Validate(
                parseResult: parseResult,
                dubbingId: dubbingId,
                speakerId: speakerId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dubbing.GetDubbingResourceByDubbingIdSpeakerBySpeakerIdSimilarVoicesAsync(
                dubbingId: dubbingId,
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