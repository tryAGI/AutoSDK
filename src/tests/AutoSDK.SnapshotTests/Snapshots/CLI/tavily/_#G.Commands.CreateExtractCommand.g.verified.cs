//HintName: G.Commands.CreateExtractCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateExtractCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> urls,
            string? query,
            int? chunksPerSource,
            global::G.CreateExtractRequestExtractDepth? extractDepth,
            bool? includeImages,
            bool? includeFavicon,
            global::G.CreateExtractRequestFormat? format,
            float? timeout,
            bool? includeUsage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateExtractResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.OneOf<string, global::System.Collections.Generic.IList<string>>> Urls { get; } = new(
            name: "urls")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Query { get; } = new(
            name: "query")
        {
            Description = @"User intent for reranking extracted content chunks. When provided, chunks are reranked based on relevance to this query.",
        };

        private global::System.CommandLine.Option<int?> ChunksPerSource { get; } = new(
            name: "chunksPerSource")
        {
            Description = @"Chunks are short content snippets (maximum 500 characters each) pulled directly from the source. Use `chunks_per_source` to define the maximum number of relevant chunks returned per source and to control the `raw_content` length. Chunks will appear in the `raw_content` field as: `<chunk 1> [...] <chunk 2> [...] <chunk 3>`. Available only when `query` is provided. Must be between 1 and 5.",
        };

        private global::System.CommandLine.Option<global::G.CreateExtractRequestExtractDepth?> ExtractDepth { get; } = new(
            name: "extractDepth")
        {
            Description = @"The depth of the extraction process. `advanced` extraction retrieves more data, including tables and embedded content, with higher success but may increase latency.`basic` extraction costs 1 credit per 5 successful URL extractions, while `advanced` extraction costs 2 credits per 5 successful URL extractions.",
        };

        private global::System.CommandLine.Option<bool?> IncludeImages { get; } = new(
            name: "includeImages")
        {
            Description = @"Include a list of images extracted from the URLs in the response. Default is false.",
        };

        private global::System.CommandLine.Option<bool?> IncludeFavicon { get; } = new(
            name: "includeFavicon")
        {
            Description = @"Whether to include the favicon URL for each result.",
        };

        private global::System.CommandLine.Option<global::G.CreateExtractRequestFormat?> Format { get; } = new(
            name: "format")
        {
            Description = @"The format of the extracted web page content. `markdown` returns content in markdown format. `text` returns plain text and may increase latency.",
        };

        private global::System.CommandLine.Option<float?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Maximum time in seconds to wait for the URL extraction before timing out. Must be between 1.0 and 60.0 seconds. If not specified, default timeouts are applied based on extract_depth: 10 seconds for basic extraction and 30 seconds for advanced extraction.",
        };

        private global::System.CommandLine.Option<bool?> IncludeUsage { get; } = new(
            name: "includeUsage")
        {
            Description = @"Whether to include credit usage information in the response. `NOTE:`The value may be 0 if the total successful URL extractions has not yet reached 5 calls. See our [Credits & Pricing documentation](https://docs.tavily.com/documentation/api-credits) for details.",
        };


        public CreateExtractCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Extract web page content from one or more specified URLs using Tavily Extract.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Urls);
            Options.Add(Query);
            Options.Add(ChunksPerSource);
            Options.Add(ExtractDepth);
            Options.Add(IncludeImages);
            Options.Add(IncludeFavicon);
            Options.Add(Format);
            Options.Add(Timeout);
            Options.Add(IncludeUsage);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var urls = parseResult.GetRequiredValue(Urls);
            var query = parseResult.GetRequiredValue(Query);
            var chunksPerSource = parseResult.GetRequiredValue(ChunksPerSource);
            var extractDepth = parseResult.GetRequiredValue(ExtractDepth);
            var includeImages = parseResult.GetRequiredValue(IncludeImages);
            var includeFavicon = parseResult.GetRequiredValue(IncludeFavicon);
            var format = parseResult.GetRequiredValue(Format);
            var timeout = parseResult.GetRequiredValue(Timeout);
            var includeUsage = parseResult.GetRequiredValue(IncludeUsage);

            Validate(
                parseResult: parseResult,
                urls: urls,
                query: query,
                chunksPerSource: chunksPerSource,
                extractDepth: extractDepth,
                includeImages: includeImages,
                includeFavicon: includeFavicon,
                format: format,
                timeout: timeout,
                includeUsage: includeUsage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateExtractAsync(
                urls: urls,
                query: query,
                chunksPerSource: chunksPerSource,
                extractDepth: extractDepth,
                includeImages: includeImages,
                includeFavicon: includeFavicon,
                format: format,
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