//HintName: G.Commands.ToolsApiCreateToolsWebSearchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ToolsApiCreateToolsWebSearchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? query,
            global::G.WebSearchRequestTopic? topic,
            global::G.WebSearchRequestSearchDepth? searchDepth,
            int? chunksPerSource,
            int? maxResults,
            global::G.WebSearchRequestTimeRange? timeRange,
            int? days,
            global::G.OneOf<global::G.WebSearchRequestIncludeRawContent?, bool?>? includeRawContent,
            bool? includeAnswer,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            global::G.WebSearchRequestCountry? country,
            bool? stream,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.WebSearchResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Query { get; } = new(
            name: "query")
        {
            Description = @"The search query.",
        };

        private global::System.CommandLine.Option<global::G.WebSearchRequestTopic?> Topic { get; } = new(
            name: "topic")
        {
            Description = @"The search topic category. Use `news` for current events and news articles, or `general` for broader web search.",
        };

        private global::System.CommandLine.Option<global::G.WebSearchRequestSearchDepth?> SearchDepth { get; } = new(
            name: "searchDepth")
        {
            Description = @"Controls search comprehensiveness:

- `basic`: Returns fewer but highly relevant results
- `advanced`: Performs a deeper search with more results",
        };

        private global::System.CommandLine.Option<int?> ChunksPerSource { get; } = new(
            name: "chunksPerSource")
        {
            Description = @"Only applies when `search_depth` is `advanced`. Specifies how many text segments to extract from each source. Limited to 3 chunks maximum.",
        };

        private global::System.CommandLine.Option<int?> MaxResults { get; } = new(
            name: "maxResults")
        {
            Description = @"Limits the number of search results returned. Cannot exceed 20 sources.",
        };

        private global::System.CommandLine.Option<global::G.WebSearchRequestTimeRange?> TimeRange { get; } = new(
            name: "timeRange")
        {
            Description = @"Filters results to content published within the specified time range back from the current date. For example, `week` or `w` returns results from the past 7 days.",
        };

        private global::System.CommandLine.Option<int?> Days { get; } = new(
            name: "days")
        {
            Description = @"For news topic searches, specifies how many days of news coverage to include.",
        };

        private global::System.CommandLine.Option<global::G.OneOf<global::G.WebSearchRequestIncludeRawContent?, bool?>?> IncludeRawContent { get; } = new(
            name: "includeRawContent")
        {
            Description = @"Controls how raw content is included in search results:

- `text`: Returns plain text without formatting markup
- `markdown`: Returns structured content with markdown formatting (headers, links, bold text)
- `true`: Same as `markdown`
- `false`: Raw content is not included (default if unset)",
        };

        private global::System.CommandLine.Option<bool?> IncludeAnswer { get; } = new(
            name: "includeAnswer")
        {
            Description = @"Whether to include a generated answer to the query in the response. If `false`, only search results are returned.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> IncludeDomains { get; } = new(
            name: "includeDomains")
        {
            Description = @"Domains to include in the search. If unset, the search includes all domains.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ExcludeDomains { get; } = new(
            name: "excludeDomains")
        {
            Description = @"Domains to exclude from the search. If unset, the search includes all domains.",
        };

        private global::System.CommandLine.Option<global::G.WebSearchRequestCountry?> Country { get; } = new(
            name: "country")
        {
            Description = @"Localizes search results to a specific country. Only applies to general topic searches.",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"Enables streaming of search results as they become available.",
        };


        public ToolsApiCreateToolsWebSearchCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Search the web for information about a given query and return relevant results with source URLs.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Query);
            Options.Add(Topic);
            Options.Add(SearchDepth);
            Options.Add(ChunksPerSource);
            Options.Add(MaxResults);
            Options.Add(TimeRange);
            Options.Add(Days);
            Options.Add(IncludeRawContent);
            Options.Add(IncludeAnswer);
            Options.Add(IncludeDomains);
            Options.Add(ExcludeDomains);
            Options.Add(Country);
            Options.Add(Stream);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var query = parseResult.GetRequiredValue(Query);
            var topic = parseResult.GetRequiredValue(Topic);
            var searchDepth = parseResult.GetRequiredValue(SearchDepth);
            var chunksPerSource = parseResult.GetRequiredValue(ChunksPerSource);
            var maxResults = parseResult.GetRequiredValue(MaxResults);
            var timeRange = parseResult.GetRequiredValue(TimeRange);
            var days = parseResult.GetRequiredValue(Days);
            var includeRawContent = parseResult.GetRequiredValue(IncludeRawContent);
            var includeAnswer = parseResult.GetRequiredValue(IncludeAnswer);
            var includeDomains = parseResult.GetRequiredValue(IncludeDomains);
            var excludeDomains = parseResult.GetRequiredValue(ExcludeDomains);
            var country = parseResult.GetRequiredValue(Country);
            var stream = parseResult.GetRequiredValue(Stream);

            Validate(
                parseResult: parseResult,
                query: query,
                topic: topic,
                searchDepth: searchDepth,
                chunksPerSource: chunksPerSource,
                maxResults: maxResults,
                timeRange: timeRange,
                days: days,
                includeRawContent: includeRawContent,
                includeAnswer: includeAnswer,
                includeDomains: includeDomains,
                excludeDomains: excludeDomains,
                country: country,
                stream: stream,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ToolsApi.CreateToolsWebSearchAsync(
                query: query,
                topic: topic,
                searchDepth: searchDepth,
                chunksPerSource: chunksPerSource,
                maxResults: maxResults,
                timeRange: timeRange,
                days: days,
                includeRawContent: includeRawContent,
                includeAnswer: includeAnswer,
                includeDomains: includeDomains,
                excludeDomains: excludeDomains,
                country: country,
                stream: stream,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}