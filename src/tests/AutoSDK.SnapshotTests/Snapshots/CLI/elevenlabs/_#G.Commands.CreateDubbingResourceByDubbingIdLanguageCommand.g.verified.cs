//HintName: G.Commands.CreateDubbingResourceByDubbingIdLanguageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateDubbingResourceByDubbingIdLanguageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string dubbingId,
            string? xiApiKey,
            string? language,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.LanguageAddedResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DubbingId { get; } = new(
            name: "dubbingId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string?> Language { get; } = new(
            name: "language")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public CreateDubbingResourceByDubbingIdLanguageCommand(G.IApi client) : base(
            name: "create",
            description: @"Adds the given ElevenLab Turbo V2/V2.5 language code to the resource. Does not automatically generate transcripts/translations/audio.")
        {
            _client = client;

            Arguments.Add(DubbingId);
            Arguments.Add(Language);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var dubbingId = parseResult.GetRequiredValue(DubbingId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var language = parseResult.GetRequiredValue(Language);

            Validate(
                parseResult: parseResult,
                dubbingId: dubbingId,
                xiApiKey: xiApiKey,
                language: language,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dubbing.CreateDubbingResourceByDubbingIdLanguageAsync(
                dubbingId: dubbingId,
                xiApiKey: xiApiKey,
                language: language,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}