//HintName: G.Commands.GetPronunciationDictionariesByPronunciationDictionaryIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetPronunciationDictionariesByPronunciationDictionaryIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string pronunciationDictionaryId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetPronunciationDictionaryMetadataResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> PronunciationDictionaryId { get; } = new(
            name: "pronunciationDictionaryId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetPronunciationDictionariesByPronunciationDictionaryIdCommand(G.IApi client) : base(
            name: "get",
            description: @"Get metadata for a pronunciation dictionary")
        {
            _client = client;

            Arguments.Add(PronunciationDictionaryId);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pronunciationDictionaryId = parseResult.GetRequiredValue(PronunciationDictionaryId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                pronunciationDictionaryId: pronunciationDictionaryId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PronunciationDictionary.GetPronunciationDictionariesByPronunciationDictionaryIdAsync(
                pronunciationDictionaryId: pronunciationDictionaryId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}