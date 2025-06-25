//HintName: G.Commands.CorporaQueryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CorporaQueryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid corpusId,
            string? query,
            int? maxResults,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.UltravoxV1CorpusQueryResult> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> CorpusId { get; } = new(
            name: "corpusId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Query { get; } = new(
            name: "query")
        {
            Description = @"The query to run.",
        };

        private global::System.CommandLine.Option<int?> MaxResults { get; } = new(
            name: "maxResults")
        {
            Description = @"The maximum number of results to return.",
        };
        public CorporaQueryCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "corpora",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CorpusId);
            Options.Add(Query);
            Options.Add(MaxResults);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var corpusId = parseResult.GetRequiredValue(CorpusId);
            var query = parseResult.GetRequiredValue(Query);
            var maxResults = parseResult.GetRequiredValue(MaxResults);

            Validate(
                parseResult: parseResult,
                corpusId: corpusId,
                query: query,
                maxResults: maxResults,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Corpora.CorporaQueryAsync(
                corpusId: corpusId,
                query: query,
                maxResults: maxResults,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}