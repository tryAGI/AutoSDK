//HintName: G.Commands.StoresSearchStoreFilesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresSearchStoreFilesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.MultiModalQuery query,
            global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>> storeIdentifiers,
            int? topK,
            global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? filters,
            global::G.AnyOf<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds,
            global::G.StoreFileSearchOptions? searchOptions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.StoreFileSearchResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.MultiModalQuery> Query { get; } = new(
            name: "query")
        {
            Description = @"Search query text",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>>> StoreIdentifiers { get; } = new(
            name: "storeIdentifiers")
        {
            Description = @"IDs or names of stores to search",
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

        private global::System.CommandLine.Option<global::G.StoreFileSearchOptions?> SearchOptions { get; } = new(
            name: "searchOptions")
        {
            Description = @"Search configuration options",
        };


        public StoresSearchStoreFilesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "search",
            description: @"Search for files within a store based on semantic similarity.

Args:
    store_identifier: The ID or name of the store to search within
    search_params: Search configuration including query text, pagination, and filters

Returns:
    StoreFileSearchResponse: List of matching files with relevance scores")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Query);
            Arguments.Add(StoreIdentifiers);
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
            var storeIdentifiers = parseResult.GetRequiredValue(StoreIdentifiers);
            var topK = parseResult.GetRequiredValue(TopK);
            var filters = parseResult.GetRequiredValue(Filters);
            var fileIds = parseResult.GetRequiredValue(FileIds);
            var searchOptions = parseResult.GetRequiredValue(SearchOptions);

            Validate(
                parseResult: parseResult,
                query: query,
                storeIdentifiers: storeIdentifiers,
                topK: topK,
                filters: filters,
                fileIds: fileIds,
                searchOptions: searchOptions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.SearchStoreFilesAsync(
                query: query,
                storeIdentifiers: storeIdentifiers,
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