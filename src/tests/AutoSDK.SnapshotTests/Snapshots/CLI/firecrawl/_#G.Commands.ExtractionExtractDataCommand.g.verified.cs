//HintName: G.Commands.ExtractionExtractDataCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExtractionExtractDataCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string> urls,
            string? prompt,
            object? schema,
            bool? enableWebSearch,
            bool? ignoreSitemap,
            bool? includeSubdomains,
            bool? showSources,
            global::G.ScrapeOptions? scrapeOptions,
            bool? ignoreInvalidURLs,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ExtractResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Urls { get; } = new(
            name: "urls")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"Prompt to guide the extraction process",
        };

        private global::System.CommandLine.Option<object?> Schema { get; } = new(
            name: "schema")
        {
            Description = @"Schema to define the structure of the extracted data. Must conform to [JSON Schema](https://json-schema.org/).",
        };

        private global::System.CommandLine.Option<bool?> EnableWebSearch { get; } = new(
            name: "enableWebSearch")
        {
            Description = @"When true, the extraction will use web search to find additional data",
        };

        private global::System.CommandLine.Option<bool?> IgnoreSitemap { get; } = new(
            name: "ignoreSitemap")
        {
            Description = @"When true, sitemap.xml files will be ignored during website scanning",
        };

        private global::System.CommandLine.Option<bool?> IncludeSubdomains { get; } = new(
            name: "includeSubdomains")
        {
            Description = @"When true, subdomains of the provided URLs will also be scanned",
        };

        private global::System.CommandLine.Option<bool?> ShowSources { get; } = new(
            name: "showSources")
        {
            Description = @"When true, the sources used to extract the data will be included in the response as `sources` key",
        };

        private global::System.CommandLine.Option<global::G.ScrapeOptions?> ScrapeOptions { get; } = new(
            name: "scrapeOptions")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> IgnoreInvalidURLs { get; } = new(
            name: "ignoreInvalidURLs")
        {
            Description = @"If invalid URLs are specified in the urls array, they will be ignored. Instead of them failing the entire request, an extract using the remaining valid URLs will be performed, and the invalid URLs will be returned in the invalidURLs field of the response.",
        };


        public ExtractionExtractDataCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "extract",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Urls);
            Options.Add(Prompt);
            Options.Add(Schema);
            Options.Add(EnableWebSearch);
            Options.Add(IgnoreSitemap);
            Options.Add(IncludeSubdomains);
            Options.Add(ShowSources);
            Options.Add(ScrapeOptions);
            Options.Add(IgnoreInvalidURLs);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var urls = parseResult.GetRequiredValue(Urls);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var schema = parseResult.GetRequiredValue(Schema);
            var enableWebSearch = parseResult.GetRequiredValue(EnableWebSearch);
            var ignoreSitemap = parseResult.GetRequiredValue(IgnoreSitemap);
            var includeSubdomains = parseResult.GetRequiredValue(IncludeSubdomains);
            var showSources = parseResult.GetRequiredValue(ShowSources);
            var scrapeOptions = parseResult.GetRequiredValue(ScrapeOptions);
            var ignoreInvalidURLs = parseResult.GetRequiredValue(IgnoreInvalidURLs);

            Validate(
                parseResult: parseResult,
                urls: urls,
                prompt: prompt,
                schema: schema,
                enableWebSearch: enableWebSearch,
                ignoreSitemap: ignoreSitemap,
                includeSubdomains: includeSubdomains,
                showSources: showSources,
                scrapeOptions: scrapeOptions,
                ignoreInvalidURLs: ignoreInvalidURLs,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Extraction.ExtractDataAsync(
                urls: urls,
                prompt: prompt,
                schema: schema,
                enableWebSearch: enableWebSearch,
                ignoreSitemap: ignoreSitemap,
                includeSubdomains: includeSubdomains,
                showSources: showSources,
                scrapeOptions: scrapeOptions,
                ignoreInvalidURLs: ignoreInvalidURLs,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}