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
            string? xClientName,
            string? model,
            string query,
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.RerankDocument>> documents,
            int? topN,
            global::System.Collections.Generic.IList<string>? rankFields,
            bool? returnDocuments,
            int? maxChunksPerDoc,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RerankResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Query { get; } = new(
            name: "query")
        {
            Description = @"The search query",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.RerankDocument>>> Documents { get; } = new(
            name: "documents")
        {
            Description = @"A list of document objects or strings to rerank.
If a document is provided the text fields is required and all other fields will be preserved in the response.

The total max chunks (length of documents * max_chunks_per_doc) must be less than 10000.

We recommend a maximum of 1,000 documents for optimal endpoint performance.",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = @"The identifier of the model to use, eg `rerank-v3.5`.",
        };

        private global::System.CommandLine.Option<int?> TopN { get; } = new(
            name: "topN")
        {
            Description = @"The number of most relevant documents or indices to return, defaults to the length of the documents",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> RankFields { get; } = new(
            name: "rankFields")
        {
            Description = @"If a JSON object is provided, you can specify which keys you would like to have considered for reranking. The model will rerank based on order of the fields passed in (i.e. rank_fields=['title','author','text'] will rerank using the values in title, author, text  sequentially. If the length of title, author, and text exceeds the context length of the model, the chunking will not re-consider earlier fields). If not provided, the model will use the default text field for ranking.",
        };

        private global::System.CommandLine.Option<bool?> ReturnDocuments { get; } = new(
            name: "returnDocuments")
        {
            Description = @"- If false, returns results without the doc text - the api will return a list of {index, relevance score} where index is inferred from the list passed into the request.
- If true, returns results with the doc text passed in - the api will return an ordered list of {index, text, relevance score} where index + text refers to the list passed into the request.",
        };

        private global::System.CommandLine.Option<int?> MaxChunksPerDoc { get; } = new(
            name: "maxChunksPerDoc")
        {
            Description = @"The maximum number of chunks to produce internally from a document",
        };
        public RerankCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "rerank",
            description: @"This endpoint takes in a query and a list of texts and produces an ordered array with each text assigned a relevance score.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Query);
            Arguments.Add(Documents);
            Options.Add(XClientName);
            Options.Add(Model);
            Options.Add(TopN);
            Options.Add(RankFields);
            Options.Add(ReturnDocuments);
            Options.Add(MaxChunksPerDoc);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var model = parseResult.GetRequiredValue(Model);
            var query = parseResult.GetRequiredValue(Query);
            var documents = parseResult.GetRequiredValue(Documents);
            var topN = parseResult.GetRequiredValue(TopN);
            var rankFields = parseResult.GetRequiredValue(RankFields);
            var returnDocuments = parseResult.GetRequiredValue(ReturnDocuments);
            var maxChunksPerDoc = parseResult.GetRequiredValue(MaxChunksPerDoc);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                model: model,
                query: query,
                documents: documents,
                topN: topN,
                rankFields: rankFields,
                returnDocuments: returnDocuments,
                maxChunksPerDoc: maxChunksPerDoc,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.RerankAsync(
                xClientName: xClientName,
                model: model,
                query: query,
                documents: documents,
                topN: topN,
                rankFields: rankFields,
                returnDocuments: returnDocuments,
                maxChunksPerDoc: maxChunksPerDoc,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}