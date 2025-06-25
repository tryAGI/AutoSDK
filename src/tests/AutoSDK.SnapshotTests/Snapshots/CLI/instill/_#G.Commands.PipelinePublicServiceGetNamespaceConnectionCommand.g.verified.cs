//HintName: G.Commands.PipelinePublicServiceGetNamespaceConnectionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceGetNamespaceConnectionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string connectionId,
            global::G.PipelinePublicServiceGetNamespaceConnectionView? view,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetNamespaceConnectionResponse response,
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

        private global::System.CommandLine.Option<global::G.PipelinePublicServiceGetNamespaceConnectionView?> View { get; } = new(
            name: "view")
        {
            Description = @"View allows clients to specify the desired view in the response.

 - VIEW_BASIC: Default view.
 - VIEW_FULL: Full representation.",
        };
        public PipelinePublicServiceGetNamespaceConnectionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Returns the details of a connection.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(ConnectionId);
            Options.Add(View);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var connectionId = parseResult.GetRequiredValue(ConnectionId);
            var view = parseResult.GetRequiredValue(View);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                connectionId: connectionId,
                view: view,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceGetNamespaceConnectionAsync(
                namespaceId: namespaceId,
                connectionId: connectionId,
                view: view,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}