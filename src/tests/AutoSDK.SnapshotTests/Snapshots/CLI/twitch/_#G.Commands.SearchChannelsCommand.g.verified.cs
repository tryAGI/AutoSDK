//HintName: G.Commands.SearchChannelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchChannelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string query,
            bool? liveOnly,
            int? first,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SearchChannelsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Query { get; } = new(
            name: "query")
        {
            Description = @"The URI-encoded search string. For example, encode search strings like _angel of death_ as `angel%20of%20death`.",
        };

        private global::System.CommandLine.Option<bool?> LiveOnly { get; } = new(
            name: "liveOnly")
        {
            Description = @"A Boolean value that determines whether the response includes only channels that are currently streaming live. Set to **true** to get only channels that are streaming live; otherwise, **false** to get live and offline channels. The default is **false**.",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of items to return per page in the response. The minimum page size is 1 item per page and the maximum is 100 items per page. The default is 20.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)",
        };
        public SearchChannelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "search",
            description: @"Gets the channels that match the specified query and have streamed content within the past 6 months.

The fields that the API uses for comparison depends on the value that the _live\_only_ query parameter is set to. If _live\_only_ is **false**, the API matches on the broadcaster’s login name. However, if _live\_only_ is **true**, the API matches on the broadcaster’s name and category name.

To match, the beginning of the broadcaster’s name or category must match the query string. The comparison is case insensitive. If the query string is angel\_of\_death, it matches all names that begin with angel\_of\_death. However, if the query string is a phrase like _angel of death_, it matches to names starting with angelofdeath or names starting with angel\_of\_death.

By default, the results include both live and offline channels. To get only live channels set the _live\_only_ query parameter to **true**.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Query);
            Options.Add(LiveOnly);
            Options.Add(First);
            Options.Add(After);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var query = parseResult.GetRequiredValue(Query);
            var liveOnly = parseResult.GetRequiredValue(LiveOnly);
            var first = parseResult.GetRequiredValue(First);
            var after = parseResult.GetRequiredValue(After);

            Validate(
                parseResult: parseResult,
                query: query,
                liveOnly: liveOnly,
                first: first,
                after: after,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Search.SearchChannelsAsync(
                query: query,
                liveOnly: liveOnly,
                first: first,
                after: after,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}