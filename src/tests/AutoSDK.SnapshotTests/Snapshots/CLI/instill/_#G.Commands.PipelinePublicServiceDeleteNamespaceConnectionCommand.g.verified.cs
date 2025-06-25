//HintName: G.Commands.PipelinePublicServiceDeleteNamespaceConnectionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceDeleteNamespaceConnectionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string connectionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"Namespace ID.",
        };

        private global::System.CommandLine.Argument<string> ConnectionId { get; } = new(
            name: "connectionId")
        {
            Description = @"Connection ID.",
        };

        public PipelinePublicServiceDeleteNamespaceConnectionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Deletes a connection.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(ConnectionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var connectionId = parseResult.GetRequiredValue(ConnectionId);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                connectionId: connectionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceDeleteNamespaceConnectionAsync(
                namespaceId: namespaceId,
                connectionId: connectionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}