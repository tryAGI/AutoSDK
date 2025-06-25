//HintName: G.Commands.AppsDeleteTokenCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsDeleteTokenCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string clientId,
            string accessToken,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ClientId { get; } = new(
            name: "clientId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> AccessToken { get; } = new(
            name: "accessToken")
        {
            Description = "",
        };

        public AppsDeleteTokenCommand(G.IApi client) : base(
            name: "apps",
            description: @"OAuth  or GitHub application owners can revoke a single token for an OAuth application or a GitHub application with an OAuth authorization.")
        {
            _client = client;

            Arguments.Add(ClientId);
            Arguments.Add(AccessToken);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var clientId = parseResult.GetRequiredValue(ClientId);
            var accessToken = parseResult.GetRequiredValue(AccessToken);

            Validate(
                parseResult: parseResult,
                clientId: clientId,
                accessToken: accessToken,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Apps.AppsDeleteTokenAsync(
                clientId: clientId,
                accessToken: accessToken,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}