//HintName: G.Commands.StoresListStoreFilesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresListStoreFilesCommand : global::System.CommandLine.Command
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


        public StoresListStoreFilesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"DEPRECATED: Use POST /stores/{store_identifier}/files/list instead")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StoreIdentifier);
            Options.Add(Limit);
            Options.Add(After);
            Options.Add(Before);
            Options.Add(IncludeTotal);
            Options.Add(Statuses);

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

            Validate(
                parseResult: parseResult,
                storeIdentifier: storeIdentifier,
                limit: limit,
                after: after,
                before: before,
                includeTotal: includeTotal,
                statuses: statuses,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.ListStoreFilesAsync(
                storeIdentifier: storeIdentifier,
                limit: limit,
                after: after,
                before: before,
                includeTotal: includeTotal,
                statuses: statuses,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}