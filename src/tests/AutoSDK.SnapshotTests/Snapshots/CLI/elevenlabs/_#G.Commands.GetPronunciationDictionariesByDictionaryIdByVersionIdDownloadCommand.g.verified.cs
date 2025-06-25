//HintName: G.Commands.GetPronunciationDictionariesByDictionaryIdByVersionIdDownloadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetPronunciationDictionariesByDictionaryIdByVersionIdDownloadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string dictionaryId,
            string versionId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DictionaryId { get; } = new(
            name: "dictionaryId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> VersionId { get; } = new(
            name: "versionId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetPronunciationDictionariesByDictionaryIdByVersionIdDownloadCommand(G.IApi client) : base(
            name: "get",
            description: @"Get a PLS file with a pronunciation dictionary version rules")
        {
            _client = client;

            Arguments.Add(DictionaryId);
            Arguments.Add(VersionId);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var dictionaryId = parseResult.GetRequiredValue(DictionaryId);
            var versionId = parseResult.GetRequiredValue(VersionId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                dictionaryId: dictionaryId,
                versionId: versionId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PronunciationDictionary.GetPronunciationDictionariesByDictionaryIdByVersionIdDownloadAsync(
                dictionaryId: dictionaryId,
                versionId: versionId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}