//HintName: G.Commands.CreateCrawlCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateCrawlCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string url,
            string? instructions,
            int? chunksPerSource,
            int? maxDepth,
            int? maxBreadth,
            int? limit,
            global::System.Collections.Generic.IList<string>? selectPaths,
            global::System.Collections.Generic.IList<string>? selectDomains,
            global::System.Collections.Generic.IList<string>? excludePaths,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            bool? allowExternal,
            bool? includeImages,
            global::G.CreateCrawlRequestExtractDepth? extractDepth,
            global::G.CreateCrawlRequestFormat? format,
            bool? includeFavicon,
            float? timeout,
            bool? includeUsage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateCrawlResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Url { get; } = new(
            name: "url")
        {
            Description = @"The root URL to begin the crawl.",
        };

        private global::System.CommandLine.Option<string?> Instructions { get; } = new(
            name: "instructions")
        {
            Description = @"Natural language instructions for the crawler. When specified, the mapping cost increases to 2 API credits per 10 successful pages instead of 1 API credit per 10 pages.",
        };

        private global::System.CommandLine.Option<int?> ChunksPerSource { get; } = new(
            name: "chunksPerSource")
        {
            Description = @"Chunks are short content snippets (maximum 500 characters each) pulled directly from the source. Use `chunks_per_source` to define the maximum number of relevant chunks returned per source and to control the `raw_content` length. Chunks will appear in the `raw_content` field as: `<chunk 1> [...] <chunk 2> [...] <chunk 3>`. Available only when `instructions` are provided. Must be between 1 and 5.",
        };

        private global::System.CommandLine.Option<int?> MaxDepth { get; } = new(
            name: "maxDepth")
        {
            Description = @"Max depth of the crawl. Defines how far from the base URL the crawler can explore.",
        };

        private global::System.CommandLine.Option<int?> MaxBreadth { get; } = new(
            name: "maxBreadth")
        {
            Description = @"Max number of links to follow per level of the tree (i.e., per page).",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Total number of links the crawler will process before stopping.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> SelectPaths { get; } = new(
            name: "selectPaths")
        {
            Description = @"Regex patterns to select only URLs with specific path patterns (e.g., `/docs/.*`, `/api/v1.*`).",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> SelectDomains { get; } = new(
            name: "selectDomains")
        {
            Description = @"Regex patterns to select crawling to specific domains or subdomains (e.g., `^docs\.example\.com$`).",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ExcludePaths { get; } = new(
            name: "excludePaths")
        {
            Description = @"Regex patterns to exclude URLs with specific path patterns (e.g., `/private/.*`, `/admin/.*`).",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ExcludeDomains { get; } = new(
            name: "excludeDomains")
        {
            Description = @"Regex patterns to exclude specific domains or subdomains from crawling (e.g., `^private\.example\.com$`).",
        };

        private global::System.CommandLine.Option<bool?> AllowExternal { get; } = new(
            name: "allowExternal")
        {
            Description = @"Whether to include external domain links in the final results list.",
        };

        private global::System.CommandLine.Option<bool?> IncludeImages { get; } = new(
            name: "includeImages")
        {
            Description = @"Whether to include images in the crawl results.",
        };

        private global::System.CommandLine.Option<global::G.CreateCrawlRequestExtractDepth?> ExtractDepth { get; } = new(
            name: "extractDepth")
        {
            Description = @"Advanced extraction retrieves more data, including tables and embedded content, with higher success but may increase latency. `basic` extraction costs 1 credit per 5 successful extractions, while `advanced` extraction costs 2 credits per 5 successful extractions.",
        };

        private global::System.CommandLine.Option<global::G.CreateCrawlRequestFormat?> Format { get; } = new(
            name: "format")
        {
            Description = @"The format of the extracted web page content. `markdown` returns content in markdown format. `text` returns plain text and may increase latency.",
        };

        private global::System.CommandLine.Option<bool?> IncludeFavicon { get; } = new(
            name: "includeFavicon")
        {
            Description = @"Whether to include the favicon URL for each result.",
        };

        private global::System.CommandLine.Option<float?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Maximum time in seconds to wait for the crawl operation before timing out. Must be between 10 and 150 seconds.",
        };

        private global::System.CommandLine.Option<bool?> IncludeUsage { get; } = new(
            name: "includeUsage")
        {
            Description = @"Whether to include credit usage information in the response. `NOTE:`The value may be 0 if the total use of /extract and /map have not yet reached minimum requirements. See our [Credits & Pricing documentation](https://docs.tavily.com/documentation/api-credits) for details.",
        };


        public CreateCrawlCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Tavily Crawl is a graph-based website traversal tool that can explore hundreds of paths in parallel with built-in extraction and intelligent discovery.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Url);
            Options.Add(Instructions);
            Options.Add(ChunksPerSource);
            Options.Add(MaxDepth);
            Options.Add(MaxBreadth);
            Options.Add(Limit);
            Options.Add(SelectPaths);
            Options.Add(SelectDomains);
            Options.Add(ExcludePaths);
            Options.Add(ExcludeDomains);
            Options.Add(AllowExternal);
            Options.Add(IncludeImages);
            Options.Add(ExtractDepth);
            Options.Add(Format);
            Options.Add(IncludeFavicon);
            Options.Add(Timeout);
            Options.Add(IncludeUsage);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var url = parseResult.GetRequiredValue(Url);
            var instructions = parseResult.GetRequiredValue(Instructions);
            var chunksPerSource = parseResult.GetRequiredValue(ChunksPerSource);
            var maxDepth = parseResult.GetRequiredValue(MaxDepth);
            var maxBreadth = parseResult.GetRequiredValue(MaxBreadth);
            var limit = parseResult.GetRequiredValue(Limit);
            var selectPaths = parseResult.GetRequiredValue(SelectPaths);
            var selectDomains = parseResult.GetRequiredValue(SelectDomains);
            var excludePaths = parseResult.GetRequiredValue(ExcludePaths);
            var excludeDomains = parseResult.GetRequiredValue(ExcludeDomains);
            var allowExternal = parseResult.GetRequiredValue(AllowExternal);
            var includeImages = parseResult.GetRequiredValue(IncludeImages);
            var extractDepth = parseResult.GetRequiredValue(ExtractDepth);
            var format = parseResult.GetRequiredValue(Format);
            var includeFavicon = parseResult.GetRequiredValue(IncludeFavicon);
            var timeout = parseResult.GetRequiredValue(Timeout);
            var includeUsage = parseResult.GetRequiredValue(IncludeUsage);

            Validate(
                parseResult: parseResult,
                url: url,
                instructions: instructions,
                chunksPerSource: chunksPerSource,
                maxDepth: maxDepth,
                maxBreadth: maxBreadth,
                limit: limit,
                selectPaths: selectPaths,
                selectDomains: selectDomains,
                excludePaths: excludePaths,
                excludeDomains: excludeDomains,
                allowExternal: allowExternal,
                includeImages: includeImages,
                extractDepth: extractDepth,
                format: format,
                includeFavicon: includeFavicon,
                timeout: timeout,
                includeUsage: includeUsage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateCrawlAsync(
                url: url,
                instructions: instructions,
                chunksPerSource: chunksPerSource,
                maxDepth: maxDepth,
                maxBreadth: maxBreadth,
                limit: limit,
                selectPaths: selectPaths,
                selectDomains: selectDomains,
                excludePaths: excludePaths,
                excludeDomains: excludeDomains,
                allowExternal: allowExternal,
                includeImages: includeImages,
                extractDepth: extractDepth,
                format: format,
                includeFavicon: includeFavicon,
                timeout: timeout,
                includeUsage: includeUsage,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}