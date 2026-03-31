//HintName: G.Commands.RerankingCreateRerankingCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RerankingCreateRerankingCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            string query,
            global::System.Collections.Generic.IList<string> docs,
            string? instruction,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.RerankingResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"ID of the reranking model to use.",
        };

        private global::System.CommandLine.Argument<string> Query { get; } = new(
            name: "query")
        {
            Description = @"The search query to rank documents against.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Docs { get; } = new(
            name: "docs")
        {
            Description = @"An array of documents to rank. Each document is a string containing the text content.
Maximum of 100 documents per request.",
        };

        private global::System.CommandLine.Option<string?> Instruction { get; } = new(
            name: "instruction")
        {
            Description = @"Optional instruction to guide the reranking process. If not provided, 
a default instruction will be used.",
        };


        public RerankingCreateRerankingCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Given a query and a list of documents, returns the documents ranked by their relevance to the query.
The documents are scored and sorted in descending order of relevance.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Query);
            Arguments.Add(Docs);
            Options.Add(Instruction);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var query = parseResult.GetRequiredValue(Query);
            var docs = parseResult.GetRequiredValue(Docs);
            var instruction = parseResult.GetRequiredValue(Instruction);

            Validate(
                parseResult: parseResult,
                model: model,
                query: query,
                docs: docs,
                instruction: instruction,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Reranking.CreateRerankingAsync(
                model: model,
                query: query,
                docs: docs,
                instruction: instruction,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}