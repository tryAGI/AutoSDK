//HintName: G.Commands.GraphqlPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GraphqlPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? operationName,
            string? query,
            object? variables,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GraphQLResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> OperationName { get; } = new(
            name: "operationName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Query { get; } = new(
            name: "query")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> Variables { get; } = new(
            name: "variables")
        {
            Description = "",
        };
        public GraphqlPostCommand(G.IApi client) : base(
            name: "graphql",
            description: @"Get a response based on a GraphQL query")
        {
            _client = client;

            Options.Add(OperationName);
            Options.Add(Query);
            Options.Add(Variables);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var operationName = parseResult.GetRequiredValue(OperationName);
            var query = parseResult.GetRequiredValue(Query);
            var variables = parseResult.GetRequiredValue(Variables);

            Validate(
                parseResult: parseResult,
                operationName: operationName,
                query: query,
                variables: variables,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Graphql.GraphqlPostAsync(
                operationName: operationName,
                query: query,
                variables: variables,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}