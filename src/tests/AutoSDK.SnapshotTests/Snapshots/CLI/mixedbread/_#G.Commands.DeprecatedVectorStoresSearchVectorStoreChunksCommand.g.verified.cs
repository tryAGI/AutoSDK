//HintName: G.Commands.DeprecatedVectorStoresSearchVectorStoreChunksCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeprecatedVectorStoresSearchVectorStoreChunksCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string query,
            global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>> vectorStoreIdentifiers,
            int? topK,
            global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? filters,
            global::G.AnyOf<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds,
            global::G.VectorStoreChunkSearchOptions? searchOptions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.VectorStoreSearchResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Query { get; } = new(
            name: "query")
        {
            Description = @"Search query text",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>>> VectorStoreIdentifiers { get; } = new(
            name: "vectorStoreIdentifiers")
        {
            Description = @"IDs or names of vector stores to search",
        };

        private global::System.CommandLine.Option<int?> TopK { get; } = new(
            name: "topK")
        {
            Description = @"Number of results to return",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"Optional filter conditions",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>?> FileIds { get; } = new(
            name: "fileIds")
        {
            Description = @"Optional list of file IDs to filter chunks by (inclusion filter)",
        };

        private global::System.CommandLine.Option<global::G.VectorStoreChunkSearchOptions?> SearchOptions { get; } = new(
            name: "searchOptions")
        {
            Description = @"Search configuration options",
        };


        public DeprecatedVectorStoresSearchVectorStoreChunksCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "search",
            description: @"DEPRECATED: Use POST /stores/search instead")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Query);
            Arguments.Add(VectorStoreIdentifiers);
            Options.Add(TopK);
            Options.Add(Filters);
            Options.Add(FileIds);
            Options.Add(SearchOptions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var query = parseResult.GetRequiredValue(Query);
            var vectorStoreIdentifiers = parseResult.GetRequiredValue(VectorStoreIdentifiers);
            var topK = parseResult.GetRequiredValue(TopK);
            var filters = parseResult.GetRequiredValue(Filters);
            var fileIds = parseResult.GetRequiredValue(FileIds);
            var searchOptions = parseResult.GetRequiredValue(SearchOptions);

            Validate(
                parseResult: parseResult,
                query: query,
                vectorStoreIdentifiers: vectorStoreIdentifiers,
                topK: topK,
                filters: filters,
                fileIds: fileIds,
                searchOptions: searchOptions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeprecatedVectorStores.SearchVectorStoreChunksAsync(
                query: query,
                vectorStoreIdentifiers: vectorStoreIdentifiers,
                topK: topK,
                filters: filters,
                fileIds: fileIds,
                searchOptions: searchOptions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}