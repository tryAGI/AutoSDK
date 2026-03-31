//HintName: G.Commands.DeprecatedVectorStoresListVectorStoresCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeprecatedVectorStoresListVectorStoresCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? limit,
            string? after,
            string? before,
            bool? includeTotal,
            string? q,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.VectorStoreListResponse response,
            global::System.Threading.CancellationToken cancellationToken);


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

        private global::System.CommandLine.Option<string?> Q { get; } = new(
            name: "q")
        {
            Description = @"Search query for fuzzy matching over name and description fields",
        };


        public DeprecatedVectorStoresListVectorStoresCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"DEPRECATED: Use GET /stores instead")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Limit);
            Options.Add(After);
            Options.Add(Before);
            Options.Add(IncludeTotal);
            Options.Add(Q);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var limit = parseResult.GetRequiredValue(Limit);
            var after = parseResult.GetRequiredValue(After);
            var before = parseResult.GetRequiredValue(Before);
            var includeTotal = parseResult.GetRequiredValue(IncludeTotal);
            var q = parseResult.GetRequiredValue(Q);

            Validate(
                parseResult: parseResult,
                limit: limit,
                after: after,
                before: before,
                includeTotal: includeTotal,
                q: q,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeprecatedVectorStores.ListVectorStoresAsync(
                limit: limit,
                after: after,
                before: before,
                includeTotal: includeTotal,
                q: q,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}