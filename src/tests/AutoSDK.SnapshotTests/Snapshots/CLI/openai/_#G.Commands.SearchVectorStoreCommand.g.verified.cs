//HintName: G.Commands.SearchVectorStoreCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchVectorStoreCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string vectorStoreId,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> query,
            bool? rewriteQuery,
            int? maxNumResults,
            global::G.OneOf<global::G.ComparisonFilter, global::G.CompoundFilter>? filters,
            global::G.VectorStoreSearchRequestRankingOptions? rankingOptions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VectorStoreSearchResultsPage response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VectorStoreId { get; } = new(
            name: "vectorStoreId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.OneOf<string, global::System.Collections.Generic.IList<string>>> Query { get; } = new(
            name: "query")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> RewriteQuery { get; } = new(
            name: "rewriteQuery")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> MaxNumResults { get; } = new(
            name: "maxNumResults")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OneOf<global::G.ComparisonFilter, global::G.CompoundFilter>?> Filters { get; } = new(
            name: "filters")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.VectorStoreSearchRequestRankingOptions?> RankingOptions { get; } = new(
            name: "rankingOptions")
        {
            Description = "",
        };
        public SearchVectorStoreCommand(G.IOpenAiClient client) : base(
            name: "search",
            description: @"")
        {
            _client = client;

            Arguments.Add(VectorStoreId);
            Arguments.Add(Query);
            Options.Add(RewriteQuery);
            Options.Add(MaxNumResults);
            Options.Add(Filters);
            Options.Add(RankingOptions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var vectorStoreId = parseResult.GetRequiredValue(VectorStoreId);
            var query = parseResult.GetRequiredValue(Query);
            var rewriteQuery = parseResult.GetRequiredValue(RewriteQuery);
            var maxNumResults = parseResult.GetRequiredValue(MaxNumResults);
            var filters = parseResult.GetRequiredValue(Filters);
            var rankingOptions = parseResult.GetRequiredValue(RankingOptions);

            Validate(
                parseResult: parseResult,
                vectorStoreId: vectorStoreId,
                query: query,
                rewriteQuery: rewriteQuery,
                maxNumResults: maxNumResults,
                filters: filters,
                rankingOptions: rankingOptions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VectorStores.SearchVectorStoreAsync(
                vectorStoreId: vectorStoreId,
                query: query,
                rewriteQuery: rewriteQuery,
                maxNumResults: maxNumResults,
                filters: filters,
                rankingOptions: rankingOptions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}