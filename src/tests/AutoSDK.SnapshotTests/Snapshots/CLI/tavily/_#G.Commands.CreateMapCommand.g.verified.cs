//HintName: G.Commands.CreateMapCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateMapCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string url,
            string? instructions,
            int? maxDepth,
            int? maxBreadth,
            int? limit,
            global::System.Collections.Generic.IList<string>? selectPaths,
            global::System.Collections.Generic.IList<string>? selectDomains,
            global::System.Collections.Generic.IList<string>? excludePaths,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            bool? allowExternal,
            float? timeout,
            bool? includeUsage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateMapResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Url { get; } = new(
            name: "url")
        {
            Description = @"The root URL to begin the mapping.",
        };

        private global::System.CommandLine.Option<string?> Instructions { get; } = new(
            name: "instructions")
        {
            Description = @"Natural language instructions for the crawler. When specified, the cost increases to 2 API credits per 10 successful pages instead of 1 API credit per 10 pages.",
        };

        private global::System.CommandLine.Option<int?> MaxDepth { get; } = new(
            name: "maxDepth")
        {
            Description = @"Max depth of the mapping. Defines how far from the base URL the crawler can explore.",
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

        private global::System.CommandLine.Option<float?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Maximum time in seconds to wait for the map operation before timing out. Must be between 10 and 150 seconds.",
        };

        private global::System.CommandLine.Option<bool?> IncludeUsage { get; } = new(
            name: "includeUsage")
        {
            Description = @"Whether to include credit usage information in the response.`NOTE:`The value may be 0 if the total successful pages mapped has not yet reached 10 calls. See our [Credits & Pricing documentation](https://docs.tavily.com/documentation/api-credits) for details.",
        };


        public CreateMapCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Tavily Map traverses websites like a graph and can explore hundreds of paths in parallel with intelligent discovery to generate comprehensive site maps.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Url);
            Options.Add(Instructions);
            Options.Add(MaxDepth);
            Options.Add(MaxBreadth);
            Options.Add(Limit);
            Options.Add(SelectPaths);
            Options.Add(SelectDomains);
            Options.Add(ExcludePaths);
            Options.Add(ExcludeDomains);
            Options.Add(AllowExternal);
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
            var maxDepth = parseResult.GetRequiredValue(MaxDepth);
            var maxBreadth = parseResult.GetRequiredValue(MaxBreadth);
            var limit = parseResult.GetRequiredValue(Limit);
            var selectPaths = parseResult.GetRequiredValue(SelectPaths);
            var selectDomains = parseResult.GetRequiredValue(SelectDomains);
            var excludePaths = parseResult.GetRequiredValue(ExcludePaths);
            var excludeDomains = parseResult.GetRequiredValue(ExcludeDomains);
            var allowExternal = parseResult.GetRequiredValue(AllowExternal);
            var timeout = parseResult.GetRequiredValue(Timeout);
            var includeUsage = parseResult.GetRequiredValue(IncludeUsage);

            Validate(
                parseResult: parseResult,
                url: url,
                instructions: instructions,
                maxDepth: maxDepth,
                maxBreadth: maxBreadth,
                limit: limit,
                selectPaths: selectPaths,
                selectDomains: selectDomains,
                excludePaths: excludePaths,
                excludeDomains: excludeDomains,
                allowExternal: allowExternal,
                timeout: timeout,
                includeUsage: includeUsage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateMapAsync(
                url: url,
                instructions: instructions,
                maxDepth: maxDepth,
                maxBreadth: maxBreadth,
                limit: limit,
                selectPaths: selectPaths,
                selectDomains: selectDomains,
                excludePaths: excludePaths,
                excludeDomains: excludeDomains,
                allowExternal: allowExternal,
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