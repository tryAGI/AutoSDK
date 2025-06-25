//HintName: G.Commands.RankV1RerankPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RankV1RerankPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::G.ApiSchemasRankTextDoc>> Query { get; } = new(
            name: "query")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.ApiSchemasRankTextDoc>>> Documents { get; } = new(
            name: "documents")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> TopN { get; } = new(
            name: "topN")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ReturnDocuments { get; } = new(
            name: "returnDocuments")
        {
            Description = "",
        };
        public RankV1RerankPostCommand(G.IApi client) : base(
            name: "rank",
            description: @"Rank pairs.")
        {
            _client = client;

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