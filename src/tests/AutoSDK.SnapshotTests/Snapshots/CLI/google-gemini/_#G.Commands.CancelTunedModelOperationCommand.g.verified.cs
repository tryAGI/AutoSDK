//HintName: G.Commands.CancelTunedModelOperationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CancelTunedModelOperationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tunedModelId,
            string operationId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TunedModelId { get; } = new(
            name: "tunedModelId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> OperationId { get; } = new(
            name: "operationId")
        {
            Description = @"",
        };

        public CancelTunedModelOperationCommand(G.IApi client) : base(
            name: "cancel",
            description: @"Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the operation, but success is not guaranteed. If the server doesn't support this method, it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether the cancellation succeeded or whether the operation completed despite cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.")
        {
            _client = client;

            Arguments.Add(TunedModelId);
            Arguments.Add(OperationId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var tunedModelId = parseResult.GetRequiredValue(TunedModelId);
            var operationId = parseResult.GetRequiredValue(OperationId);

            Validate(
                parseResult: parseResult,
                tunedModelId: tunedModelId,
                operationId: operationId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CancelTunedModelOperationAsync(
                tunedModelId: tunedModelId,
                operationId: operationId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}