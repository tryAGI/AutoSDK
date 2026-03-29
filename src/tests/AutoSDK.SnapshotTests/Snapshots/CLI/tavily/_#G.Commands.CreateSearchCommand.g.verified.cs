//HintName: G.Commands.CreateSearchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateSearchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string query,
            global::G.CreateSearchRequestSearchDepth? searchDepth,
            int? chunksPerSource,
            int? maxResults,
            global::G.CreateSearchRequestTopic? topic,
            global::G.CreateSearchRequestTimeRange? timeRange,
            string? startDate,
            string? endDate,
            global::G.OneOf<bool?, global::G.CreateSearchRequestIncludeAnswer?>? includeAnswer,
            global::G.OneOf<bool?, global::G.CreateSearchRequestIncludeRawContent?>? includeRawContent,
            bool? includeImages,
            bool? includeImageDescriptions,
            bool? includeFavicon,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            global::G.CreateSearchRequestCountry? country,
            bool? autoParameters,
            bool? exactMatch,
            bool? includeUsage,
            bool? safeSearch,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateSearchResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Query { get; } = new(
            name: "query")
        {
            Description = @"The search query to execute with Tavily.",
        };

        private global::System.CommandLine.Option<global::G.CreateSearchRequestSearchDepth?> SearchDepth { get; } = new(
            name: "searchDepth")
        {
            Description = @"Controls the latency vs. relevance tradeoff and how `results[].content` is generated:
- `advanced`: Highest relevance with increased latency. Best for detailed, high-precision queries. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).
- `basic`: A balanced option for relevance and latency. Ideal for general-purpose searches. Returns one NLP summary per URL.
- `fast`: Prioritizes lower latency while maintaining good relevance. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).
- `ultra-fast`: Minimizes latency above all else. Best for time-critical use cases. Returns one NLP summary per URL.

**Cost**:
- `basic`, `fast`, `ultra-fast`: 1 API Credit
- `advanced`: 2 API Credits

