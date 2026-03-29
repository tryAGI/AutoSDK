//HintName: G.Commands.SearchSearchAndScrapeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchSearchAndScrapeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string query,
            int? limit,
            string? tbs,
            string? location,
            int? timeout,
            bool? ignoreInvalidURLs,
            global::G.SearchAndScrapeRequestScrapeOptions? scrapeOptions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.SearchAndScrapeResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Query { get; } = new(
            name: "query")
        {
            Description = @"The search query",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Maximum number of results to return",
        };

        private global::System.CommandLine.Option<string?> Tbs { get; } = new(
            name: "tbs")
        {
            Description = @"Time-based search parameter",
        };

        private global::System.CommandLine.Option<string?> Location { get; } = new(
            name: "location")
        {
            Description = @"Location parameter for search results",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Timeout in milliseconds",
        };

        private global::System.CommandLine.Option<bool?> IgnoreInvalidURLs { get; } = new(
            name: "ignoreInvalidURLs")
        {
            Description = @"Excludes URLs from the search results that are invalid for other Firecrawl endpoints. This helps reduce errors if you are piping data from search into other Firecrawl API endpoints.",
        };

        private global::System.CommandLine.Option<global::G.SearchAndScrapeRequestScrapeOptions?> ScrapeOptions { get; } = new(
            name: "scrapeOptions")
        {
            Description = @"Options for scraping search results",
        };


        public SearchSearchAndScrapeCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "search",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Query);
            Options.Add(Limit);
            Options.Add(Tbs);
            Options.Add(Location);
            Options.Add(Timeout);
            Options.Add(IgnoreInvalidURLs);
            Options.Add(ScrapeOptions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var query = parseResult.GetRequiredValue(Query);
            var limit = parseResult.GetRequiredValue(Limit);
            var tbs = parseResult.GetRequiredValue(Tbs);
            var location = parseResult.GetRequiredValue(Location);
            var timeout = parseResult.GetRequiredValue(Timeout);
            var ignoreInvalidURLs = parseResult.GetRequiredValue(IgnoreInvalidURLs);
            var scrapeOptions = parseResult.GetRequiredValue(ScrapeOptions);

            Validate(
                parseResult: parseResult,
                query: query,
                limit: limit,
                tbs: tbs,
                location: location,
                timeout: timeout,
                ignoreInvalidURLs: ignoreInvalidURLs,
                scrapeOptions: scrapeOptions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Search.SearchAndScrapeAsync(
                query: query,
                limit: limit,
                tbs: tbs,
                location: location,
                timeout: timeout,
                ignoreInvalidURLs: ignoreInvalidURLs,
                scrapeOptions: scrapeOptions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}