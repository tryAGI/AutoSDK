//HintName: G.Commands.StoresListStoreFilesWithMetadataFilterCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresListStoreFilesWithMetadataFilterCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            int? limit,
            string? after,
            string? before,
            bool? includeTotal,
            global::System.Collections.Generic.IList<global::G.StoreFileStatus>? statuses,
            global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? metadataFilter,
            string? q,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.StoreFileListResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> StoreIdentifier { get; } = new(
            name: "storeIdentifier")
        {
            Description = @"The ID or name of the store",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Maximum number of items to return per page (1-100)",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"Cursor for forward pagination - get items after this position. Use last_cursor from previous response.",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = @"Cursor for backward pagination - get items before this position. Use first_cursor from previous response.",
        };

        private global::System.CommandLine.Option<bool?> IncludeTotal { get; } = new(
            name: "includeTotal")
        {
            Description = @"Whether to include total count in response (expensive operation)",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.StoreFileStatus>?> Statuses { get; } = new(
            name: "statuses")
        {
            Description = @"Status to filter by",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>?> MetadataFilter { get; } = new(
            name: "metadataFilter")
        {
            Description = @"Metadata filter to apply to the query",
        };

        private global::System.CommandLine.Option<string?> Q { get; } = new(
            name: "q")
        {
            Description = @"Search query for fuzzy matching over name and external_id fields",
        };


        public StoresListStoreFilesWithMetadataFilterCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"List files indexed in a vector store with pagination and metadata filter.

Args:
    vector_store_identifier: The ID or name of the vector store
    pagination: Pagination parameters and metadata filter

Returns:
    VectorStoreFileListResponse: Paginated list of vector store files")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StoreIdentifier);
            Options.Add(Limit);
            Options.Add(After);
            Options.Add(Before);
            Options.Add(IncludeTotal);
            Options.Add(Statuses);
            Options.Add(MetadataFilter);
            Options.Add(Q);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var storeIdentifier = parseResult.GetRequiredValue(StoreIdentifier);
            var limit = parseResult.GetRequiredValue(Limit);
            var after = parseResult.GetRequiredValue(After);
            var before = parseResult.GetRequiredValue(Before);
            var includeTotal = parseResult.GetRequiredValue(IncludeTotal);
            var statuses = parseResult.GetRequiredValue(Statuses);
            var metadataFilter = parseResult.GetRequiredValue(MetadataFilter);
            var q = parseResult.GetRequiredValue(Q);

            Validate(
                parseResult: parseResult,
                storeIdentifier: storeIdentifier,
                limit: limit,
                after: after,
                before: before,
                includeTotal: includeTotal,
                statuses: statuses,
                metadataFilter: metadataFilter,
                q: q,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.ListStoreFilesWithMetadataFilterAsync(
                storeIdentifier: storeIdentifier,
                limit: limit,
                after: after,
                before: before,
                includeTotal: includeTotal,
                statuses: statuses,
                metadataFilter: metadataFilter,
                q: q,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}