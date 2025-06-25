//HintName: G.Commands.Rerankv2Command.g.cs

#nullable enable

namespace G
{
    internal sealed partial class Rerankv2Command : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            global::System.Collections.Generic.IList<string> documents,
            int? maxTokensPerDoc,
            string model,
            string query,
            int? topN,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Rerankv2Response response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Documents { get; } = new(
            name: "documents")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
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

        private global::System.CommandLine.Option<int?> MaxTokensPerDoc { get; } = new(
            name: "maxTokensPerDoc")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> TopN { get; } = new(
            name: "topN")
        {
            Description = "",
        };
        public Rerankv2Command(G.IApi client) : base(
            name: "rerankv2",
            description: @"This endpoint takes in a query and a list of texts and produces an ordered array with each text assigned a relevance score.")
        {
            _client = client;

            Arguments.Add(Documents);
            Arguments.Add(Model);
            Arguments.Add(Query);
            Options.Add(XClientName);
            Options.Add(MaxTokensPerDoc);
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
            var maxTokensPerDoc = parseResult.GetRequiredValue(MaxTokensPerDoc);
            var model = parseResult.GetRequiredValue(Model);
            var query = parseResult.GetRequiredValue(Query);
            var topN = parseResult.GetRequiredValue(TopN);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                documents: documents,
                maxTokensPerDoc: maxTokensPerDoc,
                model: model,
                query: query,
                topN: topN,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Rerankv2Async(
                xClientName: xClientName,
                documents: documents,
                maxTokensPerDoc: maxTokensPerDoc,
                model: model,
                query: query,
                topN: topN,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}