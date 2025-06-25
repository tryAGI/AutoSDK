//HintName: G.Commands.GetEvalRunsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetEvalRunsCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string evalId,
            string? after,
            int? limit,
            global::G.GetEvalRunsOrder? order,
            global::G.GetEvalRunsStatus? status,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EvalRunList response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> EvalId { get; } = new(
            name: "evalId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GetEvalRunsOrder?> Order { get; } = new(
            name: "order")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GetEvalRunsStatus?> Status { get; } = new(
            name: "status")
        {
            Description = "",
        };
        public GetEvalRunsCommand(G.IOpenAiClient client) : base(
            name: "get",
            description: @"")
        {
            _client = client;

            Arguments.Add(EvalId);
            Options.Add(After);
            Options.Add(Limit);
            Options.Add(Order);
            Options.Add(Status);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var evalId = parseResult.GetRequiredValue(EvalId);
            var after = parseResult.GetRequiredValue(After);
            var limit = parseResult.GetRequiredValue(Limit);
            var order = parseResult.GetRequiredValue(Order);
            var status = parseResult.GetRequiredValue(Status);

            Validate(
                parseResult: parseResult,
                evalId: evalId,
                after: after,
                limit: limit,
                order: order,
                status: status,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Evals.GetEvalRunsAsync(
                evalId: evalId,
                after: after,
                limit: limit,
                order: order,
                status: status,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}