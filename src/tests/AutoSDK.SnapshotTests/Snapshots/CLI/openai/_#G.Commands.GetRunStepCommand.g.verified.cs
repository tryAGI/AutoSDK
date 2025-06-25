//HintName: G.Commands.GetRunStepCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetRunStepCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string threadId,
            string runId,
            string stepId,
            global::System.Collections.Generic.IList<global::G.GetRunStepIncludeItem>? include,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RunStepObject response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ThreadId { get; } = new(
            name: "threadId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> RunId { get; } = new(
            name: "runId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> StepId { get; } = new(
            name: "stepId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.GetRunStepIncludeItem>?> Include { get; } = new(
            name: "include")
        {
            Description = "",
        };
        public GetRunStepCommand(G.IOpenAiClient client) : base(
            name: "get",
            description: @"")
        {
            _client = client;

            Arguments.Add(ThreadId);
            Arguments.Add(RunId);
            Arguments.Add(StepId);
            Options.Add(Include);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var threadId = parseResult.GetRequiredValue(ThreadId);
            var runId = parseResult.GetRequiredValue(RunId);
            var stepId = parseResult.GetRequiredValue(StepId);
            var include = parseResult.GetRequiredValue(Include);

            Validate(
                parseResult: parseResult,
                threadId: threadId,
                runId: runId,
                stepId: stepId,
                include: include,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Assistants.GetRunStepAsync(
                threadId: threadId,
                runId: runId,
                stepId: stepId,
                include: include,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}