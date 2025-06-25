//HintName: G.Commands.PipelinePublicServiceUpdateNamespaceConnectionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceUpdateNamespaceConnectionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string connectionId,
            string id,
            string integrationId,
            global::G.Method method,
            object setup,
            global::System.Collections.Generic.IList<string>? scopes,
            string? identity,
            object? oAuthAccessDetails,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateNamespaceConnectionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> ConnectionId { get; } = new(
            name: "connectionId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> IntegrationId { get; } = new(
            name: "integrationId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.Method> Method { get; } = new(
            name: "method")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<object> Setup { get; } = new(
            name: "setup")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Scopes { get; } = new(
            name: "scopes")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Identity { get; } = new(
            name: "identity")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<object?> OAuthAccessDetails { get; } = new(
            name: "oAuthAccessDetails")
        {
            Description = @"",
        };
        public PipelinePublicServiceUpdateNamespaceConnectionCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Updates a connection with the supplied connection fields.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(ConnectionId);
            Arguments.Add(Id);
            Arguments.Add(IntegrationId);
            Arguments.Add(Method);
            Arguments.Add(Setup);
            Options.Add(Scopes);
            Options.Add(Identity);
            Options.Add(OAuthAccessDetails);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var connectionId = parseResult.GetRequiredValue(ConnectionId);
            var id = parseResult.GetRequiredValue(Id);
            var integrationId = parseResult.GetRequiredValue(IntegrationId);
            var method = parseResult.GetRequiredValue(Method);
            var setup = parseResult.GetRequiredValue(Setup);
            var scopes = parseResult.GetRequiredValue(Scopes);
            var identity = parseResult.GetRequiredValue(Identity);
            var oAuthAccessDetails = parseResult.GetRequiredValue(OAuthAccessDetails);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                connectionId: connectionId,
                id: id,
                integrationId: integrationId,
                method: method,
                setup: setup,
                scopes: scopes,
                identity: identity,
                oAuthAccessDetails: oAuthAccessDetails,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceUpdateNamespaceConnectionAsync(
                namespaceId: namespaceId,
                connectionId: connectionId,
                id: id,
                integrationId: integrationId,
                method: method,
                setup: setup,
                scopes: scopes,
                identity: identity,
                oAuthAccessDetails: oAuthAccessDetails,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}