//HintName: G.Commands.RerankCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RerankCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? model,
            string query,
            global::System.Collections.Generic.IList<global::G.AnyOf<string, object, global::System.Collections.Generic.IList<object>>> input,
            global::System.Collections.Generic.IList<string>? rankFields,
            int? topK,
            bool? returnInput,
            bool? rewriteQuery,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.RerankResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Query { get; } = new(
            name: "query")
        {
            Description = @"The query to rerank the documents.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.AnyOf<string, object, global::System.Collections.Generic.IList<object>>>> Input { get; } = new(
            name: "input")
        {
            Description = @"The input documents to rerank.",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = @"The model to use for reranking documents.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> RankFields { get; } = new(
            name: "rankFields")
        {
            Description = @"The fields of the documents to rank.",
        };

        private global::System.CommandLine.Option<int?> TopK { get; } = new(
            name: "topK")
        {
            Description = @"The number of documents to return.",
        };

        private global::System.CommandLine.Option<bool?> ReturnInput { get; } = new(
            name: "returnInput")
        {
            Description = @"Whether to return the documents.",
        };

        private global::System.CommandLine.Option<bool?> RewriteQuery { get; } = new(
            name: "rewriteQuery")
        {
            Description = @"Wether or not to rewrite the query before passing it to the reranking model",
        };


        public RerankCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "rerank",
            description: @"Rerank different kind of documents for a given query.

Args:
    params: RerankParams: The parameters for reranking.

Returns:
    RerankResponse: The reranked documents for the input query.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Query);
            Arguments.Add(Input);
            Options.Add(Model);
            Options.Add(RankFields);
            Options.Add(TopK);
            Options.Add(ReturnInput);
            Options.Add(RewriteQuery);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var query = parseResult.GetRequiredValue(Query);
            var input = parseResult.GetRequiredValue(Input);
            var rankFields = parseResult.GetRequiredValue(RankFields);
            var topK = parseResult.GetRequiredValue(TopK);
            var returnInput = parseResult.GetRequiredValue(ReturnInput);
            var rewriteQuery = parseResult.GetRequiredValue(RewriteQuery);

            Validate(
                parseResult: parseResult,
                model: model,
                query: query,
                input: input,
                rankFields: rankFields,
                topK: topK,
                returnInput: returnInput,
                rewriteQuery: rewriteQuery,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.RerankAsync(
                model: model,
                query: query,
                input: input,
                rankFields: rankFields,
                topK: topK,
                returnInput: returnInput,
                rewriteQuery: rewriteQuery,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}