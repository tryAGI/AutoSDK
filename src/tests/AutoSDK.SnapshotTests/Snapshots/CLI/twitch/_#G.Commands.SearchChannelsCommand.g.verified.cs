//HintName: G.Commands.SearchChannelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchChannelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> LiveOnly { get; } = new(
            name: "liveOnly")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };
        public SearchChannelsCommand(G.IApi client) : base(
            name: "search",
            description: @"Gets the channels that match the specified query and have streamed content within the past 6 months.

The fields that the API uses for comparison depends on the value that the _live\_only_ query parameter is set to. If _live\_only_ is **false**, the API matches on the broadcaster’s login name. However, if _live\_only_ is **true**, the API matches on the broadcaster’s name and category name.

To match, the beginning of the broadcaster’s name or category must match the query string. The comparison is case insensitive. If the query string is angel\_of\_death, it matches all names that begin with angel\_of\_death. However, if the query string is a phrase like _angel of death_, it matches to names starting with angelofdeath or names starting with angel\_of\_death.

By default, the results include both live and offline channels. To get only live channels set the _live\_only_ query parameter to **true**.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;

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