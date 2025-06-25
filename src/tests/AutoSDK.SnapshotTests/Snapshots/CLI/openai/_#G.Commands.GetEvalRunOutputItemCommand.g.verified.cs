//HintName: G.Commands.GetEvalRunOutputItemCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetEvalRunOutputItemCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string evalId,
            string runId,
            string outputItemId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EvalRunOutputItem response,
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

        private global::System.CommandLine.Argument<string> OutputItemId { get; } = new(
            name: "outputItemId")
        {
            Description = "",
        };

        public GetEvalRunOutputItemCommand(G.IOpenAiClient client) : base(
            name: "get",
            description: @"")
        {
            _client = client;

            Arguments.Add(EvalId);
            Arguments.Add(RunId);
            Arguments.Add(OutputItemId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var evalId = parseResult.GetRequiredValue(EvalId);
            var runId = parseResult.GetRequiredValue(RunId);
            var outputItemId = parseResult.GetRequiredValue(OutputItemId);

            Validate(
                parseResult: parseResult,
                evalId: evalId,
                runId: runId,
                outputItemId: outputItemId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Evals.GetEvalRunOutputItemAsync(
                evalId: evalId,
                runId: runId,
                outputItemId: outputItemId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}