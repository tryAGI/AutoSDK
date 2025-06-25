//HintName: G.Commands.OAuthAuthorizeConnectorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OAuthAuthorizeConnectorCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string id,
            string? afterTokenRedirect,
            string? xClientName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OAuthAuthorizeResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> AfterTokenRedirect { get; } = new(
            name: "afterTokenRedirect")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = "",
        };
        public OAuthAuthorizeConnectorCommand(G.IApi client) : base(
            name: "oauth",
            description: @"Authorize the connector with the given ID for the connector oauth app.  See ['Connector Authentication'](https://docs.cohere.com/docs/connector-authentication) for more information.")
        {
            _client = client;

            Arguments.Add(Id);
            Options.Add(AfterTokenRedirect);
            Options.Add(XClientName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var afterTokenRedirect = parseResult.GetRequiredValue(AfterTokenRedirect);
            var xClientName = parseResult.GetRequiredValue(XClientName);

            Validate(
                parseResult: parseResult,
                id: id,
                afterTokenRedirect: afterTokenRedirect,
                xClientName: xClientName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Connectors.OAuthAuthorizeConnectorAsync(
                id: id,
                afterTokenRedirect: afterTokenRedirect,
                xClientName: xClientName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}