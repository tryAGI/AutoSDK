//HintName: G.Commands.DataSourcesListDataSourcesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DataSourcesListDataSourcesCommand : global::System.CommandLine.Command
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
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DataSourceListResponse response,
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


        public DataSourcesListDataSourcesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Get all data sources.

Returns:
    The list of data sources.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Limit);
            Options.Add(After);
            Options.Add(Before);
            Options.Add(IncludeTotal);

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

            Validate(
                parseResult: parseResult,
                limit: limit,
                after: after,
                before: before,
                includeTotal: includeTotal,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DataSources.ListDataSourcesAsync(
                limit: limit,
                after: after,
                before: before,
                includeTotal: includeTotal,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}