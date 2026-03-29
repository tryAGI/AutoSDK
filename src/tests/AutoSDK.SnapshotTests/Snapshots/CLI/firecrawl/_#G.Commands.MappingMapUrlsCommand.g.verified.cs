//HintName: G.Commands.MappingMapUrlsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MappingMapUrlsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string url,
            string? search,
            bool? ignoreSitemap,
            bool? sitemapOnly,
            bool? includeSubdomains,
            int? limit,
            int? timeout,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.MapResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Url { get; } = new(
            name: "url")
        {
            Description = @"The base URL to start crawling from",
        };

        private global::System.CommandLine.Option<string?> Search { get; } = new(
            name: "search")
        {
            Description = @"Search query to use for mapping. During the Alpha phase, the 'smart' part of the search functionality is limited to 1000 search results. However, if map finds more results, there is no limit applied.",
        };

        private global::System.CommandLine.Option<bool?> IgnoreSitemap { get; } = new(
            name: "ignoreSitemap")
        {
            Description = @"Ignore the website sitemap when crawling.",
        };

        private global::System.CommandLine.Option<bool?> SitemapOnly { get; } = new(
            name: "sitemapOnly")
        {
            Description = @"Only return links found in the website sitemap",
        };

        private global::System.CommandLine.Option<bool?> IncludeSubdomains { get; } = new(
            name: "includeSubdomains")
        {
            Description = @"Include subdomains of the website",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Maximum number of links to return",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Timeout in milliseconds. There is no timeout by default.",
        };


        public MappingMapUrlsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "map",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Url);
            Options.Add(Search);
            Options.Add(IgnoreSitemap);
            Options.Add(SitemapOnly);
            Options.Add(IncludeSubdomains);
            Options.Add(Limit);
            Options.Add(Timeout);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var url = parseResult.GetRequiredValue(Url);
            var search = parseResult.GetRequiredValue(Search);
            var ignoreSitemap = parseResult.GetRequiredValue(IgnoreSitemap);
            var sitemapOnly = parseResult.GetRequiredValue(SitemapOnly);
            var includeSubdomains = parseResult.GetRequiredValue(IncludeSubdomains);
            var limit = parseResult.GetRequiredValue(Limit);
            var timeout = parseResult.GetRequiredValue(Timeout);

            Validate(
                parseResult: parseResult,
                url: url,
                search: search,
                ignoreSitemap: ignoreSitemap,
                sitemapOnly: sitemapOnly,
                includeSubdomains: includeSubdomains,
                limit: limit,
                timeout: timeout,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Mapping.MapUrlsAsync(
                url: url,
                search: search,
                ignoreSitemap: ignoreSitemap,
                sitemapOnly: sitemapOnly,
                includeSubdomains: includeSubdomains,
                limit: limit,
                timeout: timeout,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}