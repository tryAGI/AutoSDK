//HintName: G.Commands.CrawlingCrawlUrlsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CrawlingCrawlUrlsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string url,
            global::System.Collections.Generic.IList<string>? excludePaths,
            global::System.Collections.Generic.IList<string>? includePaths,
            int? maxDepth,
            int? maxDiscoveryDepth,
            bool? ignoreSitemap,
            bool? ignoreQueryParameters,
            int? limit,
            bool? allowBackwardLinks,
            bool? allowExternalLinks,
            double? delay,
            global::G.CrawlUrlsRequestWebhook? webhook,
            global::G.ScrapeOptions? scrapeOptions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CrawlResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Url { get; } = new(
            name: "url")
        {
            Description = @"The base URL to start crawling from",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ExcludePaths { get; } = new(
            name: "excludePaths")
        {
            Description = @"URL pathname regex patterns that exclude matching URLs from the crawl. For example, if you set ""excludePaths"": [""blog/.*""] for the base URL firecrawl.dev, any results matching that pattern will be excluded, such as https://www.firecrawl.dev/blog/firecrawl-launch-week-1-recap.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> IncludePaths { get; } = new(
            name: "includePaths")
        {
            Description = @"URL pathname regex patterns that include matching URLs in the crawl. Only the paths that match the specified patterns will be included in the response. For example, if you set ""includePaths"": [""blog/.*""] for the base URL firecrawl.dev, only results matching that pattern will be included, such as https://www.firecrawl.dev/blog/firecrawl-launch-week-1-recap.",
        };

        private global::System.CommandLine.Option<int?> MaxDepth { get; } = new(
            name: "maxDepth")
        {
            Description = @"Maximum depth to crawl relative to the base URL. Basically, the max number of slashes the pathname of a scraped URL may contain.",
        };

        private global::System.CommandLine.Option<int?> MaxDiscoveryDepth { get; } = new(
            name: "maxDiscoveryDepth")
        {
            Description = @"Maximum depth to crawl based on discovery order. The root site and sitemapped pages has a discovery depth of 0. For example, if you set it to 1, and you set ignoreSitemap, you will only crawl the entered URL and all URLs that are linked on that page.",
        };

        private global::System.CommandLine.Option<bool?> IgnoreSitemap { get; } = new(
            name: "ignoreSitemap")
        {
            Description = @"Ignore the website sitemap when crawling",
        };

        private global::System.CommandLine.Option<bool?> IgnoreQueryParameters { get; } = new(
            name: "ignoreQueryParameters")
        {
            Description = @"Do not re-scrape the same path with different (or none) query parameters",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Maximum number of pages to crawl. Default limit is 10000.",
        };

        private global::System.CommandLine.Option<bool?> AllowBackwardLinks { get; } = new(
            name: "allowBackwardLinks")
        {
            Description = @"Allows the crawler to follow internal links to sibling or parent URLs, not just child paths.

false: Only crawls deeper (child) URLs.
→ e.g. /features/feature-1 → /features/feature-1/tips ✅
→ Won't follow /pricing or / ❌

true: Crawls any internal links, including siblings and parents.
→ e.g. /features/feature-1 → /pricing, /, etc. ✅

Use true for broader internal coverage beyond nested paths.",
        };

        private global::System.CommandLine.Option<bool?> AllowExternalLinks { get; } = new(
            name: "allowExternalLinks")
        {
            Description = @"Allows the crawler to follow links to external websites.",
        };

        private global::System.CommandLine.Option<double?> Delay { get; } = new(
            name: "delay")
        {
            Description = @"Delay in seconds between scrapes. This helps respect website rate limits.",
        };

        private global::System.CommandLine.Option<global::G.CrawlUrlsRequestWebhook?> Webhook { get; } = new(
            name: "webhook")
        {
            Description = @"A webhook specification object.",
        };

        private global::System.CommandLine.Option<global::G.ScrapeOptions?> ScrapeOptions { get; } = new(
            name: "scrapeOptions")
        {
            Description = @"",
        };


        public CrawlingCrawlUrlsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "crawl",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Url);
            Options.Add(ExcludePaths);
            Options.Add(IncludePaths);
            Options.Add(MaxDepth);
            Options.Add(MaxDiscoveryDepth);
            Options.Add(IgnoreSitemap);
            Options.Add(IgnoreQueryParameters);
            Options.Add(Limit);
            Options.Add(AllowBackwardLinks);
            Options.Add(AllowExternalLinks);
            Options.Add(Delay);
            Options.Add(Webhook);
            Options.Add(ScrapeOptions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var url = parseResult.GetRequiredValue(Url);
            var excludePaths = parseResult.GetRequiredValue(ExcludePaths);
            var includePaths = parseResult.GetRequiredValue(IncludePaths);
            var maxDepth = parseResult.GetRequiredValue(MaxDepth);
            var maxDiscoveryDepth = parseResult.GetRequiredValue(MaxDiscoveryDepth);
            var ignoreSitemap = parseResult.GetRequiredValue(IgnoreSitemap);
            var ignoreQueryParameters = parseResult.GetRequiredValue(IgnoreQueryParameters);
            var limit = parseResult.GetRequiredValue(Limit);
            var allowBackwardLinks = parseResult.GetRequiredValue(AllowBackwardLinks);
            var allowExternalLinks = parseResult.GetRequiredValue(AllowExternalLinks);
            var delay = parseResult.GetRequiredValue(Delay);
            var webhook = parseResult.GetRequiredValue(Webhook);
            var scrapeOptions = parseResult.GetRequiredValue(ScrapeOptions);

            Validate(
                parseResult: parseResult,
                url: url,
                excludePaths: excludePaths,
                includePaths: includePaths,
                maxDepth: maxDepth,
                maxDiscoveryDepth: maxDiscoveryDepth,
                ignoreSitemap: ignoreSitemap,
                ignoreQueryParameters: ignoreQueryParameters,
                limit: limit,
                allowBackwardLinks: allowBackwardLinks,
                allowExternalLinks: allowExternalLinks,
                delay: delay,
                webhook: webhook,
                scrapeOptions: scrapeOptions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Crawling.CrawlUrlsAsync(
                url: url,
                excludePaths: excludePaths,
                includePaths: includePaths,
                maxDepth: maxDepth,
                maxDiscoveryDepth: maxDiscoveryDepth,
                ignoreSitemap: ignoreSitemap,
                ignoreQueryParameters: ignoreQueryParameters,
                limit: limit,
                allowBackwardLinks: allowBackwardLinks,
                allowExternalLinks: allowExternalLinks,
                delay: delay,
                webhook: webhook,
                scrapeOptions: scrapeOptions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}