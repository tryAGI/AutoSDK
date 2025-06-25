//HintName: G.Commands.CorporaSourcesDocumentsListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CorporaSourcesDocumentsListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid corpusId,
            string? cursor,
            int? pageSize,
            global::System.Guid sourceId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PaginatedultravoxV1CorpusDocumentList response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> CorpusId { get; } = new(
            name: "corpusId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> SourceId { get; } = new(
            name: "sourceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Cursor { get; } = new(
            name: "cursor")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"",
        };
        public CorporaSourcesDocumentsListCommand(G.IApi client) : base(
            name: "corpora",
            description: @"")
        {
            _client = client;

            Arguments.Add(CorpusId);
            Arguments.Add(SourceId);
            Options.Add(Cursor);
            Options.Add(PageSize);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var corpusId = parseResult.GetRequiredValue(CorpusId);
            var cursor = parseResult.GetRequiredValue(Cursor);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var sourceId = parseResult.GetRequiredValue(SourceId);

            Validate(
                parseResult: parseResult,
                corpusId: corpusId,
                cursor: cursor,
                pageSize: pageSize,
                sourceId: sourceId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Corpora.CorporaSourcesDocumentsListAsync(
                corpusId: corpusId,
                cursor: cursor,
                pageSize: pageSize,
                sourceId: sourceId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}