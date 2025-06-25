//HintName: G.Commands.CallsStagesMessagesAudioRetrieveCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CallsStagesMessagesAudioRetrieveCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid callId,
            global::System.Guid callStageId,
            int callStageMessageIndex,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> CallId { get; } = new(
            name: "callId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Guid> CallStageId { get; } = new(
            name: "callStageId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> CallStageMessageIndex { get; } = new(
            name: "callStageMessageIndex")
        {
            Description = "",
        };

        public CallsStagesMessagesAudioRetrieveCommand(G.IApi client) : base(
            name: "calls",
            description: @"")
        {
            _client = client;

            Arguments.Add(CallId);
            Arguments.Add(CallStageId);
            Arguments.Add(CallStageMessageIndex);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var callId = parseResult.GetRequiredValue(CallId);
            var callStageId = parseResult.GetRequiredValue(CallStageId);
            var callStageMessageIndex = parseResult.GetRequiredValue(CallStageMessageIndex);

            Validate(
                parseResult: parseResult,
                callId: callId,
                callStageId: callStageId,
                callStageMessageIndex: callStageMessageIndex,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Calls.CallsStagesMessagesAudioRetrieveAsync(
                callId: callId,
                callStageId: callStageId,
                callStageMessageIndex: callStageMessageIndex,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}