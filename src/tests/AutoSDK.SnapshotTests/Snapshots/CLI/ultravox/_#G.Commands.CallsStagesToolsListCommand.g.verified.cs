//HintName: G.Commands.CallsStagesToolsListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CallsStagesToolsListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid callId,
            global::System.Guid callStageId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.CallTool> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> CallId { get; } = new(
            name: "callId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> CallStageId { get; } = new(
            name: "callStageId")
        {
            Description = @"",
        };

        public CallsStagesToolsListCommand(G.IApi client) : base(
            name: "calls",
            description: @"")
        {
            _client = client;

            Arguments.Add(CallId);
            Arguments.Add(CallStageId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var callId = parseResult.GetRequiredValue(CallId);
            var callStageId = parseResult.GetRequiredValue(CallStageId);

            Validate(
                parseResult: parseResult,
                callId: callId,
                callStageId: callStageId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Calls.CallsStagesToolsListAsync(
                callId: callId,
                callStageId: callStageId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}