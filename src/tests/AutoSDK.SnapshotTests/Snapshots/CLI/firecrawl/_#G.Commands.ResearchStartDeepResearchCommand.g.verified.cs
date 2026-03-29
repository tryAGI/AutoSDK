//HintName: G.Commands.ResearchStartDeepResearchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ResearchStartDeepResearchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string query,
            int? maxDepth,
            int? timeLimit,
            int? maxUrls,
            string? analysisPrompt,
            string? systemPrompt,
            global::System.Collections.Generic.IList<global::G.StartDeepResearchRequestFormat>? formats,
            global::G.StartDeepResearchRequestJsonOptions? jsonOptions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.StartDeepResearchResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Query { get; } = new(
            name: "query")
        {
            Description = @"The query to research",
        };

        private global::System.CommandLine.Option<int?> MaxDepth { get; } = new(
            name: "maxDepth")
        {
            Description = @"Maximum depth of research iterations",
        };

        private global::System.CommandLine.Option<int?> TimeLimit { get; } = new(
            name: "timeLimit")
        {
            Description = @"Time limit in seconds",
        };

        private global::System.CommandLine.Option<int?> MaxUrls { get; } = new(
            name: "maxUrls")
        {
            Description = @"Maximum number of URLs to analyze",
        };

        private global::System.CommandLine.Option<string?> AnalysisPrompt { get; } = new(
            name: "analysisPrompt")
        {
            Description = @"The prompt to use for the final analysis. Useful to format the final analysis markdown in a specific way.",
        };

        private global::System.CommandLine.Option<string?> SystemPrompt { get; } = new(
            name: "systemPrompt")
        {
            Description = @"The system prompt to use for the research agent. Useful to steer the research agent to a specific direction.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.StartDeepResearchRequestFormat>?> Formats { get; } = new(
            name: "formats")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.StartDeepResearchRequestJsonOptions?> JsonOptions { get; } = new(
            name: "jsonOptions")
        {
            Description = @"Options for JSON output",
        };


        public ResearchStartDeepResearchCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "start",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Query);
            Options.Add(MaxDepth);
            Options.Add(TimeLimit);
            Options.Add(MaxUrls);
            Options.Add(AnalysisPrompt);
            Options.Add(SystemPrompt);
            Options.Add(Formats);
            Options.Add(JsonOptions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var query = parseResult.GetRequiredValue(Query);
            var maxDepth = parseResult.GetRequiredValue(MaxDepth);
            var timeLimit = parseResult.GetRequiredValue(TimeLimit);
            var maxUrls = parseResult.GetRequiredValue(MaxUrls);
            var analysisPrompt = parseResult.GetRequiredValue(AnalysisPrompt);
            var systemPrompt = parseResult.GetRequiredValue(SystemPrompt);
            var formats = parseResult.GetRequiredValue(Formats);
            var jsonOptions = parseResult.GetRequiredValue(JsonOptions);

            Validate(
                parseResult: parseResult,
                query: query,
                maxDepth: maxDepth,
                timeLimit: timeLimit,
                maxUrls: maxUrls,
                analysisPrompt: analysisPrompt,
                systemPrompt: systemPrompt,
                formats: formats,
                jsonOptions: jsonOptions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Research.StartDeepResearchAsync(
                query: query,
                maxDepth: maxDepth,
                timeLimit: timeLimit,
                maxUrls: maxUrls,
                analysisPrompt: analysisPrompt,
                systemPrompt: systemPrompt,
                formats: formats,
                jsonOptions: jsonOptions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}