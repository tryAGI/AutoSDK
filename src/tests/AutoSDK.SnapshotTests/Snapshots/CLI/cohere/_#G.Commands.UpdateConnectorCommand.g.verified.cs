//HintName: G.Commands.UpdateConnectorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateConnectorCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string id,
            string? xClientName,
            string? name,
            string? url,
            global::System.Collections.Generic.IList<string>? excludes,
            global::G.CreateConnectorOAuth? oauth,
            bool? active,
            bool? continueOnFailure,
            global::G.CreateConnectorServiceAuth? serviceAuth,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateConnectorResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"The ID of the connector to update.",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"A human-readable name for the connector.",
        };

        private global::System.CommandLine.Option<string?> Url { get; } = new(
            name: "url")
        {
            Description = @"The URL of the connector that will be used to search for documents.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Excludes { get; } = new(
            name: "excludes")
        {
            Description = @"A list of fields to exclude from the prompt (fields remain in the document).",
        };

        private global::System.CommandLine.Option<global::G.CreateConnectorOAuth?> Oauth { get; } = new(
            name: "oauth")
        {
            Description = @"The OAuth 2.0 configuration for the connector. Cannot be specified if service_auth is specified.",
        };

        private global::System.CommandLine.Option<bool?> Active { get; } = new(
            name: "active")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> ContinueOnFailure { get; } = new(
            name: "continueOnFailure")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.CreateConnectorServiceAuth?> ServiceAuth { get; } = new(
            name: "serviceAuth")
        {
            Description = @"The service to service authentication configuration for the connector. Cannot be specified if oauth is specified.",
        };
        public UpdateConnectorCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update a connector by ID. Omitted fields will not be updated. See ['Managing your Connector'](https://docs.cohere.com/docs/managing-your-connector) for more information.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(XClientName);
            Options.Add(Name);
            Options.Add(Url);
            Options.Add(Excludes);
            Options.Add(Oauth);
            Options.Add(Active);
            Options.Add(ContinueOnFailure);
            Options.Add(ServiceAuth);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var name = parseResult.GetRequiredValue(Name);
            var url = parseResult.GetRequiredValue(Url);
            var excludes = parseResult.GetRequiredValue(Excludes);
            var oauth = parseResult.GetRequiredValue(Oauth);
            var active = parseResult.GetRequiredValue(Active);
            var continueOnFailure = parseResult.GetRequiredValue(ContinueOnFailure);
            var serviceAuth = parseResult.GetRequiredValue(ServiceAuth);

            Validate(
                parseResult: parseResult,
                id: id,
                xClientName: xClientName,
                name: name,
                url: url,
                excludes: excludes,
                oauth: oauth,
                active: active,
                continueOnFailure: continueOnFailure,
                serviceAuth: serviceAuth,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Connectors.UpdateConnectorAsync(
                id: id,
                xClientName: xClientName,
                name: name,
                url: url,
                excludes: excludes,
                oauth: oauth,
                active: active,
                continueOnFailure: continueOnFailure,
                serviceAuth: serviceAuth,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}