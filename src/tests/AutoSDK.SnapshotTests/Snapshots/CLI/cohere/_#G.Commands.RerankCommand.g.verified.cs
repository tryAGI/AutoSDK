//HintName: G.Commands.RerankCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RerankCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.RerankDocument>> documents,
            int? maxChunksPerDoc,
            string? model,
            string query,
            global::System.Collections.Generic.IList<string>? rankFields,
            bool? returnDocuments,
            int? topN,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RerankResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.RerankDocument>>> Documents { get; } = new(
            name: "documents")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Query { get; } = new(
            name: "query")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> MaxChunksPerDoc { get; } = new(
            name: "maxChunksPerDoc")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> RankFields { get; } = new(
            name: "rankFields")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ReturnDocuments { get; } = new(
            name: "returnDocuments")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> TopN { get; } = new(
            name: "topN")
        {
            Description = "",
        };
        public RerankCommand(G.IApi client) : base(
            name: "rerank",
            description: @"This endpoint takes in a query and a list of texts and produces an ordered array with each text assigned a relevance score.")
        {
            _client = client;

            Arguments.Add(Documents);
            Arguments.Add(Query);
            Options.Add(XClientName);
            Options.Add(MaxChunksPerDoc);
            Options.Add(Model);
            Options.Add(RankFields);
            Options.Add(ReturnDocuments);
            Options.Add(TopN);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var documents = parseResult.GetRequiredValue(Documents);
            var maxChunksPerDoc = parseResult.GetRequiredValue(MaxChunksPerDoc);
            var model = parseResult.GetRequiredValue(Model);
            var query = parseResult.GetRequiredValue(Query);
            var rankFields = parseResult.GetRequiredValue(RankFields);
            var returnDocuments = parseResult.GetRequiredValue(ReturnDocuments);
            var topN = parseResult.GetRequiredValue(TopN);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                documents: documents,
                maxChunksPerDoc: maxChunksPerDoc,
                model: model,
                query: query,
                rankFields: rankFields,
                returnDocuments: returnDocuments,
                topN: topN,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.RerankAsync(
                xClientName: xClientName,
                documents: documents,
                maxChunksPerDoc: maxChunksPerDoc,
                model: model,
                query: query,
                rankFields: rankFields,
                returnDocuments: returnDocuments,
                topN: topN,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}