//HintName: G.Commands.RankV1RerankPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RankV1RerankPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            global::G.AnyOf<string, global::G.ApiSchemasRankTextDoc> query,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.ApiSchemasRankTextDoc>> documents,
            int? topN,
            bool? returnDocuments,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RankingOutput response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The identifier of the model.

Available models and corresponding param size and dimension:
- `jina-reranker-v2-base-multilingual`,	278M
- `jina-reranker-v1-base-en`,	137M
- `jina-reranker-v1-tiny-en`,	33M
- `jina-reranker-v1-turbo-en`,	38M
- `jina-colbert-v1-en`,	137M",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::G.ApiSchemasRankTextDoc>> Query { get; } = new(
            name: "query")
        {
            Description = @"The search query",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.ApiSchemasRankTextDoc>>> Documents { get; } = new(
            name: "documents")
        {
            Description = @"A list of text documents or strings to rerank. If a document is provided the text fields is required and all other fields will be preserved in the response.",
        };

        private global::System.CommandLine.Option<int?> TopN { get; } = new(
            name: "topN")
        {
            Description = @"The number of most relevant documents or indices to return, defaults to the length of `documents`",
        };

        private global::System.CommandLine.Option<bool?> ReturnDocuments { get; } = new(
            name: "returnDocuments")
        {
            Description = @"If false, returns results without the doc text - the api will return a list of {index, relevance score} where index is inferred from the list passed into the request. If true, returns results with the doc text passed in - the api will return an ordered list of {index, text, relevance score} where index + text refers to the list passed into the request. Defaults to true",
        };
        public RankV1RerankPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "rank",
            description: @"Rank pairs.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Query);
            Arguments.Add(Documents);
            Options.Add(TopN);
            Options.Add(ReturnDocuments);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var query = parseResult.GetRequiredValue(Query);
            var documents = parseResult.GetRequiredValue(Documents);
            var topN = parseResult.GetRequiredValue(TopN);
            var returnDocuments = parseResult.GetRequiredValue(ReturnDocuments);

            Validate(
                parseResult: parseResult,
                model: model,
                query: query,
                documents: documents,
                topN: topN,
                returnDocuments: returnDocuments,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Rerank.RankV1RerankPostAsync(
                model: model,
                query: query,
                documents: documents,
                topN: topN,
                returnDocuments: returnDocuments,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}