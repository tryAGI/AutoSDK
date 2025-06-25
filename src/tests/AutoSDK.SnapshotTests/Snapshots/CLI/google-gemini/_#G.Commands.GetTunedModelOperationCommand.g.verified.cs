//HintName: G.Commands.GetTunedModelOperationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetTunedModelOperationCommand : global::System.CommandLine.Command
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
            global::G.Operation response,
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

        public GetTunedModelOperationCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets the latest state of a long-running operation. Clients can use this method to poll the operation result at intervals as recommended by the API service.")
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
            var response = await _client.GetTunedModelOperationAsync(
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