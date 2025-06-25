//HintName: G.Commands.GetPronunciationDictionariesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetPronunciationDictionariesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? cursor,
            int? pageSize,
            global::G.GetPronunciationDictionariesV1PronunciationDictionariesGetSort? sort,
            string? sortDirection,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetPronunciationDictionariesMetadataResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Cursor { get; } = new(
            name: "cursor")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GetPronunciationDictionariesV1PronunciationDictionariesGetSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> SortDirection { get; } = new(
            name: "sortDirection")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetPronunciationDictionariesCommand(G.IApi client) : base(
            name: "get",
            description: @"Get a list of the pronunciation dictionaries you have access to and their metadata")
        {
            _client = client;

            Options.Add(Cursor);
            Options.Add(PageSize);
            Options.Add(Sort);
            Options.Add(SortDirection);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cursor = parseResult.GetRequiredValue(Cursor);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var sort = parseResult.GetRequiredValue(Sort);
            var sortDirection = parseResult.GetRequiredValue(SortDirection);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                cursor: cursor,
                pageSize: pageSize,
                sort: sort,
                sortDirection: sortDirection,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PronunciationDictionary.GetPronunciationDictionariesAsync(
                cursor: cursor,
                pageSize: pageSize,
                sort: sort,
                sortDirection: sortDirection,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}