//HintName: G.Commands.PipelinePublicServiceUpdateNamespaceConnectionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceUpdateNamespaceConnectionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"ID of the namespace that owns the connection.",
        };

        private global::System.CommandLine.Argument<string> ConnectionId { get; } = new(
            name: "connectionId")
        {
            Description = @"ID of the connection to be updated, as present in the database.",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"ID.",
        };

        private global::System.CommandLine.Argument<string> IntegrationId { get; } = new(
            name: "integrationId")
        {
            Description = @"Integration ID. It determines for which type of components can reference
this connection.",
        };

        private global::System.CommandLine.Argument<global::G.Method> Method { get; } = new(
            name: "method")
        {
            Description = @"Connection method. It references the setup schema provided by the
integration.",
        };

        private global::System.CommandLine.Argument<object> Setup { get; } = new(
            name: "setup")
        {
            Description = @"Connection details. This field is required on creation, optional on view.
When viewing the connection details, the setup values will be redacted.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Scopes { get; } = new(
            name: "scopes")
        {
            Description = @"A list of scopes that identify the resources that the connection will be
able to access on the user's behalf. This is typically passed on creation
when the setup has been generated through an OAuth flow with a limited set
of scopes.",
        };

        private global::System.CommandLine.Option<string?> Identity { get; } = new(
            name: "identity")
        {
            Description = @"When the connection method is METHOD_OAUTH, this field will hold the
identity (e.g., email, username) with which the access token has been
generated.",
        };

        private global::System.CommandLine.Option<object?> OAuthAccessDetails { get; } = new(
            name: "oAuthAccessDetails")
        {
            Description = @"When the connection method is METHOD_OAUTH, the access token might come
with some extra information that might vary across vendors. This
information is passed as connection metadata.",
        };
        public PipelinePublicServiceUpdateNamespaceConnectionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Updates a connection with the supplied connection fields.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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