//HintName: G.Commands.CancelEvalRunCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CancelEvalRunCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string evalId,
            string runId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EvalRun response,
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

        public CancelEvalRunCommand(G.IOpenAiClient client) : base(
            name: "cancel",
            description: @"")
        {
            _client = client;

            Arguments.Add(EvalId);
            Arguments.Add(RunId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var evalId = parseResult.GetRequiredValue(EvalId);
            var runId = parseResult.GetRequiredValue(RunId);

            Validate(
                parseResult: parseResult,
                evalId: evalId,
                runId: runId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Evals.CancelEvalRunAsync(
                evalId: evalId,
                runId: runId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}