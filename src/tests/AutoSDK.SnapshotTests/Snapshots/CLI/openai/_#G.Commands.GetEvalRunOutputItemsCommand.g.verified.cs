//HintName: G.Commands.GetEvalRunOutputItemsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetEvalRunOutputItemsCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string evalId,
            string runId,
            string? after,
            int? limit,
            global::G.GetEvalRunOutputItemsStatus? status,
            global::G.GetEvalRunOutputItemsOrder? order,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EvalRunOutputItemList response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> EvalId { get; } = new(
            name: "evalId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> RunId { get; } = new(
            name: "runId")
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

        private global::System.CommandLine.Option<global::G.GetEvalRunOutputItemsStatus?> Status { get; } = new(
            name: "status")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GetEvalRunOutputItemsOrder?> Order { get; } = new(
            name: "order")
        {
            Description = "",
        };
        public GetEvalRunOutputItemsCommand(G.IOpenAiClient client) : base(
            name: "get",
            description: @"")
        {
            _client = client;

            Arguments.Add(EvalId);
            Arguments.Add(RunId);
            Options.Add(After);
            Options.Add(Limit);
            Options.Add(Status);
            Options.Add(Order);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var evalId = parseResult.GetRequiredValue(EvalId);
            var runId = parseResult.GetRequiredValue(RunId);
            var after = parseResult.GetRequiredValue(After);
            var limit = parseResult.GetRequiredValue(Limit);
            var status = parseResult.GetRequiredValue(Status);
            var order = parseResult.GetRequiredValue(Order);

            Validate(
                parseResult: parseResult,
                evalId: evalId,
                runId: runId,
                after: after,
                limit: limit,
                status: status,
                order: order,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Evals.GetEvalRunOutputItemsAsync(
                evalId: evalId,
                runId: runId,
                after: after,
                limit: limit,
                status: status,
                order: order,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}