//HintName: G.Commands.StoresListStoreEventsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresListStoreEventsCommand : global::System.CommandLine.Command
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
            global::System.DateTime? filterBefore,
            global::System.DateTime? filterAfter,
            global::G.ListStoreEventsEventType eventType,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.StoreEventListResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> StoreIdentifier { get; } = new(
            name: "storeIdentifier")
        {
            Description = @"The ID or name of the store",
        };

        private global::System.CommandLine.Argument<global::G.ListStoreEventsEventType> EventType { get; } = new(
            name: "eventType")
        {
            Description = @"The type of event to list",
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

        private global::System.CommandLine.Option<global::System.DateTime?> FilterBefore { get; } = new(
            name: "filterBefore")
        {
            Description = @"Time to filter events before",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> FilterAfter { get; } = new(
            name: "filterAfter")
        {
            Description = @"Time to filter events after",
        };


        public StoresListStoreEventsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"List events for a store.

Args:
    store_identifier: The ID or name of the store.
    options: The pagination options.

Returns:
    StoreEventListResponse: The list of events for the store.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StoreIdentifier);
            Arguments.Add(EventType);
            Options.Add(Limit);
            Options.Add(After);
            Options.Add(Before);
            Options.Add(IncludeTotal);
            Options.Add(FilterBefore);
            Options.Add(FilterAfter);

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
            var filterBefore = parseResult.GetRequiredValue(FilterBefore);
            var filterAfter = parseResult.GetRequiredValue(FilterAfter);
            var eventType = parseResult.GetRequiredValue(EventType);

            Validate(
                parseResult: parseResult,
                storeIdentifier: storeIdentifier,
                limit: limit,
                after: after,
                before: before,
                includeTotal: includeTotal,
                filterBefore: filterBefore,
                filterAfter: filterAfter,
                eventType: eventType,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.ListStoreEventsAsync(
                storeIdentifier: storeIdentifier,
                limit: limit,
                after: after,
                before: before,
                includeTotal: includeTotal,
                filterBefore: filterBefore,
                filterAfter: filterAfter,
                eventType: eventType,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}