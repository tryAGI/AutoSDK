//HintName: G.Commands.KgApiQuestionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class KgApiQuestionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::System.Guid> graphIds,
            bool? subqueries,
            string question,
            global::G.GraphQueryConfig? queryConfig,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.QuestionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::System.Guid>> GraphIds { get; } = new(
            name: "graphIds")
        {
            Description = @"The unique identifiers of the Knowledge Graphs to query.",
        };

        private global::System.CommandLine.Argument<string> Question { get; } = new(
            name: "question")
        {
            Description = @"The question to answer using the Knowledge Graph.",
        };

        private global::System.CommandLine.Option<bool?> Subqueries { get; } = new(
            name: "subqueries")
        {
            Description = @"Specify whether to include subqueries.",
        };

        private global::System.CommandLine.Option<global::G.GraphQueryConfig?> QueryConfig { get; } = new(
            name: "queryConfig")
        {
            Description = @"Configuration options for Knowledge Graph queries.",
        };


        public KgApiQuestionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "question",
            description: @"Ask a question to specified Knowledge Graphs.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(GraphIds);
            Arguments.Add(Question);
            Options.Add(Subqueries);
            Options.Add(QueryConfig);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var graphIds = parseResult.GetRequiredValue(GraphIds);
            var subqueries = parseResult.GetRequiredValue(Subqueries);
            var question = parseResult.GetRequiredValue(Question);
            var queryConfig = parseResult.GetRequiredValue(QueryConfig);

            Validate(
                parseResult: parseResult,
                graphIds: graphIds,
                subqueries: subqueries,
                question: question,
                queryConfig: queryConfig,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.KgApi.QuestionAsync(
                graphIds: graphIds,
                subqueries: subqueries,
                question: question,
                queryConfig: queryConfig,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}