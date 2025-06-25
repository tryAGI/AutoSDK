//HintName: G.Commands.UpdateConnectorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateConnectorCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string id,
            string? xClientName,
            bool? active,
            bool? continueOnFailure,
            global::System.Collections.Generic.IList<string>? excludes,
            string? name,
            global::G.CreateConnectorOAuth? oauth,
            global::G.CreateConnectorServiceAuth? serviceAuth,
            string? url,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateConnectorResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Active { get; } = new(
            name: "active")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ContinueOnFailure { get; } = new(
            name: "continueOnFailure")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Excludes { get; } = new(
            name: "excludes")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateConnectorOAuth?> Oauth { get; } = new(
            name: "oauth")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateConnectorServiceAuth?> ServiceAuth { get; } = new(
            name: "serviceAuth")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Url { get; } = new(
            name: "url")
        {
            Description = "",
        };
        public UpdateConnectorCommand(G.IApi client) : base(
            name: "update",
            description: @"Update a connector by ID. Omitted fields will not be updated. See ['Managing your Connector'](https://docs.cohere.com/docs/managing-your-connector) for more information.")
        {
            _client = client;

            Arguments.Add(Id);
            Options.Add(XClientName);
            Options.Add(Active);
            Options.Add(ContinueOnFailure);
            Options.Add(Excludes);
            Options.Add(Name);
            Options.Add(Oauth);
            Options.Add(ServiceAuth);
            Options.Add(Url);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var active = parseResult.GetRequiredValue(Active);
            var continueOnFailure = parseResult.GetRequiredValue(ContinueOnFailure);
            var excludes = parseResult.GetRequiredValue(Excludes);
            var name = parseResult.GetRequiredValue(Name);
            var oauth = parseResult.GetRequiredValue(Oauth);
            var serviceAuth = parseResult.GetRequiredValue(ServiceAuth);
            var url = parseResult.GetRequiredValue(Url);

            Validate(
                parseResult: parseResult,
                id: id,
                xClientName: xClientName,
                active: active,
                continueOnFailure: continueOnFailure,
                excludes: excludes,
                name: name,
                oauth: oauth,
                serviceAuth: serviceAuth,
                url: url,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Connectors.UpdateConnectorAsync(
                id: id,
                xClientName: xClientName,
                active: active,
                continueOnFailure: continueOnFailure,
                excludes: excludes,
                name: name,
                oauth: oauth,
                serviceAuth: serviceAuth,
                url: url,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}