See [Search Best Practices](/documentation/best-practices/best-practices-search#search-depth) for guidance on choosing the right search depth.",
        };

        private global::System.CommandLine.Option<int?> ChunksPerSource { get; } = new(
            name: "chunksPerSource")
        {
            Description = @"Chunks are short content snippets (maximum 500 characters each) pulled directly from the source. Use `chunks_per_source` to define the maximum number of relevant chunks returned per source and to control the `content` length. Chunks will appear in the `content` field as: `<chunk 1> [...] <chunk 2> [...] <chunk 3>`. Available only when `search_depth` is `advanced`.",
        };

        private global::System.CommandLine.Option<int?> MaxResults { get; } = new(
            name: "maxResults")
        {
            Description = @"The maximum number of search results to return.",
        };

        private global::System.CommandLine.Option<global::G.CreateSearchRequestTopic?> Topic { get; } = new(
            name: "topic")
        {
            Description = @"The category of the search.`news` is useful for retrieving real-time updates, particularly about politics, sports, and major current events covered by mainstream media sources. `general` is for broader, more general-purpose searches that may include a wide range of sources.",
        };

        private global::System.CommandLine.Option<global::G.CreateSearchRequestTimeRange?> TimeRange { get; } = new(
            name: "timeRange")
        {
            Description = @"The time range back from the current date to filter results based on publish date or last updated date. Useful when looking for sources that have published or updated data.",
        };

        private global::System.CommandLine.Option<string?> StartDate { get; } = new(
            name: "startDate")
        {
            Description = @"Will return all results after the specified start date based on publish date or last updated date. Required to be written in the format YYYY-MM-DD",
        };

        private global::System.CommandLine.Option<string?> EndDate { get; } = new(
            name: "endDate")
        {
            Description = @"Will return all results before the specified end date based on publish date or last updated date. Required to be written in the format YYYY-MM-DD",
        };

        private global::System.CommandLine.Option<global::G.OneOf<bool?, global::G.CreateSearchRequestIncludeAnswer?>?> IncludeAnswer { get; } = new(
            name: "includeAnswer")
        {
            Description = @"Include an LLM-generated answer to the provided query. `basic` or `true` returns a quick answer. `advanced` returns a more detailed answer.",
        };

        private global::System.CommandLine.Option<global::G.OneOf<bool?, global::G.CreateSearchRequestIncludeRawContent?>?> IncludeRawContent { get; } = new(
            name: "includeRawContent")
        {
            Description = @"Include the cleaned and parsed HTML content of each search result. `markdown` or `true` returns search result content in markdown format. `text` returns the plain text from the results and may increase latency.",
        };

        private global::System.CommandLine.Option<bool?> IncludeImages { get; } = new(
            name: "includeImages")
        {
            Description = @"Include images in the response. Returns both a top-level `images` list of query-related images and an `images` array inside each result object with images extracted from that specific source.",
        };

        private global::System.CommandLine.Option<bool?> IncludeImageDescriptions { get; } = new(
            name: "includeImageDescriptions")
        {
            Description = @"When `include_images` is `true`, also add a descriptive text for each image.",
        };

        private global::System.CommandLine.Option<bool?> IncludeFavicon { get; } = new(
            name: "includeFavicon")
        {
            Description = @"Whether to include the favicon URL for each result.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> IncludeDomains { get; } = new(
            name: "includeDomains")
        {
            Description = @"A list of domains to specifically include in the search results. Maximum 300 domains.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ExcludeDomains { get; } = new(
            name: "excludeDomains")
        {
            Description = @"A list of domains to specifically exclude from the search results. Maximum 150 domains.",
        };

        private global::System.CommandLine.Option<global::G.CreateSearchRequestCountry?> Country { get; } = new(
            name: "country")
        {
            Description = @"Boost search results from a specific country. This will prioritize content from the selected country in the search results. Available only if topic is `general`.",
        };

        private global::System.CommandLine.Option<bool?> AutoParameters { get; } = new(
            name: "autoParameters")
        {
            Description = @"When `auto_parameters` is enabled, Tavily automatically configures search parameters based on your query's content and intent. You can still set other parameters manually, and your explicit values will override the automatic ones. The parameters `include_answer`, `include_raw_content`, and `max_results` must always be set manually, as they directly affect response size. Note: `search_depth` may be automatically set to advanced when it's likely to improve results. This uses 2 API credits per request. To avoid the extra cost, you can explicitly set `search_depth` to `basic`.",
        };

        private global::System.CommandLine.Option<bool?> ExactMatch { get; } = new(
            name: "exactMatch")
        {
            Description = @"Ensure that only search results containing the exact quoted phrase(s) in the query are returned, bypassing synonyms or semantic variations. Wrap target phrases in quotes within your query (e.g. `""John Smith"" CEO Acme Corp`). Punctuation is typically ignored inside quotes.",
        };

        private global::System.CommandLine.Option<bool?> IncludeUsage { get; } = new(
            name: "includeUsage")
        {
            Description = @"Whether to include credit usage information in the response.",
        };

        private global::System.CommandLine.Option<bool?> SafeSearch { get; } = new(
            name: "safeSearch")
        {
            Description = @"🔒 Enterprise only. 
 whether to filter out adult or unsafe content from results. Not supported for `fast` or `ultra-fast` search depths.",
        };


        public CreateSearchCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Execute a search query using Tavily Search.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Query);
            Options.Add(SearchDepth);
            Options.Add(ChunksPerSource);
            Options.Add(MaxResults);
            Options.Add(Topic);
            Options.Add(TimeRange);
            Options.Add(StartDate);
            Options.Add(EndDate);
            Options.Add(IncludeAnswer);
            Options.Add(IncludeRawContent);
            Options.Add(IncludeImages);
            Options.Add(IncludeImageDescriptions);
            Options.Add(IncludeFavicon);
            Options.Add(IncludeDomains);
            Options.Add(ExcludeDomains);
            Options.Add(Country);
            Options.Add(AutoParameters);
            Options.Add(ExactMatch);
            Options.Add(IncludeUsage);
            Options.Add(SafeSearch);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var query = parseResult.GetRequiredValue(Query);
            var searchDepth = parseResult.GetRequiredValue(SearchDepth);
            var chunksPerSource = parseResult.GetRequiredValue(ChunksPerSource);
            var maxResults = parseResult.GetRequiredValue(MaxResults);
            var topic = parseResult.GetRequiredValue(Topic);
            var timeRange = parseResult.GetRequiredValue(TimeRange);
            var startDate = parseResult.GetRequiredValue(StartDate);
            var endDate = parseResult.GetRequiredValue(EndDate);
            var includeAnswer = parseResult.GetRequiredValue(IncludeAnswer);
            var includeRawContent = parseResult.GetRequiredValue(IncludeRawContent);
            var includeImages = parseResult.GetRequiredValue(IncludeImages);
            var includeImageDescriptions = parseResult.GetRequiredValue(IncludeImageDescriptions);
            var includeFavicon = parseResult.GetRequiredValue(IncludeFavicon);
            var includeDomains = parseResult.GetRequiredValue(IncludeDomains);
            var excludeDomains = parseResult.GetRequiredValue(ExcludeDomains);
            var country = parseResult.GetRequiredValue(Country);
            var autoParameters = parseResult.GetRequiredValue(AutoParameters);
            var exactMatch = parseResult.GetRequiredValue(ExactMatch);
            var includeUsage = parseResult.GetRequiredValue(IncludeUsage);
            var safeSearch = parseResult.GetRequiredValue(SafeSearch);

            Validate(
                parseResult: parseResult,
                query: query,
                searchDepth: searchDepth,
                chunksPerSource: chunksPerSource,
                maxResults: maxResults,
                topic: topic,
                timeRange: timeRange,
                startDate: startDate,
                endDate: endDate,
                includeAnswer: includeAnswer,
                includeRawContent: includeRawContent,
                includeImages: includeImages,
                includeImageDescriptions: includeImageDescriptions,
                includeFavicon: includeFavicon,
                includeDomains: includeDomains,
                excludeDomains: excludeDomains,
                country: country,
                autoParameters: autoParameters,
                exactMatch: exactMatch,
                includeUsage: includeUsage,
                safeSearch: safeSearch,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateSearchAsync(
                query: query,
                searchDepth: searchDepth,
                chunksPerSource: chunksPerSource,
                maxResults: maxResults,
                topic: topic,
                timeRange: timeRange,
                startDate: startDate,
                endDate: endDate,
                includeAnswer: includeAnswer,
                includeRawContent: includeRawContent,
                includeImages: includeImages,
                includeImageDescriptions: includeImageDescriptions,
                includeFavicon: includeFavicon,
                includeDomains: includeDomains,
                excludeDomains: excludeDomains,
                country: country,
                autoParameters: autoParameters,
                exactMatch: exactMatch,
                includeUsage: includeUsage,
                safeSearch: safeSearch,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}