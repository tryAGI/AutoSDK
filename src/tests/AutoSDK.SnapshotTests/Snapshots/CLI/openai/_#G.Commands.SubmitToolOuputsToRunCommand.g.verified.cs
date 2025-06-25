//HintName: G.Commands.SubmitToolOuputsToRunCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SubmitToolOuputsToRunCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string threadId,
            string runId,
            global::System.Collections.Generic.IList<global::G.SubmitToolOutputsRunRequestToolOutput> toolOutputs,
            bool? stream,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RunObject response,
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

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.SubmitToolOutputsRunRequestToolOutput>> ToolOutputs { get; } = new(
            name: "toolOutputs")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = "",
        };
        public SubmitToolOuputsToRunCommand(G.IOpenAiClient client) : base(
            name: "submit",
            description: @"")
        {
            _client = client;

            Arguments.Add(ThreadId);
            Arguments.Add(RunId);
            Arguments.Add(ToolOutputs);
            Options.Add(Stream);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var threadId = parseResult.GetRequiredValue(ThreadId);
            var runId = parseResult.GetRequiredValue(RunId);
            var toolOutputs = parseResult.GetRequiredValue(ToolOutputs);
            var stream = parseResult.GetRequiredValue(Stream);

            Validate(
                parseResult: parseResult,
                threadId: threadId,
                runId: runId,
                toolOutputs: toolOutputs,
                stream: stream,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Assistants.SubmitToolOuputsToRunAsync(
                threadId: threadId,
                runId: runId,
                toolOutputs: toolOutputs,
                stream: stream,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}