//HintName: G.Commands.PipelinePublicServiceGetOperationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceGetOperationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string operationId,
            string? instillRequesterUid,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetOperationResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> OperationId { get; } = new(
            name: "operationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> InstillRequesterUid { get; } = new(
            name: "instillRequesterUid")
        {
            Description = "",
        };
        public PipelinePublicServiceGetOperationCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"This method allows requesters to request the status and outcome of
long-running operations such as asynchronous pipeline triggers.")
        {
            _client = client;

            Arguments.Add(OperationId);
            Options.Add(InstillRequesterUid);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var operationId = parseResult.GetRequiredValue(OperationId);
            var instillRequesterUid = parseResult.GetRequiredValue(InstillRequesterUid);

            Validate(
                parseResult: parseResult,
                operationId: operationId,
                instillRequesterUid: instillRequesterUid,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceGetOperationAsync(
                operationId: operationId,
                instillRequesterUid: instillRequesterUid,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}