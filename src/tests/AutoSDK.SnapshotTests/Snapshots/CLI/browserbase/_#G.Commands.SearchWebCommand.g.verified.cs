//HintName: G.Commands.SearchWebCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchWebCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string query,
            int? numResults,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.SearchWebResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Query { get; } = new(
            name: "query")
        {
            Description = @"The search query string",
        };

        private global::System.CommandLine.Option<int?> NumResults { get; } = new(
            name: "numResults")
        {
            Description = @"Number of results to return (1-25)",
        };


        public SearchWebCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "search",
            description: @"Perform a web search and return structured results.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Query);
            Options.Add(NumResults);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var query = parseResult.GetRequiredValue(Query);
            var numResults = parseResult.GetRequiredValue(NumResults);

            Validate(
                parseResult: parseResult,
                query: query,
                numResults: numResults,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SearchWebAsync(
                query: query,
                numResults: numResults,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}