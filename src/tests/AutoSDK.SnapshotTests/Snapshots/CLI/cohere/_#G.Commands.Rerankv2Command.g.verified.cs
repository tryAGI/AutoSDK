//HintName: G.Commands.Rerankv2Command.g.cs

#nullable enable

namespace G
{
    internal sealed partial class Rerankv2Command : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            string model,
            string query,
            global::System.Collections.Generic.IList<string> documents,
            int? topN,
            int? maxTokensPerDoc,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Rerankv2Response response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The identifier of the model to use, eg `rerank-v3.5`.",
        };

        private global::System.CommandLine.Argument<string> Query { get; } = new(
            name: "query")
        {
            Description = @"The search query",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Documents { get; } = new(
            name: "documents")
        {
            Description = @"A list of texts that will be compared to the `query`.
For optimal performance we recommend against sending more than 1,000 documents in a single request.

**Note**: long documents will automatically be truncated to the value of `max_tokens_per_doc`.

**Note**: structured data should be formatted as YAML strings for best performance.",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };

        private global::System.CommandLine.Option<int?> TopN { get; } = new(
            name: "topN")
        {
            Description = @"Limits the number of returned rerank results to the specified value. If not passed, all the rerank results will be returned.",
        };

        private global::System.CommandLine.Option<int?> MaxTokensPerDoc { get; } = new(
            name: "maxTokensPerDoc")
        {
            Description = @"Defaults to `4096`. Long documents will be automatically truncated to the specified number of tokens.",
        };
        public Rerankv2Command(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "rerankv2",
            description: @"This endpoint takes in a query and a list of texts and produces an ordered array with each text assigned a relevance score.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Query);
            Arguments.Add(Documents);
            Options.Add(XClientName);
            Options.Add(TopN);
            Options.Add(MaxTokensPerDoc);

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
            var maxTokensPerDoc = parseResult.GetRequiredValue(MaxTokensPerDoc);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                model: model,
                query: query,
                documents: documents,
                topN: topN,
                maxTokensPerDoc: maxTokensPerDoc,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Rerankv2Async(
                xClientName: xClientName,
                model: model,
                query: query,
                documents: documents,
                topN: topN,
                maxTokensPerDoc: maxTokensPerDoc,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}